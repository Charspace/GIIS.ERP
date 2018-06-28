using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysMenuJson
    {
        public SysMenuJson()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mMenuAsk;
        private string mMenuName;
        private string mSubMenuWidth;
        private string mParentID;

        #endregion
        #region "public member"
        [DataMember]
        public string ID
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
        public string SubMenuWidth
        {
            get { return mSubMenuWidth; }
            set { mSubMenuWidth = value; }
        }
        [DataMember]
        public string ParentID
        {
            get { return mParentID; }
            set { mParentID = value; }
        }
        


        #endregion



        #region"Default Property"
        public void setDefaultValue()
        {
            mMenuName = "";
            mMenuAsk = "";
            mSubMenuWidth = "";
            mParentID = "";
        }
        #endregion
    }
}