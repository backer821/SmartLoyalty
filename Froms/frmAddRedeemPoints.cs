using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartLoyalty
{
    public partial class frmAddRedeemPoints : Form
    {
        private int intType = 0;
        private int SaveType = 0;
        private int CurrID = 0;

        private decimal availpoint = 0;
        public frmAddRedeemPoints(int Type)
        {
            intType = Type;

            InitializeComponent();
            dgvPointadded.BackgroundColor = Color.White;
            dgvPointadded.RowHeadersVisible = false;
            dgvPointadded.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lblAddRedeem.Text = "Point " + ((intType == 0) ? "Erned? " : "Consumed? ");
        }

        private void tblo_CustReg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (SaveType == 0)
            {
                Save();
            }
            else
            {
                Edit();
            }
        }

        private void Save()
        {
            try
            {
                decimal enterpoint = decimal.Parse( txtPoints.Text.Trim());
                if (intType>0)
                {
                    if (enterpoint > availpoint)
                    {
                        MessageBox.Show("Availalble Point is " + availpoint + " only" + Environment.NewLine
                            + "This customer can not redeem " + enterpoint + " Points");
                        txtPoints.Focus();
                        return;
                    }
                }
                Database.ConnStr obj = new Database.ConnStr();

                string sql = "call SP_SavePoint('" + dtpDate.Value.ToString("yyyy-MM-dd") 
                    + "','" + txtBarcode.Tag.ToString()
                    + "','" + txtPoints.Text.Trim()
                    + "','" + intType
                    + "')";

                obj.RunQuery(sql);
                MessageBox.Show("Record Saved!", "Smart Loyalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearText();
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

                string sql = "call SP_EditPoint("+ CurrID +",'" + dtpDate.Value.ToString("yyyy-MM-dd")
                    + "','" + txtBarcode.Tag.ToString()
                    + "','" + txtPoints.Text.Trim()
                    + "','" + intType
                    + "')";

                obj.RunQuery(sql);
                MessageBox.Show("Record Updated!", "Smart Loyalty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();

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
                DialogResult dlk = MessageBox.Show("Do you want to delete the customer?", "Smart Loyalty", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            sql = string.Format("Call SP_ViewCustomerPointAlltrabs("+ intType + ")", "");
            dt = obj.GetRecords(sql);
            dgvPointadded.DataSource = dt;

            txtBarcode.Focus();
        }

        private void ClearText()
        {
            SaveType = 0;
            CurrID = 0;
            txtBarcode.Text = "";
            dtpDate.Value = DateTime.Now;
            txtPoints.Text = "";
            lblCustdet.Text = "";
            lblAddRedeem.Text = "Point " + ((intType == 0) ? "Erned? " : "Consumed? ");

            txtBarcode.Focus();
        }

        private void frmAddRedeemPoints_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            RefreshGrid();
        }

        private void dgvPointadded_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPointadded.CurrentRow != null)
            {
                CurrID = int.Parse(dgvPointadded.CurrentRow.Cells[0].Value.ToString());
                dtpDate.Value = DateTime.Parse(dgvPointadded.CurrentRow.Cells[1].Value.ToString());
                txtBarcode.Tag = dgvPointadded.CurrentRow.Cells[2].Value.ToString();
                txtBarcode.Text = dgvPointadded.CurrentRow.Cells[3].Value.ToString();
                txtBarcode.Tag = Customer_detbyBarcode(txtBarcode.Text.Trim());
                txtPoints.Text = dgvPointadded.CurrentRow.Cells[5].Value.ToString();
                SaveType = 1;

                txtBarcode.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void dgvPointadded_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvPointadded.CurrentRow != null)
                {
                    Delete(int.Parse(dgvPointadded.CurrentRow.Cells[0].Value.ToString()));
                }
            }
        }


        private int Customer_detbyBarcode(string strBarcode)
        {
            int Cust_Id = 0;
            try
            {
                Database.ConnStr obj = new Database.ConnStr();
                string sql;
                DataTable dt = new DataTable();
                sql = string.Format("Call SP_ViewDdetByBarcode("+ strBarcode + ")", "");
                dt = obj.GetRecords(sql);
                
                if(dt.Rows.Count>0)
                {
                    Cust_Id =int.Parse(dt.Rows[0]["ID"].ToString());
                    string custde = "";

                    custde += String.Format("{0}\t{1}", "Name                        :", dt.Rows[0]["Cust_name"].ToString()) + Environment.NewLine;
                    custde += String.Format("{0}\t{1}", "Mobile                      :", dt.Rows[0]["Mobile"].ToString()) + Environment.NewLine;
                    custde += String.Format("{0}\t{1}", "Place                        :", dt.Rows[0]["Place"].ToString()) + Environment.NewLine;

                    sql = string.Format("Call SP_ViewAddRedTotalPoints(" + Cust_Id + ")", "");
                    dt = obj.GetRecords(sql);
                    if(dt.Rows.Count > 0)
                    {
                        decimal ep = 0;
                        decimal.TryParse(dt.Rows[0]["EarnedPoint"].ToString(),out ep);
                        decimal rp = 0;
                        decimal.TryParse(dt.Rows[0]["RedeemedPoint"].ToString(),out rp);
                        availpoint = ep - rp;

                        custde += String.Format("{0}\t{1}", "Earned Points           :", ep) + Environment.NewLine;
                        custde += String.Format("{0}\t{1}", "Redeemed Points      :", rp) + Environment.NewLine;
                        custde += String.Format("{0}\t{1}", "Available Points        :", availpoint) + Environment.NewLine;

                    }
                    lblCustdet.Text = custde;
                }
               
            }
            catch
            {

            }
            return Cust_Id;
        }

        private void txtPoints_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                txtBarcode.Tag = Customer_detbyBarcode(txtBarcode.Text.Trim());
                if (int.Parse(txtBarcode.Tag.ToString()) > 0)
                    txtPoints.Focus();
            }
        }

        private void txtPoints_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) BtnSave.Focus();
        }
    }
}
