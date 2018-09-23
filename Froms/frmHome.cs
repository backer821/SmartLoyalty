using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartLoyalty
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
        }

        private void LoadWidgetData()
        {
            try
            {
                Database.ConnStr obj = new Database.ConnStr();
                string sql;
                DataTable dt = new DataTable();
                sql = string.Format("SELECT FORMAT(CustTotal,0) AS CustTotal," +
                                       " FORMAT(EarndPoint,0) AS EarndPoint," +
                                       " FORMAT(RedPoint, 0) AS RedPoint, " +
                                       " FORMAT(EarndPoint-RedPoint,0) AS AvailPoint FROM ( SELECT " +
                                       " (SELECT Count(*)  FROM tbl_customers) as CustTotal, " +
                                       " (SELECT SUM(Point)   FROM tbl_point_add) as EarndPoint," +
                                       " (SELECT SUM(Point)   FROM tbl_point_redeem) as RedPoint)t; ", "");
                dt = obj.GetRecords(sql);
                if (dt.Rows.Count > 0)
                {
                    lblCountCust.Text = dt.Rows[0]["CustTotal"].ToString();
                    lblCountAvailPoint.Text = dt.Rows[0]["AvailPoint"].ToString();
                    lblCountEarnedPoint.Text = dt.Rows[0]["EarndPoint"].ToString();
                    lblCountRedPoint.Text = dt.Rows[0]["RedPoint"].ToString();

                }
            }
            catch
            {

            }
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadWidgetData();
        }

    }
}
