using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace GIIS.ERP.WMS
{
    public class PREFWarehouseJson
    {
        public PREFWarehouseJson()
        {
            setDefaultValue();
        }

        #region "private member"

        private List<BookingJson> mBookingList;
        private List<ShipperJson> mShipperList;
        private List<TruckJson> mTruckList;
        private List<POJson> mPOList;
        private List<SKUJson> mSKUList;


        #endregion
        #region"Public Property"
        [DataMember(Order = 1)]
        public List<BookingJson> BookingList
        {
            get { return mBookingList; }
            set { mBookingList = value; }
        }
        [DataMember(Order = 2)]
        public List<ShipperJson> ShipperList
        {
            get { return mShipperList; }
            set { mShipperList = value; }
        }
        [DataMember(Order = 3)]
        public List<TruckJson> TruckList
        {
            get { return mTruckList; }
            set { mTruckList = value; }
        }
        [DataMember(Order = 4)]
        public List<POJson> POList
        {
            get { return mPOList; }
            set { mPOList = value; }
        }
        [DataMember(Order = 5)]
        public List<SKUJson> SKUList
        {
            get { return mSKUList; }
            set { mSKUList = value; }
        }

        #endregion

        #region"Default Property"
        public void setDefaultValue()
        {
            mBookingList = new List<BookingJson>();
            mShipperList = new List<ShipperJson>();
            mTruckList = new List<TruckJson>();
            mPOList = new List<POJson>();
            mSKUList = new List<SKUJson>();
        }
        #endregion
    }
}