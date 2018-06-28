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

        #region "getSystemMenuSetUp"
        public List<SysMenuJson> getSysMenuSetUp()
        {
            DataTable dt = mMasterBLL.selectDataTable("Sys_Menu", "");
            #region "Bind Object"
            List<SysMenuJson> list = new List<SysMenuJson>();

            foreach (DataRow row in dt.Rows)
            {
                SysMenuJson obj = new SysMenuJson();

                foreach (var prop in obj.GetType().GetProperties())
                    {
                    try
                    {
                       // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("ID");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("MenuName");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["Menu Name"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo2 = obj.GetType().GetProperty("ParentID");
                        propertyInfo2.SetValue(obj, Convert.ChangeType(row["ParentID"], propertyInfo2.PropertyType), null);

                        PropertyInfo propertyInfo3 = obj.GetType().GetProperty("SubMenuWidth");
                        propertyInfo3.SetValue(obj, Convert.ChangeType(row["SubMenuWidth"], propertyInfo3.PropertyType), null);



                        //PropertyInfo propertyInfo5 = obj.GetType().GetProperty("MenuUrl");
                        //propertyInfo5.SetValue(obj, Convert.ChangeType(row["Menu Url"], propertyInfo5.PropertyType), null);

                        //PropertyInfo propertyInfo6 = obj.GetType().GetProperty("Pannel");
                        //propertyInfo6.SetValue(obj, Convert.ChangeType(row["Menu Pannel"], propertyInfo6.PropertyType), null);

                        //PropertyInfo propertyInfo7 = obj.GetType().GetProperty("Class");
                        //propertyInfo7.SetValue(obj, Convert.ChangeType(row["Menu Class"], propertyInfo7.PropertyType), null);

                        //PropertyInfo propertyInfo8 = obj.GetType().GetProperty("DisplaySequence");
                        //propertyInfo8.SetValue(obj, Convert.ChangeType(row["Display Sequence"], propertyInfo8.PropertyType), null);

                        //PropertyInfo propertyInfo9 = obj.GetType().GetProperty("List");
                        //propertyInfo9.SetValue(obj, Convert.ChangeType(row["Menu List"], propertyInfo9.PropertyType), null);

                        //PropertyInfo propertyInfo10 = obj.GetType().GetProperty("Status");
                        //propertyInfo10.SetValue(obj, Convert.ChangeType(row["Menu Status"], propertyInfo10.PropertyType), null);

                        //PropertyInfo propertyInfo11 = obj.GetType().GetProperty("Pannel");
                        //propertyInfo11.SetValue(obj, Convert.ChangeType(row["Menu Pannel"], propertyInfo11.PropertyType), null);
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

        #region "getSystemMenuGroupSetUp"
        public List<SysMenuGroupJson> getSysMenuGroupSetUp()
        {
            DataTable dt = mMasterBLL.selectDataTable("Sys_MenuGroup", "");
            #region "Bind Object"
            List<SysMenuGroupJson> list = new List<SysMenuGroupJson>();

            foreach (DataRow row in dt.Rows)
            {
                SysMenuGroupJson obj = new SysMenuGroupJson();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("MenuGpAsk");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);

                        //PropertyInfo propertyInfo2 = obj.GetType().GetProperty("TS");
                        //propertyInfo2.SetValue(obj, Convert.ChangeType(row["TS"], propertyInfo2.PropertyType), null);

                        //PropertyInfo propertyInfo3 = obj.GetType().GetProperty("UD");
                        //propertyInfo3.SetValue(obj, Convert.ChangeType(row["UD"], propertyInfo3.PropertyType), null);
                        
                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("MenuGpName");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["Menu Group Name"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("MenuGpDesc");
                        propertyInfo5.SetValue(obj, Convert.ChangeType(row["Menu Group Description"], propertyInfo5.PropertyType), null);

                        PropertyInfo propertyInfo6 = obj.GetType().GetProperty("DisplaySequence");
                        propertyInfo6.SetValue(obj, Convert.ChangeType(row["Display Sequence"], propertyInfo6.PropertyType), null);

                        PropertyInfo propertyInfo7 = obj.GetType().GetProperty("Remark");
                        propertyInfo7.SetValue(obj, Convert.ChangeType(row["Menu List"], propertyInfo7.PropertyType), null);

                       
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

        #region "getSystemControlGroupSetUp"
        public List<SysControlGroupJson> getSysControlGroupSetUp()
        {
            DataTable dt = mMasterBLL.selectDataTable("Sys_ControlGroup", "");
            #region "Bind Object"
            List<SysControlGroupJson> list = new List<SysControlGroupJson>();

            foreach (DataRow row in dt.Rows)
            {
                SysControlGroupJson obj = new SysControlGroupJson();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("ControlGpAsk");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);

                        //PropertyInfo propertyInfo2 = obj.GetType().GetProperty("TS");
                        //propertyInfo2.SetValue(obj, Convert.ChangeType(row["TS"], propertyInfo2.PropertyType), null);

                        //PropertyInfo propertyInfo3 = obj.GetType().GetProperty("UD");
                        //propertyInfo3.SetValue(obj, Convert.ChangeType(row["UD"], propertyInfo3.PropertyType), null);

                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("ControlGpName");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["Control Group Name"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("ControlGpDesc");
                        propertyInfo5.SetValue(obj, Convert.ChangeType(row["Control Group Description"], propertyInfo5.PropertyType), null);

                        //PropertyInfo propertyInfo6 = obj.GetType().GetProperty("DisplaySequence");
                        //propertyInfo6.SetValue(obj, Convert.ChangeType(row["DisplaySequence"], propertyInfo6.PropertyType), null);

                        //PropertyInfo propertyInfo7 = obj.GetType().GetProperty("Remark");
                        //propertyInfo7.SetValue(obj, Convert.ChangeType(row["Menu List"], propertyInfo7.PropertyType), null);


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

        #region "getSystemProductSetUp"
        public List<SysProductJson> getSysProductSetUp()
        {
              DataTable dt = mMasterBLL.selectDataTable("Sys_Product", "");
            #region "Bind Object"
            List<SysProductJson> list = new List<SysProductJson>();

            foreach (DataRow row in dt.Rows)
            {
                SysProductJson obj = new SysProductJson();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("ProductAsk");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);

                        //PropertyInfo propertyInfo2 = obj.GetType().GetProperty("TS");
                        //propertyInfo2.SetValue(obj, Convert.ChangeType(row["TS"], propertyInfo2.PropertyType), null);

                        //PropertyInfo propertyInfo3 = obj.GetType().GetProperty("UD");
                        //propertyInfo3.SetValue(obj, Convert.ChangeType(row["UD"], propertyInfo3.PropertyType), null);

                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("ProductName");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["Product Name"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("ProductDesc");
                        propertyInfo5.SetValue(obj, Convert.ChangeType(row["Product Detail"], propertyInfo5.PropertyType), null);

                        //PropertyInfo propertyInfo6 = obj.GetType().GetProperty("DisplaySequence");
                        //propertyInfo6.SetValue(obj, Convert.ChangeType(row["Display Sequence"], propertyInfo6.PropertyType), null);

                        //PropertyInfo propertyInfo7 = obj.GetType().GetProperty("Remark");
                        //propertyInfo7.SetValue(obj, Convert.ChangeType(row["Remark"], propertyInfo7.PropertyType), null);


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

        #region "getSystemMenuGroupList"
        public List<SysMenuGroupListJson> getSysMenuGroupList(SysMenuGroupCri menuGroup)
        {
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
            List<SysMenuGroupListJson> list = new List<SysMenuGroupListJson>();
            #region "bind data"
            
            foreach (DataRow row in dt.Rows)
            {
                SysMenuGroupListJson obj = new SysMenuGroupListJson();

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

        #region "saveSysMenuGroup"
        public Message saveSysMenuGroup(SysMenuGroupCri menuGroupData)
        {
            Message message = new Message();
            SysMenuGroup l_MenuGroup = new SysMenuGroup();
            Boolean isAllSave = true;
           
            #region "Bind Object"
            if (menuGroupData.MenuGpAsk == "0")
                l_MenuGroup.Ask = mUtility.getStrAsk().ToString();
            else
                l_MenuGroup.Ask = menuGroupData.MenuGpAsk;

            l_MenuGroup.TS = "1";
            l_MenuGroup.UD = "1";
            l_MenuGroup.MenuGroupName = menuGroupData.MenuGpName;
            l_MenuGroup.MenuGroupDesc= menuGroupData.MenuGpDesc;
            l_MenuGroup.DisplaySequence = menuGroupData.DisplaySequence;
            l_MenuGroup.Remark = menuGroupData.Remark;

            Boolean isSave = false;
            if (menuGroupData.MenuGpAsk == "0")
                 isSave = mMasterBLL.saveObj("SYS_MENUGROUP", l_MenuGroup);
            else
                 isSave = mMasterBLL.updateObj("SYS_MENUGROUP", l_MenuGroup);

            if (isSave)
            {
                #region "save Sys_MenuGroup_User_JUN"

                SysMenuGroupJun l_DELMenuGpJun = new SysMenuGroupJun();
                l_DELMenuGpJun.MenuGroup = l_MenuGroup.Ask;
                //l_ReadMenuGroupJunforDelete.Ask = "20180626004226980";

                Boolean isDelete = mMasterBLL.deleteObj("SYS_MENUGROUP_JUN", l_DELMenuGpJun, 4);
            
                for (int i=0 ;i< menuGroupData.MenuList.Count; i++)
                {
                    SysMenuGroupJun l_MenuGroupJun = new SysMenuGroupJun();
                    l_MenuGroupJun.Ask = mUtility.getStrAsk().ToString();
                    l_MenuGroupJun.TS = "1";
                    l_MenuGroupJun.UD = "1";
                    l_MenuGroupJun.Menu = menuGroupData.MenuList[i].Ask;
                    l_MenuGroupJun.MenuGroup = l_MenuGroup.Ask;
                    l_MenuGroupJun.DisplaySequence = "0";
                    l_MenuGroupJun.Remark = "";

                    Boolean isJunSave = mMasterBLL.saveObj("Sys_MENUGROUP_JUN", l_MenuGroupJun);

                    if (!isJunSave) isAllSave = false;

                }
                #endregion

            }
            else
            {
                isAllSave = false;
            }
            #endregion

            #region "message Area"
            if (isAllSave)
            {
                message.Code = "1";
                message.Detail = "Save Successfully.";
            }
            else
            {
                message.Code = "0";
            }
            #endregion

            return message;
        }
        #endregion
     
        #region "getSystemUserList"
        public List<SysUserJson> getSysUserList(SysUserCri user)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", user.User);
            dic.Add("@Passowrd", user.PWD);
            dic.Add("@UserAsk", user.Ask);
            dic.Add("@UserDesc", user.UserDesc);
            dic.Add("@UserPhone", user.UserPhone);
            dic.Add("@UserEmail", user.UserEmail);
            dic.Add("@MenuGroupAsk", user.MenuGroupAsk);
            dic.Add("@MenuGroupName", user.MenuGroupName);
            dic.Add("@MenuGroupDesc", user.MenuGroupDesc);
            dic.Add("@ControlGroupAsk", user.ControlGroupAsk);
            dic.Add("@ControlGroupName", user.ControlGroupName);
            dic.Add("@ControlGroupDesc", user.ControlGroupDesc);
            dic.Add("@ProductAsk", user.ProductAsk);
            dic.Add("@ProductName", user.ProductName);
            dic.Add("@ProductDesc", user.ProductDesc);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_LMS_User", dic);
            List<SysUserJson> list = new List<SysUserJson>();
            #region "bind data"

            foreach (DataRow row in dt.Rows)
            {
                SysUserJson obj = new SysUserJson();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("UserID");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["User Id"], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo2 = obj.GetType().GetProperty("Ask");
                        propertyInfo2.SetValue(obj, Convert.ChangeType(row["userAsk"], propertyInfo2.PropertyType), null);

                        PropertyInfo propertyInfo3 = obj.GetType().GetProperty("UserDesc");
                        propertyInfo3.SetValue(obj, Convert.ChangeType(row["User Description"], propertyInfo3.PropertyType), null);

                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("UserPhone");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["User Phone"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("UserEmail");
                        propertyInfo5.SetValue(obj, Convert.ChangeType(row["User Email"], propertyInfo5.PropertyType), null);

                        PropertyInfo propertyInfo6 = obj.GetType().GetProperty("MenuGroupAsk");
                        propertyInfo6.SetValue(obj, Convert.ChangeType(row["menugroupAsk"], propertyInfo6.PropertyType), null);

                        PropertyInfo propertyInfo7 = obj.GetType().GetProperty("MenuGroupName");
                        propertyInfo7.SetValue(obj, Convert.ChangeType(row["Menu Group Name"], propertyInfo7.PropertyType), null);

                        PropertyInfo propertyInfo8 = obj.GetType().GetProperty("MenuGroupDesc");
                        propertyInfo8.SetValue(obj, Convert.ChangeType(row["Menu Group Description"], propertyInfo8.PropertyType), null);

                        PropertyInfo propertyInfo9 = obj.GetType().GetProperty("ControlGroupAsk");
                        propertyInfo9.SetValue(obj, Convert.ChangeType(row["controlgroupAsk"], propertyInfo9.PropertyType), null);

                        PropertyInfo propertyInfo10 = obj.GetType().GetProperty("ControlGroupName");
                        propertyInfo10.SetValue(obj, Convert.ChangeType(row["Control Group Name"], propertyInfo10.PropertyType), null);

                        PropertyInfo propertyInfo11 = obj.GetType().GetProperty("ControlGroupDesc");
                        propertyInfo11.SetValue(obj, Convert.ChangeType(row["Control Group Description"], propertyInfo11.PropertyType), null);

                        PropertyInfo propertyInfo12 = obj.GetType().GetProperty("ProductAsk");
                        propertyInfo12.SetValue(obj, Convert.ChangeType(row["productAsk"], propertyInfo12.PropertyType), null);

                        PropertyInfo propertyInfo13 = obj.GetType().GetProperty("ProductName");
                        propertyInfo13.SetValue(obj, Convert.ChangeType(row["Product Name"], propertyInfo13.PropertyType), null);

                        PropertyInfo propertyInfo14 = obj.GetType().GetProperty("ProductDesc");
                        propertyInfo14.SetValue(obj, Convert.ChangeType(row["Product Detail"], propertyInfo14.PropertyType), null);
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

        #region "saveSysUser"
        public Message saveSysUser(SysUserCri userData)
        {
            Message message = new Message();
            SysUser l_User = new SysUser();
            Boolean isAllSave = true;
            Boolean isHSave = false;

            #region "Bind Object"

            if (userData.Ask == "0")
                l_User.Ask = mUtility.getStrAsk().ToString();
            else
                l_User.Ask = userData.Ask;

            l_User.TS = "1";
            l_User.UD = "1";
            l_User.UserID = userData.UserID;
            l_User.UserDescription = userData.UserDesc;
            l_User.UserPassword = userData.PWD;
            l_User.UserEmail = userData.UserEmail;
            l_User.UserPhone = userData.UserPhone;
            l_User.DisplaySequence = userData.DisplaySequence;
            l_User.Remark = userData.Remark;

            //Save Header Table (Sys_User Table)
            if (userData.Ask == "0")
                isHSave = mMasterBLL.saveObj("SYS_USER", l_User);
            else
                isHSave = mMasterBLL.updateObj("SYS_USER", l_User);


            if (isHSave)
            {

                #region "save Sys_ControlGroup_User_JUN"
                SysControlGroupUserJun l_DELControlGpUserJun = new SysControlGroupUserJun();
                 l_DELControlGpUserJun.User = l_User.Ask;
               // l_DELControlGpUserJun.ControlGroup = "1";

                 Boolean isDelete = mMasterBLL.deleteObj("SYS_CONTROLGROUP_USER_JUN", l_DELControlGpUserJun, 4);

                for (int i = 0; i < userData.ControlGroupList.Count; i++)
                {
                    SysControlGroupUserJun l_ControlGroupUSERJun = new SysControlGroupUserJun();
                    l_ControlGroupUSERJun.Ask = mUtility.getStrAsk().ToString();
                    l_ControlGroupUSERJun.TS = "1";
                    l_ControlGroupUSERJun.UD = "1";
                    l_ControlGroupUSERJun.User = l_User.Ask;
                    l_ControlGroupUSERJun.ControlGroup = userData.ControlGroupList[i].Ask;
                    l_ControlGroupUSERJun.Remark = userData.Remark;
                    l_ControlGroupUSERJun.DisplaySequence = userData.DisplaySequence;
                                                                             
                    Boolean isJunSave = mMasterBLL.saveObj("Sys_CONTROLGROUP_USER_JUN", l_ControlGroupUSERJun);

                    if (!isJunSave) isAllSave = false;

                }

                #endregion

                #region "save Sys_MenuGroup_User_JUN"
                SysUserMenuGroupJunction l_DELMenuGpUserJun = new SysUserMenuGroupJunction();
                l_DELMenuGpUserJun.User = l_User.Ask;

                Boolean isDelete2 = mMasterBLL.deleteObj("SYS_MENUGROUP_USER_JUN", l_DELMenuGpUserJun, 4);

                for (int i = 0; i < userData.MenuGroupList.Count; i++)
                {
                    SysMenuGroupUserJun l_MenuGroupUSERJun = new SysMenuGroupUserJun();
                    l_MenuGroupUSERJun.Ask = mUtility.getStrAsk().ToString();
                    l_MenuGroupUSERJun.TS = "1";
                    l_MenuGroupUSERJun.UD = "1";
                    l_MenuGroupUSERJun.User = l_User.Ask;
                    l_MenuGroupUSERJun.MenuGroup = userData.MenuGroupList[i].Ask;

                    Boolean isJunSave = mMasterBLL.saveObj("SYS_MENUGROUP_USER_JUN", l_MenuGroupUSERJun);
                  
                    if (!isJunSave) isAllSave = false;

                }

                #endregion

               

                #region "save Sys_Product_User_JUN"
                SysProductUserJunc l_DELProductUserJun = new SysProductUserJunc();
                l_DELProductUserJun.User = l_User.Ask;
               // l_DELProductUserJun.TS = "1";
               // l_DELProductUserJun.UD = "1";
                

                Boolean isDelete3 = mMasterBLL.deleteObj("SYS_Product_USER_JUN", l_DELProductUserJun, 5);

                for (int i = 0; i < userData.ProductList.Count; i++)
                {
                    SysProductUserJunc l_ProductUSERJun = new SysProductUserJunc();
                    l_ProductUSERJun.Ask = mUtility.getStrAsk().ToString();
                    l_ProductUSERJun.TS = "1";
                    l_ProductUSERJun.UD = "1";
                    l_ProductUSERJun.Product = userData.ProductList[i].Ask;
                    l_ProductUSERJun.User = l_User.Ask;

                    Boolean isJunSave = mMasterBLL.saveObj("Sys_PRODUCT_USER_JUN", l_ProductUSERJun);

                    if (!isJunSave) isAllSave = false;

                }

                #endregion

            }
            else
            {
                isAllSave = false;
            }
            #endregion

            #region "message Area"
            if (isAllSave)
            {
                message.Code = "1";
                message.Detail = "Save Successfully.";
            }
            else
            {
                message.Code = "0";
            }
            #endregion

            return message;
        }
        #endregion

    }




}
