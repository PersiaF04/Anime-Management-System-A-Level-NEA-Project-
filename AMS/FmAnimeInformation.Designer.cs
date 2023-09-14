
namespace AMS
{
    partial class FmAnimeInformation
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbAnimeSynopsis = new System.Windows.Forms.RichTextBox();
            this.PbAnimePicture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAms = new System.Windows.Forms.Label();
            this.btFavourites = new System.Windows.Forms.Button();
            this.lbAnimeID = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbRatings = new System.Windows.Forms.Label();
            this.lbGenres = new System.Windows.Forms.Label();
            this.DbAnimeID = new System.Windows.Forms.Label();
            this.DbStatus = new System.Windows.Forms.Label();
            this.DbRatings = new System.Windows.Forms.Label();
            this.lbAnimeName = new System.Windows.Forms.Label();
            this.lbRate = new System.Windows.Forms.Label();
            this.lbStudios = new System.Windows.Forms.Label();
            this.DbStudios = new System.Windows.Forms.Label();
            this.tbGenres = new System.Windows.Forms.TextBox();
            this.cbRate = new System.Windows.Forms.ComboBox();
            this.lbEpisodes = new System.Windows.Forms.Label();
            this.DbEpisodes = new System.Windows.Forms.Label();
            this.lbEpisodesWatched = new System.Windows.Forms.Label();
            this.tbEpisodesWatched = new System.Windows.Forms.TextBox();
            this.btWatchList = new System.Windows.Forms.Button();
            this.lbWatchStatus = new System.Windows.Forms.Label();
            this.cbWatchStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnimePicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // rtbAnimeSynopsis
            // 
            this.rtbAnimeSynopsis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtbAnimeSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnimeSynopsis.Location = new System.Drawing.Point(255, 107);
            this.rtbAnimeSynopsis.Name = "rtbAnimeSynopsis";
            this.rtbAnimeSynopsis.ReadOnly = true;
            this.rtbAnimeSynopsis.Size = new System.Drawing.Size(425, 341);
            this.rtbAnimeSynopsis.TabIndex = 1;
            this.rtbAnimeSynopsis.Text = "";
            // 
            // PbAnimePicture
            // 
            this.PbAnimePicture.Location = new System.Drawing.Point(12, 119);
            this.PbAnimePicture.Name = "PbAnimePicture";
            this.PbAnimePicture.Size = new System.Drawing.Size(163, 215);
            this.PbAnimePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnimePicture.TabIndex = 2;
            this.PbAnimePicture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.lbAms);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lbAms
            // 
            this.lbAms.AutoSize = true;
            this.lbAms.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAms.Location = new System.Drawing.Point(273, 16);
            this.lbAms.Name = "lbAms";
            this.lbAms.Size = new System.Drawing.Size(171, 73);
            this.lbAms.TabIndex = 2;
            this.lbAms.Text = "AMS";
            // 
            // btFavourites
            // 
            this.btFavourites.BackColor = System.Drawing.SystemColors.Highlight;
            this.btFavourites.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFavourites.Location = new System.Drawing.Point(12, 404);
            this.btFavourites.Name = "btFavourites";
            this.btFavourites.Size = new System.Drawing.Size(171, 33);
            this.btFavourites.TabIndex = 6;
            this.btFavourites.Text = "Add to favourites";
            this.btFavourites.UseVisualStyleBackColor = false;
            this.btFavourites.Click += new System.EventHandler(this.btFavourites_Click);
            // 
            // lbAnimeID
            // 
            this.lbAnimeID.AutoSize = true;
            this.lbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimeID.Location = new System.Drawing.Point(12, 507);
            this.lbAnimeID.Name = "lbAnimeID";
            this.lbAnimeID.Size = new System.Drawing.Size(98, 24);
            this.lbAnimeID.TabIndex = 8;
            this.lbAnimeID.Text = "AnimeID =";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(12, 549);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(76, 24);
            this.lbStatus.TabIndex = 9;
            this.lbStatus.Text = "Status =";
            // 
            // lbRatings
            // 
            this.lbRatings.AutoSize = true;
            this.lbRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRatings.Location = new System.Drawing.Point(12, 594);
            this.lbRatings.Name = "lbRatings";
            this.lbRatings.Size = new System.Drawing.Size(88, 24);
            this.lbRatings.TabIndex = 10;
            this.lbRatings.Text = "Ratings =";
            // 
            // lbGenres
            // 
            this.lbGenres.AutoSize = true;
            this.lbGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenres.Location = new System.Drawing.Point(249, 507);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(88, 24);
            this.lbGenres.TabIndex = 11;
            this.lbGenres.Text = "Genres =";
            // 
            // DbAnimeID
            // 
            this.DbAnimeID.AutoSize = true;
            this.DbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbAnimeID.Location = new System.Drawing.Point(106, 507);
            this.DbAnimeID.Name = "DbAnimeID";
            this.DbAnimeID.Size = new System.Drawing.Size(25, 24);
            this.DbAnimeID.TabIndex = 13;
            this.DbAnimeID.Text = "...";
            // 
            // DbStatus
            // 
            this.DbStatus.AutoSize = true;
            this.DbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbStatus.Location = new System.Drawing.Point(94, 549);
            this.DbStatus.Name = "DbStatus";
            this.DbStatus.Size = new System.Drawing.Size(25, 24);
            this.DbStatus.TabIndex = 14;
            this.DbStatus.Text = "...";
            // 
            // DbRatings
            // 
            this.DbRatings.AutoSize = true;
            this.DbRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbRatings.Location = new System.Drawing.Point(106, 594);
            this.DbRatings.Name = "DbRatings";
            this.DbRatings.Size = new System.Drawing.Size(25, 24);
            this.DbRatings.TabIndex = 15;
            this.DbRatings.Text = "...";
            // 
            // lbAnimeName
            // 
            this.lbAnimeName.AutoSize = true;
            this.lbAnimeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimeName.Location = new System.Drawing.Point(19, 361);
            this.lbAnimeName.Name = "lbAnimeName";
            this.lbAnimeName.Size = new System.Drawing.Size(100, 24);
            this.lbAnimeName.TabIndex = 16;
            this.lbAnimeName.Text = "AnimeTitle";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRate.Location = new System.Drawing.Point(251, 465);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(48, 24);
            this.lbRate.TabIndex = 17;
            this.lbRate.Text = "Rate";
            // 
            // lbStudios
            // 
            this.lbStudios.AutoSize = true;
            this.lbStudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudios.Location = new System.Drawing.Point(249, 594);
            this.lbStudios.Name = "lbStudios";
            this.lbStudios.Size = new System.Drawing.Size(88, 24);
            this.lbStudios.TabIndex = 18;
            this.lbStudios.Text = "Studios =";
            // 
            // DbStudios
            // 
            this.DbStudios.AutoSize = true;
            this.DbStudios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbStudios.Location = new System.Drawing.Point(345, 594);
            this.DbStudios.Name = "DbStudios";
            this.DbStudios.Size = new System.Drawing.Size(25, 24);
            this.DbStudios.TabIndex = 19;
            this.DbStudios.Text = "...";
            // 
            // tbGenres
            // 
            this.tbGenres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbGenres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbGenres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGenres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenres.Location = new System.Drawing.Point(349, 511);
            this.tbGenres.Multiline = true;
            this.tbGenres.Name = "tbGenres";
            this.tbGenres.ReadOnly = true;
            this.tbGenres.Size = new System.Drawing.Size(320, 20);
            this.tbGenres.TabIndex = 20;
            // 
            // cbRate
            // 
            this.cbRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRate.FormatString = "N0";
            this.cbRate.FormattingEnabled = true;
            this.cbRate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbRate.Location = new System.Drawing.Point(305, 468);
            this.cbRate.Name = "cbRate";
            this.cbRate.Size = new System.Drawing.Size(45, 21);
            this.cbRate.TabIndex = 21;
            // 
            // lbEpisodes
            // 
            this.lbEpisodes.AutoSize = true;
            this.lbEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEpisodes.Location = new System.Drawing.Point(249, 549);
            this.lbEpisodes.Name = "lbEpisodes";
            this.lbEpisodes.Size = new System.Drawing.Size(89, 24);
            this.lbEpisodes.TabIndex = 22;
            this.lbEpisodes.Text = "Episodes";
            // 
            // DbEpisodes
            // 
            this.DbEpisodes.AutoSize = true;
            this.DbEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DbEpisodes.Location = new System.Drawing.Point(345, 549);
            this.DbEpisodes.Name = "DbEpisodes";
            this.DbEpisodes.Size = new System.Drawing.Size(25, 24);
            this.DbEpisodes.TabIndex = 23;
            this.DbEpisodes.Text = "...";
            // 
            // lbEpisodesWatched
            // 
            this.lbEpisodesWatched.AutoSize = true;
            this.lbEpisodesWatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEpisodesWatched.Location = new System.Drawing.Point(402, 465);
            this.lbEpisodesWatched.Name = "lbEpisodesWatched";
            this.lbEpisodesWatched.Size = new System.Drawing.Size(174, 24);
            this.lbEpisodesWatched.TabIndex = 24;
            this.lbEpisodesWatched.Text = "Episodes Watched:";
            // 
            // tbEpisodesWatched
            // 
            this.tbEpisodesWatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEpisodesWatched.Location = new System.Drawing.Point(593, 462);
            this.tbEpisodesWatched.Name = "tbEpisodesWatched";
            this.tbEpisodesWatched.Size = new System.Drawing.Size(56, 29);
            this.tbEpisodesWatched.TabIndex = 25;
            this.tbEpisodesWatched.Text = "0";
            this.tbEpisodesWatched.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbEpisodesWatched.Validating += new System.ComponentModel.CancelEventHandler(this.tbEpisodeWatched_Validating);
            // 
            // btWatchList
            // 
            this.btWatchList.BackColor = System.Drawing.SystemColors.Highlight;
            this.btWatchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWatchList.Location = new System.Drawing.Point(12, 454);
            this.btWatchList.Name = "btWatchList";
            this.btWatchList.Size = new System.Drawing.Size(171, 33);
            this.btWatchList.TabIndex = 26;
            this.btWatchList.Text = "Add to WatchList";
            this.btWatchList.UseVisualStyleBackColor = false;
            this.btWatchList.Click += new System.EventHandler(this.btWatchList_Click);
            // 
            // lbWatchStatus
            // 
            this.lbWatchStatus.AutoSize = true;
            this.lbWatchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWatchStatus.Location = new System.Drawing.Point(374, 647);
            this.lbWatchStatus.Name = "lbWatchStatus";
            this.lbWatchStatus.Size = new System.Drawing.Size(123, 24);
            this.lbWatchStatus.TabIndex = 29;
            this.lbWatchStatus.Text = "Watch Status:";
            // 
            // cbWatchStatus
            // 
            this.cbWatchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWatchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWatchStatus.FormattingEnabled = true;
            this.cbWatchStatus.Items.AddRange(new object[] {
            "Not Yet Watched",
            "Currently Watching",
            "Completed",
            "Dropped"});
            this.cbWatchStatus.Location = new System.Drawing.Point(503, 644);
            this.cbWatchStatus.Name = "cbWatchStatus";
            this.cbWatchStatus.Size = new System.Drawing.Size(157, 32);
            this.cbWatchStatus.TabIndex = 30;
            this.cbWatchStatus.SelectedIndexChanged += new System.EventHandler(this.cbWatchStatus_SelectedIndexChanged);
            // 
            // FmAnimeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(741, 703);
            this.Controls.Add(this.tbGenres);
            this.Controls.Add(this.cbWatchStatus);
            this.Controls.Add(this.lbWatchStatus);
            this.Controls.Add(this.btWatchList);
            this.Controls.Add(this.tbEpisodesWatched);
            this.Controls.Add(this.lbEpisodesWatched);
            this.Controls.Add(this.DbEpisodes);
            this.Controls.Add(this.lbEpisodes);
            this.Controls.Add(this.cbRate);
            this.Controls.Add(this.DbStudios);
            this.Controls.Add(this.lbStudios);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.lbAnimeName);
            this.Controls.Add(this.DbRatings);
            this.Controls.Add(this.DbStatus);
            this.Controls.Add(this.DbAnimeID);
            this.Controls.Add(this.lbGenres);
            this.Controls.Add(this.lbRatings);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbAnimeID);
            this.Controls.Add(this.btFavourites);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PbAnimePicture);
            this.Controls.Add(this.rtbAnimeSynopsis);
            this.Controls.Add(this.label1);
            this.Name = "FmAnimeInformation";
            this.Text = "FmAnimeInformation";
            this.Load += new System.EventHandler(this.FmAnimeInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbAnimePicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbAnimeSynopsis;
        private System.Windows.Forms.PictureBox PbAnimePicture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbAms;
        private System.Windows.Forms.Button btFavourites;
        private System.Windows.Forms.Label lbAnimeID;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbRatings;
        private System.Windows.Forms.Label lbGenres;
        private System.Windows.Forms.Label DbAnimeID;
        private System.Windows.Forms.Label DbStatus;
        private System.Windows.Forms.Label DbRatings;
        private System.Windows.Forms.Label lbAnimeName;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Label lbStudios;
        private System.Windows.Forms.Label DbStudios;
        private System.Windows.Forms.TextBox tbGenres;
        private System.Windows.Forms.ComboBox cbRate;
        private System.Windows.Forms.Label lbEpisodes;
        private System.Windows.Forms.Label DbEpisodes;
        private System.Windows.Forms.Label lbEpisodesWatched;
        private System.Windows.Forms.TextBox tbEpisodesWatched;
        private System.Windows.Forms.Button btWatchList;
        private System.Windows.Forms.Label lbWatchStatus;
        private System.Windows.Forms.ComboBox cbWatchStatus;
    }
}