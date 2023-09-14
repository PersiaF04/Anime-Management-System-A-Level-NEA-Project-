
namespace AMS
{
    partial class FmMenu
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
            this.btSignUp = new System.Windows.Forms.Button();
            this.btLogIn = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "AMS";
            // 
            // btSignUp
            // 
            this.btSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignUp.Location = new System.Drawing.Point(289, 139);
            this.btSignUp.Name = "btSignUp";
            this.btSignUp.Size = new System.Drawing.Size(217, 60);
            this.btSignUp.TabIndex = 1;
            this.btSignUp.Text = "Sign up";
            this.btSignUp.UseVisualStyleBackColor = true;
            this.btSignUp.Click += new System.EventHandler(this.btSignUp_Click);
            // 
            // btLogIn
            // 
            this.btLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogIn.Location = new System.Drawing.Point(289, 226);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(217, 60);
            this.btLogIn.TabIndex = 2;
            this.btLogIn.Text = "Log in";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(289, 316);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(217, 60);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // FmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.btSignUp);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmMenu";
            this.Text = "FmMenu";
            this.Load += new System.EventHandler(this.FmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSignUp;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Button btExit;
    }
}

