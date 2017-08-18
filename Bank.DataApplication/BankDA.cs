using System;
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

        public int InsertBank(BankBE modelBE)
        {
            var sqlComandText = "[dbo].[InsertBank]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlComandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = modelBE.Nombre;
                sqlCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = modelBE.Direccion;

                sqlCommand.Connection.Open();

                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
        }

        public int UpdateBank(BankBE modelBE)
        {
            var sqlComandText = "[dbo].[UpdateBank]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlComandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdBanco", SqlDbType.Int).Value = modelBE.IdBanco;
                sqlCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = modelBE.Nombre;
                sqlCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = modelBE.Direccion;

                sqlCommand.Connection.Open();

                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
        }

        public int DeleteBank(int idBanco)
        {
            var sqlComandText = "[dbo].[DeleteBank]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlComandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdBanco", SqlDbType.Int).Value = idBanco;
                sqlCommand.Connection.Open();

                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
        }

        public BankBE GetBank(int idBanco)
        {
            var responseModel = new BankBE();
            var sqlCommandText = "[dbo].[GetBank]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdBanco", SqlDbType.Int).Value = idBanco;
                sqlConnection.Open();

                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    responseModel = new BankBE
                    {
                        IdBanco = DataAccess.GetValue<int>(reader, "IdBanco"),
                        Nombre = DataAccess.GetValue<string>(reader, "Nombre"),
                        Direccion = DataAccess.GetValue<string>(reader, "Direccion"),
                    };
                }

                sqlConnection.Close();
            }

            return responseModel;
        }
    }
}
