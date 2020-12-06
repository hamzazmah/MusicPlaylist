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
    public partial class MusicPlaylist : Form
    {
        //Private Attributes
        private User userP;
        private int totalSongs;
        private HashSet<string> value;
        private Dictionary<string, HashSet<string>> playlist;
        private Dictionary<string, string> songFiles;
        private BinaryFormatter formatter;
        private string playlistFilename = "Playlist.dat";
        private string totalSongsFileName = "TotalSongs.dat";
        private string songFileName = "Songs.dat";


        public void SaveUserPlaylistOnDataFile()
        {
            //Gain Access to the file that I am going to write to
            try
            {
                //Create the FileStream that will write data on File
                FileStream writeFileStream = new FileStream(playlistFilename, FileMode.Create, FileAccess.Write);

                //Save my Dictionary of Friends to file
                this.formatter.Serialize(writeFileStream, playlist);

                //Close the WriteFileStream when done
                writeFileStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to Save Users Information!");
            }
        }

        public void ReadUserPlaylistDataFile()
        {
            //Check if I Had previously saved info on my Customers Datafile
            if (File.Exists(playlistFilename))
            {
                try
                {
                    //Create the FileStream will gain read Access to the Data File
                    FileStream readFileStream = new FileStream(playlistFilename, FileMode.Open, FileAccess.Read);

                    //Reconstruct information of friends from File
                    playlist = (Dictionary<string, HashSet<string>>)formatter.Deserialize(readFileStream);

                    //Close readFileStream when Done
                    readFileStream.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("There is a Problem Reading Users File!");
                }
            }
        }

        public void SaveSongFileOnDataFile()
        {
            //Gain Access to the file that I am going to write to
            try
            {
                //Create the FileStream that will write data on File
                FileStream writeFileStream = new FileStream(songFileName, FileMode.Create, FileAccess.Write);

                //Save my Dictionary of Friends to file
                this.formatter.Serialize(writeFileStream, songFiles);

                //Close the WriteFileStream when done
                writeFileStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to Save Users Information!");
            }
        }

        public void ReadSongFileDataFile()
        {
            //Check if I Had previously saved info on my Customers Datafile
            if (File.Exists(songFileName))
            {
                try
                {
                    //Create the FileStream will gain read Access to the Data File
                    FileStream readFileStream = new FileStream(songFileName, FileMode.Open, FileAccess.Read);

                    //Reconstruct information of friends from File
                    songFiles = (Dictionary<string, string>)formatter.Deserialize(readFileStream);

                    //Close readFileStream when Done
                    readFileStream.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("There is a Problem Reading Users File!");
                }
            }
        }


        private void SaveTotalSongsOnDataFile()
        {
            //Gain Access to the file that I am going to write to
            try
            {
                //Create the FileStream that will write data on File
                FileStream writeFileStream = new FileStream(totalSongsFileName, FileMode.Create, FileAccess.Write);

                //Save my Dictionary of Friends to file
                this.formatter.Serialize(writeFileStream, totalSongs);

                //Close the WriteFileStream when done
                writeFileStream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to Save Points Information!");
            }
        }

        private void ReadTotalSongsDataFile()
        {
            //Check if I Had previously saved info on my users Datafile
            if (File.Exists(totalSongsFileName))
            {
                try
                {
                    //Create the FileStream will gain read Access to the Data File
                    FileStream readFileStream = new FileStream(totalSongsFileName, FileMode.Open, FileAccess.Read);

                    //Reconstruct information of friends from File
                    totalSongs = (int)formatter.Deserialize(readFileStream);

                    //Close readFileStream when Done
                    readFileStream.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("There is a Problem Reading Points File!");
                }
            }
        }

        public MusicPlaylist(User user)
        {
            InitializeComponent();
            userP = user;
            playlistFilename = userP.UserName + playlistFilename;
            totalSongsFileName = userP.UserName + totalSongsFileName;
            songFileName = userP.UserName + songFileName;
            
        }

        public void addList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                lstSongs.Items.Add(list[i]);
            }
        }
        public void addCmb()
        {
            foreach (KeyValuePair<string, HashSet<string>> playlists in playlist)
            {
                cmbPlaylists.Items.Add(playlists.Key);
                cmbPlaylist2.Items.Add(playlists.Key);
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MusicPlaylist_Load(object sender, EventArgs e)
        {
            //Dictionary to load friends at run time
            playlist = new Dictionary<string, HashSet<string>>();
            songFiles = new Dictionary<string, string>();
            formatter = new BinaryFormatter();

            try
            {
                ReadUserPlaylistDataFile();
                ReadTotalSongsDataFile();
                ReadSongFileDataFile();
                if (userP.PremiumUser)
                {
                    txtPremium.Text = "Premium User!";
                }
                else if (!(userP.PremiumUser))
                {
                    txtPremium.Text = "Free User!";

                }
                txtLimit.Text = "Total Songs: " + totalSongs;
                addCmb();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load data file\n" + ex.Message);
            }
        }

        private void cmbPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAddNewPlaylist.Text = "";
            lstSongs.Items.Clear();
            foreach(KeyValuePair<string, HashSet<string>> kv in playlist)
            {
                if (kv.Key.Equals(cmbPlaylists.SelectedItem) && kv.Value!= null)
                {
                    List<string> list = new List<string>(kv.Value);
                    addList(list);
                }
            }
            
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            cmbPlaylists.Items.Clear();
            cmbPlaylist2.Items.Clear();
            if (txtAddNewPlaylist.Text != "")
            {
                value = new HashSet<string>();
                HashSet<string> newVal = new HashSet<string>();
                string key = txtAddNewPlaylist.Text;
                if (playlist.TryGetValue(key, out value))
                {
                    MessageBox.Show("PlayList already Exists!");
                }
                else
                {
                    playlist.Add(key, newVal);
                    MessageBox.Show("PlayList Added!");
                }
                SaveUserPlaylistOnDataFile();
                txtAddNewPlaylist.Text = "";
                addCmb();
            }
            else
            {
                MessageBox.Show("Please Enter Playlist Name!");
                addCmb();
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            txtAddNewPlaylist.Text = "";
            lstSongs.Items.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mp3 Files|*.mp3";
            if  (cmbPlaylists.SelectedIndex > -1)
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
                    {
                        if (kv.Key.Equals(cmbPlaylists.SelectedItem))
                        {
                            if (!(kv.Value.Contains(ofd.SafeFileName)))
                            {
                                if (!(userP.PremiumUser) && totalSongs > 100)
                                {
                                    MessageBox.Show("You cannot Add any More Songs! \nPlease Buy Premium!");
                                }
                                else if (!(userP.PremiumUser) && totalSongs <= 100)
                                {
                                    kv.Value.Add(ofd.SafeFileName);
                                    
                                    SaveUserPlaylistOnDataFile();

                                    if (!(songFiles.ContainsKey(ofd.SafeFileName)))
                                    {
                                        songFiles.Add(ofd.SafeFileName, ofd.FileName);
                                        SaveSongFileOnDataFile();
                                    }
                                    List<string> list = new List<string>(kv.Value);
                                    MessageBox.Show("New Song Added to the Playlist!");
                                    addList(list);
                                    totalSongs++;
                                    txtLimit.Text = "Total Songs: " + totalSongs;
                                    SaveTotalSongsOnDataFile();
                                }
                                if (userP.PremiumUser)
                                {
                                    kv.Value.Add(ofd.SafeFileName);
                                    SaveUserPlaylistOnDataFile();
                                    if (!(songFiles.ContainsKey(ofd.SafeFileName)))
                                    {
                                        songFiles.Add(ofd.SafeFileName, ofd.FileName);
                                        SaveSongFileOnDataFile();
                                    }
                                    List<string> list = new List<string>(kv.Value);
                                    MessageBox.Show("New Song Added to the Playlist!");
                                    totalSongs++;
                                    txtLimit.Text = "Total Songs: " + totalSongs;
                                    addList(list);
                                    SaveTotalSongsOnDataFile();
                                }
                            }
                            else if (kv.Value.Contains(ofd.SafeFileName))
                            {
                                MessageBox.Show("Song Already in the List!");
                                List<string> list = new List<string>(kv.Value);
                                addList(list);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Playlist First!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstSongs.SelectedIndex > -1)
            {
                foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
                {
                    if (kv.Key.Equals(cmbPlaylists.SelectedItem))
                    {
                        if (kv.Value.Contains(lstSongs.SelectedItem))
                        {
                            kv.Value.Remove(lstSongs.SelectedItem.ToString());
                            SaveUserPlaylistOnDataFile();
                            List<string> list = new List<string>(kv.Value);
                            MessageBox.Show("Song Removed from the Playlist!");
                            totalSongs--;
                            txtLimit.Text = "Total Songs: " + totalSongs;
                            lstSongs.Items.Clear();
                            addList(list);
                            SaveTotalSongsOnDataFile();
                        }
                        else
                        {
                            MessageBox.Show("Song Not in the List!");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a Song First!");
            }
        }

        private void btnDuplcateSongs_Click(object sender, EventArgs e)
        {
            lstSongs.Items.Clear();
            if (cmbPlaylists.SelectedIndex >= 0 && cmbPlaylist2.SelectedIndex >= 0)
            {
                string key1 = cmbPlaylists.SelectedItem.ToString();
                string key2 = cmbPlaylist2.SelectedItem.ToString();

                if (!(key1.Equals(key2)))
                {
                    HashSet<string> duplicate = new HashSet<string>();

                    HashSet<string> set1 = new HashSet<string>();

                    HashSet<string> set2 = new HashSet<string>();
                    foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
                    {
                        if (kv.Key.Equals(key1))
                        {
                            set1 = new HashSet<string>(kv.Value);
                        }
                        else if (kv.Key.Equals(key2))
                        {
                            set2 = new HashSet<string>(kv.Value);
                        }
                    }

                    duplicate = new HashSet<string>(set1.Intersect(set2));
                    if (duplicate.Count > 0)
                    {
                        lstSongs.Items.Add("-Duplicates between the lists-");
                        List<string> list = new List<string>(duplicate);
                        addList(list);
                    }
                    else
                    {
                        MessageBox.Show("No Duplicates!");
                    }
                }

                else
                {
                    MessageBox.Show("Plesae Select 2 Different Playlist's!");
                }

                
            }
            else
            {
                MessageBox.Show("Please Select 2 Playlist's!");
            }
            
        }

        private void btnUnifyPlaylist_Click(object sender, EventArgs e)
        {
            lstSongs.Items.Clear();
            if (cmbPlaylists.SelectedIndex >= 0 && cmbPlaylist2.SelectedIndex >= 0)
            {
                string key1 = cmbPlaylists.SelectedItem.ToString();
                string key2 = cmbPlaylist2.SelectedItem.ToString();

                if (!(key1.Equals(key2)))
                {
                    HashSet<string> unify = new HashSet<string>();

                    HashSet<string> set1 = new HashSet<string>();

                    HashSet<string> set2 = new HashSet<string>();
                    foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
                    {
                        if (kv.Key.Equals(key1))
                        {
                            set1 = new HashSet<string>(kv.Value);
                        }
                        else if (kv.Key.Equals(key2))
                        {
                            set2 = new HashSet<string>(kv.Value);
                        }
                    }

                    unify = new HashSet<string>(set1.Union(set2));
                    if (unify.Count > 0)
                    {
                        lstSongs.Items.Add("-Unified PlayLists-");
                        var list = new List<string>(unify);
                        addList(list);
                    }
                    else
                    {
                        MessageBox.Show("Playlist(s) Empty!");
                    }
                }
                else
                {
                    MessageBox.Show("Plesae Select 2 Different Playlist's!");
                }

            }
            else
            {
                MessageBox.Show("Please Select 2 Playlist's!");
            }
        }

        private void btnUnique_Click(object sender, EventArgs e)
        {
            lstSongs.Items.Clear();
            if (cmbPlaylists.SelectedIndex >= 0 && cmbPlaylist2.SelectedIndex >=  0)
            {
                string key1 = cmbPlaylists.SelectedItem.ToString();
                string key2 = cmbPlaylist2.SelectedItem.ToString();

                if (!(key1.Equals(key2)))
                {
                    HashSet<string> set1 = new HashSet<string>();

                    HashSet<string> set2 = new HashSet<string>();
                    foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
                    {
                        if (kv.Key.Equals(key1))
                        {
                            set1 = new HashSet<string>(kv.Value);
                        }
                        else if (kv.Key.Equals(key2))
                        {
                            set2 = new HashSet<string>(kv.Value);
                        }
                    }
                    if ((set1.IsSupersetOf(set2)) && set2.Count > 0 && set1.Count > 0)
                    {
                        lstSongs.Items.Add(key1 + " is a Supper Set of " + key2);
                    }
                    else
                    {
                        MessageBox.Show("Lists Empty or Not a Superset!");
                    }
                }
                else
                {
                    MessageBox.Show("Plesae Select 2 Different Playlist's!");
                }
                
            }
            else
            {
                MessageBox.Show("Please Select 2 Playlist's!");
            }
        }

        private void btnUnifyAllPlaylists_Click(object sender, EventArgs e)
        {
            lstSongs.Items.Clear();
            var listoflist = new List<List<string>>();
            HashSet<string> unify = new HashSet<string>();
            foreach (KeyValuePair<string, HashSet<string>> kv in playlist)
            {
                listoflist.Add(new List<string>(kv.Value));
            }
            if (listoflist.Count > 0)
            {
                unify = new HashSet<string>(listoflist[0]);
            }
            for (int i = 0; i < listoflist.Count; i++)
            {
                var set = new HashSet<string>(listoflist[i]);
                unify.UnionWith(set);
            }
            if (unify.Count > 0)
            {
                lstSongs.Items.Add("-Unified Playlist-");
                List<string> list = new List<string>(unify);
                addList(list);
                cmbPlaylists.SelectedItem = null;
                cmbPlaylist2.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Playlist(s) Empty!");
            }
        }

        private void btnPlayMusic_Click(object sender, EventArgs e)
        {
            Player play = new Player();
            if(lstSongs.SelectedIndex > -1)
            {
                foreach (KeyValuePair<string, string> kv in songFiles)
                {
                    if (kv.Key.Equals(lstSongs.SelectedItem.ToString()))
                    {
                        play.Show();
                        play.windowsMediaPlayerMusic.URL = kv.Value;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please Select Song!");
            }
        }
    }
}
