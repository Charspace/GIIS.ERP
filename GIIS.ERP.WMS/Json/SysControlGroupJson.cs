using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysControlGroupJson
    {
        public SysControlGroupJson()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mControlGpAsk;
        private string mControlGpName;
        private string mControlGpDesc;
        
        #endregion
        #region "public member"
        [DataMember]

        public string ControlGpAsk
        {
            get { return mControlGpAsk; }
            set { mControlGpAsk = value; }
        }
        [DataMember]
        public string ControlGpName
        {
            get { return mControlGpName; }
            set { mControlGpName = value; }

        }
        [DataMember]
        public string ControlGpDesc
        {
            get { return mControlGpDesc; }
            set { mControlGpDesc = value; }
        }
       
        
        
        #endregion
     
        
        
        #region"Default Property"
        public void setDefaultValue()
        {
            mControlGpAsk = "";
            mControlGpName = "";
            mControlGpDesc = "";
        }
        #endregion
    }
}