namespace AMS
{
    partial class FmAMS_admin_
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
            this.lbAms = new System.Windows.Forms.Label();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.rbUsers = new System.Windows.Forms.RadioButton();
            this.rbAnimeStatus = new System.Windows.Forms.RadioButton();
            this.rbAnimeGenres = new System.Windows.Forms.RadioButton();
            this.rbAnimeStudios = new System.Windows.Forms.RadioButton();
            this.rbStudios = new System.Windows.Forms.RadioButton();
            this.rbGenres = new System.Windows.Forms.RadioButton();
            this.rbAnimes = new System.Windows.Forms.RadioButton();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btShow = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.btMainForm = new System.Windows.Forms.Button();
            this.gbAMS.SuspendLayout();
            this.gbSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAMS
            // 
            this.gbAMS.BackColor = System.Drawing.SystemColors.Highlight;
            this.gbAMS.Controls.Add(this.lbAms);
            this.gbAMS.Location = new System.Drawing.Point(0, 0);
            this.gbAMS.Name = "gbAMS";
            this.gbAMS.Size = new System.Drawing.Size(798, 91);
            this.gbAMS.TabIndex = 0;
            this.gbAMS.TabStop = false;
            // 
            // lbAms
            // 
            this.lbAms.AutoSize = true;
            this.lbAms.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAms.Location = new System.Drawing.Point(314, 9);
            this.lbAms.Name = "lbAms";
            this.lbAms.Size = new System.Drawing.Size(171, 73);
            this.lbAms.TabIndex = 2;
            this.lbAms.Text = "AMS";
            // 
            // gbSelect
            // 
            this.gbSelect.BackColor = System.Drawing.SystemColors.Highlight;
            this.gbSelect.Controls.Add(this.rbUsers);
            this.gbSelect.Controls.Add(this.rbAnimeStatus);
            this.gbSelect.Controls.Add(this.rbAnimeGenres);
            this.gbSelect.Controls.Add(this.rbAnimeStudios);
            this.gbSelect.Controls.Add(this.rbStudios);
            this.gbSelect.Controls.Add(this.rbGenres);
            this.gbSelect.Controls.Add(this.rbAnimes);
            this.gbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSelect.Location = new System.Drawing.Point(12, 97);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(234, 247);
            this.gbSelect.TabIndex = 1;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select list";
            // 
            // rbUsers
            // 
            this.rbUsers.AutoSize = true;
            this.rbUsers.Location = new System.Drawing.Point(16, 213);
            this.rbUsers.Name = "rbUsers";
            this.rbUsers.Size = new System.Drawing.Size(111, 24);
            this.rbUsers.TabIndex = 6;
            this.rbUsers.TabStop = true;
            this.rbUsers.Text = "list all Users";
            this.rbUsers.UseVisualStyleBackColor = true;
            // 
            // rbAnimeStatus
            // 
            this.rbAnimeStatus.AutoSize = true;
            this.rbAnimeStatus.Location = new System.Drawing.Point(16, 183);
            this.rbAnimeStatus.Name = "rbAnimeStatus";
            this.rbAnimeStatus.Size = new System.Drawing.Size(160, 24);
            this.rbAnimeStatus.TabIndex = 5;
            this.rbAnimeStatus.TabStop = true;
            this.rbAnimeStatus.Text = "list all anime status";
            this.rbAnimeStatus.UseVisualStyleBackColor = true;
            // 
            // rbAnimeGenres
            // 
            this.rbAnimeGenres.AutoSize = true;
            this.rbAnimeGenres.Location = new System.Drawing.Point(16, 153);
            this.rbAnimeGenres.Name = "rbAnimeGenres";
            this.rbAnimeGenres.Size = new System.Drawing.Size(165, 24);
            this.rbAnimeGenres.TabIndex = 4;
            this.rbAnimeGenres.TabStop = true;
            this.rbAnimeGenres.Text = "list all anime genres";
            this.rbAnimeGenres.UseVisualStyleBackColor = true;
            // 
            // rbAnimeStudios
            // 
            this.rbAnimeStudios.AutoSize = true;
            this.rbAnimeStudios.Location = new System.Drawing.Point(16, 123);
            this.rbAnimeStudios.Name = "rbAnimeStudios";
            this.rbAnimeStudios.Size = new System.Drawing.Size(167, 24);
            this.rbAnimeStudios.TabIndex = 3;
            this.rbAnimeStudios.TabStop = true;
            this.rbAnimeStudios.Text = "list all anime studios";
            this.rbAnimeStudios.UseVisualStyleBackColor = true;
            // 
            // rbStudios
            // 
            this.rbStudios.AutoSize = true;
            this.rbStudios.Location = new System.Drawing.Point(16, 93);
            this.rbStudios.Name = "rbStudios";
            this.rbStudios.Size = new System.Drawing.Size(120, 24);
            this.rbStudios.TabIndex = 2;
            this.rbStudios.TabStop = true;
            this.rbStudios.Text = "list all studios";
            this.rbStudios.UseVisualStyleBackColor = true;
            // 
            // rbGenres
            // 
            this.rbGenres.AutoSize = true;
            this.rbGenres.Location = new System.Drawing.Point(16, 63);
            this.rbGenres.Name = "rbGenres";
            this.rbGenres.Size = new System.Drawing.Size(118, 24);
            this.rbGenres.TabIndex = 1;
            this.rbGenres.TabStop = true;
            this.rbGenres.Text = "list all genres";
            this.rbGenres.UseVisualStyleBackColor = true;
            // 
            // rbAnimes
            // 
            this.rbAnimes.AutoSize = true;
            this.rbAnimes.Location = new System.Drawing.Point(16, 33);
            this.rbAnimes.Name = "rbAnimes";
            this.rbAnimes.Size = new System.Drawing.Size(126, 24);
            this.rbAnimes.TabIndex = 0;
            this.rbAnimes.TabStop = true;
            this.rbAnimes.Text = "List all animes";
            this.rbAnimes.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(273, 97);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(484, 247);
            this.Grid.TabIndex = 2;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellContentClick);
            // 
            // btShow
            // 
            this.btShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShow.Location = new System.Drawing.Point(28, 365);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(94, 42);
            this.btShow.TabIndex = 3;
            this.btShow.Text = "Show";
            this.btShow.UseVisualStyleBackColor = true;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(345, 365);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(176, 34);
            this.tbSearch.TabIndex = 4;
            this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(269, 368);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(70, 24);
            this.lbSearch.TabIndex = 5;
            this.lbSearch.Text = "Search";
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(541, 368);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 42);
            this.btEdit.TabIndex = 6;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btMainForm
            // 
            this.btMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMainForm.Location = new System.Drawing.Point(659, 369);
            this.btMainForm.Name = "btMainForm";
            this.btMainForm.Size = new System.Drawing.Size(129, 60);
            this.btMainForm.TabIndex = 7;
            this.btMainForm.Text = "Go to Main Form";
            this.btMainForm.UseVisualStyleBackColor = true;
            this.btMainForm.Click += new System.EventHandler(this.btMainForm_Click);
            // 
            // FmAMS_admin_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMainForm);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.gbAMS);
            this.Name = "FmAMS_admin_";
            this.Text = "FmAMS_admin_";
            this.gbAMS.ResumeLayout(false);
            this.gbAMS.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAMS;
        private System.Windows.Forms.Label lbAms;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.RadioButton rbUsers;
        private System.Windows.Forms.RadioButton rbAnimeStatus;
        private System.Windows.Forms.RadioButton rbAnimeGenres;
        private System.Windows.Forms.RadioButton rbAnimeStudios;
        private System.Windows.Forms.RadioButton rbStudios;
        private System.Windows.Forms.RadioButton rbGenres;
        private System.Windows.Forms.RadioButton rbAnimes;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button btShow;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btMainForm;
    }
}