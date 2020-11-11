using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;

namespace BnS_Cash_Shop_Editor
{
    public static class dbHelper
    {
        private static SqlConnectionStringBuilder dbConnectionString;
        public static SqlConnection dbConnection;
        public static SqlConnection dbConnect(string InitialCatalog = "GoodsDb", string DataSource = "127.0.0.1", string UserID = "sa", string Password = "FSmElsXuj3ls8Fq")
        {
            dbConnectionString = new SqlConnectionStringBuilder();
            dbConnectionString.InitialCatalog = InitialCatalog;
            dbConnectionString.DataSource = DataSource;
            dbConnectionString.UserID = UserID;
            dbConnectionString.Password = Password;

            dbConnection = new SqlConnection(dbConnectionString.ConnectionString);

            return dbConnection;
        }

        public static bool IsServerConnected(string connectionString)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        public static int GetAvailableID(string dbColumn,string dbTable, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand($"SELECT max({dbColumn}) FROM {dbTable}", conn);
            var r = cmd.ExecuteReader();

            if (r.HasRows)
            {
                r.Read();
                var _r = int.Parse(r[0].ToString()) + 1;
                r.Close();
                return _r;
            }
            return -1;
        }

        public static List<string> GetTableData(string dbTable, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {dbTable}", conn);
            var r = cmd.ExecuteReader();
            List<string> data = new List<string>();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        data.Add(r[i].ToString());
                    }
                }
                r.Close();
                return data;
            }
            return null;
        }

        public static List<string> GetTableData(string dbTable,string Where, string value, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand($"SELECT * FROM {dbTable} WHERE {Where} = {value}", conn);
            var r = cmd.ExecuteReader();
            List<string> data = new List<string>();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        data.Add(r[i].ToString());
                    }
                }
                r.Close();
                return data;
            }
            return null;
        }

        public static void ClearCache(string ip = "127.0.0.1")
        {
            var wr = WebRequest.Create($"http://{ip}:6605/spawned/GoodsSrv.1.620439530/goods/cache_flush?");
            wr.Timeout = 1000;
            try
            {
                var response = (HttpWebResponse)wr.GetResponse();
            }
            catch (WebException ex)
            {

            }
        }
    }
}
