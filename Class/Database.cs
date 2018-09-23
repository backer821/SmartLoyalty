using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SmartLoyalty
{
    class Database
    {
        public static string MySqlClientString = "";// server= localhost;user id=root;password=smartl821;database="+ Databasename + ";SslMode=none";

        public static int User_Id = 0;
        public static string Username = "";

        public static void setDatabase(string Databasename)
        {
            MySqlClientString = "server= localhost;user id=root;password=smartl821;database=" + Databasename + ";SslMode=none";
        }
        public static void DBConn()
        {
            MySqlConnection conn = new MySqlConnection(MySqlClientString);
            try
            {
                if (conn.State.Equals(ConnectionState.Closed))
                {
                    conn.Open();
                }
            }
            catch (MySqlException myerror)
            {
                MessageBox.Show("Cannot connect to database: " + myerror.Message, "Error Connection", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Dispose();
            }
        }

        public class ConnStr
        {
            public MySqlConnection conn = new MySqlConnection(MySqlClientString);
            public MySqlCommand cmd = new MySqlCommand();
            public DataTable dt = new DataTable();
            public MySqlDataAdapter da = new MySqlDataAdapter();
            public DataSet ds = new DataSet();

            //Insert/Delete/Update
            public void RunQuery(string MySql)
            {
                try
                {
                    if(conn.State==ConnectionState.Closed)
                    conn.Open();

                    cmd.Connection = conn;
                    cmd.CommandText = MySql;
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }

            //Run Select Query
            public DataTable GetRecords(string MySql)
            {
                dt = new DataTable();
                da = new MySqlDataAdapter(MySql, conn);
                da.Fill(dt);
                return dt;
            }

            public DataTable GetCompInfo()
            {
                string MySql = "SELECT * FROM smartl.tbl_comp_info;";
                dt = new DataTable();
                da = new MySqlDataAdapter(MySql, conn);
                da.Fill(dt);
                return dt;
            }

        }

    }
}
