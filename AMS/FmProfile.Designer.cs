namespace AMS
{
    partial class FmProfile
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
            this.lbUsername = new System.Windows.Forms.Label();
            this.DbForename = new System.Windows.Forms.Label();
            this.DbSurname = new System.Windows.Forms.Label();
            this.btFavourites = new System.Windows.Forms.Button();
            this.btWatchList = new System.Windows.Forms.Button();
            this.btStats = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.GbUserInformation = new System.Windows.Forms.GroupBox();
            this.DbUserID = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.DbUserType = new System.Windows.Forms.Label();
            this.lbUserType = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbForename = new System.Windows.Forms.Label();
            this.GbUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(5, 9);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(164, 37);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // DbForename
            // 
            this.DbForename.AutoSize = true;
            this.DbForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbForename.Location = new System.Drawing.Point(109, 84);
            this.DbForename.Name = "DbForename";
            this.DbForename.Size = new System.Drawing.Size(98, 24);
            this.DbForename.TabIndex = 3;
            this.DbForename.Text = "Forename";
            // 
            // DbSurname
            // 
            this.DbSurname.AutoSize = true;
            this.DbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbSurname.Location = new System.Drawing.Point(109, 128);
            this.DbSurname.Name = "DbSurname";
            this.DbSurname.Size = new System.Drawing.Size(87, 24);
            this.DbSurname.TabIndex = 4;
            this.DbSurname.Text = "Surname";
            // 
            // btFavourites
            // 
            this.btFavourites.BackColor = System.Drawing.SystemColors.Highlight;
            this.btFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFavourites.Location = new System.Drawing.Point(12, 154);
            this.btFavourites.Name = "btFavourites";
            this.btFavourites.Size = new System.Drawing.Size(142, 49);
            this.btFavourites.TabIndex = 6;
            this.btFavourites.Text = "Favourites";
            this.btFavourites.UseVisualStyleBackColor = false;
            this.btFavourites.Click += new System.EventHandler(this.btFavourites_Click);
            // 
            // btWatchList
            // 
            this.btWatchList.BackColor = System.Drawing.SystemColors.Highlight;
            this.btWatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWatchList.Location = new System.Drawing.Point(12, 98);
            this.btWatchList.Name = "btWatchList";
            this.btWatchList.Size = new System.Drawing.Size(142, 42);
            this.btWatchList.TabIndex = 7;
            this.btWatchList.Text = "WatchList";
            this.btWatchList.UseVisualStyleBackColor = false;
            this.btWatchList.Click += new System.EventHandler(this.btWatchList_Click);
            // 
            // btStats
            // 
            this.btStats.BackColor = System.Drawing.SystemColors.Highlight;
            this.btStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStats.Location = new System.Drawing.Point(12, 219);
            this.btStats.Name = "btStats";
            this.btStats.Size = new System.Drawing.Size(142, 47);
            this.btStats.TabIndex = 8;
            this.btStats.Text = "Stats";
            this.btStats.UseVisualStyleBackColor = false;
            this.btStats.Click += new System.EventHandler(this.btStats_Click);
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.Control;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(443, 309);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(113, 66);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "Reset Password?";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // GbUserInformation
            // 
            this.GbUserInformation.BackColor = System.Drawing.SystemColors.Highlight;
            this.GbUserInformation.Controls.Add(this.DbUserID);
            this.GbUserInformation.Controls.Add(this.lbUserID);
            this.GbUserInformation.Controls.Add(this.DbUserType);
            this.GbUserInformation.Controls.Add(this.lbUserType);
            this.GbUserInformation.Controls.Add(this.lbSurname);
            this.GbUserInformation.Controls.Add(this.lbForename);
            this.GbUserInformation.Controls.Add(this.DbForename);
            this.GbUserInformation.Controls.Add(this.DbSurname);
            this.GbUserInformation.Location = new System.Drawing.Point(188, 70);
            this.GbUserInformation.Name = "GbUserInformation";
            this.GbUserInformation.Size = new System.Drawing.Size(368, 233);
            this.GbUserInformation.TabIndex = 10;
            this.GbUserInformation.TabStop = false;
            this.GbUserInformation.Text = "User Information";
            // 
            // DbUserID
            // 
            this.DbUserID.AutoSize = true;
            this.DbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbUserID.Location = new System.Drawing.Point(83, 37);
            this.DbUserID.Name = "DbUserID";
            this.DbUserID.Size = new System.Drawing.Size(66, 24);
            this.DbUserID.TabIndex = 10;
            this.DbUserID.Text = "UserID";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(6, 37);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(71, 24);
            this.lbUserID.TabIndex = 9;
            this.lbUserID.Text = "UserID:";
            // 
            // DbUserType
            // 
            this.DbUserType.AutoSize = true;
            this.DbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbUserType.Location = new System.Drawing.Point(109, 172);
            this.DbUserType.Name = "DbUserType";
            this.DbUserType.Size = new System.Drawing.Size(92, 24);
            this.DbUserType.TabIndex = 8;
            this.DbUserType.Text = "UserType";
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.Location = new System.Drawing.Point(6, 172);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(97, 24);
            this.lbUserType.TabIndex = 7;
            this.lbUserType.Text = "UserType:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.Location = new System.Drawing.Point(6, 128);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(92, 24);
            this.lbSurname.TabIndex = 6;
            this.lbSurname.Text = "Surname:";
            // 
            // lbForename
            // 
            this.lbForename.AutoSize = true;
            this.lbForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForename.Location = new System.Drawing.Point(6, 84);
            this.lbForename.Name = "lbForename";
            this.lbForename.Size = new System.Drawing.Size(103, 24);
            this.lbForename.TabIndex = 5;
            this.lbForename.Text = "Forename:";
            // 
            // FmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 387);
            this.Controls.Add(this.GbUserInformation);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStats);
            this.Controls.Add(this.btWatchList);
            this.Controls.Add(this.btFavourites);
            this.Controls.Add(this.lbUsername);
            this.Name = "FmProfile";
            this.Text = "FmProfile";
            this.Load += new System.EventHandler(this.FmProfile_Load);
            this.GbUserInformation.ResumeLayout(false);
            this.GbUserInformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label DbForename;
        private System.Windows.Forms.Label DbSurname;
        private System.Windows.Forms.Button btFavourites;
        private System.Windows.Forms.Button btWatchList;
        private System.Windows.Forms.Button btStats;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.GroupBox GbUserInformation;
        private System.Windows.Forms.Label DbUserType;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbForename;
        private System.Windows.Forms.Label DbUserID;
        private System.Windows.Forms.Label lbUserID;
    }
}