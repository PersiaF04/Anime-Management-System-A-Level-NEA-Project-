
namespace AMS
{
    partial class FmEditAnimes
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
            this.lbAnimeID = new System.Windows.Forms.Label();
            this.lbAnimeTitle = new System.Windows.Forms.Label();
            this.lbEpisodes = new System.Windows.Forms.Label();
            this.lbRatings = new System.Windows.Forms.Label();
            this.tbAnimeID = new System.Windows.Forms.TextBox();
            this.tbAnimeTitle = new System.Windows.Forms.TextBox();
            this.tbEpisodes = new System.Windows.Forms.TextBox();
            this.tbRatings = new System.Windows.Forms.TextBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnimeSynopsis = new System.Windows.Forms.TextBox();
            this.tbAnimePictures = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbAnimeID
            // 
            this.lbAnimeID.AutoSize = true;
            this.lbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimeID.Location = new System.Drawing.Point(28, 43);
            this.lbAnimeID.Name = "lbAnimeID";
            this.lbAnimeID.Size = new System.Drawing.Size(82, 24);
            this.lbAnimeID.TabIndex = 0;
            this.lbAnimeID.Text = "AnimeID";
            // 
            // lbAnimeTitle
            // 
            this.lbAnimeTitle.AutoSize = true;
            this.lbAnimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimeTitle.Location = new System.Drawing.Point(28, 105);
            this.lbAnimeTitle.Name = "lbAnimeTitle";
            this.lbAnimeTitle.Size = new System.Drawing.Size(100, 24);
            this.lbAnimeTitle.TabIndex = 1;
            this.lbAnimeTitle.Text = "AnimeTitle";
            // 
            // lbEpisodes
            // 
            this.lbEpisodes.AutoSize = true;
            this.lbEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEpisodes.Location = new System.Drawing.Point(28, 166);
            this.lbEpisodes.Name = "lbEpisodes";
            this.lbEpisodes.Size = new System.Drawing.Size(89, 24);
            this.lbEpisodes.TabIndex = 2;
            this.lbEpisodes.Text = "Episodes";
            // 
            // lbRatings
            // 
            this.lbRatings.AutoSize = true;
            this.lbRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRatings.Location = new System.Drawing.Point(28, 236);
            this.lbRatings.Name = "lbRatings";
            this.lbRatings.Size = new System.Drawing.Size(72, 24);
            this.lbRatings.TabIndex = 4;
            this.lbRatings.Text = "Ratings";
            // 
            // tbAnimeID
            // 
            this.tbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimeID.Location = new System.Drawing.Point(138, 40);
            this.tbAnimeID.Name = "tbAnimeID";
            this.tbAnimeID.Size = new System.Drawing.Size(243, 29);
            this.tbAnimeID.TabIndex = 5;
            // 
            // tbAnimeTitle
            // 
            this.tbAnimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimeTitle.Location = new System.Drawing.Point(138, 105);
            this.tbAnimeTitle.Name = "tbAnimeTitle";
            this.tbAnimeTitle.Size = new System.Drawing.Size(243, 29);
            this.tbAnimeTitle.TabIndex = 6;
            // 
            // tbEpisodes
            // 
            this.tbEpisodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEpisodes.Location = new System.Drawing.Point(138, 171);
            this.tbEpisodes.Name = "tbEpisodes";
            this.tbEpisodes.Size = new System.Drawing.Size(243, 29);
            this.tbEpisodes.TabIndex = 7;
            // 
            // tbRatings
            // 
            this.tbRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRatings.Location = new System.Drawing.Point(138, 236);
            this.tbRatings.Name = "tbRatings";
            this.tbRatings.Size = new System.Drawing.Size(243, 29);
            this.tbRatings.TabIndex = 9;
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(152, 440);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(97, 42);
            this.btInsert.TabIndex = 10;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(439, 440);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(97, 42);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(295, 440);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(97, 42);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(20, 440);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(97, 42);
            this.btClear.TabIndex = 13;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "AnimeSynopsis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "AnimePictures";
            // 
            // tbAnimeSynopsis
            // 
            this.tbAnimeSynopsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimeSynopsis.Location = new System.Drawing.Point(175, 299);
            this.tbAnimeSynopsis.MaxLength = 64000;
            this.tbAnimeSynopsis.Multiline = true;
            this.tbAnimeSynopsis.Name = "tbAnimeSynopsis";
            this.tbAnimeSynopsis.Size = new System.Drawing.Size(243, 27);
            this.tbAnimeSynopsis.TabIndex = 16;
            // 
            // tbAnimePictures
            // 
            this.tbAnimePictures.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimePictures.Location = new System.Drawing.Point(175, 363);
            this.tbAnimePictures.Name = "tbAnimePictures";
            this.tbAnimePictures.Size = new System.Drawing.Size(243, 29);
            this.tbAnimePictures.TabIndex = 17;
            // 
            // FmEditAnimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(591, 494);
            this.Controls.Add(this.tbAnimePictures);
            this.Controls.Add(this.tbAnimeSynopsis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.tbRatings);
            this.Controls.Add(this.tbEpisodes);
            this.Controls.Add(this.tbAnimeTitle);
            this.Controls.Add(this.tbAnimeID);
            this.Controls.Add(this.lbRatings);
            this.Controls.Add(this.lbEpisodes);
            this.Controls.Add(this.lbAnimeTitle);
            this.Controls.Add(this.lbAnimeID);
            this.Name = "FmEditAnimes";
            this.Text = "FmEditAnimes";
            this.Load += new System.EventHandler(this.FmEditAnimes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnimeID;
        private System.Windows.Forms.Label lbAnimeTitle;
        private System.Windows.Forms.Label lbEpisodes;
        private System.Windows.Forms.Label lbRatings;
        private System.Windows.Forms.TextBox tbAnimeID;
        private System.Windows.Forms.TextBox tbAnimeTitle;
        private System.Windows.Forms.TextBox tbEpisodes;
        private System.Windows.Forms.TextBox tbRatings;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnimeSynopsis;
        private System.Windows.Forms.TextBox tbAnimePictures;
    }
}