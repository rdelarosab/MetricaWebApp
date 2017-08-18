using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Bank.DataApplication.Configuration
{
    internal static class DataAccess
    {
        public static SqlConnection GetSqlConnection()
        {
            var stringConnection = ConfigurationManager.ConnectionStrings["MetricaBankConnection"].ConnectionString;
            return new SqlConnection(stringConnection);
        }

        public static T GetValue<T>(SqlDataReader reader, string column)
        {           
            if (!reader.HasColumn(column) || reader[column] == DBNull.Value)
            {
                return default(T);
            }

            return (T)reader[column];
        }
    }

    public static class DataRecordExtensions
    {
        public static bool HasColumn(this IDataRecord dr, string columnName)
        {
            for (var i = 0; i < dr.FieldCount; i++)
            {
                if (dr.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }

            return false;
        }
    }
}
