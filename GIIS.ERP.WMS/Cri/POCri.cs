using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class POCri
    {
        public POCri()
        {
            setDefaultValue();
        }
        #region"Private Property"

        private string mAsk;
        private string mTS;
        private string mUD;
        private string mPONo;
        private string mShippingMark;
        private string mReferenceNo;
        private string mStatus;
        private string mDisplaySequence;
        private string mRemark;
        private List<SKUCri> mSKUList;

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
        public List<SKUCri> SKUList
        {
            get { return mSKUList; }
            set { mSKUList = value; }
        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "";
            mUD = "";
            mPONo = "";
            mShippingMark = "";
            mReferenceNo = "";
            mStatus = "0";
            mDisplaySequence = "0";
            mRemark = "";
            mSKUList = new List<SKUCri>();
        }
        #endregion
    }
}
