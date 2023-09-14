
namespace AMS
{
    partial class FmUserFavourites
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
            this.GbUserFavourites = new System.Windows.Forms.GroupBox();
            this.cbRatings = new System.Windows.Forms.ComboBox();
            this.lbRatings = new System.Windows.Forms.Label();
            this.lbAnimeTitle = new System.Windows.Forms.Label();
            this.lbAnimeID = new System.Windows.Forms.Label();
            this.lbUserID = new System.Windows.Forms.Label();
            this.tbAnimeTitle = new System.Windows.Forms.TextBox();
            this.tbAnimeID = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.UserFavouritesGrid = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.PbAnimePicture = new System.Windows.Forms.PictureBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.GbUserFavourites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserFavouritesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnimePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // GbUserFavourites
            // 
            this.GbUserFavourites.BackColor = System.Drawing.SystemColors.Highlight;
            this.GbUserFavourites.Controls.Add(this.cbRatings);
            this.GbUserFavourites.Controls.Add(this.lbRatings);
            this.GbUserFavourites.Controls.Add(this.lbAnimeTitle);
            this.GbUserFavourites.Controls.Add(this.lbAnimeID);
            this.GbUserFavourites.Controls.Add(this.lbUserID);
            this.GbUserFavourites.Controls.Add(this.tbAnimeTitle);
            this.GbUserFavourites.Controls.Add(this.tbAnimeID);
            this.GbUserFavourites.Controls.Add(this.tbUserID);
            this.GbUserFavourites.Location = new System.Drawing.Point(12, 66);
            this.GbUserFavourites.Name = "GbUserFavourites";
            this.GbUserFavourites.Size = new System.Drawing.Size(345, 315);
            this.GbUserFavourites.TabIndex = 2;
            this.GbUserFavourites.TabStop = false;
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
            this.cbRatings.Location = new System.Drawing.Point(131, 241);
            this.cbRatings.Name = "cbRatings";
            this.cbRatings.Size = new System.Drawing.Size(50, 32);
            this.cbRatings.TabIndex = 9;
            // 
            // lbRatings
            // 
            this.lbRatings.AutoSize = true;
            this.lbRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRatings.Location = new System.Drawing.Point(26, 244);
            this.lbRatings.Name = "lbRatings";
            this.lbRatings.Size = new System.Drawing.Size(72, 24);
            this.lbRatings.TabIndex = 8;
            this.lbRatings.Text = "Ratings";
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
            // tbAnimeTitle
            // 
            this.tbAnimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimeTitle.Location = new System.Drawing.Point(131, 168);
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
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(26, 20);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(139, 31);
            this.lbUsername.TabIndex = 15;
            this.lbUsername.Text = "Username";
            // 
            // UserFavouritesGrid
            // 
            this.UserFavouritesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UserFavouritesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserFavouritesGrid.Location = new System.Drawing.Point(375, 68);
            this.UserFavouritesGrid.Name = "UserFavouritesGrid";
            this.UserFavouritesGrid.Size = new System.Drawing.Size(473, 271);
            this.UserFavouritesGrid.TabIndex = 10;
            this.UserFavouritesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserFavouritesGrid_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(458, 373);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(189, 29);
            this.tbSearch.TabIndex = 16;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(382, 376);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(70, 24);
            this.lbSearch.TabIndex = 17;
            this.lbSearch.Text = "Search";
            // 
            // PbAnimePicture
            // 
            this.PbAnimePicture.Location = new System.Drawing.Point(718, 376);
            this.PbAnimePicture.Name = "PbAnimePicture";
            this.PbAnimePicture.Size = new System.Drawing.Size(97, 127);
            this.PbAnimePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbAnimePicture.TabIndex = 18;
            this.PbAnimePicture.TabStop = false;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(22, 400);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(88, 34);
            this.btClear.TabIndex = 19;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(130, 400);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(88, 34);
            this.btUpdate.TabIndex = 20;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(244, 400);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(88, 34);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // FmUserFavourites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(880, 560);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.PbAnimePicture);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.UserFavouritesGrid);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.GbUserFavourites);
            this.Name = "FmUserFavourites";
            this.Text = "FmUserFavourites";
            this.Load += new System.EventHandler(this.FmUserFavourites_Load);
            this.GbUserFavourites.ResumeLayout(false);
            this.GbUserFavourites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserFavouritesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbAnimePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbUserFavourites;
        private System.Windows.Forms.ComboBox cbRatings;
        private System.Windows.Forms.Label lbRatings;
        private System.Windows.Forms.Label lbAnimeTitle;
        private System.Windows.Forms.Label lbAnimeID;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.TextBox tbAnimeTitle;
        private System.Windows.Forms.TextBox tbAnimeID;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.DataGridView UserFavouritesGrid;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.PictureBox PbAnimePicture;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
    }
}