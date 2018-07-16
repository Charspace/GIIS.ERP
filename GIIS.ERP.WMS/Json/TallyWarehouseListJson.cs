using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class TallyWarehouseJson
    {
        public TallyWarehouseJson()
        {
            setDefaultValue();
        }

        #region "private member"

        private List<BookingJson> mBookingList;
        private List<TallyWarehouseDetailJson> mDetailList;        


        #endregion
        #region"Public Property"
        [DataMember(Order = 1)]
        public List<BookingJson> BookingList
        {
            get { return mBookingList; }
            set { mBookingList = value; }
        }
        [DataMember(Order = 2)]
        public List<TallyWarehouseDetailJson> DetailList
        {
            get { return mDetailList; }
            set { mDetailList = value; }
        }
        
        #endregion

        #region"Default Property"
        public void setDefaultValue()
        {
            mBookingList = new List<BookingJson>();           
            mDetailList = new List<TallyWarehouseDetailJson>();
           
            
        }
        #endregion
    }
}