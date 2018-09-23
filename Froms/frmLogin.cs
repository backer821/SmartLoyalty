using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartLoyalty
{
    public partial class frmLogin : Form
    {
        private int User_Id = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        public int LoginDetails()
        {
            base.ShowDialog();
            return User_Id;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter Username", "Samrt Loylty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Enter Password", "Samrt Loylty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                User_Id = CheckUserLogin(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (User_Id > 0) this.Close();
                txtUsername.Focus();
            }
        }

        private int CheckUserLogin(string GivUid,string GivPswd)
        {

            Database.ConnStr obj = new Database.ConnStr();
            string sql;
            int ActUid = 0;
            DataTable dt = new DataTable();
            sql = string.Format("SELECT * FROM tbl_users;", "");
            dt = obj.GetRecords(sql);
            List<string> users = new List<string>();
            List<string> passwords = new List<string>();
            List<int> ids = new List<int>();
            for (int i=0;i< dt.Rows.Count;i++)
            {
                string tempUser, tempPassword;
                int tmpID;
                tmpID = int.Parse( dt.Rows[i]["ID"].ToString());
                tempUser = dt.Rows[i]["Username"].ToString(); 
                tempPassword = dt.Rows[i]["Password"].ToString();
                ids.Add(tmpID);
                users.Add(tempUser);
                passwords.Add(tempPassword);

            }

            for (int x = 0; x < users.Count; x++)
            {
                if (users[x] == GivUid && passwords[x] == GivPswd)
                {
                    ActUid = ids[x];
                    Database.Username = users[x];
                }
            }

            if(ActUid<1)
            {
                MessageBox.Show("Incorrect Username or Password!", "Samrt Loylty",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return ActUid;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) BtnLogin.Focus();
        }
    }
}
