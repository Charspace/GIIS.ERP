using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class TallyJson
    {
        public TallyJson()
        {
            setDefaultValue();
        }

        #region "private member"
        
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mShippingMark;
        private string mDocNo;
        private string mTruckID;
        private string mTruckTypeAsk;
        private string mSKUID;
        private string mSKUDetails;
        private string mDimensionWidth;
        private string mDimensionHeight;
        private string mDimensionBase;
        private string mReceivedQty;
        private string mUOMAsk;
        private string mTallyCheckDate;
        private string mTallyReceiveDate;
        private string mTransactionDate;
        private string mSignature;
        private string mSignatureDate;
        private string mStatus;
        private string mDisplaySequence;
        private string mRemark;
        private string mBookingAsk;
        private string mAgentAsk;
        private string mShipperAsk;

        #endregion
        #region "public member"

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
        public string ShippingMark
        {
            get { return mShippingMark; }
            set { mShippingMark = value; }

        }
        [DataMember]
        public string DocNo
        {
            get { return mDocNo; }
            set { mDocNo = value; }

        }
        [DataMember]
        public string TruckID
        {
            get { return mTruckID; }
            set { mTruckID = value; }

        }
        [DataMember]
        public string TruckTypeAsk
        {
            get { return mTruckTypeAsk; }
            set { mTruckTypeAsk = value; }

        }
        [DataMember]
        public string SKUID
        {
            get { return mSKUID; }
            set { mSKUID = value; }

        }
        [DataMember]
        public string SKUDetails
        {
            get { return mSKUDetails; }
            set { mSKUDetails = value; }

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
        public string TallyCheckDate
        {
            get { return mTallyCheckDate; }
            set { mTallyCheckDate = value; }

        }
        [DataMember]
        public string TallyReceiveDate
        {
            get { return mTallyReceiveDate; }
            set { mTallyReceiveDate = value; }

        }
        [DataMember]
        public string TransactionDate
        {
            get { return mTransactionDate; }
            set { mTransactionDate = value; }

        }
        [DataMember]
        public string Signature
        {
            get { return mSignature; }
            set { mSignature = value; }

        }
        [DataMember]
        public string SignatureDate
        {
            get { return mSignatureDate; }
            set { mSignatureDate = value; }

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

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            
            mAsk = "0";
            mTS = "0";
            mUD = "0";
            mShippingMark = "";
            mDocNo = "";
            mTruckID = "";
            mTruckTypeAsk = "0";
            mSKUID = "";
            mSKUDetails = "";
            mDimensionWidth = "0";
            mDimensionHeight = "0";
            mDimensionBase = "0";
            mReceivedQty = "0";
            mUOMAsk = "0";
            mTallyCheckDate = "";
            mTallyReceiveDate = "";
            mTransactionDate = "";
            mSignature = "";
            mSignatureDate = "";
            mStatus = "0";
            mDisplaySequence = "0";
            mRemark = "";
            mBookingAsk = "0";           
            mAgentAsk = "0";
            mShipperAsk = "0";

        }
        #endregion
    }
}