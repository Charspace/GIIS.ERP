﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SKUBarcodeCri
    {
        public SKUBarcodeCri()
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
        private string mSKUAsk;
        private string mBarcodeAsk;
        private string mDimensionWidth;
        private string mDimensionHeight;
        private string mDimensionBase;
        private string mSKUWeight;
        private string mQty;
        private string mUOMAsk;
        private string mBarcodeStatus;
        private string mMergedBarcodeAsk;
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
        public string SKUAsk
        {
            get { return mSKUAsk; }
            set { mSKUAsk = value; }
        }
        [DataMember]
        public string BarcodeAsk
        {
            get { return mBarcodeAsk; }
            set { mBarcodeAsk = value; }
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
        public string Qty
        {
            get { return mQty; }
            set { mQty = value; }
        }
        [DataMember]
        public string UOMAsk
        {
            get { return mUOMAsk; }
            set { mUOMAsk = value; }
        }
        [DataMember]
        public string BarcodeStatus
        {
            get { return mBarcodeStatus; }
            set { mBarcodeStatus = value; }
        }
        [DataMember]
        public string MergedBarcodeAsk
        {
            get { return mMergedBarcodeAsk; }
            set { mMergedBarcodeAsk = value; }
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
            mTS = "";
            mUD = "";
            mSKUAsk = "0";
            mBarcodeAsk = "0";
            mDimensionWidth = "0";
            mDimensionHeight = "0";
            mDimensionBase = "0";
            mSKUWeight = "0";
            mQty = "";
            mUOMAsk = "0";
            mBarcodeStatus = "0";
            mMergedBarcodeAsk = "0";
            mStatus = "0";
            mDisplaySequence = "0";
            mRemark = "";
            
        }
        #endregion
    }
}
