using System;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{
    public struct Items : IdbExec
    {
        public int      ItemId                  ;
        public string   ItemName                ;
        public string   ItemAppGroupCode        ;
        public int      ItemType                ;
        public int      IsConsumable            ;
        public string   BasicPrice              ;
        public string   BasicCurrencyGroupId    ;
        public string   Changed                 ;
        public string   ChangerAdminAccount     ;
        public string   ItemDescription         ;

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
