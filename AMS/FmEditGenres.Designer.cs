
namespace AMS
{
    partial class FmEditGenres
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
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.lbGenreID = new System.Windows.Forms.Label();
            this.tbGenreID = new System.Windows.Forms.TextBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.lbGenre = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInsert
            // 
            this.btInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInsert.Location = new System.Drawing.Point(126, 278);
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
            this.btUpdate.Location = new System.Drawing.Point(247, 278);
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
            this.btDelete.Location = new System.Drawing.Point(359, 278);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(97, 42);
            this.btDelete.TabIndex = 14;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // lbGenreID
            // 
            this.lbGenreID.AutoSize = true;
            this.lbGenreID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenreID.Location = new System.Drawing.Point(31, 59);
            this.lbGenreID.Name = "lbGenreID";
            this.lbGenreID.Size = new System.Drawing.Size(80, 24);
            this.lbGenreID.TabIndex = 15;
            this.lbGenreID.Text = "GenreID";
            // 
            // tbGenreID
            // 
            this.tbGenreID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenreID.Location = new System.Drawing.Point(139, 54);
            this.tbGenreID.Name = "tbGenreID";
            this.tbGenreID.Size = new System.Drawing.Size(243, 29);
            this.tbGenreID.TabIndex = 16;
            // 
            // tbGenre
            // 
            this.tbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGenre.Location = new System.Drawing.Point(139, 142);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(243, 29);
            this.tbGenre.TabIndex = 17;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(31, 147);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(63, 24);
            this.lbGenre.TabIndex = 18;
            this.lbGenre.Text = "Genre";
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.Location = new System.Drawing.Point(12, 278);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(97, 42);
            this.btClear.TabIndex = 19;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // FmEditGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 332);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.tbGenre);
            this.Controls.Add(this.tbGenreID);
            this.Controls.Add(this.lbGenreID);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Name = "FmEditGenres";
            this.Text = "FmEditGenres";
            this.Load += new System.EventHandler(this.FmEditGenres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label lbGenreID;
        private System.Windows.Forms.TextBox tbGenreID;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Button btClear;
    }
}