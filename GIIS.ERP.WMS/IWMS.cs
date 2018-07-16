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

        [OperationContract]
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "getUOMList")]
        List<UOMJson> getUOMList(AuthorizationCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "getTruckTypeList")]
        List<TruckTypeJson> getTruckTypeList(AuthorizationCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "saveTallyWarehouse")]
        List<TallyJson> saveTallyWarehouse(TallyCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "getTallyWarehouseList")]
        List<TallyWarehouseJson> getTallyWarehouseList(TallyWarehouseCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "saveCheckerWarehouse")]
        List<SKUJson> saveCheckerWarehouse(CheckerWarehouseCri criteria);


        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "saveSKUBarcode")]
        List<SKUBarcodeJson> saveSKUBarcode(SKUBarcodeCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "saveAllocation")]
        List<SKUBarcodeLocationJunJson> saveAllocation(SKUBarcodeLocationJunCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "getAllocation")]
        List<SKUBarcodeLocationJunJson> getAllocation(SKUBarcodeLocationJunCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "saveCreatePicklist")]
        List<CreatePicklistJson> saveCreatePicklist(CreatePicklistCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "getSelectCreatePickList")]
        List<CreatePicklistListJson> getSelectCreatePickList(CreatePicklistCri criteria);
       
        [OperationContract]
        [WebInvoke(Method = "POST",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Bare,
       UriTemplate = "saveDeliverlist")]
        Message saveDeliverlist(DeliverlistCri criteria);


        [OperationContract]
        [WebInvoke(Method = "POST",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "savePRFEDirect")]
        List<PREFDirectListJson> savePRFEDirect(PRFEDirectCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "getPRFEDirectList")]
        List<PREFDirectListJson> getPRFEDirectList(PRFEDirectCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
         UriTemplate = "saveCheckerDirect")]
        List<CheckerDirectJson> saveCheckerDirect(CheckerDirectCri criteria);

        [OperationContract]
        [WebInvoke(Method = "POST",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "getCheckerDirect")]
        List<CheckerDirectJson> getCheckerDirect(CheckerDirectCri criteria);
    }
}
