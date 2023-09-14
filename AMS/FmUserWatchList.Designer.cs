
namespace AMS
{
    partial class FmUserWatchList
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
            this.UserWatchListGrid = new System.Windows.Forms.DataGridView();
            this.gbUserWatchList = new System.Windows.Forms.GroupBox();
            this.cbRatings = new System.Windows.Forms.ComboBox();
            this.lbRatings = new System.Windows.Forms.Label();
            this.cbWatchStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWatchStatus = new System.Windows.Forms.Label();
            this.lbAnimeTitle = new System.Windows.Forms.Label();
            this.lbAnimeID = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.tbEpisodesWatched = new System.Windows.Forms.TextBox();
            this.tbAnimeTitle = new System.Windows.Forms.TextBox();
            this.tbAnimeID = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.PbAnimePicture = new System.Windows.Forms.PictureBox();
            this.lbTotalEpisodes = new System.Windows.Forms.Label();
            this.lbEpisodeCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserWatchListGrid)).BeginInit();
            this.gbUserWatchList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnimePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // UserWatchListGrid
            // 
            this.UserWatchListGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UserWatchListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserWatchListGrid.Location = new System.Drawing.Point(377, 100);
            this.UserWatchListGrid.Name = "UserWatchListGrid";
            this.UserWatchListGrid.Size = new System.Drawing.Size(473, 271);
            this.UserWatchListGrid.TabIndex = 0;
            this.UserWatchListGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserWatchListGrid_CellContentClick);
            // 
            // gbUserWatchList
            // 
            this.gbUserWatchList.BackColor = System.Drawing.SystemColors.Highlight;
            this.gbUserWatchList.Controls.Add(this.cbRatings);
            this.gbUserWatchList.Controls.Add(this.lbRatings);
            this.gbUserWatchList.Controls.Add(this.cbWatchStatus);
            this.gbUserWatchList.Controls.Add(this.label1);
            this.gbUserWatchList.Controls.Add(this.lbWatchStatus);
            this.gbUserWatchList.Controls.Add(this.lbAnimeTitle);
            this.gbUserWatchList.Controls.Add(this.lbAnimeID);
            this.gbUserWatchList.Controls.Add(this.lbUserID);
            this.gbUserWatchList.Controls.Add(this.tbEpisodesWatched);
            this.gbUserWatchList.Controls.Add(this.tbAnimeTitle);
            this.gbUserWatchList.Controls.Add(this.tbAnimeID);
            this.gbUserWatchList.Controls.Add(this.tbUserID);
            this.gbUserWatchList.Location = new System.Drawing.Point(12, 55);
            this.gbUserWatchList.Name = "gbUserWatchList";
            this.gbUserWatchList.Size = new System.Drawing.Size(345, 422);
            this.gbUserWatchList.TabIndex = 1;
            this.gbUserWatchList.TabStop = false;
            // 
            // cbRatings
            // 
            this.cbRatings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRatings.FormattingEnabled = true;
            this.cbRatings.Items.AddRange(new object[] {
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
            this.cbRatings.Location = new System.Drawing.Point(121, 370);
            this.cbRatings.Name = "cbRatings";
            this.cbRatings.Size = new System.Drawing.Size(50, 32);
            this.cbRatings.TabIndex = 11;
            // 
            // lbRatings
            // 
            this.lbRatings.AutoSize = true;
            this.lbRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRatings.Location = new System.Drawing.Point(10, 373);
            this.lbRatings.Name = "lbRatings";
            this.lbRatings.Size = new System.Drawing.Size(72, 24);
            this.lbRatings.TabIndex = 10;
            this.lbRatings.Text = "Ratings";
            // 
            // cbWatchStatus
            // 
            this.cbWatchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWatchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWatchStatus.FormattingEnabled = true;
            this.cbWatchStatus.Items.AddRange(new object[] {
            "Currently Watching",
            "Not Yet Watched",
            "Completed",
            "Dropped"});
            this.cbWatchStatus.Location = new System.Drawing.Point(136, 241);
            this.cbWatchStatus.Name = "cbWatchStatus";
            this.cbWatchStatus.Size = new System.Drawing.Size(183, 32);
            this.cbWatchStatus.TabIndex = 9;
            this.cbWatchStatus.SelectedIndexChanged += new System.EventHandler(this.cbWatchStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Watch Status";
            // 
            // lbWatchStatus
            // 
            this.lbWatchStatus.AutoSize = true;
            this.lbWatchStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWatchStatus.Location = new System.Drawing.Point(6, 298);
            this.lbWatchStatus.Name = "lbWatchStatus";
            this.lbWatchStatus.Size = new System.Drawing.Size(94, 48);
            this.lbWatchStatus.TabIndex = 7;
            this.lbWatchStatus.Text = "Episodes \r\nWatched";
            // 
            // lbAnimeTitle
            // 
            this.lbAnimeTitle.AutoSize = true;
            this.lbAnimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimeTitle.Location = new System.Drawing.Point(16, 173);
            this.lbAnimeTitle.Name = "lbAnimeTitle";
            this.lbAnimeTitle.Size = new System.Drawing.Size(100, 24);
            this.lbAnimeTitle.TabIndex = 6;
            this.lbAnimeTitle.Text = "AnimeTitle";
            // 
            // lbAnimeID
            // 
            this.lbAnimeID.AutoSize = true;
            this.lbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimeID.Location = new System.Drawing.Point(16, 105);
            this.lbAnimeID.Name = "lbAnimeID";
            this.lbAnimeID.Size = new System.Drawing.Size(82, 24);
            this.lbAnimeID.TabIndex = 5;
            this.lbAnimeID.Text = "AnimeID";
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(16, 41);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(66, 24);
            this.lbUserID.TabIndex = 4;
            this.lbUserID.Text = "UserID";
            // 
            // tbEpisodesWatched
            // 
            this.tbEpisodesWatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEpisodesWatched.Location = new System.Drawing.Point(121, 308);
            this.tbEpisodesWatched.Name = "tbEpisodesWatched";
            this.tbEpisodesWatched.Size = new System.Drawing.Size(67, 29);
            this.tbEpisodesWatched.TabIndex = 3;
            this.tbEpisodesWatched.Validating += new System.ComponentModel.CancelEventHandler(this.tbEpisodesWatched_Validating);
            // 
            // tbAnimeTitle
            // 
            this.tbAnimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimeTitle.Location = new System.Drawing.Point(131, 177);
            this.tbAnimeTitle.Name = "tbAnimeTitle";
            this.tbAnimeTitle.ReadOnly = true;
            this.tbAnimeTitle.Size = new System.Drawing.Size(189, 29);
            this.tbAnimeTitle.TabIndex = 2;
            // 
            // tbAnimeID
            // 
            this.tbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimeID.Location = new System.Drawing.Point(131, 105);
            this.tbAnimeID.Name = "tbAnimeID";
            this.tbAnimeID.ReadOnly = true;
            this.tbAnimeID.Size = new System.Drawing.Size(189, 29);
            this.tbAnimeID.TabIndex = 1;
            // 
            // tbUserID
            // 
            this.tbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.Location = new System.Drawing.Point(131, 45);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.ReadOnly = true;
            this.tbUserID.Size = new System.Drawing.Size(189, 29);
            this.tbUserID.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(449, 399);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(189, 29);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(373, 402);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(70, 24);
            this.lbSearch.TabIndex = 10;
            this.lbSearch.Text = "Search";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(32, 483);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(88, 34);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(133, 483);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(88, 34);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(244, 483);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(88, 34);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(17, 9);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(139, 31);
            this.lbUsername.TabIndex = 14;
            this.lbUsername.Text = "Username";
            // 
            // PbAnimePicture
            // 
            this.PbAnimePicture.Location = new System.Drawing.Point(681, 390);
            this.PbAnimePicture.Name = "PbAnimePicture";
            this.PbAnimePicture.Size = new System.Drawing.Size(97, 127);
            this.PbAnimePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnimePicture.TabIndex = 15;
            this.PbAnimePicture.TabStop = false;
            // 
            // lbTotalEpisodes
            // 
            this.lbTotalEpisodes.AutoSize = true;
            this.lbTotalEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalEpisodes.Location = new System.Drawing.Point(634, 533);
            this.lbTotalEpisodes.Name = "lbTotalEpisodes";
            this.lbTotalEpisodes.Size = new System.Drawing.Size(140, 24);
            this.lbTotalEpisodes.TabIndex = 16;
            this.lbTotalEpisodes.Text = "Total Episodes:";
            // 
            // lbEpisodeCount
            // 
            this.lbEpisodeCount.AutoSize = true;
            this.lbEpisodeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEpisodeCount.Location = new System.Drawing.Point(780, 533);
            this.lbEpisodeCount.Name = "lbEpisodeCount";
            this.lbEpisodeCount.Size = new System.Drawing.Size(40, 24);
            this.lbEpisodeCount.TabIndex = 17;
            this.lbEpisodeCount.Text = "???";
            // 
            // FmUserWatchList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(874, 575);
            this.Controls.Add(this.lbEpisodeCount);
            this.Controls.Add(this.lbTotalEpisodes);
            this.Controls.Add(this.PbAnimePicture);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.gbUserWatchList);
            this.Controls.Add(this.UserWatchListGrid);
            this.Name = "FmUserWatchList";
            this.Text = "FmUserWatchList";
            this.Load += new System.EventHandler(this.FmUserWatchList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserWatchListGrid)).EndInit();
            this.gbUserWatchList.ResumeLayout(false);
            this.gbUserWatchList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnimePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UserWatchListGrid;
        private System.Windows.Forms.GroupBox gbUserWatchList;
        private System.Windows.Forms.ComboBox cbWatchStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWatchStatus;
        private System.Windows.Forms.Label lbAnimeTitle;
        private System.Windows.Forms.Label lbAnimeID;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.TextBox tbEpisodesWatched;
        private System.Windows.Forms.TextBox tbAnimeTitle;
        private System.Windows.Forms.TextBox tbAnimeID;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.PictureBox PbAnimePicture;
        private System.Windows.Forms.Label lbTotalEpisodes;
        private System.Windows.Forms.Label lbEpisodeCount;
        private System.Windows.Forms.Label lbRatings;
        private System.Windows.Forms.ComboBox cbRatings;
    }
}