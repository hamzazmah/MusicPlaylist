using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlaylists
{
    public partial class Player : Form
    {
        //Title
        private String[] paths, files;
        public Player()
        {
            InitializeComponent();
        }

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mp3 Files|*.mp3";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;//Save the name of the Track.
                paths = ofd.FileNames;//Save the path of the track in path array.

                for (int i = 0; i < files.Length; i++)
                {
                    lstSongs.Items.Add(files[i]);
                }
            }
        }

        private void lstSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            windowsMediaPlayerMusic.URL = paths[lstSongs.SelectedIndex];
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
            windowsMediaPlayerMusic.Dispose();
        }
    }
}
