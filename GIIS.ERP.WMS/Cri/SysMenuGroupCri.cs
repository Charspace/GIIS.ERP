using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysMenuGroupCri
    {
        public SysMenuGroupCri()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mMenuGpAsk;
        private string mTS;
        private string mUD;
        private string mDisplaySequence;
        private string mRemark;
        private string mUser;
        private string mPWD;
        
        private string mMenuGpName;
        private string mMenuGpDesc;
        private string mMenuAsk;
        private string mMenuName;
        private string mMenuUrl;
        private List<SysMenuCri> mMenuList;

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
        public string TS
        {
            get { return mTS; }
            set { mTS = value; }
        }
        [DataMember]
        public string UD
        {
            get { return mUD; }
            set { mUD = value; }
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
        public string MenuGpAsk
        {
            get { return mMenuGpAsk; }
            set { mMenuGpAsk = value; }
        }
        [DataMember]
        public string MenuGpName
        {
            get { return mMenuGpName; }
            set { mMenuGpName = value; }
        }
        [DataMember]
        public string MenuGpDesc
        {
            get { return mMenuGpDesc; }
            set { mMenuGpDesc = value; }
        }
        [DataMember]
        public string MenuAsk
        {
            get { return mMenuAsk; }
            set { mMenuAsk = value; }
        }
        [DataMember]
        public string MenuName
        {
            get { return mMenuName; }
            set { mMenuName = value; }
        }
        [DataMember]
        public string MenuUrl
        {
            get { return mMenuUrl; }
            set { mMenuUrl = value; }
        }
        [DataMember]
        public List<SysMenuCri> MenuList
        {
            get { return mMenuList; }
            set { mMenuList = value; }
        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mUser = "";
            mPWD = "";
            mMenuGpAsk = "";
            mMenuGpName = "";
            mMenuGpDesc = "";
            mMenuAsk = "";
            mMenuName = "";
            mMenuUrl = "";

        }
        #endregion
    }
}