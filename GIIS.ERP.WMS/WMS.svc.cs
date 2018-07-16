using System;
using System.Collections.Generic;
using System.Linq;
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

        #region "getAccessMenu"
        public List<SysMenuJson> getAccessMenu(AuthorizationCri accessMenu)
        {
            bool checkSuccess = true;
            List<SysMenuJson> list = new List<SysMenuJson>();

            try {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@UserID", accessMenu.UserID);
                dic.Add("@Password", accessMenu.Password);
                dic.Add("@ProductAsk", accessMenu.ProductAsk);


                DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_USER_MENU_PRODUCT", dic);
               

                #region "Bind Object"

                foreach (DataRow row in dt.Rows)
                {
                    SysMenuJson obj = new SysMenuJson();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty("id");
                            propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);

                            PropertyInfo propertyInfo4 = obj.GetType().GetProperty("text");
                            propertyInfo4.SetValue(obj, Convert.ChangeType(row["Menu Name"], propertyInfo4.PropertyType), null);

                            PropertyInfo propertyInfo2 = obj.GetType().GetProperty("parentid");
                            propertyInfo2.SetValue(obj, Convert.ChangeType(row["ParentID"], propertyInfo2.PropertyType), null);

                            PropertyInfo propertyInfo3 = obj.GetType().GetProperty("SubMenuWidth");
                            propertyInfo3.SetValue(obj, Convert.ChangeType(row["SubMenuWidth"], propertyInfo3.PropertyType), null);

                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }
            }catch(Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            #endregion
            return list;
        }
        #endregion

        #region "getSystemMenuGroup"
        public List<SysMenuGroupJson> getSysMenuGroup(AuthorizationCri menugp)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", menugp.UserID);
            dic.Add("@Password", menugp.Password);
            dic.Add("@ProductAsk", menugp.ProductAsk);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_MenuGroup", dic);
          

            #region "Bind Object"
            List<SysMenuGroupJson> list = new List<SysMenuGroupJson>();

            foreach (DataRow row in dt.Rows)
            {
                SysMenuGroupJson obj = new SysMenuGroupJson();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
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

                        //PropertyInfo propertyInfo6 = obj.GetType().GetProperty("DisplaySequence");
                        //propertyInfo6.SetValue(obj, Convert.ChangeType(row["Display Sequence"], propertyInfo6.PropertyType), null);

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

        #region "getSystemMenuGroupList"
        public List<SysMenuGroupListJson> getSysMenuGroupList(SysMenuGroupCri menuGroup)
        {
             Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", menuGroup.User);
            dic.Add("@Password", menuGroup.PWD);
            dic.Add("@MenuGroupAsk", menuGroup.MenuGpAsk);
            dic.Add("@MenuGroupName", menuGroup.MenuGpName);
            dic.Add("@MenuGroupDesc", menuGroup.MenuGpDesc);
            dic.Add("@MenuAsk", menuGroup.MenuAsk);
            dic.Add("@MenuName", menuGroup.MenuName);
            dic.Add("@MenuUrl", menuGroup.MenuUrl);
            dic.Add("@ProductAsk", menuGroup.ProductAsk);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_MenuGroupList", dic);
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

        #region "getAccessControl"
        public List<SysControlJson> getAccessControl(AuthorizationCri accessControl)
        {
            bool checkSuccess = true;
            List<SysControlJson> list = new List<SysControlJson>();

            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@UserID", accessControl.UserID);
                dic.Add("@Password", accessControl.Password);
                dic.Add("@ProductAsk", accessControl.ProductAsk);


                DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_CONTROL_MENU_PRODUCT", dic);


                #region "Bind Object"

                foreach (DataRow row in dt.Rows)
                {
                    SysControlJson obj = new SysControlJson();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty("ControlAsk");
                            propertyInfo.SetValue(obj, Convert.ChangeType(row["Ask"], propertyInfo.PropertyType), null);

                            PropertyInfo propertyInfo1 = obj.GetType().GetProperty("ControlName");
                            propertyInfo1.SetValue(obj, Convert.ChangeType(row["Control Name"], propertyInfo1.PropertyType), null);

                            PropertyInfo propertyInfo2 = obj.GetType().GetProperty("ControlUrl");
                            propertyInfo2.SetValue(obj, Convert.ChangeType(row["Control Url"], propertyInfo2.PropertyType), null);

                            PropertyInfo propertyInfo3 = obj.GetType().GetProperty("MenuAsk");
                            propertyInfo3.SetValue(obj, Convert.ChangeType(row["MenuAsk"], propertyInfo3.PropertyType), null);

                            PropertyInfo propertyInfo4 = obj.GetType().GetProperty("ProductAsk");
                            propertyInfo4.SetValue(obj, Convert.ChangeType(row["ProductAsk"], propertyInfo4.PropertyType), null);

                            PropertyInfo propertyInfo5 = obj.GetType().GetProperty("UserAsk");
                            propertyInfo5.SetValue(obj, Convert.ChangeType(row["UserAsk"], propertyInfo5.PropertyType), null);

                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }
            }
            catch (Exception ex)
            {
                 //MessageBox.Show(ex.Message);
            }
            #endregion
            return list;
        }
        #endregion

        #region "getSystemControlGroup"
        public List<SysControlGroupJson> getSysControlGroup(AuthorizationCri controlGroup)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", controlGroup.UserID);
            dic.Add("@Password", controlGroup.Password);
            dic.Add("@ProductAsk", controlGroup.ProductAsk);
            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_ControlGroup", dic);
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

        #region "getSystemControlGroupList"
        public List<SysControlGroupListJson> getSysControlGroupList(SysControlGroupCri controlGroup)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", controlGroup.User);
            dic.Add("@Password", controlGroup.PWD);
            dic.Add("@ControlGroupAsk", controlGroup.ControlGpAsk);
            dic.Add("@ControlGroupName", controlGroup.ControlGpName);
            dic.Add("@ControlGroupDesc", controlGroup.ControlGpDesc);
            dic.Add("@ControlAsk", controlGroup.ControlAsk);
            dic.Add("@ControlName", controlGroup.ControlName);
            dic.Add("@ControlUrl", controlGroup.ControlUrl);
            dic.Add("@ProductAsk", controlGroup.ProductAsk);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_ControlGroupList", dic);
            List<SysControlGroupListJson> list = new List<SysControlGroupListJson>();
            #region "bind data"

            foreach (DataRow row in dt.Rows)
            {
                SysControlGroupListJson obj = new SysControlGroupListJson();

                foreach (var prop in obj.GetType().GetProperties())
                {
                    try
                    {
                        // PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                        //propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo = obj.GetType().GetProperty("ControlGpAsk");
                        propertyInfo.SetValue(obj, Convert.ChangeType(row["cgAsk"], propertyInfo.PropertyType), null);

                        PropertyInfo propertyInfo2 = obj.GetType().GetProperty("ControlGpName");
                        propertyInfo2.SetValue(obj, Convert.ChangeType(row["cgGpName"], propertyInfo2.PropertyType), null);

                        PropertyInfo propertyInfo3 = obj.GetType().GetProperty("ControlGpDesc");
                        propertyInfo3.SetValue(obj, Convert.ChangeType(row["cgGpDesc"], propertyInfo3.PropertyType), null);

                        PropertyInfo propertyInfo4 = obj.GetType().GetProperty("ControlAsk");
                        propertyInfo4.SetValue(obj, Convert.ChangeType(row["cAsk"], propertyInfo4.PropertyType), null);

                        PropertyInfo propertyInfo5 = obj.GetType().GetProperty("ControlName");
                        propertyInfo5.SetValue(obj, Convert.ChangeType(row["cControlName"], propertyInfo5.PropertyType), null);

                        PropertyInfo propertyInfo6 = obj.GetType().GetProperty("ControlUrl");
                        propertyInfo6.SetValue(obj, Convert.ChangeType(row["cControlUrl"], propertyInfo6.PropertyType), null);
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

        #region "getSystemProduct"
        public List<SysProductJson> getSysProduct(AuthorizationCri product)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", product.UserID);
            dic.Add("@Password", product.Password);
            dic.Add("@ProductAsk", product.ProductAsk);
            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_Product", dic);
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
            l_MenuGroup.UserRemark = menuGroupData.Remark;

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
                    l_MenuGroupJun.UserRemark = "";

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
            dic.Add("@Password", user.PWD);
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

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_User", dic);
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
            l_User.UserRemark = userData.Remark;

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
              
                 Boolean isDelete = mMasterBLL.deleteObj("SYS_CONTROLGROUP_USER_JUN", l_DELControlGpUserJun, 4);

                for (int i = 0; i < userData.ControlGroupList.Count; i++)
                {
                    SysControlGroupUserJun l_ControlGroupUSERJun = new SysControlGroupUserJun();
                    l_ControlGroupUSERJun.Ask = mUtility.getStrAsk().ToString();
                    l_ControlGroupUSERJun.TS = "1";
                    l_ControlGroupUSERJun.UD = "1";
                    l_ControlGroupUSERJun.User = l_User.Ask;
                    l_ControlGroupUSERJun.DisplaySequence = userData.ControlGroupList[i].DisplaySequence;
                    l_ControlGroupUSERJun.UserRemark = userData.ControlGroupList[i].UserRemark;
                    
                                                                             
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
                    l_MenuGroupUSERJun.DisplaySequence = userData.MenuGroupList[i].DisplaySequence;
                    l_MenuGroupUSERJun.UserRemark = userData.MenuGroupList[i].UserRemark;

                    Boolean isJunSave2 = mMasterBLL.saveObj("SYS_MENUGROUP_USER_JUN", l_MenuGroupUSERJun);
                  
                    if (!isJunSave2) isAllSave = false;

                }

                #endregion

               

                #region "save Sys_Product_User_JUN"
                SysProductUserJunc l_DELProductUserJun = new SysProductUserJunc();
                l_DELProductUserJun.User = l_User.Ask;
                             
                Boolean isDelete3 = mMasterBLL.deleteObj("SYS_Product_USER_JUN", l_DELProductUserJun, 5);

                for (int i = 0; i < userData.ProductList.Count; i++)
                {
                    SysProductUserJunc l_ProductUSERJun = new SysProductUserJunc();
                    l_ProductUSERJun.Ask = mUtility.getStrAsk().ToString();
                    l_ProductUSERJun.TS = "1";
                    l_ProductUSERJun.UD = "1";
                    l_ProductUSERJun.Product = userData.ProductList[i].Ask;
                    l_ProductUSERJun.User = l_User.Ask;
                    l_ProductUSERJun.DisplaySequence = userData.ProductList[i].DisplaySequence;
                    l_ProductUSERJun.UserRemark = userData.ProductList[i].UserRemark;

                    Boolean isJunSave3 = mMasterBLL.saveObj("Sys_PRODUCT_USER_JUN", l_ProductUSERJun);

                    if (!isJunSave3) isAllSave = false;

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

        #region "testLogIn"
        public Message testLogIn(LoginCri login)
        {
            bool checkSuccess = true;
            Message msgObj = new Message();
         try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("@UserID", login.UserID);
                dic.Add("@Password", login.Password);
                dic.Add("@ProductAsk", login.ProductAsk);

                dic.Add("@DeviceName", login.DeviceName);
                dic.Add("@LoginDateTime", login.LoginDateTime);
                dic.Add("@LoginBrowserType", login.LoginBrowserType);
                dic.Add("@IPAddress", login.IPAdress);

                bool isSuccess = mMasterBLL.executeProcedure("CS_SP_WMS_TestLogin", dic);
                //tts
                if (isSuccess)
                {
                    msgObj.Code="1";
                    msgObj.Detail="Login Test is successful.";
                }
                else
                {
                    msgObj.Code = "0";
                    msgObj.Detail = "Login Test is fail.";
                }
                
            
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
          
            return msgObj;
        }
        #endregion

        #region "savePRFEWarehouse"
        public List<PREFWarehouseJson> savePRFEWarehouse(PRFEWarehouseCri bookingData)
        {
            Message message = new Message();
            Booking l_Booking = new Booking();
            string curBookingAsk = "0";
            string curShipperAsk = "0";
            string curTruckAsk = "0";
            string curPOAsk = "0";
            string curSKUAsk = "0";
            Boolean isAllSave = true;
            Boolean isHSave = false;

            #region "Bind Object"

            if (bookingData.Ask == "0")
                l_Booking.Ask = mUtility.getStrAsk().ToString();
            else
                l_Booking.Ask = bookingData.Ask;
            
            l_Booking.TS = "1";
            l_Booking.UD = "1";
            l_Booking.BookingID = bookingData.BookingID;
            l_Booking.AgentAsk = bookingData.AgentAsk;
            l_Booking.Shipper = bookingData.Shipper;
            l_Booking.CountryAsk = bookingData.CountryAsk;
            l_Booking.CargoReceivedDate = bookingData.CargoReceivedDate;
            l_Booking.CustomIssuedDate = bookingData.CustomIssuedDate;
            l_Booking.TransactionDate = bookingData.TransactionDate;
            l_Booking.Signature = bookingData.Signature;
            l_Booking.SignatureDate = bookingData.SignatureDateSignature;
            l_Booking.BookingStatusAsk = bookingData.BookingStatusAsk;
            l_Booking.NoOfTruck = bookingData.NoOfTruck;
            l_Booking.NoOfContainer = bookingData.NoOfContainer;
            l_Booking.DisplaySequence = bookingData.DisplaySequence;
            l_Booking.Remark = bookingData.Remark;

            //currentBookingAsk 
            curBookingAsk = l_Booking.Ask;
            //Save Header Table (WMS_BOOKING Table)

            #region "Booking Save"
            if (bookingData.Ask == "0")
                isHSave = mMasterBLL.saveObj("WMS_BOOKING", l_Booking);
            else
                isHSave = mMasterBLL.updateObj("WMS_BOOKING", l_Booking);
            #endregion

            if (isHSave)
            {
                if (bookingData.ShipperList.Count > 0)
                {

                    #region "ShipperSave"
                    List<ShipperCri> l_shipperList = new List<ShipperCri>();
                    l_shipperList = bookingData.ShipperList;
                    int shipperCount = l_shipperList.Count;

                    for (int a = 0; a < shipperCount; a++)
                    {
                        Shipper l_shipper = new Shipper();

                        if (l_shipperList[a].Ask == "0")
                            l_shipper.Ask = mUtility.getStrAsk().ToString();
                        else
                            l_shipper.Ask = l_shipperList[a].Ask;

                        l_shipper.TS = "1";
                        l_shipper.UD = "1";
                        l_shipper.ShipperName = l_shipperList[a].ShipperName;
                        l_shipper.ShipperDetails = l_shipperList[a].ShipperDetails;
                        l_shipper.Status = l_shipperList[a].Status;
                        l_shipper.DisplaySequence = "1";
                        l_shipper.Remark = l_shipperList[a].Remark;

                        //currentTruckAsk
                        curShipperAsk = l_shipper.Ask;
                        Boolean isShipperSave = false;

                        if (l_shipperList[a].Ask == "0")
                            isShipperSave = mMasterBLL.saveObj("WMS_SHIPPER", l_shipper);
                        else
                            isShipperSave = mMasterBLL.updateObj("WMS_SHIPPERs", l_shipper);
                        #endregion

                        if (isShipperSave)
                        {
                            #region "BookingShipperJunctionSave"
                            BookingShipperJun bsJun = new BookingShipperJun();
                            bsJun.Ask = mUtility.getStrAsk().ToString();
                            bsJun.TS = "1";
                            bsJun.UD = "1";
                            bsJun.BookingAsk = curBookingAsk;
                            bsJun.ShipperAsk = curShipperAsk;
                            bsJun.Status = "0";
                            bsJun.DisplaySequence = "0";
                            bsJun.Remark = "";

                            Boolean isShipperJunDelete = mMasterBLL.deleteObj("WMS_BOOKING_Shipper_JUN", bsJun, 5);
                            Boolean isShipperJunSave = mMasterBLL.saveObj("WMS_BOOKING_Shipper_JUN", bsJun);
                            #endregion

                            if (bookingData.ShipperList[a].TruckList.Count > 0)
                            {
                                #region "TruckSave"
                                List<TruckCri> l_truckList = new List<TruckCri>();
                                l_truckList = bookingData.ShipperList[a].TruckList;
                                int truckCount = l_truckList.Count;

                                for (int i = 0; i < truckCount; i++)
                                {
                                    Truck l_truck = new Truck();

                                    if (l_truckList[i].Ask == "0")
                                        l_truck.Ask = mUtility.getStrAsk().ToString();
                                    else
                                        l_truck.Ask = l_truckList[i].Ask;

                                    l_truck.TS = "1";
                                    l_truck.UD = "1";
                                    l_truck.TruckID = l_truckList[i].TruckID;
                                    l_truck.TruckTypeAsk = l_truckList[i].TruckTypeAsk;
                                    l_truck.Status = l_truckList[i].Status;
                                    l_truck.DisplaySequence = "1";
                                    l_truck.Remark = l_truckList[i].Remark;

                                    //currentTruckAsk
                                    curTruckAsk = l_truck.Ask;
                                    Boolean isTruckSave = false;

                                    if (l_truckList[i].Ask == "0")
                                        isTruckSave = mMasterBLL.saveObj("WMS_TRUCK", l_truck);
                                    else
                                        isTruckSave = mMasterBLL.updateObj("WMS_TRUCK", l_truck);
                                    #endregion

                                    if (isTruckSave)
                                    {
                                        #region "BookingTruckJunctionSave"
                                        BookingTruckJun btJun = new BookingTruckJun();
                                        btJun.Ask = mUtility.getStrAsk().ToString();
                                        btJun.TS = "1";
                                        btJun.UD = "1";
                                        btJun.BookingAsk = curBookingAsk;
                                        btJun.TruckAsk = curTruckAsk;
                                        btJun.Status = "0";
                                        btJun.DisplaySequence = "0";
                                        btJun.Remark = "";
                                        btJun.ShipperAsk = curShipperAsk;

                                        Boolean isTruckJunDelete = mMasterBLL.deleteObj("WMS_BOOKING_TRUCK_JUN", btJun, 5);
                                        Boolean isTruckJunSave = mMasterBLL.saveObj("WMS_BOOKING_TRUCK_JUN", btJun);
                                        #endregion

                                        if (bookingData.ShipperList[a].TruckList[i].POList.Count > 0)
                                        {

                                            #region"POSave"
                                            List<POCri> l_poList = new List<POCri>();
                                            l_poList = bookingData.ShipperList[a].TruckList[i].POList;
                                            int poCount = l_poList.Count;

                                            for (int j = 0; j < poCount; j++)
                                            {
                                                PO l_po = new PO();

                                                if (l_poList[j].Ask == "0")
                                                    l_po.Ask = mUtility.getStrAsk().ToString();
                                                else
                                                    l_po.Ask = l_poList[j].Ask;

                                                l_po.TS = "1";
                                                l_po.UD = "1";
                                                l_po.PONo = l_poList[j].PONo;
                                                l_po.ShippingMark = l_poList[j].ShippingMark;
                                                l_po.ReferenceNo = l_poList[j].ReferenceNo;
                                                l_po.Status = l_poList[j].Status;
                                                l_po.DisplaySequence = "1";
                                                l_po.Remark = l_poList[j].Remark;

                                                //currentTruckAsk
                                                curPOAsk = l_po.Ask;
                                                Boolean isPOSave = false;
                                                if (l_poList[j].Ask == "0")
                                                    isPOSave = mMasterBLL.saveObj("WMS_PO", l_po);
                                                else
                                                    isPOSave = mMasterBLL.updateObj("WMS_PO", l_po);

                                                #endregion

                                                if (isPOSave)
                                                {
                                                    #region "TruckPOJUNSave"
                                                    TruckPOJun tpJun = new TruckPOJun();
                                                    tpJun.Ask = mUtility.getStrAsk().ToString();
                                                    tpJun.TS = "1";
                                                    tpJun.UD = "1";
                                                    tpJun.TruckAsk = curTruckAsk;
                                                    tpJun.POAsk = curPOAsk;
                                                    tpJun.Status = "0";
                                                    tpJun.DisplaySequence = "0";
                                                    tpJun.Remark = "";
                                                    tpJun.BookingAsk = curBookingAsk;
                                                    tpJun.ShipperAsk = curShipperAsk;

                                                    Boolean isPOJunDelete = mMasterBLL.deleteObj("WMS_TRUCK_PO_JUN", tpJun, 5);
                                                    Boolean isPOJunSave = mMasterBLL.saveObj("WMS_TRUCK_PO_JUN", tpJun);
                                                    #endregion

                                                    if (bookingData.ShipperList[a].TruckList[i].POList[j].SKUList.Count > 0)
                                                    {

                                                        #region"SKUSave"
                                                        List<SKUCri> l_skuList = new List<SKUCri>();
                                                        l_skuList = bookingData.ShipperList[a].TruckList[i].POList[j].SKUList;
                                                        int skuCount = l_skuList.Count;

                                                        for (int k = 0; k < skuCount; k++)
                                                        {
                                                            SKU l_sku = new SKU();

                                                            if (l_skuList[k].Ask == "0")
                                                                l_sku.Ask = mUtility.getStrAsk().ToString();
                                                            else
                                                                l_sku.Ask = l_skuList[k].Ask;

                                                            l_sku.TS = "1";
                                                            l_sku.UD = "1";
                                                            l_sku.SKUName = l_skuList[k].SKUName;
                                                            l_sku.SKUDetails = l_skuList[k].SKUDetails;
                                                            l_sku.DimensionWidth = l_skuList[k].DimensionWidth;
                                                            l_sku.DimensionHeight = l_skuList[k].DimensionHeight;
                                                            l_sku.DimensionBase = l_skuList[k].DimensionBase;
                                                            l_sku.SKUWeight = l_skuList[k].SKUWeight;
                                                            l_sku.PlanQty = l_skuList[k].PlanQty;
                                                            l_sku.UOMAsk = l_skuList[k].UOMAsk;
                                                            l_sku.ReceivedQty = l_skuList[k].ReceivedQty;
                                                            l_sku.Reference = l_skuList[k].Reference;
                                                            l_sku.TruckID = l_skuList[k].TruckID;
                                                            l_sku.TruckType = l_skuList[k].TruckType;
                                                            l_sku.GoodQty = l_skuList[k].GoodQty;
                                                            l_sku.DamageQty = l_skuList[k].DamageQty;
                                                            l_sku.ShortLandQty = l_skuList[k].ShortLandQty;
                                                            l_sku.OverlandQty = l_skuList[k].OverlandQty;
                                                            l_sku.Goodphoto = l_skuList[k].Goodphoto;
                                                            l_sku.Damagephoto = l_skuList[k].Damagephoto;
                                                            l_sku.ShortLandphoto = l_skuList[k].ShortLandphoto;
                                                            l_sku.Overlandphoto = l_skuList[k].Overlandphoto;
                                                            l_sku.Status = l_skuList[k].Status;
                                                            l_sku.DisplaySequence = "1";
                                                            l_sku.Remark = l_skuList[k].Remark;

                                                            //currentSKUAsk
                                                            curSKUAsk = l_sku.Ask;
                                                            Boolean isSKUSave = false;
                                                            if (l_skuList[k].Ask == "0")
                                                                isSKUSave = mMasterBLL.saveObj("WMS_SKU", l_sku);
                                                            else
                                                                isSKUSave = mMasterBLL.updateObj("WMS_SKU", l_sku);

                                                            #endregion

                                                            if (isSKUSave)
                                                            {
                                                                #region "POSKUJUNSave"
                                                                POSKUJun psJun = new POSKUJun();
                                                                psJun.Ask = mUtility.getStrAsk().ToString();
                                                                psJun.TS = "1";
                                                                psJun.UD = "1";
                                                                psJun.SKUAsk = curSKUAsk;
                                                                psJun.POAsk = curPOAsk;
                                                                psJun.Status = "0";
                                                                psJun.DisplaySequence = "0";
                                                                psJun.Remark = "";
                                                                psJun.BookingAsk = curBookingAsk;
                                                                psJun.TruckAsk = curTruckAsk;

                                                                Boolean isSKUJunDelete = mMasterBLL.deleteObj("WMS_PO_SKU_JUN", psJun, 5);
                                                                Boolean isSKUJunSave = mMasterBLL.saveObj("WMS_PO_SKU_JUN", psJun);
                                                                #endregion

                                                            }

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            #endregion

            #region"selectList"
            List<PREFWarehouseJson> returnlist = new List<PREFWarehouseJson>();
            PRFEWarehouseCri selectCri = new PRFEWarehouseCri();
            selectCri.UserID = bookingData.UserID;
            selectCri.Password = bookingData.Password;
            selectCri.ProductAsk = bookingData.ProductAsk;
            selectCri.Ask = curBookingAsk;

            returnlist = getPRFEWarehouse(selectCri);

            #endregion
            return returnlist;
        }
        #endregion

        #region "getPRFEWarehouse"
        public List<PREFWarehouseJson> getPRFEWarehouse(PRFEWarehouseCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);

            dic.Add("@BookingAsk", criteria.Ask);
            dic.Add("@BookingID", criteria.BookingID);
            dic.Add("@AgentAsk", criteria.AgentAsk);
            dic.Add("@Shipper", criteria.Shipper);
            dic.Add("@CountryAsk", criteria.CountryAsk);
            dic.Add("@CargoReceivedDate", criteria.CargoReceivedDate);
            dic.Add("@CustomIssuedDate", criteria.CustomIssuedDate);
            dic.Add("@TransactionDate", criteria.TransactionDate);
            dic.Add("@Signature", criteria.Signature);
            dic.Add("@SignatureDate", criteria.SignatureDateSignature);
            dic.Add("@BookingStatusAsk", criteria.BookingStatusAsk);
            dic.Add("@NoOfTruck", criteria.NoOfTruck);
            dic.Add("@NoOfContainer", criteria.NoOfContainer);

            dic.Add("@ShipperAsk", criteria.ShipperAsk);
            dic.Add("@ShipperName", criteria.ShipperName);
            dic.Add("@ShipperDetails", criteria.ShipperDetails);

            dic.Add("@TruckAsk", criteria.TruckAsk);
            dic.Add("@TruckID", criteria.TruckID);
            dic.Add("@TruckTypeAsk", criteria.TruckTypeAsk);

            dic.Add("@POAsk", criteria.POAsk);
            dic.Add("@PONo", criteria.PONo);
            dic.Add("@ShippingMark", criteria.ShippingMark);
            dic.Add("@ReferenceNo", criteria.ReferenceNo);

            dic.Add("@SKUAsk", criteria.SKUAsk);
            dic.Add("@SKUName", criteria.SKUName);
            dic.Add("@SKUDetails", criteria.SKUDetails);
            dic.Add("@DimensionWidth", criteria.DimensionWidth);
            dic.Add("@DimensionHeight", criteria.DimensionHeight);
            dic.Add("@DimensionBase", criteria.DimensionBase);
            dic.Add("@SKUWeight", criteria.SKUWeight);
            dic.Add("@PlanQty", criteria.PlanQty);
            dic.Add("@UOMAsk", criteria.UOMAsk);
            dic.Add("@ReceivedQty", criteria.ReceivedQty);
            dic.Add("@Reference", criteria.ReferenceNo);
            dic.Add("@TruckType", criteria.TruckType);
            dic.Add("@GoodQty", criteria.GoodQty);
            dic.Add("@DamageQty", criteria.DamageQty);
            dic.Add("@ShortLandQty", criteria.ShortLandQty);
            dic.Add("@OverlandQty", criteria.OverlandQty);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_PRFEWarehouseList", dic);
            List<PREFWarehouseJson> list = new List<PREFWarehouseJson>();

            #region "bind data"
            string bookingAsk = "0";
            string shipperAsk = "0";
            string truckAsk = "0";
            string poAsk = "0";
            string skuAsk = "0";

            PREFWarehouseJson obj = new PREFWarehouseJson();

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    int ind = dt.Rows.IndexOf(dr);

                    #region"BookingList"
                    if (!bookingAsk.Equals(dr[0].ToString()))
                    {
                        BookingJson bkjson = new BookingJson();
                        bkjson.Ask = dr[0].ToString();
                        bkjson.BookingID = dr[1].ToString();
                        bkjson.AgentAsk = dr[2].ToString();
                        bkjson.Shipper = dr[3].ToString();
                        bkjson.CountryAsk = dr[4].ToString();
                        bkjson.CargoReceivedDate = dr[5].ToString();
                        bkjson.CustomIssuedDate = dr[6].ToString();
                        bkjson.TransactionDate = dr[7].ToString();
                        bkjson.Signature = dr[8].ToString();
                        bkjson.SignatureDate = dr[9].ToString();
                        bkjson.NoOfTruck = dr[10].ToString();
                        bkjson.NoOfContainer = dr[11].ToString();

                        obj.BookingList.Add(bkjson);
                        bookingAsk = dr[0].ToString();
                    }
                    #endregion

                    #region"ShipperList"
                    if (!shipperAsk.Equals(dr[35].ToString()))
                    {
                        ShipperJson shipperjson = new ShipperJson();

                        shipperjson.BookingAsk = dr[0].ToString();

                        shipperjson.ShipperAsk = dr[35].ToString();
                        shipperjson.ShipperName = dr[36].ToString();
                        shipperjson.ShipperDetails = dr[37].ToString();

                        obj.ShipperList.Add(shipperjson);
                        shipperAsk = dr[35].ToString();
                    }
                    #endregion

                    #region"TruckList"
                    if (!truckAsk.Equals(dr[12].ToString()))
                    {
                        TruckJson truckjson = new TruckJson();

                        truckjson.BookingAsk = dr[0].ToString();
                        truckjson.ShipperAsk = dr[35].ToString();


                        truckjson.TruckAsk = dr[12].ToString();
                        truckjson.TruckID = dr[13].ToString();
                        truckjson.TruckTypeAsk = dr[14].ToString();

                        obj.TruckList.Add(truckjson);
                        truckAsk = dr[12].ToString();
                    }
                    #endregion

                    #region"POList"
                    if (!poAsk.Equals(dr[15].ToString()))
                    {
                        POJson pojson = new POJson();

                        pojson.BookingAsk = dr[0].ToString();
                        pojson.ShipperAsk = dr[35].ToString();
                        pojson.TruckAsk = dr[12].ToString();

                        pojson.POAsk = dr[15].ToString();
                        pojson.PONo = dr[16].ToString();
                        pojson.POShippingMark = dr[17].ToString();
                        pojson.POReferenceNo = dr[18].ToString();

                        obj.POList.Add(pojson);
                        poAsk = dr[15].ToString();
                    }
                    #endregion

                    #region"SKUList"
                    if (!skuAsk.Equals(dr[19].ToString()))
                    {
                        SKUJson skujson = new SKUJson();

                        skujson.BookingAsk = dr[0].ToString();
                        skujson.ShipperAsk = dr[35].ToString();
                        skujson.TruckAsk = dr[12].ToString();
                        skujson.POAsk = dr[15].ToString();

                        skujson.SKUAsk = dr[19].ToString();
                        skujson.SKUName = dr[20].ToString();
                        skujson.SKUDetails = dr[21].ToString();
                        skujson.SKUDimensionWidth = dr[22].ToString();
                        skujson.SKUDimensionHeight = dr[23].ToString();
                        skujson.SKUDimensionBase = dr[24].ToString();
                        skujson.SKUWeight = dr[25].ToString();
                        skujson.SKUPlanQty = dr[26].ToString();
                        skujson.SKUUOMAsk = dr[27].ToString();
                        skujson.SKUReceivedQty = dr[28].ToString();
                        skujson.SKUReference = dr[29].ToString();
                        skujson.SKUTruckType = dr[30].ToString();
                        skujson.SKUGoodQty = dr[31].ToString();
                        skujson.SKUDamageQty = dr[32].ToString();
                        skujson.SKUShortLandQty = dr[33].ToString();
                        skujson.SKUOverlandQty = dr[34].ToString();

                        obj.SKUList.Add(skujson);
                        skuAsk = dr[19].ToString();
                    }
                    #endregion
                }
                catch
                {
                    continue;
                }
            }
            list.Add(obj);

            #endregion

            return list;
        }
        #endregion

        #region "getPRFEWarehouseList"
        public List<PREFWarehouseListJson> getPRFEWarehouseList(PRFEWarehouseCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);

            dic.Add("@BookingAsk", criteria.Ask);
            dic.Add("@BookingID", criteria.BookingID);
            dic.Add("@AgentAsk", criteria.AgentAsk);
            dic.Add("@Shipper", criteria.Shipper);
            dic.Add("@CountryAsk", criteria.CountryAsk);
            dic.Add("@CargoReceivedDate", criteria.CargoReceivedDate);
            dic.Add("@CustomIssuedDate", criteria.CustomIssuedDate);
            dic.Add("@TransactionDate", criteria.TransactionDate);
            dic.Add("@Signature", criteria.Signature);
            dic.Add("@SignatureDate", criteria.SignatureDateSignature);
            dic.Add("@BookingStatusAsk", criteria.BookingStatusAsk);
            dic.Add("@NoOfTruck", criteria.NoOfTruck);
            dic.Add("@NoOfContainer", criteria.NoOfContainer);

            dic.Add("@ShipperAsk", criteria.ShipperAsk);
            dic.Add("@ShipperName", criteria.ShipperName);
            dic.Add("@ShipperDetails", criteria.ShipperDetails);

            dic.Add("@TruckAsk", criteria.TruckAsk);
            dic.Add("@TruckID", criteria.TruckID);
            dic.Add("@TruckTypeAsk", criteria.TruckTypeAsk);

            dic.Add("@POAsk", criteria.POAsk);
            dic.Add("@PONo", criteria.PONo);
            dic.Add("@ShippingMark", criteria.ShippingMark);
            dic.Add("@ReferenceNo", criteria.ReferenceNo);

            dic.Add("@SKUAsk", criteria.SKUAsk);
            dic.Add("@SKUName", criteria.SKUName);
            dic.Add("@SKUDetails", criteria.SKUDetails);
            dic.Add("@DimensionWidth", criteria.DimensionWidth);
            dic.Add("@DimensionHeight", criteria.DimensionHeight);
            dic.Add("@DimensionBase", criteria.DimensionBase);
            dic.Add("@SKUWeight", criteria.SKUWeight);
            dic.Add("@PlanQty", criteria.PlanQty);
            dic.Add("@UOMAsk", criteria.UOMAsk);
            dic.Add("@ReceivedQty", criteria.ReceivedQty);
            dic.Add("@Reference", criteria.ReferenceNo);
            dic.Add("@TruckType", criteria.TruckType);
            dic.Add("@GoodQty", criteria.GoodQty);
            dic.Add("@DamageQty", criteria.DamageQty);
            dic.Add("@ShortLandQty", criteria.ShortLandQty);
            dic.Add("@OverlandQty", criteria.OverlandQty);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_PRFEWarehouseList", dic);
            List<PREFWarehouseListJson> list = new List<PREFWarehouseListJson>();

            #region "bind data"
            String bookingAsk = "0";
           
                PREFWarehouseListJson obj = new PREFWarehouseListJson();

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    int ind = dt.Rows.IndexOf(dr);

                    if (!bookingAsk.Equals(dr[0].ToString()))
                    {
                        BookingJson bkjson = new BookingJson();
                        bkjson.Ask = dr[0].ToString();
                        bkjson.BookingID = dr[1].ToString();
                        bkjson.AgentAsk = dr[2].ToString();
                        bkjson.Shipper = dr[3].ToString();
                        bkjson.CountryAsk = dr[4].ToString();
                        bkjson.CargoReceivedDate = dr[5].ToString();
                        bkjson.CustomIssuedDate = dr[6].ToString();
                        bkjson.TransactionDate = dr[7].ToString();
                        bkjson.Signature = dr[8].ToString();
                        bkjson.SignatureDate = dr[9].ToString();
                        bkjson.NoOfTruck = dr[10].ToString();
                        bkjson.NoOfContainer = dr[11].ToString();

                        obj.BookingList.Add(bkjson);
                        bookingAsk = dr[0].ToString();
                    }

                    PREFWarehouseDetailJson prefjson = new PREFWarehouseDetailJson();
                    prefjson.BookingAsk = dr[0].ToString();
                    prefjson.BookingID = dr[1].ToString();
                    prefjson.AgentAsk = dr[2].ToString();
                    prefjson.Shipper = dr[3].ToString();
                    prefjson.CountryAsk = dr[4].ToString();
                    prefjson.CargoReceivedDate = dr[5].ToString();
                    prefjson.CustomIssuedDate = dr[6].ToString();
                    prefjson.TransactionDate = dr[7].ToString();
                    prefjson.Signature = dr[8].ToString();
                    prefjson.SignatureDate = dr[9].ToString();
                    prefjson.NoOfTruck = dr[10].ToString();
                    prefjson.NoOfContainer = dr[11].ToString();

                    prefjson.TruckAsk = dr[12].ToString();
                    prefjson.TruckID = dr[13].ToString();
                    prefjson.TruckTypeAsk = dr[14].ToString();

                    prefjson.POAsk = dr[15].ToString();
                    prefjson.PONo = dr[16].ToString();
                    prefjson.POShippingMark = dr[17].ToString();
                    prefjson.POReferenceNo = dr[18].ToString();

                    prefjson.SKUAsk = dr[19].ToString();
                    prefjson.SKUName = dr[20].ToString();
                    prefjson.SKUDetails = dr[21].ToString();
                    prefjson.SKUDimensionWidth = dr[22].ToString();
                    prefjson.SKUDimensionHeight = dr[23].ToString();
                    prefjson.SKUDimensionBase = dr[24].ToString();
                    prefjson.SKUWeight = dr[25].ToString();
                    prefjson.SKUPlanQty = dr[26].ToString();
                    prefjson.SKUUOMAsk = dr[27].ToString();
                    prefjson.SKUReceivedQty = dr[28].ToString();
                    prefjson.SKUReference = dr[29].ToString();
                    prefjson.SKUTruckType = dr[30].ToString();
                    prefjson.SKUGoodQty = dr[31].ToString();
                    prefjson.SKUDamageQty = dr[32].ToString();
                    prefjson.SKUShortLandQty = dr[33].ToString();
                    prefjson.SKUOverlandQty = dr[34].ToString();

                    prefjson.ShipperAsk = dr[35].ToString();
                    prefjson.ShipperName = dr[36].ToString();
                    prefjson.ShipperDetails = dr[37].ToString();

                    obj.DetailList.Add(prefjson);

                }
                catch
                {
                    continue;
                }
            }

                list.Add(obj);
            
            #endregion

            return list;
        }
        #endregion

        #region "getAgentList"
        public List<AgentJson> getAgentList(AuthorizationCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_Agent", dic);
            List<AgentJson> list = new List<AgentJson>();
            #region "bind data"

            foreach (DataRow dr in dt.Rows)
            {
                AgentJson obj = new AgentJson();
                            
                    try
                    {
                    
                    obj.Ask = dr[0].ToString(); 
                    obj.TS = dr[1].ToString();
                    obj.UD = dr[2].ToString();
                    obj.AgentName = dr[3].ToString();
                    obj.AgentDetails = dr[4].ToString();
                    obj.NationalID = dr[5].ToString();
                    obj.BillingAddress = dr[6].ToString();
                    obj.ShippinggAddress = dr[7].ToString();
                    obj.CompanyName = dr[8].ToString();
                    obj.Website = dr[9].ToString();
                    obj.Mobile = dr[10].ToString();
                    obj.Email = dr[11].ToString();
                    obj.ContactPersonName = dr[12].ToString();
                    obj.ContactPersonMobile = dr[13].ToString();
                    obj.Address = dr[14].ToString();
                    obj.DisplaySequence = dr[15].ToString();
                    obj.Remark = dr[16].ToString();
                    }
                    catch
                    {
                        continue;
                    }
                
                list.Add(obj);
            }
            #endregion
            return list;
        }
        #endregion

        #region "getCountryList"
        public List<CountryJson> getCountryList(AuthorizationCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_Country", dic);
            List<CountryJson> list = new List<CountryJson>();
            #region "bind data"

            foreach (DataRow dr in dt.Rows)
            {
                CountryJson obj = new CountryJson();

                try
                {

                    obj.Ask = dr[0].ToString();
                    obj.TS = dr[1].ToString();
                    obj.UD = dr[2].ToString();
                    obj.CountryName = dr[3].ToString();
                    obj.CountryDetails= dr[4].ToString();
                    obj.Status = dr[5].ToString();
                    obj.DisplaySequence = dr[6].ToString();
                    obj.Remark = dr[7].ToString();
                }
                catch
                {
                    continue;
                }

                list.Add(obj);
            }
            #endregion
            return list;
        }
        #endregion

    }

}
