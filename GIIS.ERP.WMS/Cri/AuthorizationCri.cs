using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class AuthorizationCri
    {
        public AuthorizationCri()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mUserID;
        private string mPassword;
        private string mProductAsk;
       
        #endregion
        #region "public member"
       
        [DataMember]
        public string UserID
        {
            get { return mUserID; }
            set { mUserID = value; }

        }
        [DataMember]
        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }

        }
        [DataMember]
        public String ProductAsk
        {
            get { return mProductAsk; }
            set { mProductAsk = value; }

        }


        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mUserID = "";
            mPassword = "";
            mProductAsk = "0";
        }
        #endregion
    }
}