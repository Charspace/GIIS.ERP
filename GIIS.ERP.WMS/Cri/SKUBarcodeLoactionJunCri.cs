using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SKUBarcodeLocationJunCri
    {
        public SKUBarcodeLocationJunCri()
        {
            setDefaultValue();
        }
        #region"Private Property"
        private string mUserID;
        private string mPassword;
        private string mProductAsk;

        private string mAsk;
        private string mTS;
        private string mUD;
        private string mSKUBarcodeAsk;
        private string mLocationAsk;
        private string mPalletAsk;
        private string mStatus;
        private string mDisplaySequence;
        private string mRemark;


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
        public string Ask
        {
            get { return mAsk; }
            set { mAsk = value; }
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
        public string SKUBarcodeAsk
        {
            get { return mSKUBarcodeAsk; }
            set { mSKUBarcodeAsk = value; }
        }
        [DataMember]
        public string LocationAsk
        {
            get { return mLocationAsk; }
            set { mLocationAsk = value; }
        }
        [DataMember]
        public string PalletAsk
        {
            get { return mPalletAsk; }
            set { mPalletAsk = value; }
        }

        [DataMember]
        public string Status
        {
            get { return mStatus; }
            set { mStatus = value; }
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
        

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mUserID = "";
            mPassword = "";
            mProductAsk = "0";

            mAsk = "0";
            mTS = "0";
            mUD = "0";
            mSKUBarcodeAsk = "0";
            mLocationAsk = "0";
            mPalletAsk = "0";
            
            mStatus = "0";
            mDisplaySequence = "0";
            mRemark = "";
            
        }
        #endregion
    }
}
