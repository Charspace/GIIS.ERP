using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysMenuCri
    {
        public SysMenuCri()
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
        private string mMenuAsk;
        private string mMenuName;
        

        #endregion
        #region "public member"
        [DataMember]
        public string Ask
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

        
        
        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mMenuName = "";
            mMenuAsk = "";
        }
        #endregion
    }
}