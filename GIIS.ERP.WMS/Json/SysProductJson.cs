using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysProductJson
    {
        public SysProductJson()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mProductAsk;
        private string mProductName;
        private string mProductDesc;
       
        #endregion
        #region "public member"
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
        
        
        #endregion
     
        
        
        #region"Default Property"
        public void setDefaultValue()
        {
            mProductAsk = "";
            mProductName = "";
            mProductDesc = "";
        }
        #endregion
    }
}