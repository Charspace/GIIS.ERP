using System;
using System.Collections.Generic;
using System.Text;

namespace GIIS.ERP.WMS
{
    public class POJson
    {
        public POJson()
        {
            setDefaultValue();
        }
        #region"Private Property"

        private string mPOAsk;
        private string mPOTS;
        private string mPOUD;

        private string mPONo;
        private string mPOShippingMark;
        private string mPOReferenceNo;
        private string mPOStatus;
        private string mPODisplaySequence;
        private string mPORemark;

        private string mBookingAsk;
        private string mShipperAsk;
        private string mTruckAsk;


        #endregion
        #region"Public Property"
        public string POAsk
        {
            get { return mPOAsk; }
            set { mPOAsk = value; }
        }
        public string POTS
        {
            get { return mPOTS; }
            set { mPOTS = value; }
        }
        public string POUD
        {
            get { return mPOUD; }
            set { mPOUD = value; }
        }
        public string PONo
        {
            get { return mPONo; }
            set { mPONo = value; }
        }
        public string POShippingMark
        {
            get { return mPOShippingMark; }
            set { mPOShippingMark = value; }
        }
        public string POReferenceNo
        {
            get { return mPOReferenceNo; }
            set { mPOReferenceNo = value; }
        }
        public string POStatus
        {
            get { return mPOStatus; }
            set { mPOStatus = value; }
        }
        public string PODisplaySequence
        {
            get { return mPODisplaySequence; }
            set { mPODisplaySequence = value; }
        }
        public string PORemark
        {
            get { return mPORemark; }
            set { mPORemark = value; }
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
        public string TruckAsk
        {
            get { return mTruckAsk; }
            set { mTruckAsk = value; }
        }
            #endregion
            #region"Default Property"
            public void setDefaultValue()
        {
            mPOAsk = "0";
            mPOTS = "0";
            mPOUD = "0";
            mPONo = "";
            mPOShippingMark = "";
            mPOReferenceNo = "";
            mPOStatus = "0";
            mPODisplaySequence = "0";
            mPORemark = "";
            mBookingAsk = "0";
            mShipperAsk = "0";
            mTruckAsk = "0";

        }
        #endregion
    }
}
