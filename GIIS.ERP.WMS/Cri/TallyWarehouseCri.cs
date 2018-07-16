using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class TallyWarehouseCri
    {
        public TallyWarehouseCri()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mUserID;
        private string mPassword;
        private String mProductAsk;
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mShippingMark;
        private string mDocNo;
        private string mTruckID;
        private string mTruckTypeAsk;
        private string mSKUID;
        private string mSKUDetails;
        private string mDimensionWeight;
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
        private string mBookingTS;
        private string mBookingUD;
        private string mBookingID;
        private string mShipper;
        private string mCountryAsk;
        private string mCargoReceivedDate;
        private string mCustomIssuedDate;
        private string mBookingStatusAsk;
        private string mNoOfTruck;
        private string mNoOfContainer;
        private string mBookingDisplaySequence;
        private string mBookingRemark;

        private string mAgentAsk;
        private string mAgentTS;
        private string mAgentUD;
        private string mAgentName;
        private string mAgentDetails;
        private string mNationalID;
        private string mBillingAddress;
        private string mShippingAddress;
        private string mCompanyName;
        private string mWebsite;
        private string mMobile;
        private string mEmail;
        private string mContactPersonName;
        private string mContactPersonMobile;
        private string mAddress;
        private string mAgentStatus;
        private string mAgentDisplaySequence;
        private string mAgentRemark;


        private string mShipperAsk;
        private string mShipperTS;
        private string mShipperUD;
        private string mShipperName;
        private string mShipperDetails;
        private string mShipperStatus;
        private string mShipperDisplaySequence;
        private string mShipperRemark;

        #endregion
        #region "public member"
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
        public string ProductAsk
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
        public string DimensionWeight
        {
            get { return mDimensionWeight; }
            set { mDimensionWeight = value; }

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
        public string BookingTS
        {
            get { return mBookingTS; }
            set { mBookingTS = value; }

        }
        [DataMember]
        public string BookingUD
        {
            get { return mBookingUD; }
            set { mBookingUD = value; }

        }
        [DataMember]
        public string BookingID
        {
            get { return mBookingID; }
            set { mBookingID = value; }

        }
        [DataMember]
        public string Shipper
        {
            get { return mShipper; }
            set { mShipper = value; }

        }
        [DataMember]
        public string CountryAsk
        {
            get { return mCountryAsk; }
            set { mCountryAsk = value; }

        }
        [DataMember]
        public string CargoReceivedDate
        {
            get { return mCargoReceivedDate; }
            set { mCargoReceivedDate = value; }

        }
        [DataMember]
        public string CustomIssuedDate
        {
            get { return mCustomIssuedDate; }
            set { mCustomIssuedDate = value; }

        }
        [DataMember]
        public string BookingStatusAsk
        {
            get { return mBookingStatusAsk; }
            set { mBookingStatusAsk = value; }

        }
        [DataMember]
        public string NoOfTruck
        {
            get { return mNoOfTruck; }
            set { mNoOfTruck = value; }

        }
        [DataMember]
        public string NoOfContainer
        {
            get { return mNoOfContainer; }
            set { mNoOfContainer = value; }

        }
        [DataMember]
        public string BookingDisplaySequence
        {
            get { return mBookingDisplaySequence; }
            set { mBookingDisplaySequence = value; }

        }
        [DataMember]
        public string BookingRemark
        {
            get { return mBookingRemark; }
            set { mBookingRemark = value; }

        }
        [DataMember]
        public string AgentAsk
        {
            get { return mAgentAsk; }
            set { mAgentAsk = value; }

        }
        [DataMember]
        public string AgentTS
        {
            get { return mAgentTS; }
            set { mAgentTS = value; }

        }
        [DataMember]
        public string AgentUD
        {
            get { return mAgentUD; }
            set { mAgentUD = value; }

        }
        [DataMember]
        public string AgentName
        {
            get { return mAgentName; }
            set { mAgentName = value; }

        }
        [DataMember]
        public string AgentDetails
        {
            get { return mAgentDetails; }
            set { mAgentDetails = value; }

        }
        [DataMember]
        public string NationalID
        {
            get { return mNationalID; }
            set { mNationalID = value; }

        }
        [DataMember]
        public string BillingAddress
        {
            get { return mBillingAddress; }
            set { mBillingAddress = value; }

        }
        [DataMember]
        public string ShippingAddress
        {
            get { return mShippingAddress; }
            set { mShippingAddress = value; }

        }
        [DataMember]
        public string CompanyName
        {
            get { return mCompanyName; }
            set { mCompanyName = value; }

        }
        [DataMember]
        public string Website
        {
            get { return mWebsite; }
            set { mWebsite = value; }

        }
        [DataMember]
        public string Mobile
        {
            get { return mMobile; }
            set { mMobile = value; }

        }
        [DataMember]
        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }

        }
        [DataMember]
        public string ContactPersonName
        {
            get { return mContactPersonName; }
            set { mContactPersonName = value; }

        }
        [DataMember]
        public string ContactPersonMobile
        {
            get { return mContactPersonMobile; }
            set { mContactPersonMobile = value; }

        }
        [DataMember]
        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }

        }
        [DataMember]
        public string AgentStatus
        {
            get { return mAgentStatus; }
            set { mAgentStatus = value; }

        }
        [DataMember]
        public string AgentDisplaySequence
        {
            get { return mAgentDisplaySequence; }
            set { mAgentDisplaySequence = value; }

        }
        [DataMember]
        public string AgentRemark
        {
            get { return mAgentRemark; }
            set { mAgentRemark = value; }

        }

        [DataMember]
        public string ShipperAsk
        {
            get { return mShipperAsk; }
            set { mShipperAsk = value; }
        }
        [DataMember]
        public string ShipperTS
        {
            get { return mShipperTS; }
            set { mShipperTS = value; }
        }
        [DataMember]
        public string ShipperUD
        {
            get { return mShipperUD; }
            set { mShipperUD = value; }
        }
        [DataMember]
        public string ShipperName
        {
            get { return mShipperName; }
            set { mShipperName = value; }
        }
        [DataMember]
        public string ShipperDetails
        {
            get { return mShipperDetails; }
            set { mShipperDetails = value; }
        }
        [DataMember]
        public string ShipperStatus
        {
            get { return mShipperStatus; }
            set { mShipperStatus = value; }
        }
        [DataMember]
        public string ShipperDisplaySequence
        {
            get { return mShipperDisplaySequence; }
            set { mShipperDisplaySequence = value; }
        }
        [DataMember]
        public string ShipperRemark
        {
            get { return mShipperRemark; }
            set { mShipperRemark = value; }
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
            mShippingMark = "";
            mDocNo = "";
            mTruckID = "";
            mTruckTypeAsk = "0";
            mSKUID = "";
            mSKUDetails = "";
            mDimensionWeight = "0";
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
            mBookingTS = "0";
            mBookingUD = "0";
            mBookingID = "";           
            mShipper = "";
            mCountryAsk = "0";
            mCargoReceivedDate = "";
            mCustomIssuedDate = "";
            mBookingStatusAsk = "0";
            mNoOfTruck = "0";
            mNoOfContainer = "0";
            mBookingStatusAsk = "0";
            mBookingDisplaySequence = "0";
            mBookingRemark = "0";

            mAgentAsk = "0";
            mAgentTS = "0";
            mAgentUD = "0";
            mAgentName = "";
            mAgentDetails = "";
            mNationalID = "";
            mBillingAddress = "";
            mShippingAddress = "";
            mCompanyName = "";
            mWebsite = "";
            mMobile = "";
            mEmail = "";
            mContactPersonName = "";
            mContactPersonMobile = "";
            mAddress = "";
            mAgentStatus = "0";
            mAgentDisplaySequence = "0";
            mAgentRemark = "";

            mShipperAsk = "0";
            mShipperTS = "0";
            mShipperUD = "0";
            mShipperName = "";
            mShipperDetails = "";
            mShipperStatus = "0";
            mShipperDisplaySequence = "0";
            mShipperRemark = "";
        }
        #endregion
    }
}