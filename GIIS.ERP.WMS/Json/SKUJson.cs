using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SKUJson
    {
        public SKUJson()
        {
            setDefaultValue();
        }
        #region"Private Property"
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
        private string mSKUDisplaySequence;
        private string mSKURemark;

        private string mBookingAsk;
        private string mShipperAsk;
        private string mTruckAsk;
        private string mPOAsk;

        #endregion
        #region"Public Property"

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
        
        public string SKUDisplaySequence
        {
            get { return mSKUDisplaySequence; }
            set { mSKUDisplaySequence = value; }
        }
        
        public string SKURemark
        {
            get { return mSKURemark; }
            set { mSKURemark = value; }
        }
        public string BookingAsk
        {
            get { return mBookingAsk; }
            set { mBookingAsk = value; }

        }
        public string ShipperAsk
        {
            get { return mShipperAsk; }
            set { mShipperAsk = value; }

        }
        public string TruckAsk
        {
            get { return mTruckAsk; }
            set { mTruckAsk = value; }
        }
        public string POAsk
        {
            get { return mPOAsk; }
            set { mPOAsk = value; }
        }
        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
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
            mSKUDisplaySequence = "0";
            mSKURemark = "";
            mBookingAsk = "0";
            mShipperAsk = "0";
            mTruckAsk = "0";
            mPOAsk = "0";
        }
        #endregion
    }
}
