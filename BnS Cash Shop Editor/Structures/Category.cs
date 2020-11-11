using System.Data;
using System.Data.SqlClient;

namespace BnS_Cash_Shop_Editor
{
    public struct Category:IdbExec
    {
        public int      CategoryID;
        public string   CategoryName;
        public string   AppGroupCode;
        public int      IsDisplayable;
        public int      DisplayOrder;
        public string   Changed;
        public string   ChangerAdminAccount;
        public string   CurrencyGroupId;
        public string   ParentCategory;
        public string   CategoryData;

        public int Add(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("p_AddCategoryCore", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            int newID = dbHelper.GetAvailableID("CategoryId", "Categories", conn);
            cmd.Parameters.AddWithValue("@CategoryId", newID);
            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            cmd.Parameters.AddWithValue("@AppGroupCode", AppGroupCode);
            cmd.Parameters.AddWithValue("@IsDisplayable", IsDisplayable);
            cmd.Parameters.AddWithValue("@DisplayOrder", DisplayOrder);
            cmd.Parameters.AddWithValue("@ChangerAdminAccount", ChangerAdminAccount);
            cmd.Parameters.AddWithValue("@CurrencyGroupId", CurrencyGroupId);
            cmd.Parameters.AddWithValue("@ParentCategoryId", ParentCategory);
            cmd.Parameters.AddWithValue("@CategoryData", CategoryData);
            cmd.ExecuteNonQuery();
            return newID;
        }
        
        public void Remove(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("p_RemoveCategoryCore", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryId", CategoryID);
            cmd.ExecuteNonQuery();
        }

        public void Update(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand("p_UpdateCategoryCore", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CategoryId", CategoryID);
            cmd.Parameters.AddWithValue("@CategoryName", CategoryName);
            cmd.Parameters.AddWithValue("@AppGroupCode", AppGroupCode);
            cmd.Parameters.AddWithValue("@IsDisplayable", IsDisplayable);
            cmd.Parameters.AddWithValue("@DisplayOrder", DisplayOrder);
            cmd.Parameters.AddWithValue("@ChangerAdminAccount", ChangerAdminAccount);
            cmd.Parameters.AddWithValue("@CurrencyGroupId", CurrencyGroupId);
            cmd.Parameters.AddWithValue("@ParentCategoryId", ParentCategory);
            cmd.Parameters.AddWithValue("@CategoryData", CategoryData);
            cmd.ExecuteNonQuery();
        }
    }
}
