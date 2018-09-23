namespace SmartLoyalty
{
    partial class frmAddRedeemPoints
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEntry = new System.Windows.Forms.Panel();
            this.lblCustdet = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tblo_CustReg = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtPoints = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddRedeem = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panelList = new System.Windows.Forms.Panel();
            this.dgvPointadded = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEntry.SuspendLayout();
            this.tblo_CustReg.SuspendLayout();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointadded)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEntry
            // 
            this.panelEntry.Controls.Add(this.lblCustdet);
            this.panelEntry.Controls.Add(this.txtBarcode);
            this.panelEntry.Controls.Add(this.label6);
            this.panelEntry.Controls.Add(this.tblo_CustReg);
            this.panelEntry.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEntry.Location = new System.Drawing.Point(0, 0);
            this.panelEntry.Name = "panelEntry";
            this.panelEntry.Size = new System.Drawing.Size(340, 400);
            this.panelEntry.TabIndex = 0;
            // 
            // lblCustdet
            // 
            this.lblCustdet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustdet.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustdet.Location = new System.Drawing.Point(12, 54);
            this.lblCustdet.Name = "lblCustdet";
            this.lblCustdet.Size = new System.Drawing.Size(313, 137);
            this.lblCustdet.TabIndex = 5;
            this.lblCustdet.Text = "Customer Details";
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(117, 25);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(208, 26);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Barcode : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblo_CustReg
            // 
            this.tblo_CustReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblo_CustReg.ColumnCount = 2;
            this.tblo_CustReg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.25559F));
            this.tblo_CustReg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.74441F));
            this.tblo_CustReg.Controls.Add(this.dtpDate, 1, 0);
            this.tblo_CustReg.Controls.Add(this.txtPoints, 1, 1);
            this.tblo_CustReg.Controls.Add(this.label3, 0, 0);
            this.tblo_CustReg.Controls.Add(this.lblAddRedeem, 0, 1);
            this.tblo_CustReg.Controls.Add(this.BtnCancel, 0, 2);
            this.tblo_CustReg.Controls.Add(this.BtnSave, 1, 2);
            this.tblo_CustReg.Location = new System.Drawing.Point(12, 206);
            this.tblo_CustReg.Name = "tblo_CustReg";
            this.tblo_CustReg.RowCount = 3;
            this.tblo_CustReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblo_CustReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblo_CustReg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblo_CustReg.Size = new System.Drawing.Size(313, 156);
            this.tblo_CustReg.TabIndex = 0;
            this.tblo_CustReg.Paint += new System.Windows.Forms.PaintEventHandler(this.tblo_CustReg_Paint);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(128, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(182, 26);
            this.dtpDate.TabIndex = 6;
            // 
            // txtPoints
            // 
            this.txtPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPoints.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoints.Location = new System.Drawing.Point(128, 55);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(182, 26);
            this.txtPoints.TabIndex = 6;
            this.txtPoints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPoints_KeyDown);
            this.txtPoints.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoints_KeyPress);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddRedeem
            // 
            this.lblAddRedeem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddRedeem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddRedeem.Location = new System.Drawing.Point(3, 52);
            this.lblAddRedeem.Name = "lblAddRedeem";
            this.lblAddRedeem.Size = new System.Drawing.Size(119, 25);
            this.lblAddRedeem.TabIndex = 3;
            this.lblAddRedeem.Text = "Point Erned";
            this.lblAddRedeem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(3, 107);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(119, 46);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(128, 107);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(182, 46);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.dgvPointadded);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(340, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(407, 400);
            this.panelList.TabIndex = 1;
            // 
            // dgvPointadded
            // 
            this.dgvPointadded.AllowUserToAddRows = false;
            this.dgvPointadded.AllowUserToDeleteRows = false;
            this.dgvPointadded.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPointadded.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPointadded.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPointadded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPointadded.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EDate,
            this.CustomerID,
            this.Barcode,
            this.Customer,
            this.PointAdded});
            this.dgvPointadded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPointadded.Location = new System.Drawing.Point(0, 0);
            this.dgvPointadded.Name = "dgvPointadded";
            this.dgvPointadded.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPointadded.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPointadded.RowTemplate.Height = 25;
            this.dgvPointadded.Size = new System.Drawing.Size(407, 400);
            this.dgvPointadded.TabIndex = 0;
            this.dgvPointadded.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPointadded_CellDoubleClick);
            this.dgvPointadded.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvPointadded_KeyDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // EDate
            // 
            this.EDate.DataPropertyName = "ADate";
            this.EDate.HeaderText = "Date";
            this.EDate.Name = "EDate";
            this.EDate.ReadOnly = true;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "Cust_Id";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // Barcode
            // 
            this.Barcode.DataPropertyName = "Barcode";
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Cust_name";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // PointAdded
            // 
            this.PointAdded.DataPropertyName = "Point";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PointAdded.DefaultCellStyle = dataGridViewCellStyle2;
            this.PointAdded.HeaderText = "Point Added";
            this.PointAdded.Name = "PointAdded";
            this.PointAdded.ReadOnly = true;
            // 
            // frmAddRedeemPoints
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(747, 400);
            this.Controls.Add(this.panelList);
            this.Controls.Add(this.panelEntry);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddRedeemPoints";
            this.Load += new System.EventHandler(this.frmAddRedeemPoints_Load);
            this.panelEntry.ResumeLayout(false);
            this.panelEntry.PerformLayout();
            this.tblo_CustReg.ResumeLayout(false);
            this.tblo_CustReg.PerformLayout();
            this.panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointadded)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEntry;
        private System.Windows.Forms.TableLayoutPanel tblo_CustReg;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddRedeem;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPoints;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView dgvPointadded;
        private System.Windows.Forms.Label lblCustdet;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointAdded;
    }
}
