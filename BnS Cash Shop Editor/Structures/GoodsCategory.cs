using System;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{
    public struct GoodsCategory : IdbExec
    {
        public int      GoodsId                 ;
        public int      CategoryId              ;
        public int      DisplayOrder            ;

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
