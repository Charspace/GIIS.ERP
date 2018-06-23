using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using CHARS.HR.COMMON.BOL;
using CHARS.HR.COMMON.BLL;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace GIIS.ERP.WMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WMS" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WMS.svc or WMS.svc.cs at the Solution Explorer and start debugging.
    public class WMS : IWMS
    {
       
        MasterBLL mMasterBLL = new MasterBLL();
        bool SaveStatus = false;
        SqlConnection mConn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConString"].ConnectionString);

        public void DoWork()
        {
            
        }
        public WMS()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(mConn.ConnectionString);
            mMasterBLL.ServerName = mConn.DataSource.ToString();// "DESKTOP-M0G6DC6\\SQL2014";
            mMasterBLL.DataBaseName = mConn.Database.ToString();// "LMS_APP";
            mMasterBLL.UserName = builder.UserID;
            mMasterBLL.Password = builder.Password;
        }
        public UserInfo getUserInfo()
        {
            return new UserInfo();
        }

        public SysMenu getSysMenu()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", "admin");
            DataTable tbl = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_USER_MENU", dic);
           
            return  new SysMenu();
        }
    }
}
