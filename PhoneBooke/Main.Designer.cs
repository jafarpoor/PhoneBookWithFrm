namespace PhoneBooke
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Phone = new System.Windows.Forms.Label();
            this.AddPerson = new System.Windows.Forms.Button();
            this.gridPerson = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeletPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // Phone
            // 
            this.Phone.AllowDrop = true;
            this.Phone.AutoSize = true;
            this.Phone.Dock = System.Windows.Forms.DockStyle.Right;
            this.Phone.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Phone.Location = new System.Drawing.Point(509, 0);
            this.Phone.Name = "Phone";
            this.Phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Phone.Size = new System.Drawing.Size(179, 34);
            this.Phone.TabIndex = 0;
            this.Phone.Text = "دفترچه تلفن";
            this.Phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPerson
            // 
            this.AddPerson.AutoSize = true;
            this.AddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AddPerson.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPerson.Location = new System.Drawing.Point(420, 548);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(139, 45);
            this.AddPerson.TabIndex = 1;
            this.AddPerson.Text = "افزودن مخاطب";
            this.AddPerson.UseVisualStyleBackColor = false;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // gridPerson
            // 
            this.gridPerson.AllowUserToAddRows = false;
            this.gridPerson.AllowUserToDeleteRows = false;
            this.gridPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridPerson.BackgroundColor = System.Drawing.Color.White;
            this.gridPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.LastName,
            this.Mobail,
            this.ID});
            this.gridPerson.Location = new System.Drawing.Point(67, 61);
            this.gridPerson.Name = "gridPerson";
            this.gridPerson.ReadOnly = true;
            this.gridPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridPerson.RowTemplate.Height = 24;
            this.gridPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPerson.Size = new System.Drawing.Size(520, 448);
            this.gridPerson.TabIndex = 4;
            this.gridPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPerson_CellClick);
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "نام";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Name.Width = 30;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Family";
            this.LastName.HeaderText = "نام خانوادگی";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LastName.Width = 88;
            // 
            // Mobail
            // 
            this.Mobail.DataPropertyName = "MainPhone";
            this.Mobail.HeaderText = "تلفن همراه";
            this.Mobail.Name = "Mobail";
            this.Mobail.ReadOnly = true;
            this.Mobail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mobail.Width = 79;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Visible = false;
            this.ID.Width = 28;
            // 
            // DeletPerson
            // 
            this.DeletPerson.AutoSize = true;
            this.DeletPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeletPerson.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletPerson.Location = new System.Drawing.Point(80, 548);
            this.DeletPerson.Name = "DeletPerson";
            this.DeletPerson.Size = new System.Drawing.Size(170, 45);
            this.DeletPerson.TabIndex = 6;
            this.DeletPerson.Text = "حذف کردن مخاطب";
            this.DeletPerson.UseVisualStyleBackColor = false;
            this.DeletPerson.Click += new System.EventHandler(this.DeletPerson_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(688, 659);
            this.Controls.Add(this.DeletPerson);
            this.Controls.Add(this.gridPerson);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.Phone);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            //this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.DataGridView gridPerson;
        private System.Windows.Forms.Button DeletPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}