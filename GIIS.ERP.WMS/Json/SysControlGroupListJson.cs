using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysControlGroupListJson
    {
        public SysControlGroupListJson()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mControlGpAsk;
        private string mControlGpName;
        private string mControlGpDesc;
        private string mControlAsk;
        private string mControlName;
        private string mControlUrl;
       
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
        public string ControlAsk
        {
            get { return mControlAsk; }
            set { mControlAsk = value; }
        }
        [DataMember]
        public string ControlName
        {
            get { return mControlName; }
            set { mControlName = value; }

        }
        [DataMember]
        public string ControlUrl
        {
            get { return mControlUrl; }
            set { mControlUrl = value; }
        }

        #endregion



        #region"Default Property"
        public void setDefaultValue()
        {
            mControlGpAsk = "";
            mControlGpName = "";
            mControlGpDesc = "";
            mControlAsk = "";
            mControlName = "";
            mControlUrl = "";
        }
        #endregion
    }
}