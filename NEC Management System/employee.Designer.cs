namespace Negambo_Express_Cabs
{
    partial class employee
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
            this.btnload = new System.Windows.Forms.Button();
            this.txtecon = new System.Windows.Forms.TextBox();
            this.txtndl = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtcon = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnsave = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.btnupdate = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.negamboDataSet3 = new Negambo_Express_Cabs.negamboDataSet3();
            this.tblemployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_employeeTableAdapter = new Negambo_Express_Cabs.negamboDataSet3TableAdapters.tbl_employeeTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ndlnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.negamboDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.Black;
            this.btnload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnload.Location = new System.Drawing.Point(737, 772);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(358, 44);
            this.btnload.TabIndex = 40;
            this.btnload.Text = "Load Data";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click_1);
            // 
            // txtecon
            // 
            this.txtecon.Location = new System.Drawing.Point(829, 510);
            this.txtecon.Name = "txtecon";
            this.txtecon.Size = new System.Drawing.Size(296, 22);
            this.txtecon.TabIndex = 39;
            // 
            // txtndl
            // 
            this.txtndl.Location = new System.Drawing.Point(171, 781);
            this.txtndl.Name = "txtndl";
            this.txtndl.Size = new System.Drawing.Size(314, 22);
            this.txtndl.TabIndex = 38;
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(171, 738);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(314, 22);
            this.txtnic.TabIndex = 37;
            // 
            // txtcon
            // 
            this.txtcon.Location = new System.Drawing.Point(172, 694);
            this.txtcon.Name = "txtcon";
            this.txtcon.Size = new System.Drawing.Size(314, 22);
            this.txtcon.TabIndex = 36;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(172, 507);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(314, 22);
            this.txtname.TabIndex = 35;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(171, 556);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(316, 112);
            this.txtaddress.TabIndex = 34;
            this.txtaddress.Text = "";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(619, 510);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(131, 20);
            this.metroLabel6.TabIndex = 33;
            this.metroLabel6.Text = "Emergancy Con No";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(46, 781);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(60, 20);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "NDL No";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(46, 738);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(55, 20);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "NIC No";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(37, 694);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 20);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Contact No ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 552);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 20);
            this.metroLabel2.TabIndex = 29;
            this.metroLabel2.Text = "Address";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 505);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 20);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "Name";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DarkGreen;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnsave.Highlight = true;
            this.btnsave.Location = new System.Drawing.Point(705, 830);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(136, 33);
            this.btnsave.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnsave.TabIndex = 27;
            this.btnsave.Text = "Save";
            this.btnsave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnsave.UseSelectable = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.DarkGreen;
            this.metroButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroButton2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(989, 830);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(136, 33);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 26;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.DarkGreen;
            this.btnupdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnupdate.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnupdate.Highlight = true;
            this.btnupdate.Location = new System.Drawing.Point(847, 830);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(136, 33);
            this.btnupdate.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnupdate.TabIndex = 25;
            this.btnupdate.Text = "Update";
            this.btnupdate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnupdate.UseSelectable = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactnoDataGridViewTextBoxColumn,
            this.nicnoDataGridViewTextBoxColumn,
            this.ndlnoDataGridViewTextBoxColumn,
            this.enoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblemployeeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 363);
            this.dataGridView1.TabIndex = 41;
            // 
            // negamboDataSet3
            // 
            this.negamboDataSet3.DataSetName = "negamboDataSet3";
            this.negamboDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblemployeeBindingSource
            // 
            this.tblemployeeBindingSource.DataMember = "tbl_employee";
            this.tblemployeeBindingSource.DataSource = this.negamboDataSet3;
            // 
            // tbl_employeeTableAdapter
            // 
            this.tbl_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactnoDataGridViewTextBoxColumn
            // 
            this.contactnoDataGridViewTextBoxColumn.DataPropertyName = "contact_no";
            this.contactnoDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.contactnoDataGridViewTextBoxColumn.Name = "contactnoDataGridViewTextBoxColumn";
            this.contactnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nicnoDataGridViewTextBoxColumn
            // 
            this.nicnoDataGridViewTextBoxColumn.DataPropertyName = "nic_no";
            this.nicnoDataGridViewTextBoxColumn.HeaderText = "National Id No";
            this.nicnoDataGridViewTextBoxColumn.Name = "nicnoDataGridViewTextBoxColumn";
            this.nicnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ndlnoDataGridViewTextBoxColumn
            // 
            this.ndlnoDataGridViewTextBoxColumn.DataPropertyName = "ndl_no";
            this.ndlnoDataGridViewTextBoxColumn.HeaderText = "National Driving Licence No";
            this.ndlnoDataGridViewTextBoxColumn.Name = "ndlnoDataGridViewTextBoxColumn";
            this.ndlnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // enoDataGridViewTextBoxColumn
            // 
            this.enoDataGridViewTextBoxColumn.DataPropertyName = "e_no";
            this.enoDataGridViewTextBoxColumn.HeaderText = "Emergancy Contact No";
            this.enoDataGridViewTextBoxColumn.Name = "enoDataGridViewTextBoxColumn";
            this.enoDataGridViewTextBoxColumn.Width = 150;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 1102);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.txtecon);
            this.Controls.Add(this.txtndl);
            this.Controls.Add(this.txtnic);
            this.Controls.Add(this.txtcon);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnupdate);
            this.Name = "employee";
            this.Text = " Employee";
            this.Load += new System.EventHandler(this.employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.negamboDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblemployeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.TextBox txtecon;
        private System.Windows.Forms.TextBox txtndl;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtcon;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RichTextBox txtaddress;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnsave;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private negamboDataSet3 negamboDataSet3;
        private System.Windows.Forms.BindingSource tblemployeeBindingSource;
        private negamboDataSet3TableAdapters.tbl_employeeTableAdapter tbl_employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ndlnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enoDataGridViewTextBoxColumn;
    }
}