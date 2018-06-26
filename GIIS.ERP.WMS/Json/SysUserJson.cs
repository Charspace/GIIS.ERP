using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysUserJson
    {
        public SysUserJson()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mDisplaySequence;
        private string mRemark;
        private string mUser;
        private string mPWD;

        private string mUserAsk;
        private string mUserID;
        private string mUserDesc;
        private string mUserEmail;
        private string mUserPhone;


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
        public string Ask
        {
            get { return mUserAsk; }
            set { mUserAsk = value; }
        }
        [DataMember]
        public string UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }
        [DataMember]
        public string UserDesc
        {
            get { return mUserDesc; }
            set { mUserDesc = value; }
        }
        [DataMember]
        public string UserEmail
        {
            get { return mUserEmail; }
            set { mUserEmail = value; }
        }
        [DataMember]
        public string UserPhone
        {
            get { return mUserPhone; }
            set { mUserPhone = value; }
        }

        #endregion



        #region"Default Property"
        public void setDefaultValue()
        {
            mUser = "";
            mPWD = "";
            mUserAsk = "";
            mUserID = "";
            mUserDesc = "";
            mUserPhone = "";
            mUserEmail = "";
        }
        #endregion
    }
}