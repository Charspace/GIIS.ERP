using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SKUCri
    {
        public SKUCri()
        {
            setDefaultValue();
        }
        #region"Private Property"

        private string mAsk;
        private string mTS;
        private string mUD;
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
        private string mTruckID;
        private string mTruckType;
        private string mGoodQty;
        private string mDamageQty;
        private string mShortLandQty;
        private string mOverlandQty;
        private string mGoodphoto;
        private string mDamagephoto;
        private string mShortLandphoto;
        private string mOverlandphoto;
        private string mStatus;
        private string mDisplaySequence;
        private string mRemark;


        #endregion
        #region"Public Property"
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
        public string TruckID
        {
            get { return mTruckID; }
            set { mTruckID = value; }
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
        [DataMember]
        public string Goodphoto
        {
            get { return mGoodphoto; }
            set { mGoodphoto = value; }
        }
        [DataMember]
        public string Damagephoto
        {
            get { return mDamagephoto; }
            set { mDamagephoto = value; }
        }
        [DataMember]
        public string ShortLandphoto
        {
            get { return mShortLandphoto; }
            set { mShortLandphoto = value; }
        }
        [DataMember]
        public string Overlandphoto
        {
            get { return mOverlandphoto; }
            set { mOverlandphoto = value; }
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
            mAsk = "0";
            mTS = "0";
            mUD = "0";
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
            mTruckID = "";
            mTruckType = "";
            mGoodQty = "";
            mDamageQty = "";
            mShortLandQty = "";
            mOverlandQty = "";
            mGoodphoto = "";
            mDamagephoto = "";
            mShortLandphoto = "";
            mOverlandphoto = "";
            mStatus = "0";
            mDisplaySequence = "0";
            mRemark = "";
           
        }
        #endregion
    }
}
