
namespace AMS
{
    partial class FmLogIn
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUserLogin = new System.Windows.Forms.GroupBox();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.btEnter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btReturn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbUserLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "AMS";
            // 
            // gbUserLogin
            // 
            this.gbUserLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.gbUserLogin.Controls.Add(this.cbRemember);
            this.gbUserLogin.Controls.Add(this.btEnter);
            this.gbUserLogin.Controls.Add(this.label3);
            this.gbUserLogin.Controls.Add(this.label2);
            this.gbUserLogin.Controls.Add(this.tbPword);
            this.gbUserLogin.Controls.Add(this.tbUsername);
            this.gbUserLogin.Location = new System.Drawing.Point(174, 115);
            this.gbUserLogin.Name = "gbUserLogin";
            this.gbUserLogin.Size = new System.Drawing.Size(460, 297);
            this.gbUserLogin.TabIndex = 1;
            this.gbUserLogin.TabStop = false;
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemember.Location = new System.Drawing.Point(26, 215);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(166, 28);
            this.cbRemember.TabIndex = 5;
            this.cbRemember.Text = "Remember me?";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnter.Location = new System.Drawing.Point(350, 215);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(82, 54);
            this.btEnter.TabIndex = 4;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // tbPword
            // 
            this.tbPword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPword.Location = new System.Drawing.Point(152, 148);
            this.tbPword.Name = "tbPword";
            this.tbPword.Size = new System.Drawing.Size(186, 29);
            this.tbPword.TabIndex = 1;
            this.tbPword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(152, 77);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(186, 29);
            this.tbUsername.TabIndex = 0;
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Location = new System.Drawing.Point(667, 358);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(109, 68);
            this.btReturn.TabIndex = 5;
            this.btReturn.Text = "Return To Menu";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // FmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.gbUserLogin);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmLogIn";
            this.Text = "FmLogIn";
            this.Load += new System.EventHandler(this.FmLogIn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbUserLogin.ResumeLayout(false);
            this.gbUserLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUserLogin;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.CheckBox cbRemember;
    }
}