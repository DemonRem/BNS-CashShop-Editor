using System;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{
    public struct Goods : IdbExec
    {
        public int      GoodsID;
        public string   GoodsName;
        public string   GoodsAppGroupCode;
        public int      GoodsType;
        public int      DeliveryType;
        public int      SaleStatus;
        public string   EffectiveFrom;
        public string   EffectiveTo;
        public int      SaleableQuantity;
        public int      RefundUnitCode;
        public int      IsRefundable;
        public int      IsAvailableRecurringPayment;
        public string   Changed;
        public string   ChangerAdminAccount;
        public string   GoodsDescription;
        public string   GoodsData;
        public string   ParentGoodsID;
        public int      GoodsPurchaseType;
        public string   SelectableItemQuantity;
        public int      GoodsPurchaseCheckMask;

        public int Add(SqlConnection conn)
        {
            throw new NotImplementedException();
        }

        public void Remove(SqlConnection conn)
        {
            throw new NotImplementedException();
        }

        public void Update(SqlConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
