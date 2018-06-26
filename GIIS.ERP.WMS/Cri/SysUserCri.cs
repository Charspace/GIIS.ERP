using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using CHARS.HR.COMMON.BOL;

namespace GIIS.ERP.WMS
{
    public class SysUserCri
    {
        public SysUserCri()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mUserAsk;
        private string mDisplaySequence;
        private string mRemark;
        private string mUser;
        private string mPWD;
        
        private string mUserID;
        private string mUserDesc;
        private string mUserEmail;
        private string mUserPhone;

        private string mMenuGroupAsk;
        private string mMenuGroupName;
        private string mMenuGroupDesc;

        private string mControlGroupAsk;
        private string mControlGroupName;
        private string mControlGroupDesc;

        private string mProductAsk;
        private string mProductName;
        private string mProductDesc;

        private List<SysMenuGroup> mMenuGroupList;
        private List<ControlGroup> mControlGroupList;
        private List<Product> mProductList;

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
        [DataMember]
        public string MenuGroupAsk
        {
            get { return mMenuGroupAsk; }
            set { mMenuGroupAsk = value; }
        }
        [DataMember]
        public string MenuGroupName
        {
            get { return mMenuGroupName; }
            set { mMenuGroupName = value; }
        }
        [DataMember]
        public string MenuGroupDesc
        {
            get { return mMenuGroupDesc; }
            set { mMenuGroupDesc = value; }
        }
        [DataMember]
        public string ControlGroupAsk
        {
            get { return mControlGroupAsk; }
            set { mControlGroupAsk = value; }
        }
        [DataMember]
        public string ControlGroupName
        {
            get { return mMenuGroupName; }
            set { mControlGroupName = value; }
        }
        [DataMember]
        public string ControlGroupDesc
        {
            get { return mControlGroupDesc; }
            set { mControlGroupDesc = value; }
        }
        [DataMember]
        public string ProductAsk
        {
            get { return mProductAsk; }
            set { mProductAsk = value; }
        }
        [DataMember]
        public string ProductName
        {
            get { return mProductName; }
            set { mProductName = value; }
        }
        [DataMember]
        public string ProductDesc
        {
            get { return mProductDesc; }
            set { mProductDesc = value; }
        }
        [DataMember]
        public List<SysMenuGroup> MenuGroupList
        {
            get { return mMenuGroupList; }
            set { mMenuGroupList = value; }
        }
        [DataMember]
        public List<ControlGroup> ControlGroupList
        {
            get { return mControlGroupList; }
            set { mControlGroupList = value; }
        }
        [DataMember]
        public List<Product> ProductList
        {
            get { return mProductList; }
            set { mProductList = value; }
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
            mMenuGroupAsk = "";
            mMenuGroupName = "";
            mMenuGroupDesc = "";
            mControlGroupAsk = "";
            mControlGroupName = "";
            mControlGroupDesc = "";
            mProductAsk = "";
            mProductName = "";
            mProductDesc = "";
            mMenuGroupList = new List<SysMenuGroup>();
            mControlGroupList = new List<ControlGroup>();
            mProductList = new List<Product>();

        }
        #endregion
    }
}