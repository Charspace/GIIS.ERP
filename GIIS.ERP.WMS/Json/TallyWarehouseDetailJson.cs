using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class TallyWarehouseDetailJson
    {
        public TallyWarehouseDetailJson()
        {
            setDefaultValue();
        }

        #region "private member"
        
        private string mTallyAsk;       
        private string mTallyShippingMark;
        private string mTallyDocNo;
        private string mTallyTruckID;
        private string mTallyTruckTypeAsk;
        private string mTallySKUID;
        private string mTallySKUDetails;
        private string mTallyDimensionWeight;
        private string mTallyDimensionHeight;
        private string mTallyDimensionBase;
        private string mTallyReceivedQty;
        private string mTallyUOMAsk;
        private string mTallyCheckDate;
        private string mTallyReceiveDate;
        private string mTallyTransactionDate;
        private string mTallySignature;
        private string mTallySignatureDate;
        private string mTallyStatus;
        

        private string mBookingAsk;
        private string mBookingID;
        private string mShipper;
        private string mCountryAsk;
        private string mCargoReceivedDate;
        private string mCustomIssuedDate;
        private string mBookingStatusAsk;
        private string mNoOfTruck;
        private string mNoOfContainer;

        private string mAgentAsk;
        private string mAgentName;
        private string mAgentDetails;
        private string mAgentNationalID;
        private string mAgentShippinggAddress;
        private string mAgentBillingAddress;
        private string mAgentCompanyName;
        private string mAgentWebsite;
        private string mAgentMobile;
        private string mAgentEmail;
        private string mAgentContactPersonName;
        private string mAgentContactPersonMobile;
        private string mAgentAddress;

        private string mShipperAsk;
        private string mShipperName;
        private string mShipperDetails;

        #endregion
        #region "public member"

        [DataMember]
        public string TallyAsk
        {
            get { return mTallyAsk; }
            set { mTallyAsk = value; }
        }
        
        [DataMember]
        public string TallyShippingMark
        {
            get { return mTallyShippingMark; }
            set { mTallyShippingMark = value; }

        }
        [DataMember]
        public string TallyDocNo
        {
            get { return mTallyDocNo; }
            set { mTallyDocNo = value; }

        }
        [DataMember]
        public string TallyTruckID
        {
            get { return mTallyTruckID; }
            set { mTallyTruckID = value; }

        }
        [DataMember]
        public string TallyTruckTypeAsk
        {
            get { return mTallyTruckTypeAsk; }
            set { mTallyTruckTypeAsk = value; }

        }
        [DataMember]
        public string TallySKUID
        {
            get { return mTallySKUID; }
            set { mTallySKUID = value; }

        }
        [DataMember]
        public string TallySKUDetails
        {
            get { return mTallySKUDetails; }
            set { mTallySKUDetails = value; }

        }
        [DataMember]
        public string TallyDimensionWeight
        {
            get { return mTallyDimensionWeight; }
            set { mTallyDimensionWeight = value; }

        }
        [DataMember]
        public string TallyDimensionHeight
        {
            get { return mTallyDimensionHeight; }
            set { mTallyDimensionHeight = value; }

        }
        [DataMember]
        public string TallyDimensionBase
        {
            get { return mTallyDimensionBase; }
            set { mTallyDimensionBase = value; }

        }
        [DataMember]
        public string TallyReceivedQty
        {
            get { return mTallyReceivedQty; }
            set { mTallyReceivedQty = value; }

        }
        [DataMember]
        public string TallyUOMAsk
        {
            get { return mTallyUOMAsk; }
            set { mTallyUOMAsk = value; }

        }
        [DataMember]
        public string TallyCheckDate
        {
            get { return mTallyCheckDate; }
            set { mTallyCheckDate = value; }

        }
        [DataMember]
        public string TallyReceiveDate
        {
            get { return mTallyReceiveDate; }
            set { mTallyReceiveDate = value; }

        }
        [DataMember]
        public string TallyTransactionDate
        {
            get { return mTallyTransactionDate; }
            set { mTallyTransactionDate = value; }

        }
        [DataMember]
        public string TallySignature
        {
            get { return mTallySignature; }
            set { mTallySignature = value; }

        }
        [DataMember]
        public string TallySignatureDate
        {
            get { return mTallySignatureDate; }
            set { mTallySignatureDate = value; }

        }

        [DataMember]
        public string TallyStatus
        {
            get { return mTallyStatus; }
            set { mTallyStatus = value; }

        }
        
        [DataMember]
        public string BookingAsk
        {
            get { return mBookingAsk; }
            set { mBookingAsk = value; }

        }   
       
        public string BookingID
        {
            get { return mBookingID; }
            set { mBookingID = value; }
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

        [DataMember]
        public string AgentAsk
        {
            get { return mAgentAsk; }
            set { mAgentAsk = value; }

        }
        public string AgentName
        {
            get { return mAgentName; }
            set { mAgentName = value; }
        }
        public string AgentDetails
        {
            get { return mAgentDetails; }
            set { mAgentDetails = value; }
        }
        public string AgentNationalID
        {
            get { return mAgentNationalID; }
            set { mAgentNationalID = value; }
        }
        public string AgentShippinggAddress
        {
            get { return mAgentShippinggAddress; }
            set { mAgentShippinggAddress = value; }
        }
        public string AgentBillingAddress
        {
            get { return mAgentBillingAddress; }
            set { mAgentBillingAddress = value; }
        }
        public string AgentCompanyName
        {
            get { return mAgentCompanyName; }
            set { mAgentCompanyName = value; }
        }



        public string AgentWebsite
        {
            get { return mAgentWebsite; }
            set { mAgentWebsite = value; }
        }
        public string AgentMobile
        {
            get { return mAgentMobile; }
            set { mAgentMobile = value; }
        }
        public string AgentEmail
        {
            get { return mAgentEmail; }
            set { mAgentEmail = value; }
        }
        public string AgentContactPersonName
        {
            get { return mAgentContactPersonName; }
            set { mAgentContactPersonName = value; }
        }
        public string AgentContactPersonMobile
        {
            get { return mAgentContactPersonMobile; }
            set { mAgentContactPersonMobile = value; }
        }

        public string AgentAddress
        {
            get { return mAgentAddress; }
            set { mAgentAddress = value; }
        }

        [DataMember]
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

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {

            mTallyAsk = "0";
            mTallyShippingMark = "";
            mTallyDocNo = "";
            mTallyTruckID = "";
            mTallyTruckTypeAsk = "0";
            mTallySKUID = "";
            mTallySKUDetails = "";
            mTallyDimensionWeight = "0";
            mTallyDimensionHeight = "0";
            mTallyDimensionBase = "0";
            mTallyReceivedQty = "0";
            mTallyUOMAsk = "0";
            mTallyCheckDate = "";
            mTallyReceiveDate = "";
            mTallyTransactionDate = "";
            mTallySignature = "";
            mTallySignatureDate = "";
            mTallyStatus = "0";
                              
            
            mBookingAsk = "0";
            mBookingID = "";
            mAgentAsk = "";
            mCountryAsk = "";
            mCargoReceivedDate = "";
            mCustomIssuedDate = "";          
            mBookingStatusAsk = "";
            mNoOfTruck = "0";
            mNoOfContainer = "0";

            mAgentAsk = "0";
            mAgentName = "";
            mAgentDetails = "";
            mAgentNationalID = "";
            mAgentShippinggAddress = "";
            mAgentBillingAddress = "";
            mAgentCompanyName = "";
            mAgentWebsite = "";
            mAgentMobile = "";
            mAgentEmail = "";
            mAgentContactPersonName = "";
            mAgentContactPersonMobile = "";
            mAgentAddress = "";

            mShipperAsk = "0";
            mShipperName = "";
            mShipperDetails = "";

        }
        #endregion
    }
}