using System;
using System.Collections.Generic;
using System.Text;

namespace GIIS.ERP.WMS
{
    public class BookingJson
    {
        public BookingJson()
        {
            setDefaultValue();
        }
        #region"Private Property"

        private string mAsk;
        private string mTS;
        private string mUD;
        private string mBookingID;
        private string mAgentAsk;
        private string mShipper;
        private string mCountryAsk;
        private string mCargoReceivedDate;
        private string mCustomIssuedDate;
        private string mTransactionDate;
        private string mSignature;
        private string mSignatureDate;
        private string mBookingStatusAsk;
        private string mNoOfTruck;
        private string mNoOfContainer;
        private string mDisplaySequence;
        private string mRemark;
        private string mLogisticTypeAsk;


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
        public string BookingID
        {
            get { return mBookingID; }
            set { mBookingID = value; }
        }
        public string AgentAsk
        {
            get { return mAgentAsk; }
            set { mAgentAsk = value; }
        }
        public string Shipper
        {
            get { return mShipper; }
            set { mShipper = value; }
        }
        public string CountryAsk
        {
            get { return mCountryAsk; }
            set { mCountryAsk = value; }
        }
        public string CargoReceivedDate
        {
            get { return mCargoReceivedDate; }
            set { mCargoReceivedDate = value; }
        }
        public string CustomIssuedDate
        {
            get { return mCustomIssuedDate; }
            set { mCustomIssuedDate = value; }
        }
        public string TransactionDate
        {
            get { return mTransactionDate; }
            set { mTransactionDate = value; }
        }
         public string Signature
        {
            get { return mSignature; }
            set { mSignature = value; }
        }
        public string SignatureDate
        {
            get { return mSignatureDate; }
            set { mSignature = value; }
        }
        public string BookingStatusAsk
        {
            get { return mBookingStatusAsk; }
            set { mBookingStatusAsk = value; }
        }
        public string NoOfTruck
        {
            get { return mNoOfTruck; }
            set { mNoOfTruck = value; }
        }
        public string NoOfContainer
        {
            get { return mNoOfContainer; }
            set { mNoOfContainer = value; }
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
        public string LogisticTypeAsk
        {
            get { return mLogisticTypeAsk; }
            set { mLogisticTypeAsk = value; }
        }


        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "";
            mUD = "";
            mBookingID = "";
            mAgentAsk = "";
            mCountryAsk = "";
            mCargoReceivedDate = "";
            mCustomIssuedDate = "";
            mTransactionDate = "";
            mSignature = "";
            mSignatureDate = "";
            mBookingStatusAsk = "";
            mNoOfTruck = "0";
            mNoOfContainer = "0";
            mDisplaySequence = "";
            mRemark = "";
            mLogisticTypeAsk = "0";
        }
        #endregion
    }
}
