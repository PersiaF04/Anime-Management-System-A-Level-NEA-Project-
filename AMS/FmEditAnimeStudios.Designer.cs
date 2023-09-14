
namespace AMS
{
    partial class FmEditAnimeStudios
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
            this.tbAnimeID = new System.Windows.Forms.TextBox();
            this.tbStudioID = new System.Windows.Forms.TextBox();
            this.lbStudioID = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAnimeID
            // 
            this.lbAnimeID.AutoSize = true;
            this.lbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimeID.Location = new System.Drawing.Point(12, 46);
            this.lbAnimeID.Name = "lbAnimeID";
            this.lbAnimeID.Size = new System.Drawing.Size(82, 24);
            this.lbAnimeID.TabIndex = 1;
            this.lbAnimeID.Text = "AnimeID";
            // 
            // tbAnimeID
            // 
            this.tbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimeID.Location = new System.Drawing.Point(112, 43);
            this.tbAnimeID.Name = "tbAnimeID";
            this.tbAnimeID.Size = new System.Drawing.Size(243, 29);
            this.tbAnimeID.TabIndex = 6;
            // 
            // tbStudioID
            // 
            this.tbStudioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudioID.Location = new System.Drawing.Point(112, 132);
            this.tbStudioID.Name = "tbStudioID";
            this.tbStudioID.Size = new System.Drawing.Size(243, 29);
            this.tbStudioID.TabIndex = 7;
            // 
            // lbStudioID
            // 
            this.lbStudioID.AutoSize = true;
            this.lbStudioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudioID.Location = new System.Drawing.Point(12, 137);
            this.lbStudioID.Name = "lbStudioID";
            this.lbStudioID.Size = new System.Drawing.Size(80, 24);
            this.lbStudioID.TabIndex = 8;
            this.lbStudioID.Text = "StudioID";
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(122, 214);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(97, 42);
            this.btInsert.TabIndex = 11;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(225, 214);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(97, 42);
            this.btUpdate.TabIndex = 13;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(339, 214);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(97, 42);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(9, 214);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(97, 42);
            this.btClear.TabIndex = 15;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // FmEditAnimeStudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 268);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.lbStudioID);
            this.Controls.Add(this.tbStudioID);
            this.Controls.Add(this.tbAnimeID);
            this.Controls.Add(this.lbAnimeID);
            this.Name = "FmEditAnimeStudios";
            this.Text = "FmEditAnimeStudios";
            this.Load += new System.EventHandler(this.FmEditAnimeStudios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAnimeID;
        private System.Windows.Forms.TextBox tbAnimeID;
        private System.Windows.Forms.TextBox tbStudioID;
        private System.Windows.Forms.Label lbStudioID;
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
    }
}