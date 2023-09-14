
namespace AMS
{
    partial class FmSignUp
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
            this.gbAMS = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbCreatAccount = new System.Windows.Forms.GroupBox();
            this.tbAdminKey = new System.Windows.Forms.TextBox();
            this.lbAdminKey = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.lbPword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPword = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbUserType = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbForename = new System.Windows.Forms.Label();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbForename = new System.Windows.Forms.TextBox();
            this.btReturn = new System.Windows.Forms.Button();
            this.gbAMS.SuspendLayout();
            this.GbCreatAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAMS
            // 
            this.gbAMS.BackColor = System.Drawing.SystemColors.Highlight;
            this.gbAMS.Controls.Add(this.label1);
            this.gbAMS.Location = new System.Drawing.Point(0, 1);
            this.gbAMS.Name = "gbAMS";
            this.gbAMS.Size = new System.Drawing.Size(799, 93);
            this.gbAMS.TabIndex = 0;
            this.gbAMS.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "AMS";
            // 
            // GbCreatAccount
            // 
            this.GbCreatAccount.BackColor = System.Drawing.SystemColors.Highlight;
            this.GbCreatAccount.Controls.Add(this.tbAdminKey);
            this.GbCreatAccount.Controls.Add(this.lbAdminKey);
            this.GbCreatAccount.Controls.Add(this.btSave);
            this.GbCreatAccount.Controls.Add(this.lbPword);
            this.GbCreatAccount.Controls.Add(this.lbUsername);
            this.GbCreatAccount.Controls.Add(this.tbUsername);
            this.GbCreatAccount.Controls.Add(this.tbPword);
            this.GbCreatAccount.Controls.Add(this.lbEmail);
            this.GbCreatAccount.Controls.Add(this.lbUserType);
            this.GbCreatAccount.Controls.Add(this.lbSurname);
            this.GbCreatAccount.Controls.Add(this.lbForename);
            this.GbCreatAccount.Controls.Add(this.cbUserType);
            this.GbCreatAccount.Controls.Add(this.tbEmail);
            this.GbCreatAccount.Controls.Add(this.tbSurname);
            this.GbCreatAccount.Controls.Add(this.tbForename);
            this.GbCreatAccount.Location = new System.Drawing.Point(134, 114);
            this.GbCreatAccount.Name = "GbCreatAccount";
            this.GbCreatAccount.Size = new System.Drawing.Size(508, 324);
            this.GbCreatAccount.TabIndex = 1;
            this.GbCreatAccount.TabStop = false;
            // 
            // tbAdminKey
            // 
            this.tbAdminKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdminKey.Location = new System.Drawing.Point(415, 111);
            this.tbAdminKey.Name = "tbAdminKey";
            this.tbAdminKey.Size = new System.Drawing.Size(56, 29);
            this.tbAdminKey.TabIndex = 14;
            this.tbAdminKey.Visible = false;
            // 
            // lbAdminKey
            // 
            this.lbAdminKey.AutoSize = true;
            this.lbAdminKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminKey.Location = new System.Drawing.Point(307, 114);
            this.lbAdminKey.Name = "lbAdminKey";
            this.lbAdminKey.Size = new System.Drawing.Size(102, 24);
            this.lbAdminKey.TabIndex = 13;
            this.lbAdminKey.Text = "Admin Key";
            this.lbAdminKey.Visible = false;
            // 
            // btSave
            // 
            this.btSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.Location = new System.Drawing.Point(389, 253);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(82, 49);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbPword
            // 
            this.lbPword.AutoSize = true;
            this.lbPword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPword.Location = new System.Drawing.Point(37, 276);
            this.lbPword.Name = "lbPword";
            this.lbPword.Size = new System.Drawing.Size(92, 24);
            this.lbPword.TabIndex = 11;
            this.lbPword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(37, 216);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(97, 24);
            this.lbUsername.TabIndex = 10;
            this.lbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(167, 216);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(180, 29);
            this.tbUsername.TabIndex = 9;
            // 
            // tbPword
            // 
            this.tbPword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPword.Location = new System.Drawing.Point(166, 273);
            this.tbPword.Name = "tbPword";
            this.tbPword.PasswordChar = '*';
            this.tbPword.Size = new System.Drawing.Size(180, 29);
            this.tbPword.TabIndex = 8;
            this.tbPword.UseSystemPasswordChar = true;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(37, 160);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 24);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email";
            // 
            // lbUserType
            // 
            this.lbUserType.AutoSize = true;
            this.lbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserType.Location = new System.Drawing.Point(37, 114);
            this.lbUserType.Name = "lbUserType";
            this.lbUserType.Size = new System.Drawing.Size(92, 24);
            this.lbUserType.TabIndex = 6;
            this.lbUserType.Text = "UserType";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.Location = new System.Drawing.Point(37, 66);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(87, 24);
            this.lbSurname.TabIndex = 5;
            this.lbSurname.Text = "Surname";
            // 
            // lbForename
            // 
            this.lbForename.AutoSize = true;
            this.lbForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForename.Location = new System.Drawing.Point(37, 24);
            this.lbForename.Name = "lbForename";
            this.lbForename.Size = new System.Drawing.Size(98, 24);
            this.lbForename.TabIndex = 4;
            this.lbForename.Text = "Forename";
            // 
            // cbUserType
            // 
            this.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "User",
            "Administrator"});
            this.cbUserType.Location = new System.Drawing.Point(167, 108);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(121, 32);
            this.cbUserType.TabIndex = 3;
            this.cbUserType.SelectedIndexChanged += new System.EventHandler(this.cbUserType_SelectedIndexChanged);
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(166, 160);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(282, 29);
            this.tbEmail.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurname.Location = new System.Drawing.Point(166, 63);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(180, 29);
            this.tbSurname.TabIndex = 1;
            // 
            // tbForename
            // 
            this.tbForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbForename.Location = new System.Drawing.Point(166, 19);
            this.tbForename.Name = "tbForename";
            this.tbForename.Size = new System.Drawing.Size(180, 29);
            this.tbForename.TabIndex = 0;
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReturn.Location = new System.Drawing.Point(663, 366);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(104, 72);
            this.btReturn.TabIndex = 2;
            this.btReturn.Text = "Return To Menu";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // FmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.GbCreatAccount);
            this.Controls.Add(this.gbAMS);
            this.Name = "FmSignUp";
            this.Text = "FmSignUp";
            this.gbAMS.ResumeLayout(false);
            this.gbAMS.PerformLayout();
            this.GbCreatAccount.ResumeLayout(false);
            this.GbCreatAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbCreatAccount;
        private System.Windows.Forms.Label lbForename;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbForename;
        private System.Windows.Forms.Label lbPword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbUserType;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbAdminKey;
        private System.Windows.Forms.Label lbAdminKey;
    }
}