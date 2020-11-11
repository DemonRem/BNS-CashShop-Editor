using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{
    interface IdbExec
    {
        int Add(SqlConnection conn);
        void Remove(SqlConnection conn);
        void Update(SqlConnection conn);
    }
}
