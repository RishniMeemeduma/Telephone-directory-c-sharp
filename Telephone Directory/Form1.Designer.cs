namespace Telephone_Directory
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.Mobile = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Group = new System.Windows.Forms.Label();
            this.textfirstname = new System.Windows.Forms.TextBox();
            this.textlastname = new System.Windows.Forms.TextBox();
            this.textmobile = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.directoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.telephone_bookDataSet1 = new Telephone_Directory.Telephone_bookDataSet1();
            this.textgroup = new System.Windows.Forms.ComboBox();
            this.telephone_bookDataSet = new Telephone_Directory.Telephone_bookDataSet();
            this.directoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryTableAdapter = new Telephone_Directory.Telephone_bookDataSetTableAdapters.directoryTableAdapter();
            this.directoryTableAdapter1 = new Telephone_Directory.Telephone_bookDataSet1TableAdapters.directoryTableAdapter();
            this.View = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.directoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.telephone_bookDataSet2 = new Telephone_Directory.Telephone_bookDataSet2();
            this.telephonebookDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryTableAdapter2 = new Telephone_Directory.Telephone_bookDataSet2TableAdapters.directoryTableAdapter();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_bookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_bookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_bookDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephonebookDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telephone Directory";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(12, 83);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(68, 15);
            this.fName.TabIndex = 0;
            this.fName.Text = "First Name";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(12, 109);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(68, 15);
            this.lName.TabIndex = 0;
            this.lName.Text = "Last Name";
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile.Location = new System.Drawing.Point(16, 138);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(43, 15);
            this.Mobile.TabIndex = 0;
            this.Mobile.Text = "Mobile";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(16, 164);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(39, 15);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Group.Location = new System.Drawing.Point(16, 190);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(41, 15);
            this.Group.TabIndex = 0;
            this.Group.Text = "Group";
            // 
            // textfirstname
            // 
            this.textfirstname.Location = new System.Drawing.Point(128, 81);
            this.textfirstname.Name = "textfirstname";
            this.textfirstname.Size = new System.Drawing.Size(161, 20);
            this.textfirstname.TabIndex = 1;
            // 
            // textlastname
            // 
            this.textlastname.Location = new System.Drawing.Point(128, 107);
            this.textlastname.Name = "textlastname";
            this.textlastname.Size = new System.Drawing.Size(161, 20);
            this.textlastname.TabIndex = 1;
            // 
            // textmobile
            // 
            this.textmobile.Location = new System.Drawing.Point(128, 136);
            this.textmobile.Name = "textmobile";
            this.textmobile.Size = new System.Drawing.Size(161, 20);
            this.textmobile.TabIndex = 1;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(128, 162);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(161, 20);
            this.textemail.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Green;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.Transparent;
            this.Save.Location = new System.Drawing.Point(353, 76);
            this.Save.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(87, 39);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update.Location = new System.Drawing.Point(480, 76);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(87, 39);
            this.Update.TabIndex = 2;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(353, 123);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(87, 37);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.HotPink;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.New.Location = new System.Drawing.Point(480, 123);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(87, 37);
            this.New.TabIndex = 2;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // directoryBindingSource1
            // 
            this.directoryBindingSource1.DataMember = "directory";
            this.directoryBindingSource1.DataSource = this.telephone_bookDataSet1;
            // 
            // telephone_bookDataSet1
            // 
            this.telephone_bookDataSet1.DataSetName = "Telephone_bookDataSet1";
            this.telephone_bookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textgroup
            // 
            this.textgroup.FormattingEnabled = true;
            this.textgroup.Items.AddRange(new object[] {
            "New",
            "Family",
            "Friends",
            "Office",
            "Business"});
            this.textgroup.Location = new System.Drawing.Point(128, 188);
            this.textgroup.Name = "textgroup";
            this.textgroup.Size = new System.Drawing.Size(161, 21);
            this.textgroup.TabIndex = 4;
            // 
            // telephone_bookDataSet
            // 
            this.telephone_bookDataSet.DataSetName = "Telephone_bookDataSet";
            this.telephone_bookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directoryBindingSource
            // 
            this.directoryBindingSource.DataMember = "directory";
            this.directoryBindingSource.DataSource = this.telephone_bookDataSet;
            // 
            // directoryTableAdapter
            // 
            this.directoryTableAdapter.ClearBeforeFill = true;
            // 
            // directoryTableAdapter1
            // 
            this.directoryTableAdapter1.ClearBeforeFill = true;
            // 
            // View
            // 
            this.View.BackColor = System.Drawing.Color.LightSeaGreen;
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.View.Location = new System.Drawing.Point(353, 166);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(87, 39);
            this.View.TabIndex = 5;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = false;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.groupDataGridViewTextBoxColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(555, 189);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // directoryBindingSource2
            // 
            this.directoryBindingSource2.DataMember = "directory";
            this.directoryBindingSource2.DataSource = this.telephone_bookDataSet2;
            // 
            // telephone_bookDataSet2
            // 
            this.telephone_bookDataSet2.DataSetName = "Telephone_bookDataSet2";
            this.telephone_bookDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telephonebookDataSetBindingSource
            // 
            this.telephonebookDataSetBindingSource.DataSource = this.telephone_bookDataSet;
            this.telephonebookDataSetBindingSource.Position = 0;
            // 
            // directoryTableAdapter2
            // 
            this.directoryTableAdapter2.ClearBeforeFill = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupDataGridViewTextBoxColumn
            // 
            this.groupDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.groupDataGridViewTextBoxColumn.HeaderText = "Group";
            this.groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            this.groupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.View);
            this.Controls.Add(this.textgroup);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.textmobile);
            this.Controls.Add(this.textlastname);
            this.Controls.Add(this.textfirstname);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Telephone Directory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_bookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_bookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephone_bookDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telephonebookDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Group;
        private System.Windows.Forms.TextBox textfirstname;
        private System.Windows.Forms.TextBox textlastname;
        private System.Windows.Forms.TextBox textmobile;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.ComboBox textgroup;
        private Telephone_bookDataSet telephone_bookDataSet;
        private System.Windows.Forms.BindingSource directoryBindingSource;
        private Telephone_bookDataSetTableAdapters.directoryTableAdapter directoryTableAdapter;
        private Telephone_bookDataSet1 telephone_bookDataSet1;
        private System.Windows.Forms.BindingSource directoryBindingSource1;
        private Telephone_bookDataSet1TableAdapters.directoryTableAdapter directoryTableAdapter1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource telephonebookDataSetBindingSource;
        private Telephone_bookDataSet2 telephone_bookDataSet2;
        private System.Windows.Forms.BindingSource directoryBindingSource2;
        private Telephone_bookDataSet2TableAdapters.directoryTableAdapter directoryTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
    }
}

