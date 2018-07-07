using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using CHARS.HR.COMMON.BOL;

namespace GIIS.ERP.WMS
{
    public class LoginCri
    {
        public LoginCri()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mUser;
        private string mPWD;
        private string mProductAsk;
        
        private string mDeviceName;
        private string mLoginDateTime;
        private string mLoginBrowserType;
        private string mIPAdress;
            

        #endregion
        #region "public member"
        [DataMember]
        public string UserID
        {
            get { return mUser; }
            set { mUser = value; }
        }
        [DataMember]
        public string Password
        {
            get { return mPWD; }
            set { mPWD = value; }
        }
        [DataMember]
        public string ProductAsk
        {
            get { return mProductAsk; }
            set { mProductAsk = value; }
        }
        [DataMember]
        public string DeviceName
        {
            get { return mDeviceName; }
            set { mDeviceName = value; }
        }
        [DataMember]
        public string LoginDateTime
        {
            get { return mLoginDateTime; }
            set { mLoginDateTime = value; }
        }
        [DataMember]
        public string LoginBrowserType
        {
            get { return mLoginBrowserType; }
            set { mLoginBrowserType = value; }
        }
            [DataMember]
            public string IPAdress
        {
            get { return mIPAdress; }
            set { mIPAdress = value; }
        }
    
    #endregion
    #region"Default Property"
    public void setDefaultValue()
    {
        mUser = "";
        mPWD = "";
        mProductAsk = "0";
        mDeviceName = "";
        mLoginDateTime = "";
        mLoginBrowserType = "";
        mIPAdress = "";

    }
        #endregion
    }
}