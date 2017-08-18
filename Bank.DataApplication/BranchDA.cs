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
    }
}
