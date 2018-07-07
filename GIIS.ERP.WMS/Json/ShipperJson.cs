using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class ShipperJson
    {
        public ShipperJson()
        {
            setDefaultValue();
        }
        #region"Private Property"

        private string mShipperAsk;
        private string mShipperName;
        private string mShipperDetails;
        private string mShipperStatus;
        private string mShipperDisplaySequence;
        private string mShipperRemark;

        private string mBookingAsk;
       

        #endregion
        #region"Public Property"
       
        public string ShipperAsk
        {
            get { return mShipperAsk; }
            set { mShipperAsk = value; }
        }
       
              
        public string ShipperName
        {
            get { return mShipperName; }
            set { mShipperName = value; }
        }
       
        public string ShipperDetails
        {
            get { return mShipperDetails; }
            set { mShipperDetails = value; }
        }
        
        public string ShipperStatus
        {
            get { return mShipperStatus; }
            set { mShipperStatus = value; }
        }
        
        public string ShipperDisplaySequence
        {
            get { return mShipperDisplaySequence; }
            set { mShipperDisplaySequence = value; }
        }
        
        public string ShipperRemark
        {
            get { return mShipperRemark; }
            set { mShipperRemark = value; }
        }
        
        public string BookingAsk
        {
            get { return mBookingAsk; }
            set { mBookingAsk = value; }

        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mShipperAsk = "0";
            mShipperName = "";
            mShipperDetails = "";
            mShipperStatus = "0";
            mShipperDisplaySequence = "0";
            mShipperRemark = "";
            mBookingAsk = "0";
        }
        #endregion
    }
}
