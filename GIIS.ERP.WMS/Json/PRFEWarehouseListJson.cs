using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class PREFWarehouseListJson
    {
        public PREFWarehouseListJson()
        {
            setDefaultValue();
        }

        #region "private member"

        private List<BookingJson> mBookingList;
        private List<PREFWarehouseDetailJson> mDetailList;


        #endregion
        #region"Public Property"
        [DataMember (Order = 1)]
        public List<BookingJson> BookingList
        {
            get { return mBookingList; }
            set { mBookingList = value; }
        }
        [DataMember(Order = 2)]
        public List<PREFWarehouseDetailJson> DetailList
        {
            get { return mDetailList; }
            set { mDetailList = value; }
        }
        #endregion

        #region"Default Property"
        public void setDefaultValue()
        {

            mDetailList = new List<PREFWarehouseDetailJson>();
            mBookingList = new List<BookingJson>();

        }
        #endregion
    }
}