using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysControlJson
    {
        public SysControlJson()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mControlAsk;
        private string mControlName;
        private string mControlUrl;
        private string mUserAsk;
        private string mMenuAsk;
        private string mProductAsk;

        #endregion
        #region "public member"
        [DataMember]
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
        [DataMember]
        public string MenuAsk
        {
            get { return mMenuAsk; }
            set { mMenuAsk = value; }
        }
        [DataMember]
        public string ProductAsk
        {
            get { return mProductAsk; }
            set { mProductAsk = value; }
        }
        [DataMember]
        public string UserAsk
        {
            get { return mUserAsk; }
            set { mUserAsk = value; }
        }

        #endregion



        #region"Default Property"
        public void setDefaultValue()
        {
            mControlAsk = "0";
            mControlName = "";
            mControlUrl = "";
            mMenuAsk = "0";
            mProductAsk = "0";
            mUserAsk = "0";
        }
        #endregion
    }
}