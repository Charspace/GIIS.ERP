using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class CreatePicklistCri

    {
        public CreatePicklistCri()
        {
            setDefaultValue();
        }
    #region"Private Property"

    private string mUserID;
    private string mPassword;
    private string mProductAsk;

        private string mBookingAsk;
        private string mSKUBarcodeAsk;

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

        private string mContainerAsk;
        private string mContainerTS;
        private string mContainerUD;

        private string mContainerNo;
        private string mContainerDetails;
        private string mContainerSealNo;
        private string mContainerWidth;
        private string mContainerHeight;
        private string mContainerBase;
        private string mContainerType;
        private string mContainerColor;
        private string mContainerTruckTypeAsk;
        private string mContainerCarrier;
        private string mContainerVoy;
        private string mContainerVesselNo;
        private string mContainerETA;
        private string mContainerETD;
        private string mContainerCutOffDate;
        private string mContainerPaperlessCode;
        private string mContainerPicture;
        private string mContainerCountryAsk;
        private string mContainerTareWeight;
        private string mContainerGrossWeight;
        private string mContainerMattWeight;
        private string mContainerTotalWeight;
        private string mContainerStatus;
        private string mContainerDisplaySequence;
        private string mContainerRemark;

    #endregion
    #region"Public Property"
    [DataMember]
    public string UserID
    {
        get { return mUserID; }
        set { mUserID = value; }

    }
    [DataMember]
    public string Password
    {
        get { return mPassword; }
        set { mPassword = value; }

    }
    [DataMember]
    public String ProductAsk
    {
        get { return mProductAsk; }
        set { mProductAsk = value; }

    }
        [DataMember]
        public string BookingAsk
        {
            get { return mBookingAsk; }
            set { mBookingAsk = value; }
        }
        [DataMember]
        public string SKUBarcodeAsk
        {
            get { return mSKUBarcodeAsk; }
            set { mSKUBarcodeAsk = value; }
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
    public string ContainerAsk
    {
            get { return mContainerAsk; }
            set { mContainerAsk = value; }
        }
    [DataMember]
    public string ContainerTS
    {
            get { return mContainerTS; }
            set { mContainerTS = value; }
        }
    [DataMember]
    public string ContainerUD
    {
            get { return mContainerUD; }
            set { mContainerUD = value; }
        }
    [DataMember]
    public string ContainerNo
        {
            get { return mContainerNo; }
            set { mContainerNo = value; }
        }
    [DataMember]
    public string ContainerDetails
        {
            get { return mContainerDetails; }
            set { mContainerDetails = value; }
        }
    [DataMember]
    public string ContainerSealNo
    {
            get { return mContainerSealNo; }
            set { mContainerSealNo = value; }
        }
    [DataMember]
    public string ContainerWidth
        {
            get { return mContainerWidth; }
            set { mContainerWidth = value; }
        }
    [DataMember]
    public string ContainerHeight
    {
            get { return mContainerHeight; }
            set { mContainerHeight = value; }
        }
    [DataMember]
    public string ContainerBase
    {
            get { return mContainerBase; }
            set { mContainerBase = value; }
        }
    [DataMember]
    public string ContainerType
        {
            get { return mContainerType; }
            set { mContainerType = value; }
        }


    [DataMember]
    public string ContainerColor
    {
            get { return mContainerColor; }
            set { mContainerColor = value; }
        }
    [DataMember]
    public string ContainerTruckTypeAsk
    {
            get { return mContainerTruckTypeAsk; }
            set { mContainerTruckTypeAsk = value; }
        }
    [DataMember]
    public string ContainerCarrier
    {
            get { return mContainerCarrier; }
            set { mContainerCarrier = value; }
        }
    [DataMember]

    public string ContainerVoy
    {
            get { return mContainerVoy; }
            set { mContainerVoy = value; }
        }
    [DataMember]
    public string ContainerVesselNo
    {
            get { return mContainerVesselNo; }
            set { mContainerVesselNo = value; }
        }


    [DataMember]
    public string ContainerETA
    {
            get { return mContainerETA; }
            set { mContainerETA = value; }
        }
    [DataMember]
    public string ContainerETD
    {
            get { return mContainerETD; }
            set { mContainerETD = value; }
        }
    [DataMember]

    public string ContainerCutOffDate
    {
            get { return mContainerCutOffDate; }
            set { mContainerCutOffDate = value; }
        }
    [DataMember]
    public string ContainerPaperlessCode
    {
            get { return mContainerPaperlessCode; }
            set { mContainerPaperlessCode = value; }
        }
    [DataMember]

    public string ContainerPicture
        {
            get { return mContainerPicture; }
            set { mContainerPicture = value; }
        }
        [DataMember]
        public string ContainerCountryAsk
        {
            get { return mContainerCountryAsk; }
            set { mContainerCountryAsk = value; }
        }
        [DataMember]
        public string ContainerTareWeight
        {
            get { return mContainerTareWeight; }
            set { mContainerTareWeight = value; }
        }
        [DataMember]
        public string ContainerGrossWeight
        {
            get { return mContainerGrossWeight; }
            set { mContainerGrossWeight = value; }
        }
        [DataMember]
        public string ContainerMattWeight
        {
            get { return mContainerMattWeight; }
            set { mContainerMattWeight = value; }
        }
        [DataMember]
        public string ContainerTotalWeight
        {
            get { return mContainerTotalWeight; }
            set { mContainerTotalWeight = value; }
        }
        [DataMember]
    public string ContainerStatus
    {
            get { return mContainerStatus; }
            set { mContainerStatus = value; }
        }
    [DataMember]
    public string ContainerDisplaySequence
    {
            get { return mContainerDisplaySequence; }
            set { mContainerDisplaySequence = value; }
        }
    [DataMember]

    public string ContainerRemark
    {
            get { return mContainerRemark; }
            set { mContainerRemark = value; }
        }



        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mUserID = "";
            mPassword = "";
            mProductAsk = "0";

            mBookingAsk = "0";
            mSKUBarcodeAsk = "0";

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

            mContainerAsk = "0";
        mContainerTS = "";
        mContainerUD = "";
            mContainerNo = "";
            mContainerDetails = "";
        mContainerSealNo = "";
            mContainerWidth = "0";
        mContainerHeight = "0";
        mContainerBase = "0";
            mContainerType = "";
        mContainerColor = "";
        mContainerTruckTypeAsk = "0";
        mContainerCarrier = "";
        mContainerVoy = "";
        mContainerVesselNo = "";
        mContainerETA = "";
        mContainerETD = "";
        mContainerCutOffDate = "";
        mContainerPaperlessCode = "";
            mContainerPicture = "";
            mContainerCountryAsk = "0";
            mContainerTareWeight = "0";
            mContainerGrossWeight = "0";
            mContainerMattWeight = "0";
            mContainerTotalWeight = "0";


            mContainerStatus = "0";
        mContainerDisplaySequence = "0";
        mContainerRemark = "";

        }
        #endregion
    }
}

