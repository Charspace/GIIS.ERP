using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIIS.ERP.WMS
{
    public class TruckTypeJson
    {
        public TruckTypeJson()
        {
            setDefaultValue();
        }
        #region"Private Property"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mCode;
        private string mDescription;
        private string mTotalGrossW;
        private string mTareWeight;
        private string mStockWeight;
        private string mTotalWeight;
        private string mTotalVol;
        private string mStatus;
        private string mDisplaySequence;
        private string mRemark;


        #endregion
        #region"Public Property"
        public string Ask
        {
            get { return mAsk; }
            set { mAsk = value; }
        }
        public string TS
        {
            get { return mTS; }
            set { mTS = value; }
        }
        public string UD
        {
            get { return mUD; }
            set { mUD = value; }
        }
        public string Code
        {
            get { return mCode; }
            set { mCode = value; }
        }
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }
        public string TotalGrossW
        {
            get { return mTotalGrossW; }
            set { mTotalGrossW = value; }
        }
        public string TareWeight
        {
            get { return mTareWeight; }
            set { mTareWeight = value; }
        }
        public string StockWeight
        {
            get { return mStockWeight; }
            set { mStockWeight = value; }
        }
        public string TotalWeight
        {
            get { return mTotalWeight; }
            set { mTotalWeight = value; }
        }
        public string TotalVol
        {
            get { return mTotalVol; }
            set { mTotalVol = value; }
        }

        public string Status
        {
            get { return mStatus; }
            set { mStatus = value; }
        }
        public string DisplaySequence
        {
            get { return mDisplaySequence; }
            set { mDisplaySequence = value; }
        }
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
            mTS = "";
            mUD = "";
            mCode = "";
            mDescription = "";
            mTotalGrossW = "";
            mTareWeight = "";
            mStockWeight = "";
            mTotalWeight = "";
            mTotalVol = "";
            mStatus = "";
            mDisplaySequence = "0";
            mRemark = "";

        }
        #endregion
    }

}