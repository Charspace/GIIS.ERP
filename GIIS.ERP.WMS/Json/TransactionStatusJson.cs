using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GIIS.ERP.WMS
{
    public class TransactionStatusJson
    {
        public TransactionStatusJson()
        {
            setDefaultValue();
        }
        #region"Private Property"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mStatusName;
        private string mStatusDetails;        
        private string mDisplaySequence;
        private string mUserRemark;

        #endregion
        #region"Public Property"
        [DataMember]
        public string ID
        {
            get { return mAsk; }
            set { mAsk = value; }
        }
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
        public string StatusName
        {
            get { return mStatusName; }
            set { mStatusName = value; }
        }
        [DataMember]
        public string StatusDetails
        {
            get { return mStatusDetails; }
            set { mStatusDetails = value; }
        }
        [DataMember]

        public string DisplaySequence
        {
            get { return mDisplaySequence; }
            set { mDisplaySequence = value; }
        }
        [DataMember]
        public string UserRemark
        {
            get { return mUserRemark; }
            set { mUserRemark = value; }
        }

       
        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
         mAsk="0";
         mTS = "";
         mUD = "";
         mStatusName = "";
         mStatusDetails = "";        
         mDisplaySequence = "";
         mUserRemark = "";
       }
        #endregion
    }
}
