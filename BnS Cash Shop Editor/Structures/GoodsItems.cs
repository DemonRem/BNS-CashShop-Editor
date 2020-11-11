using System;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{
    public struct GoodsItems : IdbExec
    {
        public int      GoodsId                 ;
        public int      ItemId                  ;
        public int      ItemQuantity            ;
        public int      ItemExpirationType      ;
        public string   ItemExpireAt            ;
        public string   ItemExpirationDuration  ;
        public string   ItemData                ;
        public int      DeliveryPriority        ;
        public string   LimitedGameServerMask   ;
        public string   IsSelectableItem        ;

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
