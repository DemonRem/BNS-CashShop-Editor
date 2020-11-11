using System;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{
    public struct GoodsDisplay : IdbExec
    {
        public int      GoodsID                     ;
        public int      LanguageCode                ;
        public string   GoodsDisplayName            ;
        public string   GoodsDisplayDescription     ;

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
