using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class Message
    {
        public Message()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mCode;
        private string mDetail;
                
        #endregion
        #region "public member"
        [DataMember]

        public string Code
        {
            get { return mCode; }
            set { mCode = value; }
        }
        public string Detail
        {
            get { return mDetail; }
            set { mDetail = value; }

        }
             
        #endregion
     
        
        
        #region"Default Property"
        public void setDefaultValue()
        {
            mCode = "";
            mDetail = "";
        }
        #endregion
    }
}