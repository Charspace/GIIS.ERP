using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysMenuGroupListJson
    {
        public SysMenuGroupListJson()
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

        #endregion



        #region"Default Property"
        public void setDefaultValue()
        {
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