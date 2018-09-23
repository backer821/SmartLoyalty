using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections.Specialized;

namespace SmartLoyalty
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            for(int i=0;i< panelButtons.Controls.Count;i++)
            {
                if (panelButtons.Controls[i].GetType()==typeof(Button))
                {
                    Button button = (Button)panelButtons.Controls[i];
                    button.TabStop = false;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); //transparent
                }
            }
            BtnHome.Tag = panelformArea;
        }

        private void BtnTab_Click(object sender, EventArgs e)
        {
            makenormalButton();
            Button btn = (Button)sender;
            btn.BackColor = Color.LightSteelBlue;
            btn.ForeColor = Color.White;
            switch (btn.Name)
            {
                case "BtnHome":
                    LoadForms(new frmHome());
                    break;
                case "BtnCustReg":
                    LoadForms(new FormCustReg());
                    break; 
                case "BtnAddPoint":
                    LoadForms(new frmAddRedeemPoints(0));
                    break;
                case "BtnRedmPoint": 
                    LoadForms(new frmAddRedeemPoints(1));
                    break;
                case "BtnReport": 
                    LoadForms(new frmReports());
                    break;
                case "BtnLogOut":
                    Application.Exit();
                    break;
            }
        }

        private void makenormalButton()
        {
            for(int i=0;i<panelButtons.Controls.Count;i++)
            {
                Button btn = (Button)panelButtons.Controls[i];
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
            }
        }

        private void DisposeControls()
        {
            List<Control> ctrls = new List<Control>();
            foreach (Control c in panelformArea.Controls) ctrls.Add(c);
            panelformArea.Controls.Clear();
            foreach (Control c in ctrls) c.Dispose();
        }
        private void LoadForms(Form objForm)
        {
            DisposeControls();
            objForm.TopLevel = false;
            panelformArea.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            frmLogin frml = new frmLogin();
            Database.User_Id= frml.LoginDetails();
            if (Database.User_Id < 1) Application.Exit();
            lblLoginUser.Text = "User: " + Database.Username;
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnTab_Click(BtnHome,e);
        }

    }
}

