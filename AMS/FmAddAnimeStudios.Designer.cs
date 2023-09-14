
namespace AMS
{
    partial class FmAddAnimeStudios
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
            this.tbAnimeID = new System.Windows.Forms.TextBox();
            this.tbStudioID = new System.Windows.Forms.TextBox();
            this.lbAnimeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAnimeID
            // 
            this.tbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAnimeID.Location = new System.Drawing.Point(101, 65);
            this.tbAnimeID.Name = "tbAnimeID";
            this.tbAnimeID.Size = new System.Drawing.Size(224, 26);
            this.tbAnimeID.TabIndex = 4;
            // 
            // tbStudioID
            // 
            this.tbStudioID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStudioID.Location = new System.Drawing.Point(101, 134);
            this.tbStudioID.Name = "tbStudioID";
            this.tbStudioID.Size = new System.Drawing.Size(224, 26);
            this.tbStudioID.TabIndex = 5;
            // 
            // lbAnimeID
            // 
            this.lbAnimeID.AutoSize = true;
            this.lbAnimeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimeID.Location = new System.Drawing.Point(12, 67);
            this.lbAnimeID.Name = "lbAnimeID";
            this.lbAnimeID.Size = new System.Drawing.Size(82, 24);
            this.lbAnimeID.TabIndex = 10;
            this.lbAnimeID.Text = "AnimeID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "StudioID";
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(274, 226);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(78, 37);
            this.btInsert.TabIndex = 16;
            this.btInsert.Text = "Insert";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // FmAddAnimeStudios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(376, 275);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAnimeID);
            this.Controls.Add(this.tbStudioID);
            this.Controls.Add(this.tbAnimeID);
            this.Name = "FmAddAnimeStudios";
            this.Text = "FmAddAnimeStudios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAnimeID;
        private System.Windows.Forms.TextBox tbStudioID;
        private System.Windows.Forms.Label lbAnimeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btInsert;
    }
}