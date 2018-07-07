using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CHARS.HR.COMMON.BOL;

namespace GIIS.ERP.WMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWMS" in both code and config file together.
    [ServiceContract]
    public interface IWMS
    {
        void DoWork();

        [OperationContract]        
        [WebInvoke(Method = "GET",
              RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json,
              BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "getUserInfo")]
        UserInfo getUserInfo();

        [OperationContract]
        [WebInvoke(Method = "POST",
              RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json,
              BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "getAccessMenu")]
               List<SysMenuJson> getAccessMenu(AuthorizationCri menu);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "getAccessControl")]
        List<SysControlJson> getAccessControl(AuthorizationCri menu);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "getSysMenuGroup")]
        List<SysMenuGroupJson> getSysMenuGroup(AuthorizationCri menugroup);

        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "getSysControlGroup")]
        List<SysControlGroupJson> getSysControlGroup(AuthorizationCri controlgroup);

        [OperationContract]
        [WebInvoke(Method = "POST",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "getSysProduct")]
        List<SysProductJson> getSysProduct(AuthorizationCri product);

        [OperationContract]
        [WebInvoke(Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
              UriTemplate = "getSysMenuGroupList")]
        List<SysMenuGroupListJson> getSysMenuGroupList(SysMenuGroupCri menuGroup);


        [OperationContract]
        [WebInvoke(Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
              UriTemplate = "getSysControlGroupList")]
        List<SysControlGroupListJson> getSysControlGroupList(SysControlGroupCri menuGroup);

        [OperationContract]
        [WebInvoke(Method = "POST",
                   RequestFormat = WebMessageFormat.Json,
                   ResponseFormat = WebMessageFormat.Json,
                   BodyStyle = WebMessageBodyStyle.Bare,
                    UriTemplate = "saveSysMenuGroup")]
        Message saveSysMenuGroup(SysMenuGroupCri menuGroup);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "getSysUserList")]
        List<SysUserJson> getSysUserList(SysUserCri user);

        [OperationContract]
        [WebInvoke(Method = "POST",
                   RequestFormat = WebMessageFormat.Json,
                   ResponseFormat = WebMessageFormat.Json,
                   BodyStyle = WebMessageBodyStyle.Bare,
                    UriTemplate = "saveSysUser")]
        Message saveSysUser(SysUserCri user);

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
             UriTemplate = "testLogIn")]
        Message testLogIn(LoginCri login);

        [OperationContract]
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "savePRFEWarehouse")]
        List<PREFWarehouseJson> savePRFEWarehouse(PRFEWarehouseCri login);

        [OperationContract]
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "getPRFEWarehouseList")]
        List<PREFWarehouseListJson> getPRFEWarehouseList(PRFEWarehouseCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "getAgentList")]
        List<AgentJson> getAgentList(AuthorizationCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "getCountryList")]
        List<CountryJson> getCountryList(AuthorizationCri criteria);

    }
}
