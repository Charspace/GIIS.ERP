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
using CHARS.HR.COMMON.General;
using System.Reflection;

namespace GIIS.ERP.WMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WMS" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WMS.svc or WMS.svc.cs at the Solution Explorer and start debugging.
    public class WMS : IWMS
    {
        Utility mUtility = new Utility();
        MasterBLL mMasterBLL = new MasterBLL();
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

        //public SysMenu getSysMenu()
        //{
        //    SysMenu a = new SysMenu();
        //    Dictionary<string, string> dic = new Dictionary<string, string>();
        //    dic.Add("@UserID", "admin");
        //    DataTable tbl = mMasterBLL.executeSelectProcedure("CS_SP_SELECT_USER_MENU", dic);

        //    #region "Bind Object"
        //    //if (a.Ask == "0")
        //    //{
        //    //    a.Ask = mUtility.getStrAsk().ToString();
        //    //    SaveStatus = true;
        //    //}
        //    //else
        //    //{
        //    //    l_Read.Ask = aReadInfo.Ask;
        //    //    SaveStatus = false;
        //    //}

        //    //l_Read.Ts = aReadInfo.Ts;
        //    //l_Read.UD = aReadInfo.UD;
        //    //l_Read.MemberAsk = aReadInfo.MemberAsk;
        //    //l_Read.BookAsk = aReadInfo.BookAsk;
        //    //l_Read.MarkAsk = aReadInfo.MarkAsk;
        //    //l_Read.ReadStatus = aReadInfo.ReadStatus;
        //    //l_Read.ReadDate = aReadInfo.ReadDate;
        //    //l_Read.ExpiredDate = aReadInfo.ExpiredDate;
        //    //l_Read.ExtendTime = aReadInfo.ExtendTime;
        //    //l_Read.Remark = aReadInfo.Remark;
        //    //l_Read.ReturnDate = aReadInfo.ReturnDate;
        //    //l_Read.Libray = aReadInfo.Libray;
        //    #endregion


        //    return new SysMenu();
        //}

        #region "getSystemMenu"
        public List<SysMenu> getSysMenu()
        {
            SysMenu a = new SysMenu();

            DataTable dt = mMasterBLL.selectDataTable("Sys_Menu", "");
            #region "Bind Object"
            List<SysMenu> list = new List<SysMenu>();

            foreach (DataRow row in dt.Rows)
            {
                SysMenu obj = new SysMenu();

                foreach (var prop in obj.GetType().GetProperties())
                    {
                    try
                    {
                       // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("Ask");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);


                        PropertyInfo propertyInfo2 = obj.GetType().GetProperty("MenuName");
                        propertyInfo2.SetValue(obj, Convert.ChangeType(row["Menu Name"], propertyInfo2.PropertyType), null);

                    }
                    catch
                    {
                        continue;
                    }
                }

                list.Add(obj);
            }
            #endregion
            return list;
        }
        #endregion

        #region "getSystemMenuGroup"
        public List<SysMenuGroup> getSysMenuGroup(SysMenuGroupCri menuGroup)
        {
            SysMenuGroup a = new SysMenuGroup();

            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", menuGroup.User);
            dic.Add("@Passowrd", menuGroup.PWD);
            dic.Add("@MenuGroupAsk", menuGroup.MenuGpAsk);
            dic.Add("@MenuGroupName", menuGroup.MenuGpName);
            dic.Add("@MenuGroupDesc", menuGroup.MenuGpDesc);
            dic.Add("@MenuAsk", menuGroup.MenuAsk);
            dic.Add("@MenuName", menuGroup.MenuName);
            dic.Add("@MenuUrl", menuGroup.MenuUrl);
            
            DataTable dt = mMasterBLL.executeSelectProcedure("CS_LMS_MenuGroup", dic);
            List<SysMenuGroup> list = new List<SysMenuGroup>();
            #region "bind data"
            
            foreach (DataRow row in dt.Rows)
            {
                SysMenuGroup obj = new SysMenuGroup();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("MenuGpAsk");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["mgAsk"], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo2 = obj.GetType().GetProperty("MenuGpName");
                        propertyInfo2.SetValue(obj, Convert.ChangeType(row["mgGpName"], propertyInfo2.PropertyType), null);

                        PropertyInfo propertyInfo3 = obj.GetType().GetProperty("MenuGpDesc");
                        propertyInfo3.SetValue(obj, Convert.ChangeType(row["mgGpDesc"], propertyInfo3.PropertyType), null);

                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("MenuAsk");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["mAsk"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("MenuName");
                        propertyInfo5.SetValue(obj, Convert.ChangeType(row["mMenuName"], propertyInfo5.PropertyType), null);

                        PropertyInfo propertyInfo6 = obj.GetType().GetProperty("MenuUrl");
                        propertyInfo6.SetValue(obj, Convert.ChangeType(row["mMenuUrl"], propertyInfo6.PropertyType), null);
                    }
                    catch
                    {
                        continue;
                    }
                }

                list.Add(obj);
            }
            #endregion
            return list;
        }
        #endregion

        #region "testingArea"
        //public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
        //{
        //    try
        //    {
        //        List<T> list = new List<T>();

        //        foreach (DataRow row in table.Rows)
        //        {
        //            T obj = new T();

        //            foreach (var prop in obj.GetType().GetProperties())
        //            {
        //                try
        //                {
        //                    PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
        //                    propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
        //                }
        //                catch
        //                {
        //                    continue;
        //                }
        //            }

        //            list.Add(obj);
        //        }

        //        return list;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        #endregion

        public Message saveSysMenuGroup(SysMenuGroupCri menuGroup)
        {
            Message message = new Message();
            SysMenuGroupCri dataMenuGroup = new SysMenuGroupCri();
            #region "Bind Object"
            if (menuGroup.MenuGpAsk == "0")
                dataMenuGroup.MenuGpAsk = mUtility.getStrAsk().ToString();
            else
                dataMenuGroup.MenuGpAsk = menuGroup.MenuGpAsk;

            dataMenuGroup.TS = "1";
            dataMenuGroup.UD = "0";
            dataMenuGroup.DisplaySequence = menuGroup.DisplaySequence;
            dataMenuGroup.Remark = menuGroup.Remark;

            dataMenuGroup.MenuGpName = menuGroup.MenuGpName;
            dataMenuGroup.MenuGpDesc = menuGroup.MenuGpDesc;

            Boolean isSave = mMasterBLL.saveObj("Sys_MenuTable", dataMenuGroup);

            #endregion
            return message;
        }

    }


}
