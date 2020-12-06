using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlaylists
{
    public partial class Register : Form
    {
        //Private Attributes
        private User user;

        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool userExists = false;
            StreamReader str;
            StreamWriter stw;
            if (txtPassword.Text != "" && txtUserName.Text != "" && ((radYes.Checked) || (radNo.Checked)))
            {
                using (str = new StreamReader("Pass.txt", true))
                {
                    while (!str.EndOfStream)
                    {
                        if (str.ReadLine().Equals(txtUserName.Text))
                        {
                            userExists = true;
                        }

                    }
                }

                if (userExists == false)
                {
                    using (stw = new StreamWriter("Pass.txt", append: true))
                    {
                        stw.WriteLine(txtUserName.Text);
                        stw.WriteLine(txtPassword.Text);
                        if (radYes.Checked)
                        {
                            stw.WriteLine("true");
                            user = new User(txtUserName.Text, txtPassword.Text, true);
                        }
                        else if (radNo.Checked)
                        {
                            stw.WriteLine("false");
                            user = new User(txtUserName.Text, txtPassword.Text, false);
                        }
                        MusicPlaylist mp = new MusicPlaylist(user);
                        this.Visible = false;
                        MessageBox.Show(txtUserName.Text, " Welcome!");
                        mp.Show();
                    }
                }
                else
                {
                    MessageBox.Show("You are already Registered!");
                }
            }
            else
            {
                MessageBox.Show("Field(s) cannot be Empty!");
            }       
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
