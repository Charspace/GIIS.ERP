using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class PREFWarehouseDetailJson
    {
        public PREFWarehouseDetailJson()
        {
            setDefaultValue();
        }

        #region "private member"

       
        private string mBookingAsk;
        private string mBookingID;
        private string mAgentAsk;
        private string mShipper;
        private string mCountryAsk;
        private string mCargoReceivedDate;
        private string mCustomIssuedDate;
        private string mTransactionDate;
        private string mSignature;
        private string mSignatureDate;
        private string mNoOfTruck;
        private string mNoOfContainer;
        private string mBookingStatusAsk;
        private string mBookingRemark;

        private string mShipperAsk;
        private string mShipperName;
        private string mShipperDetails;

        private string mTruckAsk;
        private string mTruckID;
        private string mTruckTypeAsk;
        private string mTruckStatus;
        private string mTruckRemark;

        private string mPOAsk;
        private string mPONo;
        private string mPOShippingMark;
        private string mPOReferenceNo;
        private string mPOStatus;
        private string mPORemark;

        private string mSKUAsk;
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
        private string mSKUTruckID;
        private string mSKUTruckType;
        private string mSKUGoodQty;
        private string mSKUDamageQty;
        private string mSKUShortLandQty;
        private string mSKUOverlandQty;
        private string mSKUGoodphoto;
        private string mSKUDamagephoto;
        private string mSKUShortLandphoto;
        private string mSKUOverlandphoto;
        private string mSKUStatus;
        private string mSKURemark;


        #endregion
        #region"Public Property"
        public string BookingAsk
        {
            get { return mBookingAsk; }
            set { mBookingAsk = value; }
        }
        public string BookingID
        {
            get { return mBookingID; }
            set { mBookingID = value; }
        }
        public string AgentAsk
        {
            get { return mAgentAsk; }
            set { mAgentAsk = value; }
        }
        public string Shipper
        {
            get { return mShipper; }
            set { mShipper = value; }
        }
        public string CountryAsk
        {
            get { return mCountryAsk; }
            set { mCountryAsk = value; }
        }
        public string CargoReceivedDate
        {
            get { return mCargoReceivedDate; }
            set { mCargoReceivedDate = value; }
        }
        public string CustomIssuedDate
        {
            get { return mCustomIssuedDate; }
            set { mCustomIssuedDate = value; }
        }
        public string TransactionDate
        {
            get { return mTransactionDate; }
            set { mTransactionDate = value; }
        }
        public string Signature
        {
            get { return mSignature; }
            set { mSignature = value; }
        }
        public string SignatureDate
        {
            get { return mSignatureDate; }
            set { mSignature = value; }
        }
        public string BookingStatusAsk
        {
            get { return mBookingStatusAsk; }
            set { mBookingStatusAsk = value; }
        }
        public string NoOfTruck
        {
            get { return mNoOfTruck; }
            set { mNoOfTruck = value; }
        }
        public string NoOfContainer
        {
            get { return mNoOfContainer; }
            set { mNoOfContainer = value; }
        }

        public string ShipperAsk
        {
            get { return mShipperAsk; }
            set { mShipperAsk = value; }
        }
        public string ShipperName
        {
            get { return mShipperName; }
            set { mShipperName = value; }
        }
        public string ShipperDetails
        {
            get { return mShipperDetails; }
            set { mShipperDetails = value; }
        }
        public string TruckAsk
        {
            get { return mTruckAsk; }
            set { mTruckAsk = value; }
        }       
        public string TruckID
        {
            get { return mTruckID; }
            set { mTruckID = value; }
        }
        public string TruckTypeAsk
        {
            get { return mTruckTypeAsk; }
            set { mTruckTypeAsk = value; }
        }
        public string TruckStatus
        {
            get { return mTruckStatus; }
            set { mTruckStatus = value; }
        }
        public string TruckRemark
        {
            get { return mTruckRemark; }
            set { mTruckRemark = value; }
        }

        public string POAsk
        {
            get { return mPOAsk; }
            set { mPOAsk = value; }
        }
        public string PONo
        {
            get { return mPONo; }
            set { mPONo = value; }
        }
        public string POShippingMark
        {
            get { return mPOShippingMark; }
            set { mPOShippingMark = value; }
        }
        public string POReferenceNo
        {
            get { return mPOReferenceNo; }
            set { mPOReferenceNo = value; }
        }
        public string POStatus
        {
            get { return mPOStatus; }
            set { mPOStatus = value; }
        }
        public string PORemark
        {
            get { return mPORemark; }
            set { mPORemark = value; }
        }

        public string SKUAsk
        {
            get { return mSKUAsk; }
            set { mSKUAsk = value; }
        }
        public string SKUName
        {
            get { return mSKUName; }
            set { mSKUName = value; }
        }
        public string SKUDetails
        {
            get { return mSKUDetails; }
            set { mSKUDetails = value; }
        }
        public string SKUDimensionWidth
        {
            get { return mSKUDimensionWidth; }
            set { mSKUDimensionWidth = value; }
        }
        public string SKUDimensionHeight
        {
            get { return mSKUDimensionHeight; }
            set { mSKUDimensionHeight = value; }
        }
        public string SKUDimensionBase
        {
            get { return mSKUDimensionBase; }
            set { mSKUDimensionBase = value; }
        }
        public string SKUWeight
        {
            get { return mSKUWeight; }
            set { mSKUWeight = value; }
        }
        public string SKUPlanQty
        {
            get { return mSKUPlanQty; }
            set { mSKUPlanQty = value; }
        }
        public string SKUUOMAsk
        {
            get { return mSKUUOMAsk; }
            set { mSKUUOMAsk = value; }
        }
        public string SKUReceivedQty
        {
            get { return mSKUReceivedQty; }
            set { mSKUReceivedQty = value; }
        }
        public string SKUReference
        {
            get { return mSKUReference; }
            set { mSKUReference = value; }
        }
        public string SKUTruckID
        {
            get { return mSKUTruckID; }
            set { mSKUTruckID = value; }
        }
        public string SKUTruckType
        {
            get { return mSKUTruckType; }
            set { mSKUTruckType = value; }
        }
        public string SKUGoodQty
        {
            get { return mSKUGoodQty; }
            set { mSKUGoodQty = value; }
        }
        public string SKUDamageQty
        {
            get { return mSKUDamageQty; }
            set { mSKUDamageQty = value; }
        }
        public string SKUShortLandQty
        {
            get { return mSKUShortLandQty; }
            set { mSKUShortLandQty = value; }
        }
        public string SKUOverlandQty
        {
            get { return mSKUOverlandQty; }
            set { mSKUOverlandQty = value; }
        }
        public string SKUGoodphoto
        {
            get { return mSKUGoodphoto; }
            set { mSKUGoodphoto = value; }
        }
        public string SKUDamagephoto
        {
            get { return mSKUDamagephoto; }
            set { mSKUDamagephoto = value; }
        }
        public string SKUShortLandphoto
        {
            get { return mSKUShortLandphoto; }
            set { mSKUShortLandphoto = value; }
        }
        public string SKUOverlandphoto
        {
            get { return mSKUOverlandphoto; }
            set { mSKUOverlandphoto = value; }
        }
        public string SKUStatus
        {
            get { return mSKUStatus; }
            set { mSKUStatus = value; }
        }
        public string SKURemark
        {
            get { return mSKURemark; }
            set { mSKURemark = value; }
        }

      
        #endregion

        #region"Default Property"
        public void setDefaultValue()
        {
            mBookingAsk = "0";
            mBookingID = "";
            mAgentAsk = "";
            mCountryAsk = "";
            mCargoReceivedDate = "";
            mCustomIssuedDate = "";
            mTransactionDate = "";
            mSignature = "";
            mSignatureDate = "";
            mBookingStatusAsk = "";
            mNoOfTruck = "0";
            mNoOfContainer = "0";
            mBookingRemark = "";

            mShipperAsk = "0";
            mShipperName = "";
            mShipperDetails = "";

            mTruckAsk = "0";
            mTruckID = "";
            mTruckTypeAsk = "";
            mTruckStatus = "0";
            mTruckRemark = "";

            mPOAsk = "0";
            mPONo = "";
            mPOShippingMark = "";
            mPOReferenceNo = "";
            mPOStatus = "0";
            mPORemark = "";

            mSKUAsk = "0";
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
            mSKUTruckID = "";
            mSKUTruckType = "";
            mSKUGoodQty = "";
            mSKUDamageQty = "";
            mSKUShortLandQty = "";
            mSKUOverlandQty = "";
            mSKUGoodphoto = "";
            mSKUDamagephoto = "";
            mSKUShortLandphoto = "";
            mSKUOverlandphoto = "";
            mSKUStatus = "0";
            mSKURemark = "";
            

        }
        #endregion
    }
}