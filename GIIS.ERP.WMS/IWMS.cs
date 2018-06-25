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
        [WebInvoke(Method = "GET",
              RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json,
              BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "getSysMenu")]
               List<SysMenu> getSysMenu();


        [OperationContract]
        [WebInvoke(Method = "POST",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             BodyStyle = WebMessageBodyStyle.Bare,
              UriTemplate = "getSysMenuGroup")]
        List<SysMenuGroup> getSysMenuGroup(SysMenuGroupCri menuGroup);

        [OperationContract]
        [WebInvoke(Method = "POST",
                   RequestFormat = WebMessageFormat.Json,
                   ResponseFormat = WebMessageFormat.Json,
                   BodyStyle = WebMessageBodyStyle.Bare,
                    UriTemplate = "saveSysMenuGroup")]
        Message saveSysMenuGroup(SysMenuGroupCri menuGroup);

    }
}
