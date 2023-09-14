
namespace AMS
{
    partial class FmEditAnimeStatus
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.tbAnimeID = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAnimeID
            // 
            this.lbAnimeID.AutoSize = true;
            this.lbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimeID.Location = new System.Drawing.Point(12, 72);
            this.lbAnimeID.Name = "lbAnimeID";
            this.lbAnimeID.Size = new System.Drawing.Size(82, 24);
            this.lbAnimeID.TabIndex = 0;
            this.lbAnimeID.Text = "AnimeID";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(12, 133);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(60, 24);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Status";
            // 
            // tbAnimeID
            // 
            this.tbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimeID.Location = new System.Drawing.Point(110, 69);
            this.tbAnimeID.Name = "tbAnimeID";
            this.tbAnimeID.Size = new System.Drawing.Size(178, 29);
            this.tbAnimeID.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Finished Airing",
            "Currently Airing",
            "Not Yet Aired"});
            this.cbStatus.Location = new System.Drawing.Point(110, 133);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(164, 32);
            this.cbStatus.TabIndex = 3;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(16, 203);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(97, 42);
            this.btClear.TabIndex = 17;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(119, 203);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(97, 42);
            this.btInsert.TabIndex = 18;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(222, 203);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(97, 42);
            this.btUpdate.TabIndex = 19;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(325, 203);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(97, 42);
            this.btDelete.TabIndex = 20;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // FmEditAnimeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 257);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.tbAnimeID);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbAnimeID);
            this.Name = "FmEditAnimeStatus";
            this.Text = "FmEditAnimeStatus";
            this.Load += new System.EventHandler(this.FmEditAnimeStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnimeID;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox tbAnimeID;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
    }
}