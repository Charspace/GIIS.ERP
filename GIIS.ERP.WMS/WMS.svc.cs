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

        #region "getSystemMenuSetUp"
        public List<SysMenu> getSysMenuSetUp()
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

                        PropertyInfo propertyInfo2 = obj.GetType().GetProperty("TS");
                        propertyInfo2.SetValue(obj, Convert.ChangeType(row["TS"], propertyInfo2.PropertyType), null);

                        PropertyInfo propertyInfo3 = obj.GetType().GetProperty("UD");
                        propertyInfo3.SetValue(obj, Convert.ChangeType(row["UD"], propertyInfo3.PropertyType), null);

                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("MenuName");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["Menu Name"], propertyInfo4.PropertyType), null);
                        
                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("MenuUrl");
                        propertyInfo5.SetValue(obj, Convert.ChangeType(row["Menu Url"], propertyInfo5.PropertyType), null);

                        PropertyInfo propertyInfo6 = obj.GetType().GetProperty("Pannel");
                        propertyInfo6.SetValue(obj, Convert.ChangeType(row["Menu Pannel"], propertyInfo6.PropertyType), null);

                        PropertyInfo propertyInfo7 = obj.GetType().GetProperty("Class");
                        propertyInfo7.SetValue(obj, Convert.ChangeType(row["Menu Class"], propertyInfo7.PropertyType), null);

                        PropertyInfo propertyInfo8 = obj.GetType().GetProperty("DisplaySequence");
                        propertyInfo8.SetValue(obj, Convert.ChangeType(row["Display Sequence"], propertyInfo8.PropertyType), null);

                        PropertyInfo propertyInfo9 = obj.GetType().GetProperty("List");
                        propertyInfo9.SetValue(obj, Convert.ChangeType(row["Menu List"], propertyInfo9.PropertyType), null);

                        PropertyInfo propertyInfo10 = obj.GetType().GetProperty("Status");
                        propertyInfo10.SetValue(obj, Convert.ChangeType(row["Menu Status"], propertyInfo10.PropertyType), null);

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
        public List<SysMenuGroup> getSysMenuGroupSetUp()
        {
            SysMenu a = new SysMenu();

            DataTable dt = mMasterBLL.selectDataTable("Sys_MenuGroup", "");
            #region "Bind Object"
            List<SysMenuGroup> list = new List<SysMenuGroup>();

            foreach (DataRow row in dt.Rows)
            {
                SysMenuGroup obj = new SysMenuGroup();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("Ask");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo2 = obj.GetType().GetProperty("TS");
                        propertyInfo2.SetValue(obj, Convert.ChangeType(row["TS"], propertyInfo2.PropertyType), null);

                        PropertyInfo propertyInfo3 = obj.GetType().GetProperty("UD");
                        propertyInfo3.SetValue(obj, Convert.ChangeType(row["UD"], propertyInfo3.PropertyType), null);
                        
                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("MenuGroupName");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["Menu Group Name"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("MenuGroupDesc");
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
        public List<ControlGroup> getSysControlGroupSetUp()
        {
            ControlGroup a = new ControlGroup();

            DataTable dt = mMasterBLL.selectDataTable("Sys_ControlGroup", "");
            #region "Bind Object"
            List<ControlGroup> list = new List<ControlGroup>();

            foreach (DataRow row in dt.Rows)
            {
                ControlGroup obj = new ControlGroup();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("Ask");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo2 = obj.GetType().GetProperty("TS");
                        propertyInfo2.SetValue(obj, Convert.ChangeType(row["TS"], propertyInfo2.PropertyType), null);

                        PropertyInfo propertyInfo3 = obj.GetType().GetProperty("UD");
                        propertyInfo3.SetValue(obj, Convert.ChangeType(row["UD"], propertyInfo3.PropertyType), null);

                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("ControlGroupName");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["Control Group Name"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("ControlGroupDesc");
                        propertyInfo5.SetValue(obj, Convert.ChangeType(row["Control Group Description"], propertyInfo5.PropertyType), null);

                        PropertyInfo propertyInfo6 = obj.GetType().GetProperty("DisplaySequence");
                        propertyInfo6.SetValue(obj, Convert.ChangeType(row["DisplaySequence"], propertyInfo6.PropertyType), null);

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

        #region "getSystemProductSetUp"
        public List<Product> getSysProductSetUp()
        {
            Product a = new Product();

            DataTable dt = mMasterBLL.selectDataTable("Sys_Product", "");
            #region "Bind Object"
            List<Product> list = new List<Product>();

            foreach (DataRow row in dt.Rows)
            {
                Product obj = new Product();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("Ask");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo2 = obj.GetType().GetProperty("TS");
                        propertyInfo2.SetValue(obj, Convert.ChangeType(row["TS"], propertyInfo2.PropertyType), null);

                        PropertyInfo propertyInfo3 = obj.GetType().GetProperty("UD");
                        propertyInfo3.SetValue(obj, Convert.ChangeType(row["UD"], propertyInfo3.PropertyType), null);

                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("ProductName");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["Product Name"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("ProductDesc");
                        propertyInfo5.SetValue(obj, Convert.ChangeType(row["Product Description"], propertyInfo5.PropertyType), null);

                        PropertyInfo propertyInfo6 = obj.GetType().GetProperty("DisplaySequence");
                        propertyInfo6.SetValue(obj, Convert.ChangeType(row["Display Sequence"], propertyInfo6.PropertyType), null);

                        PropertyInfo propertyInfo7 = obj.GetType().GetProperty("Remark");
                        propertyInfo7.SetValue(obj, Convert.ChangeType(row["Remark"], propertyInfo7.PropertyType), null);


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
        public List<SysMenuGroupJson> getSysMenuGroupList(SysMenuGroupCri menuGroup)
        {
            SysMenuGroupJson a = new SysMenuGroupJson();

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
            List<SysMenuGroupJson> list = new List<SysMenuGroupJson>();
            #region "bind data"
            
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
            SysMenuGroup l_ReadMenuGroup = new SysMenuGroup();
            Boolean isAllSave = true;
           
            #region "Bind Object"
            if (menuGroupData.MenuGpAsk == "0")
                l_ReadMenuGroup.Ask = mUtility.getStrAsk().ToString();
            else
                l_ReadMenuGroup.Ask = menuGroupData.MenuGpAsk;

            l_ReadMenuGroup.TS = "1";
            l_ReadMenuGroup.UD = "1";
            l_ReadMenuGroup.MenuGroupName = menuGroupData.MenuGpName;
            l_ReadMenuGroup.MenuGroupDesc= menuGroupData.MenuGpDesc;
            l_ReadMenuGroup.DisplaySequence = menuGroupData.DisplaySequence;
            l_ReadMenuGroup.Remark = menuGroupData.Remark;
            
            Boolean isSave = mMasterBLL.saveObj("SYS_MENUGROUP", l_ReadMenuGroup);

            if (isSave)
            {
                #region "save Sys_MenuGroup_User_JUN"

                SysMenuGroupJunction l_ReadMenuGroupJunforDelete = new SysMenuGroupJunction();
                l_ReadMenuGroupJunforDelete.MenuGroup = l_ReadMenuGroup.Ask;
                
                Boolean isDelete = mMasterBLL.deleteObj("SYS_MENUGROUP_JUN", l_ReadMenuGroupJunforDelete , 3);
            
                for (int i=0 ;i< menuGroupData.MenuList.Count; i++)
                {
                    SysMenuGroupJunction l_ReadMenuGroupJun = new SysMenuGroupJunction();
                    l_ReadMenuGroupJun.Ask = mUtility.getStrAsk().ToString();
                    l_ReadMenuGroupJun.TS = "1";
                    l_ReadMenuGroupJun.UD = "1";
                    l_ReadMenuGroupJun.Menu = menuGroupData.MenuList[i].Ask;
                    l_ReadMenuGroupJun.MenuGroup = l_ReadMenuGroup.Ask;

                    Boolean isJunSave = mMasterBLL.saveObj("Sys_MENUGROUP_JUN", l_ReadMenuGroupJun);

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
            SysUserJson a = new SysUserJson();

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
            SysUser l_ReadUser = new SysUser();
            Boolean isAllSave = true;

            #region "Bind Object"
            if (userData.Ask == "0")
                l_ReadUser.Ask = mUtility.getStrAsk().ToString();
            else
                l_ReadUser.Ask = userData.Ask;

            l_ReadUser.TS = "1";
            l_ReadUser.UD = "1";
            l_ReadUser.UserID = userData.UserID;
            l_ReadUser.UserDescription = userData.UserDesc;
            l_ReadUser.UserPassword = userData.PWD;
            l_ReadUser.UserEmail = userData.UserEmail;
            l_ReadUser.UserPhone = userData.UserPhone;

            Boolean isSave = mMasterBLL.saveObj("SYS_USER", l_ReadUser);

            if (isSave)
            {
                #region "save Sys_MenuGroup_User_JUN"
                SysMenuGroupUserJun l_ReadMenuGroupUserJunforDelete = new SysMenuGroupUserJun();
                l_ReadMenuGroupUserJunforDelete.Ask = "0";
                l_ReadMenuGroupUserJunforDelete.TS = "1";
                l_ReadMenuGroupUserJunforDelete.UD = "1";
                l_ReadMenuGroupUserJunforDelete.User = l_ReadUser.Ask;
                l_ReadMenuGroupUserJunforDelete.MenuGroup = "";

                Boolean isDelete = mMasterBLL.deleteObj("SYS_MENUGROUP_USER_JUN", l_ReadMenuGroupUserJunforDelete, 3);

                for (int i = 0; i < userData.MenuGroupList.Count; i++)
                {
                    SysMenuGroupUserJun l_ReadMenuGroupUSERJun = new SysMenuGroupUserJun();
                    l_ReadMenuGroupUSERJun.Ask = mUtility.getStrAsk().ToString();
                    l_ReadMenuGroupUSERJun.TS = "1";
                    l_ReadMenuGroupUSERJun.UD = "1";
                    l_ReadMenuGroupUSERJun.User = l_ReadUser.Ask;
                    l_ReadMenuGroupUSERJun.MenuGroup = userData.MenuGroupList[i].Ask;

                    Boolean isJunSave = mMasterBLL.saveObj("Sys_MENUGROUP_USER_JUN", l_ReadMenuGroupUSERJun);

                    if (!isJunSave) isAllSave = false;

                }

                #endregion

                #region "save Sys_ControlGroup_User_JUN"
                SysControlGroupUserJun l_ReadControlGroupUserJunforDelete = new SysControlGroupUserJun();
                l_ReadControlGroupUserJunforDelete.User = l_ReadUser.Ask;

                Boolean isDelete2 = mMasterBLL.deleteObj("SYS_CONTROLGROUP_USER_JUN", l_ReadControlGroupUserJunforDelete, 3);

                for (int i = 0; i < userData.ControlGroupList.Count; i++)
                {
                    SysControlGroupUserJun l_ReadControlGroupUSERJun = new SysControlGroupUserJun();
                    l_ReadControlGroupUSERJun.Ask = mUtility.getStrAsk().ToString();
                    l_ReadControlGroupUSERJun.TS = "1";
                    l_ReadControlGroupUSERJun.UD = "1";
                    l_ReadControlGroupUSERJun.User = l_ReadUser.Ask;
                    l_ReadControlGroupUSERJun.ControlGroup = userData.ControlGroupList[i].Ask;
                    

                    Boolean isJunSave = mMasterBLL.saveObj("Sys_CONTROLGROUP_USER_JUN", l_ReadControlGroupUSERJun);

                    if (!isJunSave) isAllSave = false;

                }

                #endregion

                #region "save Sys_Product_User_JUN"
                SysProductUserJunc l_ReadProductUserJunforDelete = new SysProductUserJunc();
                l_ReadProductUserJunforDelete.User = l_ReadUser.Ask;
                l_ReadProductUserJunforDelete.TS = "1";
                l_ReadProductUserJunforDelete.UD = "1";
                

                Boolean isDelete3 = mMasterBLL.deleteObj("SYS_Product_USER_JUN", l_ReadControlGroupUserJunforDelete, 1);

                for (int i = 0; i < userData.ProductList.Count; i++)
                {
                    SysProductUserJunc l_ReadProductUSERJun = new SysProductUserJunc();
                    l_ReadProductUSERJun.Ask = mUtility.getStrAsk().ToString();
                    l_ReadProductUSERJun.TS = "1";
                    l_ReadProductUSERJun.UD = "1";
                    l_ReadProductUSERJun.Product = userData.ProductList[i].Ask;
                    l_ReadProductUSERJun.User = l_ReadUser.Ask;

                    Boolean isJunSave = mMasterBLL.saveObj("Sys_PRODUCT_USER_JUN", l_ReadProductUSERJun);

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
