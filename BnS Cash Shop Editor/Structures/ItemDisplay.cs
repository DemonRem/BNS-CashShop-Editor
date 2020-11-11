using System;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{
    public struct ItemDisplay : IdbExec
    {
        public int      ItemId                  ;
        public int      LanguageCode            ;
        public string   ItemDisplayName         ;
        public string   ItemDisplayDescription  ;

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
