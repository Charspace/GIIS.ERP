using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class SysMenuGroupObj
    {
        public SysMenuGroupObj()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mAsk;
        private string mTS;
        private string mUD;
        private string mMenu_Name;
        private string mMenu_Url;
        private string mMenu_Panel;
        private string mMenu_Tab;
        private string mMenu_Class;
        private string mDisplay_Sequence;
        private string mMenu_List;
        private string mMenu_Status;
        private string mUser_Remark;
     
        #endregion

        #region "public member"
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
        public string MenuName
        {
            get { return mMenu_Name; }
            set { mMenu_Name = value; }
        }
        [DataMember]
        public string DisplaySequence
        {
            get { return mDisplay_Sequence; }
            set { mDisplay_Sequence = value; }
        }
        [DataMember]
        public string MenuUrl
        {
            get { return mMenu_Url; }
            set { mMenu_Url = value; }
        }

        [DataMember]
        public string MenuPanel
        {
            get { return mMenu_Panel; }
            set { mMenu_Panel = value; }
        }
        [DataMember]
        public string MenuTab
        {
            get { return mMenu_Tab; }
            set { mMenu_Tab = value; }
        }
        [DataMember]
        public string MenuClass
        {
            get { return mMenu_Class; }
            set { mMenu_Class = value; }
        }
        [DataMember]
        public string MenuList
        {
            get { return mMenu_List; }
            set { mMenu_List = value; }
        }
        [DataMember]
        public string MenuStatus
        {
            get { return mMenu_Status; }
            set { mMenu_Status = value; }
        }
        [DataMember]
        public string UserRemark
        {
            get { return mUser_Remark; }
            set { mUser_Remark = value; }
        }
       
        #endregion

        #region"Default Property"
        public void setDefaultValue()
        {
            mAsk = "";
            mTS = "";
            mUD = "";
            mMenu_Name = "";
            mMenu_Url = "";
            mMenu_Panel = "";
            mMenu_Tab = "";
            mMenu_Class = "";
            mDisplay_Sequence = "";
            mMenu_List = "";
            mMenu_Status = "";
            mUser_Remark = "";

        }
        #endregion
    }
}