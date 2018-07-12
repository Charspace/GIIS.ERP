using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIIS.ERP.WMS
{
    public class UOMJson
    {
        public UOMJson()
        {
            setDefaultValue();
        }
        #region"Private Property"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mName;
        private string mDetails;
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
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public string Details
        {
            get { return mDetails; }
            set { mDetails = value; }
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
            mName = "";
            mDetails = "";
            mStatus = "";
            mDisplaySequence = "0";
            mRemark = "";

        }
        #endregion
    }

}