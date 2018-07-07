using System;
using System.Collections.Generic;
using System.Text;

namespace GIIS.ERP.WMS
{
    public class AgentJson
    {
        public AgentJson()
        {
            setDefaultValue();
        }
        #region"Private Property"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mAgentName;
        private string mAgentDetails;
        private string mNationalID;
        private string mShippinggAddress;
        private string mBillingAddress;
        private string mCompanyName;
        private string mWebsite;
        private string mMobile;
        private string mEmail;
        private string mContactPersonName;
        private string mContactPersonMobile;
        private string mAddress;
        private string mDisplaySequence;
        private string mRemark;





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
        public string NationalID
        {
            get { return mNationalID; }
            set { mNationalID = value; }
        }
        public string ShippinggAddress
        {
            get { return mShippinggAddress; }
            set { mShippinggAddress = value; }
        }
        public string BillingAddress
        {
            get { return mBillingAddress; }
            set { mBillingAddress = value; }
        }
        public string CompanyName
        {
            get { return mCompanyName; }
            set { mCompanyName = value; }
        }



        public string Website
        {
            get { return mWebsite; }
            set { mWebsite = value; }
        }
        public string Mobile
        {
            get { return mMobile; }
            set { mMobile = value; }
        }
        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }
        public string ContactPersonName
        {
            get { return mContactPersonName; }
            set { mContactPersonName = value; }
        }
        public string ContactPersonMobile
        {
            get { return mContactPersonMobile; }
            set { mContactPersonMobile = value; }
        }

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
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


        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            Ask = "0";
            TS = "";
            UD = "";
            mAgentName = "";
            mAgentDetails = "";
            mNationalID = "";
            mShippinggAddress = "";
            mBillingAddress = "";
            mCompanyName = "";
            mWebsite = "";
            mMobile = "";
            mEmail = "";
            mContactPersonName = "";
            mContactPersonMobile = "";
            mAddress = "";
            mDisplaySequence = "0";
            mRemark = "";

        }
        #endregion
    }
}