using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class PRFEWarehouseCri
    {
        public PRFEWarehouseCri()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mUserID;
        private string mPassword;
        private string mProductAsk;
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mBookingID;
        private string mAgentAsk;
        private string mShipper;
        private string mCountryAsk;
        private string mCargoReceivedDate;
        private string mCustomIssuedDate;
        private string mTransactionDate;
        private string mSignature;
        private string mSignatureDate;
        private string mBookingStatusAsk;
        private string mNoOfTruck;
        private string mNoOfContainer;
        private string mDisplaySequence;
        private string mRemark;

        private string mShipperAsk;
        private string mShipperName;
        private string mShipperDetails;

        private string mTruckAsk;
        private string mTruckID;
        private string mTruckTypeAsk;

        private string mPOAsk;
        private string mPONo;
        private string mShippingMark;
        private string mReferenceNo;

        private string mSKUAsk;
        private string mSKUName;
        private string mSKUDetails;
        private string mDimensionWidth;
        private string mDimensionHeight;
        private string mDimensionBase;
        private string mSKUWeight;
        private string mPlanQty;
        private string mUOMAsk;
        private string mReceivedQty;
        private string mReference;       
        private string mTruckType;
        private string mGoodQty;
        private string mDamageQty;
        private string mShortLandQty;
        private string mOverlandQty;

        private List<ShipperCri> mShipperList;
        
       

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
        public string BookingID
        {
            get { return mBookingID; }
            set { mBookingID = value; }

        }
        [DataMember]
        public string AgentAsk
        {
            get { return mAgentAsk; }
            set { mAgentAsk = value; }

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
        public string SignatureDateSignature
        {
            get { return mSignatureDate; }
            set { mSignatureDate = value; }

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
        public List<ShipperCri> ShipperList
        {
            get { return mShipperList; }
            set { mShipperList = value; }

        }
        [DataMember]
        public string ShipperAsk
        {
            get { return mShipperAsk; }
            set { mShipperAsk = value; }
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
        public string TruckAsk
        {
            get { return mTruckAsk; }
            set { mTruckAsk = value; }
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
        public string POAsk
        {
            get { return mPOAsk; }
            set { mPOAsk = value; }
        }
        [DataMember]
        public string PONo
        {
            get { return mPONo; }
            set { mPONo = value; }
        }
        [DataMember]
        public string ShippingMark
        {
            get { return mShippingMark; }
            set { mShippingMark = value; }
        }
        [DataMember]
        public string ReferenceNo
        {
            get { return mReferenceNo; }
            set { mReferenceNo = value; }
        }
        [DataMember]
        public string SKUAsk
        {
            get { return mSKUAsk; }
            set { mSKUAsk = value; }
        }

        [DataMember]
        public string SKUName
        {
            get { return mSKUName; }
            set { mSKUName = value; }
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
        public string SKUWeight
        {
            get { return mSKUWeight; }
            set { mSKUWeight = value; }
        }
        [DataMember]
        public string PlanQty
        {
            get { return mPlanQty; }
            set { mPlanQty = value; }
        }
        [DataMember]
        public string UOMAsk
        {
            get { return mUOMAsk; }
            set { mUOMAsk = value; }
        }
        [DataMember]
        public string ReceivedQty
        {
            get { return mReceivedQty; }
            set { mReceivedQty = value; }
        }
        [DataMember]
        public string Reference
        {
            get { return mReference; }
            set { mReference = value; }
        }
       
        [DataMember]
        public string TruckType
        {
            get { return mTruckType; }
            set { mTruckType = value; }
        }
        [DataMember]
        public string GoodQty
        {
            get { return mGoodQty; }
            set { mGoodQty = value; }
        }
        [DataMember]
        public string DamageQty
        {
            get { return mDamageQty; }
            set { mDamageQty = value; }
        }
        [DataMember]
        public string ShortLandQty
        {
            get { return mShortLandQty; }
            set { mShortLandQty = value; }
        }
        [DataMember]
        public string OverlandQty
        {
            get { return mOverlandQty; }
            set { mOverlandQty = value; }
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
            mBookingID = "";
            mAgentAsk = "";
            mShipper = "";
            mCountryAsk = "0";
            mCargoReceivedDate = "";
            mCustomIssuedDate = "";
            mTransactionDate = "";
            mSignature = "";
            mSignatureDate = "";
            mBookingStatusAsk = "0";
            mNoOfTruck = "0";
            mNoOfContainer = "0";
            mBookingStatusAsk = "0";
            mDisplaySequence = "0";
            mRemark = "";

            mShipperAsk = "0";
            mShipperName = "";
            mShipperDetails = "";

            mTruckAsk = "0";
            mTruckID = "";
            mTruckTypeAsk = "0";

            mPOAsk = "0";
            mPONo = "";
            mShippingMark = "";
            mReferenceNo = "";

            mSKUAsk = "0";
            mSKUName = "";
            mSKUDetails = "";
            mDimensionWidth = "0";
            mDimensionHeight = "0";
            mDimensionBase = "0";
            mSKUWeight = "0";
            mPlanQty = "0";
            mUOMAsk = "0";
            mReceivedQty = "";
            mReference = "";           
            mTruckType = "";
            mGoodQty = "";
            mDamageQty = "";
            mShortLandQty = "";
            mOverlandQty = "";
            mTruckAsk = "0";
            mPOAsk = "0";
            mSKUAsk = "0";
            mShipperList = new List<ShipperCri>();
           
        }
        #endregion
    }
}