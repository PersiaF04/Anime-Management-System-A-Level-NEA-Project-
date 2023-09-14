
namespace AMS
{
    partial class FmReset
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lbConfirmNewPassword = new System.Windows.Forms.Label();
            this.tbConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.btChange = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(12, 63);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(112, 24);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Enter Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(229, 58);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(273, 29);
            this.tbEmail.TabIndex = 1;
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(10, 125);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(191, 24);
            this.lbNewPassword.TabIndex = 2;
            this.lbNewPassword.Text = "Enter New Password:";
            this.lbNewPassword.Visible = false;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPassword.Location = new System.Drawing.Point(229, 125);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(273, 29);
            this.tbNewPassword.TabIndex = 3;
            this.tbNewPassword.UseSystemPasswordChar = true;
            this.tbNewPassword.Visible = false;
            // 
            // lbConfirmNewPassword
            // 
            this.lbConfirmNewPassword.AutoSize = true;
            this.lbConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmNewPassword.Location = new System.Drawing.Point(10, 195);
            this.lbConfirmNewPassword.Name = "lbConfirmNewPassword";
            this.lbConfirmNewPassword.Size = new System.Drawing.Size(211, 24);
            this.lbConfirmNewPassword.TabIndex = 4;
            this.lbConfirmNewPassword.Text = "Confirm New Password:";
            this.lbConfirmNewPassword.Visible = false;
            // 
            // tbConfirmNewPassword
            // 
            this.tbConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmNewPassword.Location = new System.Drawing.Point(229, 192);
            this.tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            this.tbConfirmNewPassword.Size = new System.Drawing.Size(273, 29);
            this.tbConfirmNewPassword.TabIndex = 5;
            this.tbConfirmNewPassword.UseSystemPasswordChar = true;
            this.tbConfirmNewPassword.Visible = false;
            // 
            // btChange
            // 
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.Location = new System.Drawing.Point(509, 245);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(90, 55);
            this.btChange.TabIndex = 6;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btFind
            // 
            this.btFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFind.Location = new System.Drawing.Point(519, 58);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(71, 29);
            this.btFind.TabIndex = 7;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // FmReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 312);
            this.Controls.Add(this.btFind);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.tbConfirmNewPassword);
            this.Controls.Add(this.lbConfirmNewPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Name = "FmReset";
            this.Text = "FmReset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lbConfirmNewPassword;
        private System.Windows.Forms.TextBox tbConfirmNewPassword;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btFind;
    }
}