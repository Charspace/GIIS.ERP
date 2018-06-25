using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysMenuGroup
    {
        public SysMenuGroup()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mMenuGpAsk;
        private string mMenuGpName;
        private string mMenuGpDesc;
        private string mMenuAsk;
        private string mMenuName;
        private string mMenuUrl;


        #endregion
        #region "public member"
        [DataMember]

        public string MenuGpAsk
        {
            get { return mMenuGpAsk; }
            set { mMenuGpAsk = value; }
        }
        public string MenuGpName
        {
            get { return mMenuGpName; }
            set { mMenuGpName = value; }

        }

        public string MenuGpDesc
        {
            get { return mMenuGpDesc; }
            set { mMenuGpDesc = value; }
        }
        public string MenuUrl
        {
            get { return mMenuUrl; }
            set { mMenuUrl = value; }

        }

        public string MenuAsk
        {
            get { return mMenuAsk; }
            set { mMenuAsk = value; }
        }
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