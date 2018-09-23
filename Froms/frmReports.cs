using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace SmartLoyalty
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
            dgvReprt.BackgroundColor = Color.White;
            dgvReprt.RowHeadersVisible = false;
            dgvReprt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void tblo_CustReg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FillCustomers()
        {
            Database.ConnStr obj = new Database.ConnStr();
            string sql;
            DataTable dt = new DataTable();
            sql = string.Format("SELECT ID,concat(Barcode,'-',Cust_name) as Cname FROM smartl.tbl_customers;", "");
            dt = obj.GetRecords(sql);
            cmbCustomer.ValueMember = "ID";
            cmbCustomer.DisplayMember = "Cname";
            cmbCustomer.DataSource = dt;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            FillCustomers();
        }

        private RadioButton GetSelRb()
        {
            RadioButton rbret = null;
            for (int i=0;i< tableLayoutPanel1.Controls.Count;i++)
            {
                if(tableLayoutPanel1.Controls[i].GetType()==typeof(RadioButton))
                {
                    RadioButton RB = (RadioButton)tableLayoutPanel1.Controls[i];
                    if (RB.Checked) rbret = RB;
                }
            }
            return rbret;
        }

        private void radioButton_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            string sql = "";
            int Cust_Id = (cmbCustomer.SelectedValue != null) ? int.Parse(cmbCustomer.SelectedValue.ToString()) : 0;
            if (rb.Checked)
            {
                if (rb.Name == "RB1")
                {
                    sql = string.Format("Call SP_Report_Details(0,'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "');", "");
                }
                else if (rb.Name == "RB2")
                {
                    sql = string.Format("Call SP_Report_Details(" + Cust_Id + ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "');", "");
                }
                else if (rb.Name == "RB3")
                {
                    sql = string.Format("Call SP_Report_Summary(0,'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "');", "");
                }
                else if (rb.Name == "RB4")
                {
                    sql = string.Format("Call SP_Report_Summary(" + Cust_Id + ",'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "');", "");
                }
                else if (rb.Name == "RB5")
                {
                    sql = string.Format("Call SP_Report_PendingPoints();", "");
                }

                Database.ConnStr obj = new Database.ConnStr();
                DataTable dt = new DataTable();
                dt = obj.GetRecords(sql);
                dgvReprt.DataSource = dt;
            }
        }



        private void cmbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            RadioButton RB = GetSelRb();
            if(RB.Name=="RB2"| RB.Name == "RB4")
            radioButton_Click(RB, e);
        }


        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "SmartLoyalty.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(dgvReprt, sfd.FileName); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsPrint  _ClsPrint = new ClsPrint(dgvReprt, "Smart Loyalty");
            _ClsPrint.PrintForm();
        }
    }
}
