using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace GIIS.ERP.WMS
{
    public class PalletJson
    {
        public PalletJson()
        {
            setDefaultValue();
        }
        #region"Private Property"
        private string mAsk;
        private string mTS;
        private string mUD;

        private string mName;
        private string mDetails;
        private string mType;
        private string mDimensionWidth;
        private string mDimensionHeight;
        private string mDimensionBase;
        private string mTareWeight;

        private string mGrossWeight;
        private string mMattWeight;

        private string mTotalWeight;
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
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        [DataMember]
        public string Details
        {
            get { return mDetails; }
            set { mDetails = value; }
        }
        [DataMember]
        public string Type
        {
            get { return mType; }
            set { mType = value; }
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
        public string TareWeight
        {
            get { return mTareWeight; }
            set { mTareWeight = value; }
        }
        [DataMember]
        public string GrossWeight
        {
            get { return mGrossWeight; }
            set { mGrossWeight = value; }
        }
        [DataMember]
        public string MattWeight
        {
            get { return mMattWeight; }
            set { mMattWeight = value; }
        }
        [DataMember]
        public string TotalWeight
        {
            get { return mDimensionHeight; }
            set { mTotalWeight = value; }
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
            Ask = "0";
            TS = "";
            UD = "";
            mName = "";
            mDetails = "";
            mType = "";
            mDimensionWidth = "0";
            mDimensionHeight = "0";
            mDimensionBase = "0";
            mTareWeight = "0";

            mGrossWeight = "0";
            mMattWeight = "0";

            mTotalWeight = "0";
            mStatus = "0";
            mDisplaySequence = "0";
            mRemark = "";

        }
        #endregion
    }

}