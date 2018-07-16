using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class CreatePicklistListJson
    {
        public CreatePicklistListJson()
        {
            setDefaultValue();
        }

        #region "private member"

        private List<BookingJson> mBookingList;
        private List<CreatePicklistDetailJson> mDetailList;


        #endregion
        #region"Public Property"
        [DataMember (Order = 1)]
        public List<BookingJson> BookingList
        {
            get { return mBookingList; }
            set { mBookingList = value; }
        }
        [DataMember(Order = 2)]
        public List<CreatePicklistDetailJson> DetailList
        {
            get { return mDetailList; }
            set { mDetailList = value; }
        }
        #endregion

        #region"Default Property"
        public void setDefaultValue()
        {

            mDetailList = new List<CreatePicklistDetailJson>();
            mBookingList = new List<BookingJson>();

        }
        #endregion
    }
}