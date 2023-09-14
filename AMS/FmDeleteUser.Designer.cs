
namespace AMS
{
    partial class FmDeleteUser
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
            this.lbUserID = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.BtClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserID.Location = new System.Drawing.Point(12, 34);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(66, 24);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "UserID";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(12, 88);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(97, 24);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // tbUserID
            // 
            this.tbUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserID.Location = new System.Drawing.Point(115, 31);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.ReadOnly = true;
            this.tbUserID.Size = new System.Drawing.Size(48, 29);
            this.tbUserID.TabIndex = 2;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(115, 83);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(186, 29);
            this.tbUsername.TabIndex = 3;
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(263, 141);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(94, 39);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // BtClear
            // 
            this.BtClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClear.Location = new System.Drawing.Point(27, 141);
            this.BtClear.Name = "BtClear";
            this.BtClear.Size = new System.Drawing.Size(94, 39);
            this.BtClear.TabIndex = 5;
            this.BtClear.Text = "Clear";
            this.BtClear.UseVisualStyleBackColor = true;
            this.BtClear.Click += new System.EventHandler(this.BtClear_Click);
            // 
            // FmDeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 192);
            this.Controls.Add(this.BtClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbUserID);
            this.Name = "FmDeleteUser";
            this.Text = "FmDeleteUser";
            this.Load += new System.EventHandler(this.FmDeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button BtClear;
    }
}