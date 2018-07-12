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

            try
            {
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
            }
            catch (Exception ex)
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
            l_MenuGroup.MenuGroupDesc = menuGroupData.MenuGpDesc;
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

                for (int i = 0; i < menuGroupData.MenuList.Count; i++)
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

                if (isSuccess)
                {
                    msgObj.Code = "1";
                    msgObj.Detail = "Login Test is successful.";
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

            string curAgentAsk = "0";
            string curBookingAsk = "0";
            string curShipperAsk = "0";
            string curTruckAsk = "0";
            string curPOAsk = "0";
            string curSKUAsk = "0";
            Boolean isAllSave = true;
            Boolean isHSave = false;

            #region "Bind Object"
            #region"saveAgent"
            Agent l_Agent = new Agent();
            if (bookingData.AgentAsk == "0")
                l_Agent.Ask = mUtility.getStrAsk().ToString();
            else
                l_Agent.Ask = bookingData.AgentAsk;

            l_Agent.TS = "1";
            l_Agent.UD = "1";
            l_Agent.AgentName = bookingData.AgentName;
            l_Agent.AgentDetails = bookingData.AgentDetails;
            l_Agent.NationalID = bookingData.AgentNationalID;
            l_Agent.BillingAddress = bookingData.AgentBillingAddress;
            l_Agent.ShippinggAddress = bookingData.AgentShippingAddress;
            l_Agent.CompanyName = bookingData.AgentCompanyName;
            l_Agent.Website = bookingData.AgentWebsite;
            l_Agent.Mobile = bookingData.AgentMobile;
            l_Agent.Email = bookingData.AgentEmail;
            l_Agent.ContactPersonName = bookingData.AgentContactPersonName;
            l_Agent.ContactPersonMobile = bookingData.AgentContactPersonMobile;
            l_Agent.Address = bookingData.AgentAddress;
            l_Agent.DisplaySequence = bookingData.AgentDisplaySequence;
            l_Agent.Remark = bookingData.AgentRemark;

            //currentBookingAsk 
            curAgentAsk = l_Agent.Ask;
            //Save Header Table (WMS_BOOKING Table)

          
            if (bookingData.AgentAsk == "0")
                isHSave = mMasterBLL.saveObj("WMS_AGENT", l_Agent);
            else
                isHSave = mMasterBLL.updateObj("WMS_AGENT", l_Agent);

            #endregion
            Booking l_Booking = new Booking();
            if (bookingData.Ask == "0")
                l_Booking.Ask = mUtility.getStrAsk().ToString();
            else
                l_Booking.Ask = bookingData.Ask;

            l_Booking.TS = "1";
            l_Booking.UD = "1";
            l_Booking.BookingID = bookingData.BookingID;
            l_Booking.AgentAsk = curAgentAsk;
            l_Booking.Shipper = bookingData.Shipper;
            l_Booking.CountryAsk = bookingData.CountryAsk;
            l_Booking.CargoReceivedDate = bookingData.CargoReceivedDate;
            l_Booking.CustomIssuedDate = bookingData.CustomIssuedDate;
            l_Booking.TransactionDate = bookingData.TransactionDate;
            l_Booking.Signature = bookingData.Signature;
            l_Booking.SignatureDate = bookingData.SignatureDate;
            l_Booking.BookingStatusAsk = bookingData.BookingStatusAsk;
            l_Booking.NoOfTruck = bookingData.NoOfTruck;
            l_Booking.NoOfContainer = bookingData.NoOfContainer;
            l_Booking.DisplaySequence = bookingData.DisplaySequence;
            l_Booking.Remark = bookingData.Remark;
            l_Booking.LogisticTypeAsk = bookingData.LogisticTypeAsk;

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

                        l_shipper.TS = l_shipperList[a].TS;
                        l_shipper.UD = l_shipperList[a].UD;
                        l_shipper.ShipperName = l_shipperList[a].ShipperName;
                        l_shipper.ShipperDetails = l_shipperList[a].ShipperDetails;
                        l_shipper.Status = l_shipperList[a].Status;
                        l_shipper.DisplaySequence = l_shipperList[a].DisplaySequence;
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

                                    l_truck.TS = l_truckList[i].TS;
                                    l_truck.UD = l_truckList[i].UD;
                                    l_truck.TruckID = l_truckList[i].TruckID;
                                    l_truck.TruckTypeAsk = l_truckList[i].TruckTypeAsk;
                                    l_truck.Status = l_truckList[i].Status;
                                    l_truck.DisplaySequence = l_truckList[i].DisplaySequence;
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

                                                l_po.TS = l_poList[j].TS;
                                                l_po.UD = l_poList[j].UD;
                                                l_po.PONo = l_poList[j].PONo;
                                                l_po.ShippingMark = l_poList[j].ShippingMark;
                                                l_po.ReferenceNo = l_poList[j].ReferenceNo;
                                                l_po.Status = l_poList[j].Status;
                                                l_po.DisplaySequence = l_poList[j].DisplaySequence;
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

                                                            l_sku.TS = l_skuList[k].TS;
                                                            l_sku.UD = l_skuList[k].UD;
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
                                                            l_sku.DisplaySequence = l_skuList[k].DisplaySequence;
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
            selectCri.AgentAsk = curAgentAsk;
            
            

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
            dic.Add("@SignatureDate", criteria.SignatureDate);
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
            dic.Add("@ShippingMark", criteria.POShippingMark);
            dic.Add("@ReferenceNo", criteria.POReferenceNo);

            dic.Add("@SKUAsk", criteria.SKUAsk);
            dic.Add("@SKUName", criteria.SKUName);
            dic.Add("@SKUDetails", criteria.SKUDetails);
            dic.Add("@DimensionWidth", criteria.SKUDimensionWidth);
            dic.Add("@DimensionHeight", criteria.SKUDimensionHeight);
            dic.Add("@DimensionBase", criteria.SKUDimensionBase);
            dic.Add("@SKUWeight", criteria.SKUWeight);
            dic.Add("@PlanQty", criteria.SKUPlanQty);
            dic.Add("@UOMAsk", criteria.SKUUOMAsk);
            dic.Add("@ReceivedQty", criteria.SKUReceivedQty);
            dic.Add("@Reference", criteria.SKUReference);
            dic.Add("@TruckType", criteria.SKUTruckType);
            dic.Add("@GoodQty", criteria.SKUGoodQty);
            dic.Add("@DamageQty", criteria.SKUDamageQty);
            dic.Add("@ShortLandQty", criteria.SKUShortLandQty);
            dic.Add("@OverlandQty", criteria.SKUOverlandQty);

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
                    if ((!bookingAsk.Equals(dr[0].ToString())) && (!dr[0].ToString().Equals("")))
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
                        bkjson.TS = dr[38].ToString();
                        bkjson.UD = dr[39].ToString();
                        bkjson.DisplaySequence= dr[40].ToString();
                        bkjson.Remark= dr[41].ToString();

                        obj.BookingList.Add(bkjson);
                        bookingAsk = dr[0].ToString();
                    }
                    #endregion

                    #region"ShipperList"
                    if ((!shipperAsk.Equals(dr[35].ToString()))  && (!dr[35].ToString().Equals("")))
                    {
                        ShipperJson shipperjson = new ShipperJson();

                        shipperjson.BookingAsk = dr[0].ToString();

                        shipperjson.ShipperAsk = dr[35].ToString();
                        shipperjson.ShipperName = dr[36].ToString();
                        shipperjson.ShipperDetails = dr[37].ToString();

                        shipperjson.ShipperTS = dr[57].ToString();
                        shipperjson.ShipperUD = dr[58].ToString();
                        shipperjson.ShipperStatus = dr[59].ToString();
                        shipperjson.ShipperDisplaySequence = dr[60].ToString();
                        shipperjson.ShipperRemark = dr[61].ToString();

                        obj.ShipperList.Add(shipperjson);
                        shipperAsk = dr[35].ToString();
                    }
                    #endregion

                    #region"TruckList"
                    if ((!truckAsk.Equals(dr[12].ToString())) && (!dr[12].ToString().Equals("")))
                    {
                        TruckJson truckjson = new TruckJson();

                        truckjson.BookingAsk = dr[0].ToString();
                        truckjson.ShipperAsk = dr[35].ToString();


                        truckjson.TruckAsk = dr[12].ToString();
                        truckjson.TruckID = dr[13].ToString();
                        truckjson.TruckTypeAsk = dr[14].ToString();

                        truckjson.TruckTS = dr[42].ToString();
                        truckjson.TruckUD= dr[43].ToString();
                        truckjson.TruckStatus= dr[44].ToString();
                        truckjson.TruckDisplaySequence= dr[45].ToString();
                        truckjson.TruckRemark= dr[46].ToString();

                        obj.TruckList.Add(truckjson);
                        truckAsk = dr[12].ToString();
                    }
                    #endregion

                    #region"POList"
                    if ((!poAsk.Equals(dr[15].ToString())) && (!dr[15].ToString().Equals("")))
                    {
                        POJson pojson = new POJson();

                        pojson.BookingAsk = dr[0].ToString();
                        pojson.ShipperAsk = dr[35].ToString();
                        pojson.TruckAsk = dr[12].ToString();

                        pojson.POAsk = dr[15].ToString();
                        pojson.PONo = dr[16].ToString();
                        pojson.POShippingMark = dr[17].ToString();
                        pojson.POReferenceNo = dr[18].ToString();

                        pojson.POTS= dr[47].ToString();
                        pojson.POUD= dr[48].ToString();
                        pojson.POStatus= dr[49].ToString();
                        pojson.PODisplaySequence= dr[50].ToString();
                        pojson.PORemark= dr[51].ToString();

                        obj.POList.Add(pojson);
                        poAsk = dr[15].ToString();
                    }
                    #endregion

                    #region"SKUList"
                    if ((!skuAsk.Equals(dr[19].ToString())) && (!dr[19].ToString().Equals("")))
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

                        skujson.SKUTS = dr[52].ToString();
                        skujson.SKUUD = dr[53].ToString();
                        skujson.SKUStatus = dr[54].ToString();
                        skujson.SKUDisplaySequence = dr[55].ToString();
                        skujson.SKURemark = dr[56].ToString();


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
            dic.Add("@SignatureDate", criteria.SignatureDate);
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
            dic.Add("@ShippingMark", criteria.POShippingMark);
            dic.Add("@ReferenceNo", criteria.POReferenceNo);

            dic.Add("@SKUAsk", criteria.SKUAsk);
            dic.Add("@SKUName", criteria.SKUName);
            dic.Add("@SKUDetails", criteria.SKUDetails);
            dic.Add("@DimensionWidth", criteria.SKUDimensionWidth);
            dic.Add("@DimensionHeight", criteria.SKUDimensionHeight);
            dic.Add("@DimensionBase", criteria.SKUDimensionBase);
            dic.Add("@SKUWeight", criteria.SKUWeight);
            dic.Add("@PlanQty", criteria.SKUPlanQty);
            dic.Add("@UOMAsk", criteria.SKUUOMAsk);
            dic.Add("@ReceivedQty", criteria.SKUReceivedQty);
            dic.Add("@Reference", criteria.SKUReference);
            dic.Add("@TruckType", criteria.SKUTruckType);
            dic.Add("@GoodQty", criteria.SKUGoodQty);
            dic.Add("@DamageQty", criteria.SKUDamageQty);
            dic.Add("@ShortLandQty", criteria.SKUShortLandQty);
            dic.Add("@OverlandQty", criteria.SKUOverlandQty);

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

                    if ((!bookingAsk.Equals(dr[0].ToString())) && (!dr[0].ToString().Equals("")))
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

                        bkjson.TS = dr[38].ToString();
                        bkjson.UD = dr[39].ToString();
                        bkjson.DisplaySequence = dr[40].ToString();
                        bkjson.Remark = dr[41].ToString();

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
                    prefjson.TruckTS = dr[42].ToString();
                    prefjson.TruckUD = dr[43].ToString();
                    prefjson.TruckStatus = dr[44].ToString();
                    prefjson.TruckDisplaySequence = dr[45].ToString();
                    prefjson.TruckRemark = dr[46].ToString();

                    prefjson.POAsk = dr[15].ToString();
                    prefjson.PONo = dr[16].ToString();
                    prefjson.POShippingMark = dr[17].ToString();
                    prefjson.POReferenceNo = dr[18].ToString();
                    prefjson.POTS = dr[47].ToString();
                    prefjson.POUD = dr[48].ToString();
                    prefjson.POStatus = dr[49].ToString();
                    prefjson.PODisplaySequence = dr[50].ToString();
                    prefjson.PORemark = dr[51].ToString();

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
                    prefjson.SKUTS = dr[52].ToString();
                    prefjson.SKUUD = dr[53].ToString();
                    prefjson.SKUStatus = dr[54].ToString();
                    prefjson.SKUDisplaySequence = dr[55].ToString();
                    prefjson.SKURemark = dr[56].ToString();

                    prefjson.ShipperAsk = dr[35].ToString();
                    prefjson.ShipperName = dr[36].ToString();
                    prefjson.ShipperDetails = dr[37].ToString();
                    prefjson.ShipperTS = dr[57].ToString();
                    prefjson.ShipperUD = dr[58].ToString();
                    prefjson.ShipperStatus = dr[59].ToString();
                    prefjson.ShipperDisplaySequence = dr[60].ToString();
                    prefjson.ShipperRemark = dr[61].ToString();


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
                    obj.CountryDetails = dr[4].ToString();
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

        #region "getUOMList"
        public List<UOMJson> getUOMList(AuthorizationCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_UOM", dic);
            List<UOMJson> list = new List<UOMJson>();
            #region "bind data"

            foreach (DataRow dr in dt.Rows)
            {
                UOMJson obj = new UOMJson();

                try
                {

                    obj.Ask = dr[0].ToString();
                    obj.TS = dr[1].ToString();
                    obj.UD = dr[2].ToString();
                    obj.Name = dr[3].ToString();
                    obj.Details = dr[4].ToString();
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

        #region "getTruckTypeList"
        public List<TruckTypeJson> getTruckTypeList(AuthorizationCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_Truck_Type", dic);
            List<TruckTypeJson> list = new List<TruckTypeJson>();
            #region "bind data"

            foreach (DataRow dr in dt.Rows)
            {
                TruckTypeJson obj = new TruckTypeJson();

                try
                {

                    obj.Ask = dr[0].ToString();
                    obj.TS = dr[1].ToString();
                    obj.UD = dr[2].ToString();
                    obj.Code = dr[3].ToString();
                    obj.Description = dr[4].ToString();
                    obj.TotalGrossW = dr[5].ToString();
                    obj.TareWeight = dr[6].ToString();
                    obj.StockWeight = dr[7].ToString();
                    obj.TotalWeight = dr[8].ToString();
                    obj.TotalVol = dr[9].ToString();
                    obj.Status = dr[10].ToString();
                    obj.DisplaySequence = dr[11].ToString();
                    obj.Remark = dr[12].ToString();
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

        #region "saveTallyWarehouse"
        public List<TallyJson> saveTallyWarehouse(TallyCri criteria)
        {
            Message message = new Message();
            Tally l_Tally = new Tally();
            List<TallyJson> list = new List<TallyJson>();
            Boolean isAllSave = true;
            string curTallyAsk = "0";

            #region "Bind Object"
            if (criteria.Ask == "0")
                l_Tally.Ask = mUtility.getStrAsk().ToString();
            else
                l_Tally.Ask = criteria.Ask;

            l_Tally.TS = criteria.TS;
            l_Tally.UD = criteria.UD;
            l_Tally.ShippingMark = criteria.ShippingMark;
            l_Tally.DocNo = criteria.DocNo;
            l_Tally.TruckID = criteria.TruckID;
            l_Tally.TruckTypeAsk = criteria.TruckTypeAsk;
            l_Tally.SKUID = criteria.SKUID;
            l_Tally.SKUDetials = criteria.SKUDetails;
            l_Tally.DimensionWeight = criteria.DimensionWeight;
            l_Tally.DimensionHeight = criteria.DimensionHeight;
            l_Tally.DimensionBase = criteria.DimensionBase;
            l_Tally.ReceivedQty = criteria.ReceivedQty;
            l_Tally.UOMAsk = criteria.UOMAsk;
            l_Tally.TallyCheckDate = criteria.TallyCheckDate;
            l_Tally.TallyReceiveDate = criteria.TallyReceiveDate;
            l_Tally.TransactionDate = criteria.TransactionDate;
            l_Tally.Signature = criteria.Signature;
            l_Tally.SignatureDate = criteria.SignatureDate;
            l_Tally.BookingAsk = criteria.BookingAsk;
            l_Tally.Status = criteria.Status;
            l_Tally.DisplaySequence = criteria.DisplaySequence;
            l_Tally.Remark = criteria.Remark;
            l_Tally.AgentAsk = criteria.AgentAsk;
            l_Tally.ShipperAsk = criteria.ShipperAsk;


            Boolean isSave = false;
            curTallyAsk = l_Tally.Ask;
            if (criteria.Ask == "0")
                isSave = mMasterBLL.saveObj("WMS_TALLY", l_Tally);
            else
                isSave = mMasterBLL.updateObj("WMS_TALLY", l_Tally);


            #endregion

            #region "listArea"
            TallyWarehouseCri selectcriteria = new TallyWarehouseCri();
            selectcriteria.UserID = criteria.UserID;
            selectcriteria.Password = criteria.Password;
            selectcriteria.ProductAsk = criteria.ProductAsk;
            selectcriteria.Ask = curTallyAsk;

            list = getTallyWarehouse(selectcriteria);

            #endregion

            return list;
        }
        #endregion

        #region "getTallyWarehouse"
        public List<TallyJson> getTallyWarehouse(TallyWarehouseCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);

            dic.Add("@Ask", criteria.Ask);
            dic.Add("@ShippingMark", criteria.ShippingMark);
            dic.Add("@DocNo", criteria.DocNo);
            dic.Add("@TruckID", criteria.TruckID);
            dic.Add("@TruckTypeAsk", criteria.TruckTypeAsk);
            dic.Add("@SKUID", criteria.SKUID);
            dic.Add("@SKUDetails", criteria.SKUDetails);
            dic.Add("@DimensionWidth", criteria.DimensionWeight);
            dic.Add("@DimensionHeight", criteria.DimensionHeight);
            dic.Add("@DimensionBase", criteria.DimensionBase);
            dic.Add("@ReceivedQty", criteria.ReceivedQty);
            dic.Add("@UOMAsk", criteria.UOMAsk);
            dic.Add("@TallyCheckDate", criteria.TallyCheckDate);
            dic.Add("@TallyReceiveDate", criteria.TallyReceiveDate);
            dic.Add("@TransactionDate", criteria.TransactionDate);
            dic.Add("@Signature", criteria.Signature);
            dic.Add("@SignatureDate", criteria.SignatureDate);

            dic.Add("@BookingAsk", criteria.BookingAsk);
            dic.Add("@BookingID", criteria.BookingID);
            dic.Add("@Shipper", criteria.Shipper);
            dic.Add("@CountryAsk", criteria.CountryAsk);
            dic.Add("@CargoReceivedDate", criteria.CargoReceivedDate);
            dic.Add("@CustomIssuedDate", criteria.CustomIssuedDate);
            dic.Add("@BookingStatusAsk", criteria.BookingStatusAsk);
            dic.Add("@NoOfTruck", criteria.NoOfTruck);
            dic.Add("@NoOfContainer", criteria.NoOfContainer);

            dic.Add("@AgentAsk", criteria.AgentAsk);
            dic.Add("@AgentName", criteria.AgentName);
            dic.Add("@AgentDetails", criteria.AgentDetails);
            dic.Add("@NationalID", criteria.NationalID);
            dic.Add("@BillingAddress", criteria.BillingAddress);
            dic.Add("@ShippingAddress", criteria.ShippingAddress);
            dic.Add("@CompanyName", criteria.CompanyName);
            dic.Add("@Website", criteria.Website);
            dic.Add("@Mobile", criteria.Mobile);
            dic.Add("@Email", criteria.Email);
            dic.Add("@ContactPersonName", criteria.ContactPersonName);
            dic.Add("@ContactPersonMobile", criteria.ContactPersonMobile);
            dic.Add("@Address", criteria.Address);

            dic.Add("@ShipperAsk", criteria.ShipperAsk);
            dic.Add("@ShipperName", criteria.ShipperName);
            dic.Add("@ShipperDetails", criteria.ShipperDetails);


            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_TallyWarehouseList", dic);

            #region "bind data"

            List<TallyJson> list = new List<TallyJson>();

            string bookingAsk = "0";

            TallyJson obj = new TallyJson();

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    int ind = dt.Rows.IndexOf(dr);

                    obj.Ask = dr[0].ToString();
                    obj.ShippingMark = dr[1].ToString();
                    obj.DocNo = dr[2].ToString();
                    obj.TruckID = dr[3].ToString();
                    obj.TruckTypeAsk = dr[4].ToString();
                    obj.SKUID = dr[5].ToString();
                    obj.SKUDetails = dr[6].ToString();
                    obj.DimensionWidth = dr[7].ToString();
                    obj.DimensionHeight = dr[8].ToString();
                    obj.DimensionBase = dr[9].ToString();
                    obj.ReceivedQty = dr[10].ToString();
                    obj.UOMAsk = dr[11].ToString();
                    obj.TallyCheckDate = dr[12].ToString();
                    obj.TallyReceiveDate = dr[13].ToString();
                    obj.TransactionDate = dr[14].ToString();
                    obj.Signature = dr[15].ToString();
                    obj.SignatureDate = dr[16].ToString();
                    obj.BookingAsk = dr[17].ToString();
                    obj.AgentAsk = dr[18].ToString();
                    obj.ShipperAsk = dr[19].ToString();

                    obj.TS = dr[49].ToString();
                    obj.UD = dr[50].ToString();
                    obj.Status = dr[51].ToString();
                    obj.DisplaySequence = dr[52].ToString();
                    obj.Remark = dr[53].ToString();

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

        #region "getTallyWarehouseList"
        public List<TallyWarehouseJson> getTallyWarehouseList(TallyWarehouseCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);

            dic.Add("@Ask", criteria.Ask);
            dic.Add("@ShippingMark", criteria.ShippingMark);
            dic.Add("@DocNo", criteria.DocNo);
            dic.Add("@TruckID", criteria.TruckID);
            dic.Add("@TruckTypeAsk", criteria.TruckTypeAsk);
            dic.Add("@SKUID", criteria.SKUID);
            dic.Add("@SKUDetails", criteria.SKUDetails);
            dic.Add("@DimensionWidth", criteria.DimensionWeight);
            dic.Add("@DimensionHeight", criteria.DimensionHeight);
            dic.Add("@DimensionBase", criteria.DimensionBase);
            dic.Add("@ReceivedQty", criteria.ReceivedQty);
            dic.Add("@UOMAsk", criteria.UOMAsk);
            dic.Add("@TallyCheckDate", criteria.TallyCheckDate);
            dic.Add("@TallyReceiveDate", criteria.TallyReceiveDate);
            dic.Add("@TransactionDate", criteria.TransactionDate);
            dic.Add("@Signature", criteria.Signature);
            dic.Add("@SignatureDate", criteria.SignatureDate);

            dic.Add("@BookingAsk", criteria.BookingAsk);
            dic.Add("@BookingID", criteria.BookingID);
            dic.Add("@Shipper", criteria.Shipper);
            dic.Add("@CountryAsk", criteria.CountryAsk);
            dic.Add("@CargoReceivedDate", criteria.CargoReceivedDate);
            dic.Add("@CustomIssuedDate", criteria.CustomIssuedDate);
            dic.Add("@BookingStatusAsk", criteria.BookingStatusAsk);
            dic.Add("@NoOfTruck", criteria.NoOfTruck);
            dic.Add("@NoOfContainer", criteria.NoOfContainer);

            dic.Add("@AgentAsk", criteria.AgentAsk);
            dic.Add("@AgentName", criteria.AgentName);
            dic.Add("@AgentDetails", criteria.AgentDetails);
            dic.Add("@NationalID", criteria.NationalID);
            dic.Add("@BillingAddress", criteria.BillingAddress);
            dic.Add("@ShippingAddress", criteria.ShippingAddress);
            dic.Add("@CompanyName", criteria.CompanyName);
            dic.Add("@Website", criteria.Website);
            dic.Add("@Mobile", criteria.Mobile);
            dic.Add("@Email", criteria.Email);
            dic.Add("@ContactPersonName", criteria.ContactPersonName);
            dic.Add("@ContactPersonMobile", criteria.ContactPersonMobile);
            dic.Add("@Address", criteria.Address);

            dic.Add("@ShipperAsk", criteria.ShipperAsk);
            dic.Add("@ShipperName", criteria.ShipperName);
            dic.Add("@ShipperDetails", criteria.ShipperDetails);


            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_TallyWarehouseList", dic);

            #region "bind data"

            List<TallyWarehouseJson> list = new List<TallyWarehouseJson>();

            string bookingAsk = "0";
                     
            TallyWarehouseJson obj = new TallyWarehouseJson();

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    int ind = dt.Rows.IndexOf(dr);

                    if ((!bookingAsk.Equals(dr[0].ToString())) && (!dr[0].ToString().Equals("")))
                    {
                        BookingJson bkjson = new BookingJson();
                        bkjson.Ask = dr[20].ToString();
                        bkjson.BookingID = dr[21].ToString();
                        bkjson.AgentAsk = dr[22].ToString();
                        bkjson.Shipper = dr[23].ToString();
                        bkjson.CountryAsk = dr[24].ToString();
                        bkjson.CargoReceivedDate = dr[25].ToString();
                        bkjson.CustomIssuedDate = dr[26].ToString();
                        bkjson.TransactionDate = dr[27].ToString();
                        bkjson.Signature = dr[28].ToString();
                        bkjson.SignatureDate = dr[29].ToString();
                        bkjson.BookingStatusAsk = dr[30].ToString();
                        bkjson.NoOfTruck = dr[31].ToString();
                        bkjson.NoOfContainer = dr[32].ToString();

                        obj.BookingList.Add(bkjson);
                        bookingAsk = dr[20].ToString();
                    }

                    TallyWarehouseDetailJson dtljson = new TallyWarehouseDetailJson();

                    dtljson.TallyAsk = dr[0].ToString();
                    dtljson.TallyShippingMark=dr[1].ToString();
                    dtljson.TallyDocNo = dr[2].ToString();
                    dtljson.TallyTruckID = dr[3].ToString();
                    dtljson.TallyTruckTypeAsk = dr[4].ToString();
                    dtljson.TallySKUID = dr[5].ToString();
                    dtljson.TallySKUDetails = dr[6].ToString();
                    dtljson.TallyDimensionWeight = dr[7].ToString();
                    dtljson.TallyDimensionHeight = dr[8].ToString();
                    dtljson.TallyDimensionBase = dr[9].ToString();
                    dtljson.TallyReceivedQty = dr[10].ToString();
                    dtljson.TallyUOMAsk = dr[11].ToString();
                    dtljson.TallyCheckDate = dr[12].ToString();
                    dtljson.TallyReceiveDate = dr[13].ToString();
                    dtljson.TallyTransactionDate = dr[14].ToString();
                    dtljson.TallySignature = dr[15].ToString();
                    dtljson.TallySignatureDate = dr[16].ToString();
                    dtljson.BookingAsk = dr[17].ToString();
                    dtljson.AgentAsk = dr[18].ToString();
                    dtljson.ShipperAsk = dr[19].ToString();

                    dtljson.AgentAsk = dr[33].ToString();
                    dtljson.AgentName = dr[34].ToString();
                    dtljson.AgentDetails = dr[35].ToString();
                    dtljson.AgentNationalID = dr[36].ToString();
                    dtljson.AgentBillingAddress = dr[37].ToString();
                    dtljson.AgentShippinggAddress = dr[38].ToString();
                    dtljson.AgentCompanyName = dr[39].ToString();
                    dtljson.AgentWebsite = dr[40].ToString();
                    dtljson.AgentMobile = dr[41].ToString();
                    dtljson.AgentEmail = dr[42].ToString();
                    dtljson.AgentContactPersonName = dr[43].ToString();
                    dtljson.AgentContactPersonMobile = dr[44].ToString();
                    dtljson.AgentAddress = dr[45].ToString();

                    dtljson.ShipperAsk = dr[46].ToString();
                    dtljson.ShipperName = dr[47].ToString();
                    dtljson.ShipperDetails = dr[48].ToString();

                    obj.DetailList.Add(dtljson);

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

        #region "saveCheckerWarehouse"
        public List<SKUJson> saveCheckerWarehouse(CheckerWarehouseCri criteria)
        {
            Message message = new Message();
            SKU l_sku = new SKU();
            SKUChecker l_skuChecker = new SKUChecker();
            List<SKUJson> list = new List<SKUJson>();
            Boolean isAllSave = true;
            string curSKUAsk = "0";

            #region "Bind Object"
            
            #region "saveSKU"
            if (criteria.Ask == "0")
                l_sku.Ask = mUtility.getStrAsk().ToString();
            else
                l_sku.Ask = criteria.Ask;

            l_sku.TS = criteria.TS;
            l_sku.UD = criteria.UD;
            l_sku.SKUName = criteria.SKUName;
            l_sku.SKUDetails = criteria.SKUDetails;
            l_sku.DimensionWidth = criteria.DimensionWidth;
            l_sku.DimensionHeight = criteria.DimensionHeight;
            l_sku.DimensionBase = criteria.DimensionBase;
            l_sku.SKUWeight = criteria.SKUWeight;
            l_sku.PlanQty = criteria.PlanQty;
            l_sku.UOMAsk = criteria.UOMAsk;
            l_sku.ReceivedQty = criteria.ReceivedQty;      
            l_sku.Reference = criteria.Reference;
            l_sku.TruckID = criteria.TruckID;
            l_sku.TruckType = criteria.TruckType;
            l_sku.GoodQty = criteria.GoodQty;
            l_sku.DamageQty = criteria.DamageQty;
            l_sku.ShortLandQty = criteria.ShortLandQty;
            l_sku.OverlandQty = criteria.OverlandQty;
            l_sku.Goodphoto = criteria.Goodphoto;
            l_sku.Damagephoto = criteria.Damagephoto;
            l_sku.ShortLandphoto = criteria.ShortLandphoto;
            l_sku.Overlandphoto = criteria.Overlandphoto;
            l_sku.Status = criteria.Status;
            l_sku.DisplaySequence = criteria.DisplaySequence;
            l_sku.Remark = criteria.Remark;


            Boolean isSave = false;
            curSKUAsk = l_sku.Ask;
            if (criteria.Ask == "0")
                isSave = mMasterBLL.saveObj("WMS_SKU", l_sku);
            else
                isSave = mMasterBLL.updateObj("WMS_SKU", l_sku);

            #endregion

            #region"saveSKUChecker"
           // if (criteria.Ask == "0")
                l_skuChecker.Ask = mUtility.getStrAsk().ToString();
            //else
              //  l_skuChecker.Ask = criteria.Ask;

            l_skuChecker.TS = criteria.TS;
            l_skuChecker.UD = criteria.UD;
            l_skuChecker.BookingAsk = criteria.BookingAsk;
            l_skuChecker.AgentAsk = criteria.AgentAsk;
            l_skuChecker.ShipperAsk = criteria.ShipperAsk;
            l_skuChecker.ContainerAsk = criteria.ContainerAsk;
            l_skuChecker.SKUAsk = curSKUAsk;
            l_skuChecker.DimensionWidth = criteria.DimensionWidth;
            l_skuChecker.DimensionHeight = criteria.DimensionHeight;
            l_skuChecker.DimensionBase = criteria.DimensionBase;
            l_skuChecker.SKUWeight = criteria.SKUWeight;
            l_skuChecker.ReceivedQty = criteria.ReceivedQty;
            l_skuChecker.UOMAsk = criteria.UOMAsk;
            l_skuChecker.Status = criteria.Status;
            l_skuChecker.DisplaySequence = criteria.DisplaySequence;
            l_skuChecker.Remark = criteria.Remark;


            Boolean isSave2 = false;
            curSKUAsk = l_sku.Ask;
            //if (criteria.Ask == "0")
                isSave2 = mMasterBLL.saveObj("WMS_SKU_CHECKER", l_skuChecker);
            //else
              //  isSave2 = mMasterBLL.updateObj("WMS_SKU_CHECKER", l_skuChecker);
            #endregion
           
            
            #endregion

            #region "listArea"
            SKUCri selectcriteria = new SKUCri();
            selectcriteria.UserID = criteria.UserID;
            selectcriteria.Password = criteria.Password;
            selectcriteria.ProductAsk = criteria.ProductAsk;
            selectcriteria.Ask = curSKUAsk;

            list = getCheckerWarehouse(selectcriteria);

            #endregion

            return list;
        }
        #endregion

        #region "getCheckerWarehouse"
        public List<SKUJson> getCheckerWarehouse(SKUCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);
            dic.Add("@SKUAsk", criteria.Ask);


            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_CheckerWarehouseList", dic);

            #region "bind data"

            List<SKUJson> list = new List<SKUJson>();
                       
            SKUJson obj = new SKUJson();

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    obj.SKUAsk = dr[0].ToString();
                    obj.SKUName = dr[1].ToString();
                    obj.SKUDetails = dr[2].ToString();
                    obj.SKUDimensionWidth = dr[3].ToString();
                    obj.SKUDimensionHeight = dr[4].ToString();
                    obj.SKUDimensionBase = dr[5].ToString();
                    obj.SKUWeight = dr[6].ToString();
                    obj.SKUPlanQty = dr[7].ToString();
                    obj.SKUUOMAsk = dr[8].ToString();
                    obj.SKUReceivedQty = dr[9].ToString();
                    obj.SKUReference = dr[10].ToString();
                    obj.SKUTruckType = dr[11].ToString();
                    obj.SKUGoodQty = dr[12].ToString();
                    obj.SKUDamageQty = dr[13].ToString();
                    obj.SKUShortLandQty = dr[14].ToString();
                    obj.SKUOverlandQty = dr[15].ToString();
                    obj.SKUGoodphoto = dr[16].ToString();
                    obj.SKUDamagephoto = dr[17].ToString();
                    obj.SKUShortLandphoto = dr[18].ToString();
                    obj.SKUOverlandphoto = dr[19].ToString();

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

        #region "saveSKUBarcode"
        public List<SKUBarcodeJson> saveSKUBarcode(SKUBarcodeCri criteria)
        {
            Message message = new Message();
            SKUBarcode l_skubarcode = new SKUBarcode();
            List<SKUBarcodeJson> list = new List<SKUBarcodeJson>();
            Boolean isAllSave = true;
            string curSKUBarcodeAsk = "0";

            #region "Bind Object"
            if (criteria.Ask == "0")
                l_skubarcode.Ask = mUtility.getStrAsk().ToString();
            else
                l_skubarcode.Ask = criteria.Ask;

            l_skubarcode.TS = criteria.TS;
            l_skubarcode.UD = criteria.UD;
            l_skubarcode.SKUAsk = criteria.SKUAsk;
            l_skubarcode.BarcodeAsk = criteria.BarcodeAsk;
            l_skubarcode.DimensionWidth = criteria.DimensionWidth;
            l_skubarcode.DimensionHeight = criteria.DimensionHeight;
            l_skubarcode.DimensionBase = criteria.DimensionBase;
            l_skubarcode.SKUWeight = criteria.SKUWeight;
            l_skubarcode.Qty = criteria.Qty;
            l_skubarcode.UOMAsk = criteria.UOMAsk;
            l_skubarcode.BarcodeStatus = criteria.BarcodeStatus;
            l_skubarcode.MergedBarcodeAsk = criteria.MergedBarcodeAsk;
            l_skubarcode.Status = criteria.Status;
            l_skubarcode.DisplaySequence = criteria.DisplaySequence;
            l_skubarcode.Remark = criteria.Remark;


            Boolean isSave = false;
            curSKUBarcodeAsk = l_skubarcode.Ask;
            if (criteria.Ask == "0")
                isSave = mMasterBLL.saveObj("WMS_SKU_Barcode", l_skubarcode);
            else
                isSave = mMasterBLL.updateObj("WMS_SKU_Barcode", l_skubarcode);


            #endregion

            #region "listArea"
            SKUBarcodeCri selectcriteria = new SKUBarcodeCri();
            selectcriteria.UserID = criteria.UserID;
            selectcriteria.Password = criteria.Password;
            selectcriteria.ProductAsk = criteria.ProductAsk;
            selectcriteria.Ask = curSKUBarcodeAsk;

            list = getSKUBarcode(selectcriteria);

            #endregion

            return list;
        }
        #endregion

        #region "getSKUBarcode"
        public List<SKUBarcodeJson> getSKUBarcode(SKUBarcodeCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);
            dic.Add("@SKUBarcodeAsk", criteria.Ask);


            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_SKUBarcode", dic);

            #region "bind data"

            List<SKUBarcodeJson> list = new List<SKUBarcodeJson>();

            SKUBarcodeJson obj = new SKUBarcodeJson();

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    obj.Ask = dr[0].ToString();
                    obj.SKUAsk = dr[1].ToString();
                    obj.BarcodeAsk = dr[2].ToString();
                    obj.DimensionWidth = dr[3].ToString();
                    obj.DimensionHeight = dr[4].ToString();
                    obj.DimensionBase = dr[5].ToString();
                    obj.SKUWeight = dr[6].ToString();
                    obj.Qty = dr[7].ToString();
                    obj.UOMAsk = dr[8].ToString();
                    obj.BarcodeStatus = dr[9].ToString();
                    obj.MergedBarcodeAsk = dr[10].ToString();
                   
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

        #region "saveAllocation"
        public List<SKUBarcodeLocationJunJson> saveAllocation(SKUBarcodeLocationJunCri criteria)
        {
            SKUBarcodeLocationJun l_obj = new SKUBarcodeLocationJun();
            List<SKUBarcodeLocationJunJson> list = new List<SKUBarcodeLocationJunJson>();
            string curJunAsk = "0";

            #region "Bind Object"
            if (criteria.Ask == "0")
                l_obj.Ask = mUtility.getStrAsk().ToString();
            else
                l_obj.Ask = criteria.Ask;

            l_obj.TS = criteria.TS;
            l_obj.UD = criteria.UD;
            l_obj.SKUBarcodeAsk = criteria.SKUBarcodeAsk;
            l_obj.LocationAsk = criteria.LocationAsk;
            l_obj.PalletAsk = criteria.PalletAsk;
            l_obj.Status = criteria.Status;
            l_obj.DisplaySequence = criteria.DisplaySequence;
            l_obj.Remark = criteria.Remark;


            Boolean isSave = false;
            curJunAsk = l_obj.Ask;
            if (criteria.Ask == "0")
                isSave = mMasterBLL.saveObj("WMS_SKUBARCODE_LOC_JUN", l_obj);
            else
                isSave = mMasterBLL.updateObj("WMS_SKUBARCODE_LOC_JUN", l_obj);


            #endregion

            #region "listArea"
            SKUBarcodeLocationJunCri selectcriteria = new SKUBarcodeLocationJunCri();
            selectcriteria.UserID = criteria.UserID;
            selectcriteria.Password = criteria.Password;
            selectcriteria.ProductAsk = criteria.ProductAsk;
            selectcriteria.Ask = curJunAsk;

            list = getAllocation(selectcriteria);

            #endregion

            return list;
        }
        #endregion

        #region "getAllocation"
        public List<SKUBarcodeLocationJunJson> getAllocation(SKUBarcodeLocationJunCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);
            dic.Add("@Ask", criteria.Ask);


            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_Allocation", dic);

            #region "bind data"

            List<SKUBarcodeLocationJunJson> list = new List<SKUBarcodeLocationJunJson>();

            SKUBarcodeLocationJunJson obj = new SKUBarcodeLocationJunJson();

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    obj.Ask = dr[0].ToString();
                    obj.TS = dr[1].ToString();
                    obj.UD = dr[2].ToString();
                    obj.SKUBarcodeAsk = dr[3].ToString();
                    obj.LocationAsk = dr[4].ToString();
                    obj.PalletAsk = dr[5].ToString();
                    obj.Status = dr[6].ToString();
                    obj.DisplaySequence = dr[7].ToString();
                    obj.Remark = dr[8].ToString();
                   
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

        #region"saveCreatePicklist"
        public List<CreatePicklistJson> saveCreatePicklist(CreatePicklistCri criteria)
        {
            Picklist l_obj = new Picklist();
            Container l_obj2 = new Container();

            List<CreatePicklistJson> list = new List<CreatePicklistJson>();
            string curPicklistAsk = "0";
            string curContainerAsk = "0";

            #region "Bind Object"
            #region"Picklist"
            if (criteria.PicklistAsk == "0")
                l_obj.Ask = mUtility.getStrAsk().ToString();
            else
                l_obj.Ask = criteria.PicklistAsk;

            l_obj.TS = criteria.PicklistAsk;
            l_obj.UD = criteria.PicklistUD;
            l_obj.PicklistNo = criteria.PicklistNo;
            l_obj.PicklistDetails = criteria.PicklistDetails;
            l_obj.UserAsk = criteria.PicklistUserAsk;
            l_obj.CreatedDate = criteria.PicklistCreatedDate;
            l_obj.FinishedDate = criteria.PicklistFinishedDate;
            l_obj.DisplaySequence = criteria.PicklistDisplaySequence;
            l_obj.Remark = criteria.PicklistRemark;

            Boolean isSave = false;
            curPicklistAsk = l_obj.Ask;
            if (criteria.PicklistAsk == "0")
                isSave = mMasterBLL.saveObj("WMS_PICKLIST", l_obj);
            else
                isSave = mMasterBLL.updateObj("WMS_PICKLIST", l_obj);
            #endregion

            #region"Container"
            if (criteria.ContainerAsk == "0")
                l_obj2.Ask = mUtility.getStrAsk().ToString();
            else
                l_obj2.Ask = criteria.PicklistAsk;

            l_obj.TS = criteria.PicklistAsk;
            l_obj2.UD = criteria.PicklistUD;
            l_obj2.ContainerNo = criteria.ContainerNo;
            l_obj2.ContainerDetails = criteria.ContainerDetails;
            l_obj2.SealNo = criteria.ContainerSealNo;
            l_obj2.Width = criteria.ContainerWidth;
            l_obj2.Height = criteria.ContainerHeight;
            l_obj2.Base = criteria.ContainerBase;
            l_obj2.ContainerType = criteria.ContainerType;
            l_obj2.Color = criteria.ContainerColor;
            l_obj2.TruckTypeAsk = criteria.ContainerTruckTypeAsk;
            l_obj2.Carrier = criteria.ContainerCarrier;
            l_obj2.Voy = criteria.ContainerVoy;
            l_obj2.VesselNo = criteria.ContainerVesselNo;
            l_obj2.ETA = criteria.ContainerETA;
            l_obj2.ETD = criteria.ContainerETD;
            l_obj2.CutOffDate = criteria.ContainerCutOffDate;
            l_obj2.PaperlessCode = criteria.ContainerPaperlessCode;
            l_obj2.ContainerPicture = criteria.ContainerVesselNo;
            l_obj2.CountryAsk = criteria.ContainerCountryAsk;
            l_obj2.TareWeight = criteria.ContainerTareWeight;
            l_obj2.GrossWeight = criteria.ContainerGrossWeight;
            l_obj2.MattWeight = criteria.ContainerMattWeight;
            l_obj2.TotalWeight = criteria.ContainerTotalWeight;
            l_obj2.DisplaySequence = criteria.PicklistDisplaySequence;
            l_obj2.Remark = criteria.PicklistRemark;

            Boolean isContainerSave = false;
            curContainerAsk = l_obj2.Ask;
            if (criteria.ContainerAsk == "0")
                isContainerSave = mMasterBLL.saveObj("WMS_CONTAINER", l_obj2);
            else
                isContainerSave = mMasterBLL.updateObj("WMS_CONTAINER", l_obj2);

            #endregion

            if (isContainerSave && isSave)
            {
                #region "PicklistContainerJun"
                PicklistContainerJun pcjun = new PicklistContainerJun();
                pcjun.Ask = mUtility.getStrAsk().ToString();
                pcjun.TS = "1";
                pcjun.UD = "1";
                pcjun.PickListAsk = curPicklistAsk;
                pcjun.ContainerAsk = curContainerAsk;
                pcjun.Status = "0";
                pcjun.DisplaySequence = "0";
                pcjun.Remark = "";

                Boolean ispcJunDelete = mMasterBLL.deleteObj("WMS_PICKLIST_CONTAINER_JUN", pcjun, 4);
                Boolean ispcJunSave = mMasterBLL.saveObj("WMS_PICKLIST_CONTAINER_JUN", pcjun);
                #endregion

                #region"searchSKUBarcodeLocationJun"
                SKUBarcodeLocationJun l_obj3 = new SKUBarcodeLocationJun();
                l_obj3.SKUBarcodeAsk = criteria.SKUBarcodeAsk;
                DataTable dt = mMasterBLL.selectDataTablebyIndex("WMS_SKUBARCODE_LOC_JUN", l_obj3,4);

                foreach (DataRow dr in dt.Rows)
                {
                    try
                    {
                        SKUBarcodeLocationJun l_obj4 = new SKUBarcodeLocationJun();

                        l_obj4.Ask = dr[0].ToString();
                        l_obj4.TS = dr[1].ToString();
                        l_obj4.UD = dr[2].ToString();
                        l_obj4.SKUBarcodeAsk = dr[3].ToString();
                        l_obj4.LocationAsk = dr[4].ToString();
                        l_obj4.PalletAsk = dr[5].ToString();
                        l_obj4.Status = dr[6].ToString();
                        l_obj4.DisplaySequence = dr[7].ToString();
                        l_obj4.Remark = dr[8].ToString();

                        LocationPicklistJun l_obj5 = new LocationPicklistJun();
                        l_obj5.Ask = mUtility.getStrAsk().ToString();
                        l_obj5.TS = "0";
                        l_obj5.UD = "0";
                        l_obj5.SkuBarcodeLocJunAsk = l_obj4.Ask;
                        l_obj5.PickListAsk = curPicklistAsk;
                        l_obj5.Status = "0";
                        l_obj5.DisplaySequence = "0";
                        l_obj5.Remark = "";
                        l_obj5.BookingAsk = criteria.BookingAsk;

                        Boolean islpJunDelete = mMasterBLL.deleteObj("WMS_LOC_PICKLIST_JUN", l_obj5, 4);
                        Boolean islpJunSave = mMasterBLL.saveObj("WMS_LOC_PICKLIST_JUN", l_obj5);
                    }
                    catch
                    {
                        continue;
                    }
                }




                #endregion

                #region "listArea"
                CreatePicklistCri selectcriteria = new CreatePicklistCri();
                selectcriteria.UserID = criteria.UserID;
                selectcriteria.Password = criteria.Password;
                selectcriteria.ProductAsk = criteria.ProductAsk;
                selectcriteria.PicklistAsk = curPicklistAsk;
                selectcriteria.ContainerAsk = curContainerAsk;
                selectcriteria.BookingAsk = criteria.BookingAsk;

                list = getCreatePickList(selectcriteria);

                #endregion
            }
            return list;
            #endregion
        }
        #endregion

        #region "getCreatePickList"
        public List<CreatePicklistJson> getCreatePickList(CreatePicklistCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);
            dic.Add("@PicklistAsk", criteria.PicklistAsk);
            dic.Add("@ContainerAsk", criteria.ContainerAsk);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_CreatePickList", dic);

            #region "bind data"

            List<CreatePicklistJson> list = new List<CreatePicklistJson>();

          

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                    CreatePicklistJson obj = new CreatePicklistJson();
                    obj.BookingAsk = criteria.BookingAsk;

                    obj.PicklistAsk = dr[0].ToString();
                    obj.PicklistTS = dr[1].ToString();
                    obj.PicklistUD = dr[2].ToString();
                    obj.PicklistNo = dr[3].ToString();
                    obj.PicklistDetails = dr[4].ToString();
                    obj.PicklistUserAsk = dr[5].ToString();
                    obj.PicklistCreatedDate = dr[6].ToString();
                    obj.PicklistFinishedDate = dr[7].ToString();
                    obj.PicklistStatus = dr[8].ToString();
                    obj.PicklistDisplaySequence = dr[9].ToString();
                    obj.PicklistRemark = dr[10].ToString();

                    obj.ContainerAsk = dr[11].ToString();
                    obj.ContainerTS = dr[12].ToString();
                    obj.ContainerUD = dr[13].ToString();
                    obj.ContainerNo = dr[14].ToString();
                    obj.ContainerDetails = dr[15].ToString();
                    obj.ContainerSealNo = dr[16].ToString();
                    obj.ContainerWidth = dr[17].ToString();
                    obj.ContainerHeight = dr[18].ToString();
                    obj.ContainerBase = dr[19].ToString();
                    obj.ContainerColor = dr[20].ToString();
                    obj.ContainerTruckTypeAsk = dr[21].ToString();
                    obj.ContainerCarrier = dr[22].ToString();
                    obj.ContainerVoy = dr[23].ToString();
                    obj.ContainerVesselNo = dr[24].ToString();
                    obj.ContainerETA = dr[25].ToString();
                    obj.ContainerETD = dr[26].ToString();
                    obj.ContainerCutOffDate = dr[27].ToString();
                    obj.ContainerPaperlessCode = dr[28].ToString();
                    obj.ContainerPicture = dr[29].ToString();
                    obj.ContainerCountryAsk = dr[30].ToString();
                    obj.ContainerTareWeight = dr[31].ToString();
                    obj.ContainerGrossWeight = dr[32].ToString();
                    obj.ContainerMattWeight = dr[33].ToString();
                    obj.ContainerTotalWeight = dr[33].ToString();
                    obj.ContainerStatus = dr[34].ToString();
                    obj.ContainerDisplaySequence = dr[35].ToString();
                    obj.ContainerRemark = dr[36].ToString();

                    list.Add(obj);
                }
                catch
                {
                    continue;
                }
                
            }


            #endregion

            return list;
        }
        #endregion

        #region "getSelectCreatePickList"
        public List<CreatePicklistListJson> getSelectCreatePickList(CreatePicklistCri criteria)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("@UserID", criteria.UserID);
            dic.Add("@Password", criteria.Password);
            dic.Add("@ProductAsk", criteria.ProductAsk);

            dic.Add("@BookignAsk", criteria.BookingAsk);
            dic.Add("@SKUBarcodeAsk", criteria.SKUBarcodeAsk);

            dic.Add("@PicklistAsk", criteria.PicklistAsk);
            dic.Add("@PicklistNo", criteria.PicklistNo);
            dic.Add("@PicklistDetails", criteria.PicklistDetails);
            dic.Add("@PicklistUserAsk", criteria.PicklistUserAsk);
            dic.Add("@PicklistCreatedDate", criteria.PicklistCreatedDate);
            dic.Add("@PicklistFinishedDate", criteria.PicklistFinishedDate);
            dic.Add("@PicklistStatus", criteria.PicklistStatus);
            dic.Add("@PicklistDisplaySequence", criteria.PicklistDisplaySequence);
            dic.Add("@PicklistRemark", criteria.PicklistRemark);

            dic.Add("@ContainerAsk", criteria.ContainerAsk);
            dic.Add("@ContainerNo", criteria.ContainerNo);
            dic.Add("@ContainerDetails", criteria.ContainerDetails);
            dic.Add("@ContainerSealNo", criteria.ContainerSealNo);
            dic.Add("@ContainerWidth", criteria.ContainerWidth);
            dic.Add("@ContainerHeight", criteria.ContainerHeight);
            dic.Add("@ContainerBase", criteria.ContainerBase);
            dic.Add("@ContainerType", criteria.ContainerType);
            dic.Add("@ContainerColor", criteria.ContainerColor);
            dic.Add("@ContainerTruckTypeAsk", criteria.ContainerTruckTypeAsk);
            dic.Add("@ContainerCarrier", criteria.ContainerCarrier);
            dic.Add("@ContainerVoy", criteria.ContainerVoy);
            dic.Add("@ContainerVesselNo", criteria.ContainerVesselNo);
            dic.Add("@ContainerETA", criteria.ContainerETA);
            dic.Add("@ContainerETD", criteria.ContainerETD);
            dic.Add("@ContainerCutOffDate", criteria.ContainerCutOffDate);
            dic.Add("@ContainerPaperlessCode", criteria.ContainerPaperlessCode);
            dic.Add("@ContainerPicture", criteria.ContainerPicture);
            dic.Add("@ContainerCountryAsk", criteria.ContainerCountryAsk);
            dic.Add("@ContainerTareWeight", criteria.ContainerTareWeight);
            dic.Add("@ContainerGrossWeight", criteria.ContainerGrossWeight);
            dic.Add("@ContainerMattWeight", criteria.ContainerMattWeight);
            dic.Add("@ContainerTotalWeight", criteria.ContainerTotalWeight);
            dic.Add("@ContainerStatus", criteria.ContainerStatus);
            dic.Add("@ContainerDisplaySequence", criteria.ContainerDisplaySequence);
            dic.Add("@ContainerRemark", criteria.ContainerRemark);

            DataTable dt = mMasterBLL.executeSelectProcedure("CS_SP_WMS_SelectCreatePickList", dic);

            #region "bind data"

            List<CreatePicklistListJson> list = new List<CreatePicklistListJson>();
            string bookingAsk = "0";
            CreatePicklistListJson obj = new CreatePicklistListJson();

            foreach (DataRow dr in dt.Rows)
            {
                try
                {
                 
                    if ((!bookingAsk.Equals(dr[0].ToString())) && (!dr[0].ToString().Equals("")))
                    {
                        BookingJson bkjson = new BookingJson();
                        bkjson.Ask = dr[0].ToString();
                        bkjson.TS = dr[1].ToString();
                        bkjson.UD = dr[2].ToString();
                        bkjson.BookingID = dr[3].ToString();
                        bkjson.AgentAsk = dr[4].ToString();
                        bkjson.Shipper = dr[5].ToString();
                        bkjson.CountryAsk = dr[6].ToString();
                        bkjson.CargoReceivedDate = dr[7].ToString();
                        bkjson.CustomIssuedDate = dr[8].ToString();
                        bkjson.TransactionDate = dr[9].ToString();
                        bkjson.Signature = dr[10].ToString();
                        bkjson.SignatureDate = dr[11].ToString();
                        bkjson.NoOfTruck = dr[12].ToString();
                        bkjson.NoOfContainer = dr[13].ToString();

                      
                        bkjson.DisplaySequence = dr[14].ToString();
                        bkjson.Remark = dr[15].ToString();
                        bkjson.LogisticTypeAsk = dr[16].ToString();

                        obj.BookingList.Add(bkjson);
                        bookingAsk = dr[0].ToString();
                    }

                    CreatePicklistDetailJson dtl = new CreatePicklistDetailJson();
                    dtl.BookingAsk = bookingAsk;

                    dtl.AgentAsk = dr[17].ToString();
                    dtl.AgentTS = dr[18].ToString();
                    dtl.AgentUD = dr[19].ToString();
                    dtl.AgentName = dr[20].ToString();
                    dtl.AgentDetails = dr[21].ToString();
                    dtl.AgentNationalID = dr[22].ToString();
                    dtl.AgentBillingAddress = dr[23].ToString();
                    dtl.AgentShippingAddress = dr[24].ToString();
                    dtl.AgentCompanyName = dr[25].ToString();
                    dtl.AgentWebsite = dr[26].ToString();
                    dtl.AgentMobile = dr[27].ToString();
                    dtl.AgentEmail = dr[28].ToString();
                    dtl.AgentContactPersonName = dr[29].ToString();
                    dtl.AgentContactPersonMobile = dr[30].ToString();
                    dtl.AgentDisplaySequence = dr[31].ToString();
                    dtl.AgentRemark = dr[32].ToString();

                    dtl.ShipperAsk = dr[33].ToString();
                    dtl.ShipperTS = dr[34].ToString();
                    dtl.ShipperUD = dr[35].ToString();
                    dtl.ShipperName = dr[36].ToString();
                    dtl.ShipperDetails = dr[37].ToString();
                    dtl.ShipperStatus = dr[38].ToString();
                    dtl.ShipperDisplaySequence = dr[39].ToString();
                    dtl.ShipperRemark = dr[40].ToString();

                    dtl.PicklistAsk = dr[41].ToString();
                    dtl.PicklistTS = dr[42].ToString();
                    dtl.PicklistUD = dr[43].ToString();
                    dtl.PicklistNo = dr[44].ToString();
                    dtl.PicklistDetails = dr[45].ToString();
                    dtl.PicklistUserAsk = dr[46].ToString();
                    dtl.PicklistCreatedDate = dr[47].ToString();
                    dtl.PicklistFinishedDate = dr[48].ToString();
                    dtl.PicklistStatus = dr[49].ToString();
                    dtl.PicklistDisplaySequence = dr[50].ToString();
                    dtl.PicklistRemark = dr[51].ToString();

                    dtl.SKUBarcodeAsk = dr[52].ToString();
                    dtl.SKUBarcodeTS = dr[53].ToString();
                    dtl.SKUBarcodeUD = dr[54].ToString();
                    dtl.SKUBarcodeSKUAsk = dr[55].ToString();
                    dtl.SKUBarcodeBarcodeAsk = dr[56].ToString();
                    dtl.SKUBarcodeDimensionWidth = dr[57].ToString();
                    dtl.SKUBarcodeDimensionHeight = dr[58].ToString();
                    dtl.SKUBarcodeDimensionBase = dr[59].ToString();
                    dtl.SKUBarcodeQty = dr[60].ToString();
                    dtl.SKUBarcodeUOMAsk = dr[61].ToString();
                    dtl.SKUBarcodeBarcodeStatus = dr[62].ToString();
                    dtl.SKUBarcodeMergedBarcodeAsk = dr[63].ToString();
                    dtl.SKUBarcodeBarcodeAsk = dr[64].ToString();
                    dtl.SKUBarcodeStatus = dr[65].ToString();
                    dtl.SKUBarcodeDisplaySequence = dr[66].ToString();
                    dtl.SKUBarcodeRemark = dr[67].ToString();

                    dtl.LocationAsk = dr[68].ToString();
                    dtl.LocationTS = dr[69].ToString();
                    dtl.LocationUD = dr[70].ToString();
                    dtl.LocationBarcodeAsk = dr[71].ToString();
                    dtl.LocationName = dr[72].ToString();
                    dtl.LocationDetails = dr[73].ToString();
                    dtl.LocationBuilding = dr[74].ToString();
                    dtl.LocationLevel = dr[75].ToString();
                    dtl.LocationZone = dr[76].ToString();
                    dtl.LocationGPSLT = dr[77].ToString();
                    dtl.LocationGPSLG = dr[78].ToString();
                    dtl.LocationType = dr[79].ToString();
                    dtl.LocationBase = dr[80].ToString();
                    dtl.LocationWidth = dr[81].ToString();
                    dtl.LocationHeight = dr[82].ToString();
                    dtl.LocationCapacityWeigth = dr[83].ToString();
                    dtl.LocationStatus = dr[84].ToString();
                    dtl.LocationDisplaySequence = dr[85].ToString();
                    dtl.LocationRemark = dr[86].ToString();

                    obj.DetailList.Add(dtl);

                    

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

        #region"saveDeliverlist"
        public Message saveDeliverlist(DeliverlistCri criteria)
        {
            Message message = new Message();
            bool isupd1 = false;
            bool isupd2 = false;
          
            #region "Bind Object"              
            
                #region"searchLocationPicklistJun"
                LocationPicklistJun l_obj1 = new LocationPicklistJun();
                l_obj1.Ask = criteria.LocationPicklistJunAsk;
                DataTable dt = mMasterBLL.selectDataTablebyIndex("WMS_LOC_PICKLIST_JUN", l_obj1, 1);

                 foreach (DataRow dr in dt.Rows)
                {
                try
                {
                    LocationPicklistJun l_obj2 = new LocationPicklistJun();

                    l_obj2.Ask = dr[0].ToString();
                    l_obj2.TS = dr[1].ToString();
                    l_obj2.UD = dr[2].ToString();
                    l_obj2.SkuBarcodeLocJunAsk = dr[3].ToString();
                    l_obj2.PickListAsk = dr[4].ToString();
                    l_obj2.Status = "1";
                    l_obj2.DisplaySequence = dr[6].ToString();
                    l_obj2.Remark = dr[7].ToString();

                    isupd1 = mMasterBLL.updateObj("WMS_LOC_PICKLIST_JUN", l_obj2);

                }
                catch
                {
                    continue;
                }
                              
            }
            #endregion

                #region"searchLocationPicklistJun"
            SKUBarcodeLocationJun l_obj3 = new SKUBarcodeLocationJun();
            l_obj3.Ask = criteria.SKUBarcodeLocationJunAsk;
            DataTable dt2 = mMasterBLL.selectDataTablebyIndex("WMS_SKUBARCODE_LOC_JUN", l_obj3, 1);

            foreach (DataRow dr in dt2.Rows)
            {
                try
                {
                    SKUBarcodeLocationJun l_obj4 = new SKUBarcodeLocationJun();

                    l_obj4.Ask = dr[0].ToString();
                    l_obj4.TS = dr[1].ToString();
                    l_obj4.UD = dr[2].ToString();
                    l_obj4.SKUBarcodeAsk = dr[3].ToString();
                    l_obj4.LocationAsk = dr[4].ToString();
                    l_obj4.PalletAsk = dr[5].ToString();
                    l_obj4.Status = "1";
                    l_obj4.DisplaySequence = dr[7].ToString();
                    l_obj4.Remark = dr[8].ToString();

                    isupd2 = mMasterBLL.updateObj("WMS_SKUBARCODE_LOC_JUN", l_obj4);

                }
                catch
                {
                    continue;
                }

            }
            #endregion

            if(isupd1 && isupd2)
            {
                message.Code = "2";
                message.Detail = "Update Successfully.";
            }
            else
            {
                message.Code = "0";
                message.Detail = "Update Failed.";
            }


            return message;
            #endregion
        }
        #endregion


    }
}
