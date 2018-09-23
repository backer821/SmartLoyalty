using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartLoyalty
{
    public partial class FormCustReg : Form
    {
        int SaveType = 0;
        int CurrID = 0;
        public FormCustReg()
        {
            InitializeComponent();

            dgvCust.BackgroundColor = Color.White;
            dgvCust.RowHeadersVisible = false;
            dgvCust.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void tblo_CustReg_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(SaveType==0)
            {
                Save();
            }
            else
            {
                Edit();
            }
        }

        private bool IsExistBarcode(string strBarcode)
        {
            bool sts = false;

            try
            {
                Database.ConnStr obj = new Database.ConnStr();
                string sql;
                DataTable dt = new DataTable();
                sql = string.Format("Call SP_ViewDdetByBarcode(" + strBarcode + ")", "");
                dt = obj.GetRecords(sql);
                sts = (dt.Rows.Count > 0);
            }
            catch
            {

            }
            return sts;
        }
        private void Save()
        { 
            try
            {
                if (IsExistBarcode(txtBarcode.Text.Trim()))
                {
                    MessageBox.Show("This Barcode already used!", "Smart Loyalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBarcode.Focus();
                }
                else
                {
                    Database.ConnStr obj = new Database.ConnStr();

                    string sql = "Insert into tbl_customers(Barcode, Cust_name, Place, Mobile, email) values('"
                        + txtBarcode.Text.Trim() + "','" + txtname.Text.Trim() + "','" + txtplace.Text.Trim() + "','"
                        + txtmobile.Text.Trim() + "','" + txtemail.Text.Trim() + "')";

                    obj.RunQuery(sql);
                    MessageBox.Show("Record Saved!", "Smart Loyalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, ":: User Account ::", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Edit()
        {
            try
            {
                Database.ConnStr obj = new Database.ConnStr();

                string sql = "UPDATE tbl_customers SET "
                    + " Barcode = '" + txtBarcode.Text 
                    + "', Cust_name = '" + txtname.Text
                    + "', Place = '" + txtplace.Text
                    + "', Mobile = '" + txtmobile.Text
                    + "', email = '" + txtmobile.Text
                    + "' WHERE ID = '" + CurrID + "'";

                obj.RunQuery(sql);
                MessageBox.Show("Record Updated!", "Smart Loyalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearText();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, ":: User Account ::", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Delete(int ID)
        {
            try
            {
                Database.ConnStr obj = new Database.ConnStr();
                DialogResult dlk = MessageBox.Show("Do you want to delete the customer?", "Smart Loyalty",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlk == DialogResult.Yes)
                {
                    string sql = "DELETE FROM tbl_customers WHERE ID = '" + ID + "'";
                    obj.RunQuery(sql);
                    MessageBox.Show("Record Deleted!", "Smart Loyalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Smart Loyalty", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void RefreshGrid()
        {
            Database.ConnStr obj = new Database.ConnStr();
            string sql;
            DataTable dt = new DataTable();
            sql = string.Format("Select * from tbl_customers", "");
            dt = obj.GetRecords(sql);
            dgvCust.DataSource = dt;

            txtBarcode.Focus();
        }

        private void FormCustReg_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dgvCust_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCust.CurrentRow!=null)
            {
                CurrID = int.Parse( dgvCust.CurrentRow.Cells[0].Value.ToString());
                txtBarcode.Text = dgvCust.CurrentRow.Cells[1].Value.ToString();
                txtname.Text = dgvCust.CurrentRow.Cells[2].Value.ToString();
                txtplace.Text = dgvCust.CurrentRow.Cells[3].Value.ToString();
                txtmobile.Text = dgvCust.CurrentRow.Cells[4].Value.ToString();
                txtemail.Text = dgvCust.CurrentRow.Cells[5].Value.ToString();

                SaveType = 1;

                txtBarcode.Focus();
            }
        }

        private void ClearText()
        {
            SaveType = 0;
            CurrID = 0;
            txtBarcode.Text = "";
            txtname.Text = "";
            txtmobile.Text = "";
            txtplace.Text = "";
            txtemail.Text = "";

            txtBarcode.Focus();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void dgvCust_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                if (dgvCust.CurrentRow != null)
                {
                    Delete(int.Parse(dgvCust.CurrentRow.Cells[0].Value.ToString()));
                }
            }
        }
    }
}
