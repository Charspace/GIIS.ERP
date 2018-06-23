using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GIIS.ERP.WMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WMS" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WMS.svc or WMS.svc.cs at the Solution Explorer and start debugging.
    public class WMS : IWMS
    {
        public void DoWork()
        {

        }
        public UserInfo getUserInfo()
        {
            return new UserInfo();
        }
    }
}
