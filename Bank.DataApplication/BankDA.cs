using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bank.DataApplication.Configuration;
using Bank.Entities;

namespace Bank.DataApplication
{
    public class BankDA
    {
        public List<BankBE> GetAllBanks()
        {
            var lstBankRespose = new List<BankBE>();
            var sqlCommandText = "[dbo].[GetAllBanks]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var objTemp = new BankBE
                    {
                        IdBanco = DataAccess.GetValue<int>(reader, "IdBanco"),
                        Nombre = DataAccess.GetValue<string>(reader, "Nombre"),
                        Direccion = DataAccess.GetValue<string>(reader, "Direccion")
                    };

                    lstBankRespose.Add(objTemp);
                }

                sqlConnection.Close();
            }

            return lstBankRespose;
        }
    }
}
