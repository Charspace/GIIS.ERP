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
        private string mTruckID;
        private string mTruckTypeAsk;
        private string mTruckStatus;
        private string mTruckDisplaySequence;
        private string mTruckRemark;

        private string mBookingAsk;
        private string mShipperAsk;

        #endregion
        #region"Public Property"
        
        public string TruckAsk
        {
            get { return mTruckAsk; }
            set { mTruckAsk = value; }
        }
      
        
        public string TruckID
        {
            get { return mTruckID; }
            set { mTruckID = value; }
        }
        
        public string TruckTypeAsk
        {
            get { return mTruckTypeAsk; }
            set { mTruckTypeAsk = value; }
        }
   
        public string TruckStatus
        {
            get { return mTruckStatus; }
            set { mTruckStatus = value; }
        }
       
        public string TruckDisplaySequence
        {
            get { return mTruckDisplaySequence; }
            set { mTruckDisplaySequence = value; }
        }
       
        public string TruckRemark
        {
            get { return mTruckRemark; }
            set { mTruckRemark = value; }
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

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mTruckAsk = "0";
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
