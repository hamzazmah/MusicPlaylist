namespace MusicPlaylists
{
    partial class MusicPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlaylist));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlaylists = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddNewPlaylist = new System.Windows.Forms.TextBox();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnifyPlaylist = new System.Windows.Forms.Button();
            this.btnUnique = new System.Windows.Forms.Button();
            this.btnDuplcateSongs = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPremium = new System.Windows.Forms.TextBox();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlayMusic = new System.Windows.Forms.Button();
            this.lstSongs = new System.Windows.Forms.ListBox();
            this.cmbPlaylist2 = new System.Windows.Forms.ComboBox();
            this.btnUnifyAllPlaylists = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Playlist:";
            // 
            // cmbPlaylists
            // 
            this.cmbPlaylists.FormattingEnabled = true;
            this.cmbPlaylists.Location = new System.Drawing.Point(57, 62);
            this.cmbPlaylists.Name = "cmbPlaylists";
            this.cmbPlaylists.Size = new System.Drawing.Size(188, 21);
            this.cmbPlaylists.TabIndex = 1;
            this.cmbPlaylists.SelectedIndexChanged += new System.EventHandler(this.cmbPlaylists_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Playlist:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Songs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(511, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add New Playlist:";
            // 
            // txtAddNewPlaylist
            // 
            this.txtAddNewPlaylist.Location = new System.Drawing.Point(606, 62);
            this.txtAddNewPlaylist.Name = "txtAddNewPlaylist";
            this.txtAddNewPlaylist.Size = new System.Drawing.Size(251, 20);
            this.txtAddNewPlaylist.TabIndex = 6;
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlaylist.Location = new System.Drawing.Point(606, 92);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(251, 32);
            this.btnAddPlaylist.TabIndex = 7;
            this.btnAddPlaylist.Text = "Add Playlist";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(507, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Playlist Functions:";
            // 
            // btnUnifyPlaylist
            // 
            this.btnUnifyPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnifyPlaylist.Location = new System.Drawing.Point(606, 168);
            this.btnUnifyPlaylist.Name = "btnUnifyPlaylist";
            this.btnUnifyPlaylist.Size = new System.Drawing.Size(117, 32);
            this.btnUnifyPlaylist.TabIndex = 9;
            this.btnUnifyPlaylist.Text = "Unify Playlists";
            this.btnUnifyPlaylist.UseVisualStyleBackColor = true;
            this.btnUnifyPlaylist.Click += new System.EventHandler(this.btnUnifyPlaylist_Click);
            // 
            // btnUnique
            // 
            this.btnUnique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnique.Location = new System.Drawing.Point(606, 206);
            this.btnUnique.Name = "btnUnique";
            this.btnUnique.Size = new System.Drawing.Size(251, 32);
            this.btnUnique.TabIndex = 10;
            this.btnUnique.Text = "Playlist Part of Another Playlist";
            this.btnUnique.UseVisualStyleBackColor = true;
            this.btnUnique.Click += new System.EventHandler(this.btnUnique_Click);
            // 
            // btnDuplcateSongs
            // 
            this.btnDuplcateSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuplcateSongs.Location = new System.Drawing.Point(606, 130);
            this.btnDuplcateSongs.Name = "btnDuplcateSongs";
            this.btnDuplcateSongs.Size = new System.Drawing.Size(251, 32);
            this.btnDuplcateSongs.TabIndex = 12;
            this.btnDuplcateSongs.Text = "DuplicateSongs";
            this.btnDuplcateSongs.UseVisualStyleBackColor = true;
            this.btnDuplcateSongs.Click += new System.EventHandler(this.btnDuplcateSongs_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(514, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 39);
            this.label6.TabIndex = 13;
            this.label6.Text = "Song Functions:";
            // 
            // btnAddSong
            // 
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Location = new System.Drawing.Point(606, 306);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(251, 52);
            this.btnAddSong.TabIndex = 20;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Snow;
            this.btnDelete.Location = new System.Drawing.Point(606, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(251, 52);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete Song";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPremium
            // 
            this.txtPremium.Location = new System.Drawing.Point(475, 422);
            this.txtPremium.Name = "txtPremium";
            this.txtPremium.Size = new System.Drawing.Size(103, 20);
            this.txtPremium.TabIndex = 22;
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(475, 454);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(103, 20);
            this.txtLimit.TabIndex = 23;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Firebrick;
            this.btnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.Location = new System.Drawing.Point(817, 0);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(46, 56);
            this.btnQuit.TabIndex = 24;
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 56);
            this.panel1.TabIndex = 25;
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPlayMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayMusic.ForeColor = System.Drawing.Color.Snow;
            this.btnPlayMusic.Location = new System.Drawing.Point(606, 422);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(251, 52);
            this.btnPlayMusic.TabIndex = 26;
            this.btnPlayMusic.Text = "Play Music";
            this.btnPlayMusic.UseVisualStyleBackColor = false;
            this.btnPlayMusic.Click += new System.EventHandler(this.btnPlayMusic_Click);
            // 
            // lstSongs
            // 
            this.lstSongs.FormattingEnabled = true;
            this.lstSongs.Location = new System.Drawing.Point(57, 93);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(412, 381);
            this.lstSongs.TabIndex = 27;
            // 
            // cmbPlaylist2
            // 
            this.cmbPlaylist2.FormattingEnabled = true;
            this.cmbPlaylist2.Location = new System.Drawing.Point(271, 62);
            this.cmbPlaylist2.Name = "cmbPlaylist2";
            this.cmbPlaylist2.Size = new System.Drawing.Size(198, 21);
            this.cmbPlaylist2.TabIndex = 28;
            // 
            // btnUnifyAllPlaylists
            // 
            this.btnUnifyAllPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnifyAllPlaylists.Location = new System.Drawing.Point(740, 168);
            this.btnUnifyAllPlaylists.Name = "btnUnifyAllPlaylists";
            this.btnUnifyAllPlaylists.Size = new System.Drawing.Size(117, 32);
            this.btnUnifyAllPlaylists.TabIndex = 30;
            this.btnUnifyAllPlaylists.Text = "Unify All Playlists";
            this.btnUnifyAllPlaylists.UseVisualStyleBackColor = true;
            this.btnUnifyAllPlaylists.Click += new System.EventHandler(this.btnUnifyAllPlaylists_Click);
            // 
            // MusicPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 479);
            this.Controls.Add(this.btnUnifyAllPlaylists);
            this.Controls.Add(this.cmbPlaylist2);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.btnPlayMusic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.txtPremium);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDuplcateSongs);
            this.Controls.Add(this.btnUnique);
            this.Controls.Add(this.btnUnifyPlaylist);
            this.Controls.Add(this.btnAddPlaylist);
            this.Controls.Add(this.txtAddNewPlaylist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPlaylists);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicPlaylist";
            this.Load += new System.EventHandler(this.MusicPlaylist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlaylists;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddNewPlaylist;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnifyPlaylist;
        private System.Windows.Forms.Button btnUnique;
        private System.Windows.Forms.Button btnDuplcateSongs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPremium;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlayMusic;
        private System.Windows.Forms.ListBox lstSongs;
        private System.Windows.Forms.ComboBox cmbPlaylist2;
        private System.Windows.Forms.Button btnUnifyAllPlaylists;
    }
}