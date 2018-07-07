using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class ShipperCri
    {
        public ShipperCri()
        {
            setDefaultValue();
        }
        #region"Private Property"

        private string mAsk;
        private string mTS;
        private string mUD;
        private string mShipperName;
        private string mShipperDetails;
        private string mStatus;
        private string mDisplaySequence;
        private string mRemark;
        private List<TruckCri> mTruckList;

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
        public List<TruckCri> TruckList
        {
            get { return mTruckList; }
            set { mTruckList = value; }

        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "";
            mUD = "";
            mShipperName = "";
            mShipperDetails = "";
            mStatus = "0";
            mDisplaySequence = "0";
            mRemark = "";
            mTruckList = new List<TruckCri>();
        }
        #endregion
    }
}
