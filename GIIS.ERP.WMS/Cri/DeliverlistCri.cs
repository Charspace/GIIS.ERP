using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class DeliverlistCri

    {
        public DeliverlistCri()
        {
            setDefaultValue();
        }
         #region"Private Property"

        private string mUserID;
        private string mPassword;
        private string mProductAsk;

        private string mContainerAsk;
        private string mPicklistAsk;
        private string mLocationPicklistJunAsk;
        private string mSKUBarcodeLocationJunAsk;
             

    #endregion
    #region"Public Property"
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
        [DataMember]
        public String ContainerAsk
        {
            get { return mContainerAsk; }
            set { mContainerAsk = value; }

        }
        [DataMember]
        public String PicklistAsk
        {
            get { return mPicklistAsk; }
            set { mPicklistAsk = value; }

        }
        [DataMember]
        public String LocationPicklistJunAsk
        {
            get { return mLocationPicklistJunAsk; }
            set { mLocationPicklistJunAsk = value; }

        }
        [DataMember]
        public String SKUBarcodeLocationJunAsk
        {
            get { return mSKUBarcodeLocationJunAsk; }
            set { mSKUBarcodeLocationJunAsk = value; }

        }


        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mUserID = "";
            mPassword = "";
            mProductAsk = "0";
            mContainerAsk = "0";
            mPicklistAsk = "0";
            mLocationPicklistJunAsk = "0";
            mSKUBarcodeLocationJunAsk = "0";

        }
        #endregion
    }
}

