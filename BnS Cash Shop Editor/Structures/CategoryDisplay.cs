using System.Data;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{
    public struct CategoryDisplay: IdbExec
    {
        public int      CategoryID;
        public int      LanguageCode;
        public string   CategoryDisplayName;
        public string   CategoryDisplayDescription;

        public int Add(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("p_AddCategoryDisplayCore", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryId", CategoryID);
            cmd.Parameters.AddWithValue("@LanguageCode", LanguageCode);
            cmd.Parameters.AddWithValue("@CategoryDisplayName", CategoryDisplayName);
            cmd.Parameters.AddWithValue("@CategoryDisplayDescription", CategoryDisplayDescription);
            cmd.ExecuteNonQuery();

            return CategoryID;
        }

        public void Remove(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("p_RemoveCategoryDisplayByCategoryIdCore", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryId", CategoryID);
            cmd.ExecuteNonQuery();
        }

        public void Update(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("p_UpdateCategoryDisplayCore", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryId", CategoryID);
            cmd.Parameters.AddWithValue("@LanguageCode", LanguageCode);
            cmd.Parameters.AddWithValue("@CategoryDisplayName", CategoryDisplayName);
            cmd.Parameters.AddWithValue("@CategoryDisplayDescription", CategoryDisplayDescription);
            cmd.ExecuteNonQuery();
        }
    }
}
