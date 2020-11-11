using System;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{

    public struct GoodsSalePricePolicy : IdbExec
    {
        public int      GoodsId                 ;
        public int      CurrencyGroupId         ;
        public int      PricePolicyType         ;
        public string   EffectiveFrom           ;
        public string   EffectiveTo             ;
        public string   SalePrice               ;
        public string   DiscountValueType       ;
        public string   DiscountValue           ;
        public string   DiscountKey             ;
        public string   RewardValueType         ;
        public string   RewardValue             ;
        public string   RewardTargetKey         ;
        public string   RewardTargetKeyType     ;
        public string   GameGradeKey            ;

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
