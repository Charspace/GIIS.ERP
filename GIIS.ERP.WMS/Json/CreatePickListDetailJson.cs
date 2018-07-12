using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class CreatePicklistDetailJson

    {
        public CreatePicklistDetailJson()
        {
            setDefaultValue();
        }
        #region"Private Property"
        private string mBookingAsk;

        private string mAgentAsk;
        private string mAgentTS;
        private string mAgentUD;
        private string mAgentName;
        private string mAgentDetails;
        private string mAgentNationalID;
        private string mAgentBillingAddress;
        private string mAgentShippingAddress;
        private string mAgentCompanyName;
        private string mAgentWebsite;
        private string mAgentMobile;
        private string mAgentEmail;
        private string mAgentContactPersonName;
        private string mAgentContactPersonMobile;
        private string mAgentAddress;
        private string mAgentDisplaySequence;
        private string mAgentRemark;

        private string mShipperAsk;
        private string mShipperTS;
        private string mShipperUD;
        private string mShipperName;
        private string mShipperDetails;
        private string mShipperStatus;
        private string mShipperDisplaySequence;
        private string mShipperRemark;

        private string mPicklistAsk;
        private string mPicklistTS;
        private string mPicklistUD;
        private string mPicklistNo;
        private string mPicklistDetails;
        private string mPicklistUserAsk;
        private string mPicklistCreatedDate;
        private string mPicklistFinishedDate;
        private string mPicklistStatus;
        private string mPicklistDisplaySequence;
        private string mPicklistRemark;

        private string mLocationAsk;
        private string mLocationTS;
        private string mLocationUD;
        private string mLocationBarcodeAsk;
        private string mLocationName;
        private string mLocationDetails;
        private string mLocationBuilding;
        private string mLocationLevel;
        private string mLocationZone;
        private string mLocationGPSLT;
        private string mLocationGPSLG;
        private string mLocationType;
        private string mLocationBase;
        private string mLocationWidth;
        private string mLocationHeight;
        private string mLocationCapacityWeigth;
        private string mLocationStatus;
        private string mLocationDisplaySequence;
        private string mLocationRemark;

        private string mSKUBarcodeAsk;
        private string mSKUBarcodeTS;
        private string mSKUBarcodeUD;
        private string mSKUBarcodeSKUAsk;
        private string mSKUBarcodeBarcodeAsk;
        private string mSKUBarcodeDimensionWidth;
        private string mSKUBarcodeDimensionHeight;
        private string mSKUBarcodeDimensionBase;
        private string mSKUBarcodeSKUWeight;
        private string mSKUBarcodeQty;
        private string mSKUBarcodeUOMAsk;
        private string mSKUBarcodeBarcodeStatus;
        private string mSKUBarcodeMergedBarcodeAsk;
        private string mSKUBarcodeStatus;
        private string mSKUBarcodeDisplaySequence;
        private string mSKUBarcodeRemark;

        #endregion
        #region"Public Property"
        [DataMember]
        public string BookingAsk
        {
            get { return mBookingAsk; }
            set { mBookingAsk = value; }
        }
        [DataMember]
        public string AgentAsk
        {
            get { return mAgentAsk; }
            set { mAgentAsk = value; }
        }
        [DataMember]
        public string AgentTS
        {
            get { return mAgentTS; }
            set { mAgentTS = value; }
        }
        [DataMember]
        public string AgentUD
        {
            get { return mAgentUD; }
            set { mAgentUD = value; }
        }
        [DataMember]
        public string AgentName
        {
            get { return mAgentName; }
            set { mAgentName = value; }

        }
        [DataMember]
        public string AgentDetails
        {
            get { return mAgentDetails; }
            set { mAgentDetails = value; }
        }
        [DataMember]
        public string AgentNationalID
        {
            get { return mAgentNationalID; }
            set { mAgentNationalID = value; }
        }
        [DataMember]
        public string AgentBillingAddress
        {
            get { return mAgentBillingAddress; }
            set { mAgentBillingAddress = value; }
        }
        [DataMember]
        public string AgentShippingAddress
        {
            get { return mAgentShippingAddress; }
            set { mAgentShippingAddress = value; }
        }
        [DataMember]
        public string AgentCompanyName
        {
            get { return mAgentCompanyName; }
            set { mAgentCompanyName = value; }
        }
        [DataMember]
        public string AgentWebsite
        {
            get { return mAgentWebsite; }
            set { mAgentWebsite = value; }
        }
        [DataMember]
        public string AgentMobile
        {
            get { return mAgentMobile; }
            set { mAgentMobile = value; }
        }
        [DataMember]
        public string AgentEmail
        {
            get { return mAgentEmail; }
            set { mAgentEmail = value; }
        }
        [DataMember]
        public string AgentContactPersonName
        {
            get { return mAgentContactPersonName; }
            set { mAgentContactPersonName = value; }
        }

        [DataMember]
        public string AgentContactPersonMobile
        {
            get { return mAgentContactPersonMobile; }
            set { mAgentContactPersonMobile = value; }
        }
        [DataMember]
        public string AgentAddress
        {
            get { return mAgentAddress; }
            set { mAgentAddress = value; }
        }
        [DataMember]
        public string AgentDisplaySequence
        {
            get { return mAgentDisplaySequence; }
            set { mAgentDisplaySequence = value; }
        }

        [DataMember]
        public string AgentRemark
        {
            get { return mAgentRemark; }
            set { mAgentRemark = value; }
        }
        [DataMember]
        public string ShipperAsk
        {
            get { return mShipperAsk; }
            set { mShipperAsk = value; }
        }
        [DataMember]
        public string ShipperTS
        {
            get { return mShipperTS; }
            set { mShipperTS = value; }

        }
        [DataMember]
        public string ShipperUD
        {
            get { return mShipperUD; }
            set { mShipperUD = value; }

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
        public string ShipperStatus
        {
            get { return mShipperStatus; }
            set { mShipperStatus = value; }
        }
        [DataMember]
        public string ShipperDisplaySequence
        {
            get { return mShipperDisplaySequence; }
            set { mShipperDisplaySequence = value; }
        }
        [DataMember]
        public string ShipperRemark
        {
            get { return mShipperRemark; }
            set { mShipperRemark = value; }
        }
        [DataMember]
        public string PicklistAsk
        {
            get { return mPicklistAsk; }
            set { mPicklistAsk = value; }
        }
        [DataMember]
        public string PicklistTS
        {
            get { return mPicklistTS; }
            set { mPicklistTS = value; }
        }
        [DataMember]
        public string PicklistUD
        {
            get { return mPicklistUD; }
            set { mPicklistUD = value; }
        }
        [DataMember]
        public string PicklistNo
        {
            get { return mPicklistNo; }
            set { mPicklistNo = value; }
        }
        [DataMember]
        public string PicklistDetails
        {
            get { return mPicklistDetails; }
            set { mPicklistDetails = value; }
        }
        [DataMember]
        public string PicklistUserAsk
        {
            get { return mPicklistUserAsk; }
            set { mPicklistUserAsk = value; }
        }
        [DataMember]
        public string PicklistCreatedDate
        {
            get { return mPicklistCreatedDate; }
            set { mPicklistCreatedDate = value; }
        }
        [DataMember]
        public string PicklistFinishedDate
        {
            get { return mPicklistFinishedDate; }
            set { mPicklistFinishedDate = value; }
        }
        [DataMember]
        public string PicklistStatus
        {
            get { return mPicklistStatus; }
            set { mPicklistStatus = value; }
        }
        [DataMember]

        public string PicklistDisplaySequence
        {
            get { return mPicklistDisplaySequence; }
            set { mPicklistDisplaySequence = value; }
        }
        [DataMember]
        public string PicklistRemark
        {
            get { return mPicklistRemark; }
            set { mPicklistRemark = value; }
        }
        [DataMember]
        public string LocationAsk
        {
            get { return mLocationAsk; }
            set { mLocationAsk = value; }
        }
        [DataMember]
        public string LocationTS
        {
            get { return mLocationTS; }
            set { mLocationTS = value; }
        }
        [DataMember]
        public string LocationUD
        {
            get { return mLocationUD; }
            set { mLocationUD = value; }
        }
        [DataMember]
        public string LocationBarcodeAsk
        {
            get { return mLocationBarcodeAsk; }
            set { mLocationBarcodeAsk = value; }
        }
        [DataMember]
        public string LocationName
        {
            get { return mLocationName; }
            set { mLocationName = value; }
        }
        [DataMember]
        public string LocationDetails
        {
            get { return mLocationDetails; }
            set { mLocationDetails = value; }
        }
        [DataMember]
        public string LocationBuilding
        {
            get { return mLocationBuilding; }
            set { mLocationBuilding = value; }
        }
        [DataMember]
        public string LocationLevel
        {
            get { return mLocationLevel; }
            set { mLocationLevel = value; }
        }
        [DataMember]

        public string LocationZone
        {
            get { return mLocationZone; }
            set { mLocationZone = value; }
        }
        [DataMember]
        public string LocationGPSLT
        {
            get { return mLocationGPSLT; }
            set { mLocationGPSLT = value; }
        }
        [DataMember]
        public string LocationGPSLG
        {
            get { return mLocationGPSLG; }
            set { mLocationGPSLG = value; }
        }
        [DataMember]
        public string LocationType
        {
            get { return mLocationType; }
            set { mLocationType = value; }
        }
        [DataMember]
        public string LocationBase
        {
            get { return mLocationBase; }
            set { mLocationBase = value; }
        }
        [DataMember]

        public string LocationWidth
        {
            get { return mLocationWidth; }
            set { mLocationWidth = value; }
        }
        [DataMember]
        public string LocationHeight
        {
            get { return mLocationHeight; }
            set { mLocationHeight = value; }
        }
        [DataMember]
        public string LocationCapacityWeigth
        {
            get { return mLocationCapacityWeigth; }
            set { mLocationCapacityWeigth = value; }
        }
        [DataMember]

        public string LocationStatus
        {
            get { return mLocationStatus; }
            set { mLocationStatus = value; }
        }
        [DataMember]
        public string LocationDisplaySequence
        {
            get { return mLocationDisplaySequence; }
            set { mLocationDisplaySequence = value; }
        }
        [DataMember]
        public string LocationRemark
        {
            get { return mLocationRemark; }
            set { mLocationRemark = value; }
        }
        [DataMember]
        public string SKUBarcodeAsk
        {
            get { return mSKUBarcodeAsk; }
            set { mSKUBarcodeAsk = value; }
        }

        [DataMember]
        public string SKUBarcodeSKUAsk
        {
            get { return mSKUBarcodeSKUAsk; }
            set { mSKUBarcodeSKUAsk = value; }
        }
        [DataMember]
        public string SKUBarcodeTS
        {
            get { return mSKUBarcodeTS; }
            set { mSKUBarcodeTS = value; }
        }

        [DataMember]
        public string SKUBarcodeUD
        {
            get { return mSKUBarcodeUD; }
            set { mSKUBarcodeUD = value; }
        }
        [DataMember]
        public string SKUBarcodeDimensionWidth
        {
            get { return mSKUBarcodeDimensionWidth; }
            set { mSKUBarcodeDimensionWidth = value; }
        }
        [DataMember]
        public string SKUBarcodeDimensionHeight
        {
            get { return mSKUBarcodeDimensionHeight; }
            set { mSKUBarcodeDimensionHeight = value; }
        }
        [DataMember]
        public string SKUBarcodeDimensionBase
        {
            get { return mSKUBarcodeDimensionBase; }
            set { mSKUBarcodeDimensionBase = value; }
        }
        [DataMember]
        public string SKUBarcodeSKUWeight
        {
            get { return mSKUBarcodeSKUWeight; }
            set { mSKUBarcodeSKUWeight = value; }
        }
        [DataMember]
        public string SKUBarcodeQty
        {
            get { return mSKUBarcodeQty; }
            set { mSKUBarcodeQty = value; }
        }
        [DataMember]
        public string SKUBarcodeUOMAsk
        {
            get { return mSKUBarcodeUOMAsk; }
            set { mSKUBarcodeUOMAsk = value; }
        }
        [DataMember]
        public string SKUBarcodeBarcodeStatus
        {
            get { return mSKUBarcodeBarcodeStatus; }
            set { mSKUBarcodeBarcodeStatus = value; }
        }
        [DataMember]
        public string SKUBarcodeMergedBarcodeAsk
        {
            get { return mSKUBarcodeMergedBarcodeAsk; }
            set { mSKUBarcodeMergedBarcodeAsk = value; }
        }

        [DataMember]
        public string SKUBarcodeStatus
        {
            get { return mSKUBarcodeStatus; }
            set { mSKUBarcodeStatus = value; }
        }
        [DataMember]
        public string SKUBarcodeDisplaySequence
        {
            get { return mSKUBarcodeDisplaySequence; }
            set { mSKUBarcodeDisplaySequence = value; }
        }
        [DataMember]
        public string SKUBarcodeRemark
        {
            get { return mSKUBarcodeRemark; }
            set { mSKUBarcodeRemark = value; }
        }
        [DataMember]
        public string SKUBarcodeBarcodeAsk
        {
            get { return mSKUBarcodeBarcodeAsk; }
            set { mSKUBarcodeBarcodeAsk = value; }
        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mBookingAsk = "0";

            mAgentAsk = "0";
            mAgentTS = "0";
            mAgentUD = "0";
            mAgentName = "";
            mAgentDetails = "";
            mAgentNationalID = "";
            mAgentBillingAddress = "";
            mAgentShippingAddress = "";
            mAgentCompanyName = "";
            mAgentWebsite = "";
            mAgentMobile = "";
            mAgentEmail = "";
            mAgentContactPersonMobile = "";
            mAgentContactPersonName = "";
            mAgentAddress = "";
            mAgentDisplaySequence = "0";
            mAgentRemark = "";

            mPicklistAsk = "0";
            mPicklistTS = "";
            mPicklistUD = "";
            mPicklistNo = "";
            mPicklistDetails = "";
            mPicklistUserAsk = "0";
            mPicklistCreatedDate = "";
            mPicklistFinishedDate = "";
            mPicklistStatus = "0";
            mPicklistDisplaySequence = "0";
            mPicklistRemark = "";

            mLocationAsk = "0";
            mLocationTS = "";
            mLocationUD = "";
            mLocationBarcodeAsk = "0";
            mLocationName = "";
            mLocationDetails = "";
            mLocationBuilding = "";
            mLocationLevel = "";
            mLocationZone = "";
            mLocationGPSLT = "";
            mLocationGPSLG = "";
            mLocationType = "";
            mLocationBase = "";
            mLocationWidth = "0";
            mLocationHeight = "0";
            mLocationCapacityWeigth = "0";
            mLocationStatus = "0";
            mLocationDisplaySequence = "0";
            mLocationRemark = "";

            mSKUBarcodeAsk = "0";

            mSKUBarcodeSKUAsk = "0";
            mSKUBarcodeTS = "0";
            mSKUBarcodeUD = "0";
            mSKUBarcodeBarcodeAsk = "0";
            mSKUBarcodeDimensionWidth = "0";
            mSKUBarcodeDimensionHeight = "0";
            mSKUBarcodeDimensionBase = "0";
            mSKUBarcodeSKUWeight = "0";
            mSKUBarcodeQty = "";
            mSKUBarcodeUOMAsk = "0";
            mSKUBarcodeBarcodeStatus = "0";
            mSKUBarcodeMergedBarcodeAsk = "0";
            mSKUBarcodeStatus = "0";
            mSKUBarcodeDisplaySequence = "0";
            mSKUBarcodeRemark = "";
        }
        #endregion
    }
}

