using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class TruckJson
    {
        public TruckJson()
        {
            setDefaultValue();
        }
        #region"Private Property"

        private string mTruckAsk;
        private string mTruckTS;
        private string mTruckUD;
        private string mTruckID;
        private string mTruckTypeAsk;
        private string mTruckStatus;
        private string mTruckDisplaySequence;
        private string mTruckRemark;

        private string mBookingAsk;
        private string mShipperAsk;

        #endregion
        #region"Public Property"
        [DataMember]
        public string TruckAsk
        {
            get { return mTruckAsk; }
            set { mTruckAsk = value; }
        }
        [DataMember]
        public string TruckTS
        {
            get { return mTruckTS; }
            set { mTruckTS = value; }
        }
        [DataMember]
        public string TruckUD
        {
            get { return mTruckUD; }
            set { mTruckUD = value; }
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
        public string TruckStatus
        {
            get { return mTruckStatus; }
            set { mTruckStatus = value; }
        }
        [DataMember]
        public string TruckDisplaySequence
        {
            get { return mTruckDisplaySequence; }
            set { mTruckDisplaySequence = value; }
        }
        [DataMember]
        public string TruckRemark
        {
            get { return mTruckRemark; }
            set { mTruckRemark = value; }
        }
        [DataMember]
        public string BookingAsk
        {
            get { return mBookingAsk; }
            set { mBookingAsk = value; }

        }
        [DataMember]
        public string ShipperAsk
        {
            get { return mShipperAsk; }
            set { mShipperAsk = value; }

        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mTruckAsk = "0";
            mTruckTS = "0";
            mTruckUD = "0";
            mTruckID = "";
            mTruckTypeAsk = "";
            mTruckStatus = "0";
            mTruckDisplaySequence = "0";
            mTruckRemark = "";
            mBookingAsk = "0";
            mShipperAsk = "0";
        }
        #endregion
    }
}
