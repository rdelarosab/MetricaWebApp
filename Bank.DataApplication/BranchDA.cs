using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bank.DataApplication.Configuration;
using Bank.Entities;

namespace Bank.DataApplication
{
    public class BranchDA
    {
        public List<BranchBE> GetAllBranchs(int idBanco)
        {
            var lstBranchRespose = new List<BranchBE>();
            var sqlCommandText = "[dbo].[GetAllBranch]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdBanco", SqlDbType.Int).Value = idBanco;
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var objTemp = new BranchBE
                    {
                        IdSucursal = DataAccess.GetValue<int>(reader, "IdSucursal"),
                        Nombre = DataAccess.GetValue<string>(reader, "Nombre"),
                        Direccion = DataAccess.GetValue<string>(reader, "Direccion"),
                        IdBanco = DataAccess.GetValue<int>(reader, "IdBanco")
                    };

                    lstBranchRespose.Add(objTemp);
                }

                sqlConnection.Close();
            }

            return lstBranchRespose;
        }

        public int InsertBranch(BranchBE modelBE)
        {
            var sqlComandText = "[dbo].[InsertBranch]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlComandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = modelBE.Nombre;
                sqlCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = modelBE.Direccion;
                sqlCommand.Parameters.Add("@IdBanco", SqlDbType.Int).Value = modelBE.IdBanco;

                sqlCommand.Connection.Open();

                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
        }

        public int UpdateBranch(BranchBE modelBE)
        {
            var sqlComandText = "[dbo].[UpdateBranch]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlComandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = modelBE.IdSucursal;
                sqlCommand.Parameters.Add("@IdBanco", SqlDbType.VarChar).Value = modelBE.IdBanco;
                sqlCommand.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = modelBE.Nombre;
                sqlCommand.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = modelBE.Direccion;

                sqlCommand.Connection.Open();

                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
        }

        public int DeleteBranch(int idSucursal)
        {
            var sqlComandText = "[dbo].[DeleteBranch]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlComandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = idSucursal;
                sqlCommand.Connection.Open();

                return Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
        }

        public BranchBE GetBranch(int idSucursal)
        {
            var responseModel = new BranchBE();
            var sqlCommandText = "[dbo].[GetBranch]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = idSucursal;
                sqlConnection.Open();

                var reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    responseModel = new BranchBE
                    {
                        IdSucursal = DataAccess.GetValue<int>(reader, "IdSucursal"),
                        Nombre = DataAccess.GetValue<string>(reader, "Nombre"),
                        Direccion = DataAccess.GetValue<string>(reader, "Direccion"),
                        IdBanco = DataAccess.GetValue<int>(reader, "IdBanco")
                    };
                }

                sqlConnection.Close();
            }

            return responseModel;
        }
    }
}
