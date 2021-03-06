﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysMenuGroupJson
    {
        public SysMenuGroupJson()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mMenuGpAsk;
        private string mMenuGpName;
        private string mMenuGpDesc;
       
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
        
        #endregion
     
        
        
        #region"Default Property"
        public void setDefaultValue()
        {
            mMenuGpAsk = "";
            mMenuGpName = "";
            mMenuGpDesc = "";
        }
        #endregion
    }
}