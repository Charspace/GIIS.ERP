using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using CHARS.HR.COMMON.BOL;

namespace GIIS.ERP.WMS
{
    public class SysControlGroupCri
    {
        public SysControlGroupCri()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mControlGpAsk;
        private string mDisplaySequence;
        private string mRemark;
        private string mUser;
        private string mPWD;
        
        private string mControlGpName;
        private string mControlGpDesc;
        private string mControlAsk;
        private string mControlName;
        private string mControlUrl;
        private string mproductAsk;
      
        private List<SysControl> mControlList;

        #endregion
        #region "public member"
        [DataMember]
        public string User
        {
            get { return mUser; }
            set { mUser = value; }
        }
        [DataMember]
        public string PWD
        {
            get { return mPWD; }
            set { mPWD = value; }
        }
      
        [DataMember]
        public string DisplaySequence
        {
            get { return mDisplaySequence; }
            set { mDisplaySequence = value; }
        }
        [DataMember]
        public string Remark
        {
            get { return mRemark; }
            set { mRemark = value; }
        }

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
        public List<SysControl> ControlList
        {
            get { return mControlList; }
            set { mControlList = value; }
        }
        [DataMember]
        public string ProductAsk
        {
            get { return mproductAsk; }
            set { mproductAsk = value; }
        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mUser = "";
            mPWD = "";
            mControlGpAsk = "";
            mControlGpName = "";
            mControlGpDesc = "";
            mControlAsk = "";
            mControlName = "";
            mControlUrl = "";
            mControlList = new List<SysControl>();
            mproductAsk = "0";
        }
        #endregion
    }
}