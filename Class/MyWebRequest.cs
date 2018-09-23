using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Net;
using System.Collections.Specialized;
namespace SmartLoyalty
{
    public class MyWebRequest
    {
        public string CreateLic_Data()
        {
            string pagesource = "";
            string urlAddress = "https://smartl.000webhostapp.com/product/create.php";
            List<string> licIfodata = Get_Lic_Data();

            string Cl_name = "";
            string Cl_place = "";
            string Cl_mobno = "";
            string Cl_LIC_Data = "";

            if (licIfodata.Count>0)
            {
                Cl_name = licIfodata[1];
                Cl_place = licIfodata[2];
                Cl_mobno = licIfodata[3];
                Cl_LIC_Data = licIfodata[6];
            }

            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
               {
                    { "Client_Name",Cl_name},
                    { "Client_Place",Cl_place},
                    { "Mobile_No",Cl_mobno},
                    { "Lic_info",Cl_LIC_Data},
                    { "Lic_Status","0"}
               };
                 pagesource = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
            }
            return  pagesource;
        }

        public string FindLic_Data(string Cl_name, string Cl_place, string Cl_mobno)
        {
            string pagesource = "";
            string urlAddress = "https://smartl.000webhostapp.com/product/find.php";
            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
               {
                    { "Client_Name",Cl_name},
                    { "Client_Place",Cl_place},
                    { "Mobile_No",Cl_mobno}
               };
                pagesource = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
            }
            return pagesource;
        }


        private List<string> Get_Lic_Data()
        {
            List<string> retData = new List<string>();
            try
            {
                string Prc_id = GetProc_Id();
                string HDD_id = GetHardDiskSerialNo();
                string OS_id = GetOSSerialNo();
                string Comp_data = "";
                Database.ConnStr db = new Database.ConnStr();
                DataTable dtbl = db.GetCompInfo();
                if(dtbl.Rows.Count>0)
                {
                    retData.Add(dtbl.Rows[0]["ID"].ToString());
                    retData.Add(dtbl.Rows[0]["Client_Name"].ToString());
                    retData.Add(dtbl.Rows[0]["Client_Place"].ToString());
                    retData.Add(dtbl.Rows[0]["Mobile_No"].ToString());
                    retData.Add(dtbl.Rows[0]["Lic_info"].ToString());
                    retData.Add(dtbl.Rows[0]["Lic_Status"].ToString());
                    Comp_data = dtbl.Rows[0]["Client_Name"].ToString() + dtbl.Rows[0]["Mobile_No"].ToString();
                }

                retData.Add(Prc_id + HDD_id + OS_id + Comp_data);
            }
            catch
            {

            }
            return retData;
        }

        private string GetProc_Id()
        {
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            return id;
        }

        private string GetHardDiskSerialNo()
        {
            ManagementClass mangnmt = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = mangnmt.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol)
            {
                result += Convert.ToString(strt["VolumeSerialNumber"]);
            }
            return result;
        }

        private string GetOSSerialNo()
        {
            ManagementObject os = new ManagementObject("Win32_OperatingSystem=@");
            string serial = (string)os["SerialNumber"];

            return serial;
        }


    }
}
