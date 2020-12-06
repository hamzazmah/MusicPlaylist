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
    public partial class Login : Form
    {
        //Private Attributes
        private User user;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string login = "Default"; 
            string pass = "Default";
            bool premium = false;
            int counter = 0;
            StreamReader str;
            using (str = new StreamReader("Pass.txt", true))
            {
                while (!str.EndOfStream)
                {
                    string line = str.ReadLine();
                    if (line.Equals(txtUserName.Text))
                    {
                        login = line;
                        
                        break;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }
            using (str = new StreamReader("Pass.txt", true))
            {
                try
                {
                    string line = File.ReadLines("Pass.txt").Skip(counter+1).Take(1).First();
                    if (line.Equals(txtPassword.Text))
                    {
                        pass = line;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                
            }
            using (str = new StreamReader("Pass.txt", true))
            {
                try
                {
                    string line = File.ReadLines("Pass.txt").Skip(counter+2).Take(1).First();
                    if (line.Equals("true"))
                    {
                        premium = Convert.ToBoolean(line);
                    }
                }
                catch (Exception ex)
                {

                }

            }
            if (txtUserName.Text == login && txtPassword.Text == pass)
            {
                user = new User(login, pass, premium);
                MusicPlaylist mpl = new MusicPlaylist(user);
                this.Visible = false;
                MessageBox.Show(txtUserName.Text, " Welcome!");
                mpl.Show();
            }
            else if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("User id or password is missing");
            }
            else if (txtUserName.Text != login || txtPassword.Text != pass)
            {
                MessageBox.Show("Invalid ID or Password");
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            this.Visible = false;
            reg.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

