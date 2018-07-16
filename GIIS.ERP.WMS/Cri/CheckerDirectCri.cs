using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace GIIS.ERP.WMS
{
    public class CheckerDirectCri
    {
        public CheckerDirectCri()
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
        private string mBookingAsk;
        private string mAgentAsk;
        private string mShipperAsk;
        private string mContainerAsk;
        private string mSKUAsk;
        private string mDimensionWidth;
        private string mDimensionHeight;
        private string mDimensionBase;
        private string mSKUWeight;
        private string mReceivedQty;
        private string mUOMAsk;
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
        public string BookingAsk
        {
            get { return mBookingAsk; }
            set { mBookingAsk = value; }
        }
        [DataMember]
        public string AgentAsk
        {
            get { return mAgentAsk; }
            set { mAgentAsk = value; }
        }
        [DataMember]
        public string ShipperAsk
        {
            get { return mShipperAsk; }
            set { mShipperAsk = value; }
        }
        [DataMember]
        public string ContainerAsk
        {
            get { return mContainerAsk; }
            set { mContainerAsk = value; }
        }
        [DataMember]
        public string SKUAsk
        {
            get { return mSKUAsk; }
            set { mSKUAsk = value; }
        }
        [DataMember]
        public string DimensionWidth
        {
            get { return mDimensionWidth; }
            set { mDimensionWidth = value; }
        }
        [DataMember]
        public string DimensionHeight
        {
            get { return mDimensionHeight; }
            set { mDimensionHeight = value; }
        }
        [DataMember]
        public string DimensionBase
        {
            get { return mDimensionBase; }
            set { mDimensionBase = value; }
        }
        [DataMember]
        public string SKUWeight
        {
            get { return mSKUWeight; }
            set { mSKUWeight = value; }
        }
        [DataMember]
        public string ReceivedQty
        {
            get { return mReceivedQty; }
            set { mReceivedQty = value; }
        }
        [DataMember]
        public string UOMAsk
        {
            get { return mUOMAsk; }
            set { mUOMAsk = value; }
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
            mSKUAsk = "0";
            mBookingAsk = "0";
            mAgentAsk = "0";
            mShipperAsk = "0";
            mContainerAsk = "0";
            mDimensionWidth = "0";
            mDimensionHeight = "0";
            mDimensionBase = "0";
            mSKUWeight = "0";
            mReceivedQty = "0";
            mUOMAsk = "0";
            mStatus = "0";
            mDisplaySequence = "0";
            mRemark = "";

        }
        #endregion
    }
}
