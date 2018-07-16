using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class AllocatonWarehouseCri
    {
        public AllocatonWarehouseCri()
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
        private string mShipperTS;
        private string mShippterUD;
        private string mShipperName;
        private string mShipperDetails;
        private string mShipperStatus;
        private string mShipperDisplaySequence;
        private string mShipperRemark;

        private string mTruckAsk;
        private string mTruckTS;
        private string mTruckUD;
        private string mTruckID;
        private string mTruckTypeAsk;
        private string mTruckStatus;
        private string mTruckDisplaySequence;
        private string mTruckRemark;


        private string mPOAsk;
        private string mPOTS;
        private string mPOUD;
        private string mPONo;
        private string mPOShippingMark;
        private string mPOReferenceNo;
        private string mPODisplaySequence;
        private string mPOStatus;        
        private string mPORemark;


        private string mSKUAsk;
        private string mSKUTS;
        private string mSKUUD;
        private string mSKUName;
        private string mSKUDetails;
        private string mSKUDimensionWidth;
        private string mSKUDimensionHeight;
        private string mSKUDimensionBase;
        private string mSKUWeight;
        private string mSKUPlanQty;
        private string mSKUUOMAsk;
        private string mSKUReceivedQty;
        private string mSKUReference;       
        private string mSKUTruckType;
        private string mSKUGoodQty;
        private string mSKUDamageQty;
        private string mSKUShortLandQty;
        private string mSKUOverlandQty;
        private string mSKUStatus;
        private string mSKUDisplaySequence;
        private string mSKURemark;

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
        public string SignatureDate
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
        public string ShipperTS
        {
            get { return mShipperTS; }
            set { mShipperTS = value; }

        }
        [DataMember]
        public string ShippterUD
        {
            get { return mShippterUD; }
            set { mShippterUD = value; }

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
        [DataMember]
        public string TruckAsk
        {
            get { return mTruckAsk; }
            set { mTruckAsk = value; }
        }
        [DataMember]
        public string TruckTS
        {
            get { return mTruckTS; }
            set { mTruckTS = value; }
        }
        [DataMember]
        public string TruckUD
        {
            get { return mTruckUD; }
            set { mTruckUD = value; }
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
        public string TruckStatus
        {
            get { return mTruckStatus; }
            set { mTruckStatus = value; }
        }
        [DataMember]
        public string TruckDisplaySequence
        {
            get { return mTruckDisplaySequence; }
            set { mTruckDisplaySequence = value; }
        }
        [DataMember]
        public string TruckRemark
        {
            get { return mTruckRemark; }
            set { mTruckRemark = value; }
        }
        [DataMember]
        public string POAsk
        {
            get { return mPOAsk; }
            set { mPOAsk = value; }
        }
        [DataMember]
        public string POTS
        {
            get { return mPOTS; }
            set { mPOTS = value; }
        }
        [DataMember]
        public string POUD
        {
            get { return mPOUD; }
            set { mPOUD = value; }
        }
        [DataMember]
        public string PONo
        {
            get { return mPONo; }
            set { mPONo = value; }
        }
        [DataMember]
        public string POShippingMark
        {
            get { return mPOShippingMark; }
            set { mPOShippingMark = value; }
        }
        [DataMember]
        public string POReferenceNo
        {
            get { return mPOReferenceNo; }
            set { mPOReferenceNo = value; }
        }
        [DataMember]
        public string POStatus
        {
            get { return mPOStatus; }
            set { mPOStatus = value; }
        }
        [DataMember]
        public string PODisplaySequence
        {
            get { return mPODisplaySequence; }
            set { mPODisplaySequence = value; }
        }
        [DataMember]
        public string PORemark
        {
            get { return mPORemark; }
            set { mPORemark = value; }
        }
        [DataMember]
        public string SKUAsk
        {
            get { return mSKUAsk; }
            set { mSKUAsk = value; }
        }
        [DataMember]
        public string SKUTS
        {
            get { return mSKUTS; }
            set { mSKUTS = value; }
        }
        [DataMember]
        public string SKUUD
        {
            get { return mSKUUD; }
            set { mSKUUD = value; }
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
        public string SKUDimensionWidth
        {
            get { return mSKUDimensionWidth; }
            set { mSKUDimensionWidth = value; }
        }
        [DataMember]
        public string SKUDimensionHeight
        {
            get { return mSKUDimensionHeight; }
            set { mSKUDimensionHeight = value; }
        }
        [DataMember]
        public string SKUDimensionBase
        {
            get { return mSKUDimensionBase; }
            set { mSKUDimensionBase = value; }
        }
        [DataMember]
        public string SKUWeight
        {
            get { return mSKUWeight; }
            set { mSKUWeight = value; }
        }
        [DataMember]
        public string SKUPlanQty
        {
            get { return mSKUPlanQty; }
            set { mSKUPlanQty = value; }
        }
        [DataMember]
        public string SKUUOMAsk
        {
            get { return mSKUUOMAsk; }
            set { mSKUUOMAsk = value; }
        }
        [DataMember]
        public string SKUReceivedQty
        {
            get { return mSKUReceivedQty; }
            set { mSKUReceivedQty = value; }
        }
        [DataMember]
        public string SKUReference
        {
            get { return mSKUReference; }
            set { mSKUReference = value; }
        }
       
        [DataMember]
        public string SKUTruckType
        {
            get { return mSKUTruckType; }
            set { mSKUTruckType = value; }
        }
        [DataMember]
        public string SKUGoodQty
        {
            get { return mSKUGoodQty; }
            set { mSKUGoodQty = value; }
        }
        [DataMember]
        public string SKUDamageQty
        {
            get { return mSKUDamageQty; }
            set { mSKUDamageQty = value; }
        }
        [DataMember]
        public string SKUShortLandQty
        {
            get { return mSKUShortLandQty; }
            set { mSKUShortLandQty = value; }
        }
        [DataMember]
        public string SKUOverlandQty
        {
            get { return mSKUOverlandQty; }
            set { mSKUOverlandQty = value; }
        }
        [DataMember]
        public string SKUStatus
        {
            get { return mSKUStatus; }
            set { mSKUStatus = value; }

        }
        [DataMember]
        public string SKUDisplaySequence
        {
            get { return mSKUDisplaySequence; }
            set { mSKUDisplaySequence = value; }
        }
        [DataMember]
        public string SKURemark
        {
            get { return mSKURemark; }
            set { mSKURemark = value; }
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
            mShipperTS = "0";
            mShippterUD = "0";
            mShipperName = "";
            mShipperDetails = "";
            mShipperStatus = "0";
            mShipperDisplaySequence = "0";
            mShipperRemark = "";

            mTruckAsk = "0";
            mTruckTS = "0";
            mTruckUD = "0";
            mTruckID = "";
            mTruckTypeAsk = "0";
            mTruckStatus = "0";
            mTruckDisplaySequence = "0";
            mTruckRemark = "";

            mPOAsk = "0";
            mPOTS = "0";
            mPOUD = "0";
            mPONo = "";
            mPOShippingMark = "";
            mPOReferenceNo = "";
            mPOStatus = "0";
            mPODisplaySequence = "0";
            mPORemark = "0";

            mSKUAsk = "0";
            mSKUTS = "0";
            mSKUUD = "0";
            mSKUName = "";
            mSKUDetails = "";
            mSKUDimensionWidth = "0";
            mSKUDimensionHeight = "0";
            mSKUDimensionBase = "0";
            mSKUWeight = "0";
            mSKUPlanQty = "0";
            mSKUUOMAsk = "0";
            mSKUReceivedQty = "";
            mSKUReference = "";
            mSKUTruckType = "";
            mSKUGoodQty = "";
            mSKUDamageQty = "";
            mSKUShortLandQty = "";
            mSKUOverlandQty = "";
            mSKUStatus = "0";
            mSKUDisplaySequence = "0";
            mRemark = "0";
            mTruckAsk = "0";
            mPOAsk = "0";
            mSKUAsk = "0";
            mShipperList = new List<ShipperCri>();
           
        }
        #endregion
    }
}