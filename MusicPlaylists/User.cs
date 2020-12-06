using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylists
{
    [Serializable]
    public class User
    {
        //Private Attributes
        private string userName;
        private string password;
        private bool premiumUser;

        //Getters & Setters
        public string UserName { get { return this.userName; } set { this.userName = value; } }

        public string Password { get { return this.password; } set { this.password = value; } }

        public bool PremiumUser { get { return this.premiumUser; } set { this.premiumUser = value; } }

        //Constructor
        public User()
        {
            userName = "";
            password = "";
            premiumUser = false;
        }
        public User(string userName,string password, bool premiumUser)
        {
            this.userName = userName;
            this.password = password;
            this.premiumUser = premiumUser;
        }

        public override string ToString()
        {
            return ("User: " + this.userName + " \t User has Premium: " + this.premiumUser);
        }

        public class ApplicationContext
        {
            private ApplicationContext()
            {
            }

            public User UserInfo { get; set; }

            public static ApplicationContext Current { get; set; }

            public void Init(User userInfo)
            {
                if (Current != null)
                    throw new Exception("Context already initialized");

                Current = new ApplicationContext()
                {
                    UserInfo = userInfo
                };
            }
        }
    }
}
