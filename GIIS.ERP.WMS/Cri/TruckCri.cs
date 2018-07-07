using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class TruckCri
    {
        public TruckCri()
        {
            setDefaultValue();
        }
        #region"Private Property"

        private string mAsk;
        private string mTS;
        private string mUD;
        private string mTruckID;
        private string mTruckTypeAsk;
        private string mStatus;
        private string mDisplaySequence;
        private string mRemark;
        private List<POCri> mPOList;

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
        public List<POCri> POList
        {
            get { return mPOList; }
            set { mPOList = value; }

        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "";
            mUD = "";
            mTruckID = "";
            mTruckTypeAsk = "";
            mStatus = "0";
            mDisplaySequence = "0";
            mRemark = "";
            mPOList = new List<POCri>();
        }
        #endregion
    }
}
