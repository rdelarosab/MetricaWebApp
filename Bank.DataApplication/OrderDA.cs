using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Bank.DataApplication.Configuration;
using Bank.Entities;

namespace Bank.DataApplication
{
    public class OrderDA
    {
        public List<OrderBE> GetAllOrdersFilter(int idSucursal, int moneda)
        {
            var lstOrderResponse = new List<OrderBE>();
            var sqlCommandText = "[dbo].[GetAllOrdersFilter]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdSucursal", SqlDbType.Int).Value = idSucursal;
                sqlCommand.Parameters.Add("@Moneda", SqlDbType.Int).Value = moneda;
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var objTemp = new OrderBE
                    {
                        IdOrden = DataAccess.GetValue<int>(reader, "IdOrden"),
                        Monto = DataAccess.GetValue<decimal>(reader, "Monto"),
                        Moneda = DataAccess.GetValue<int>(reader, "Moneda"),
                        Estado = DataAccess.GetValue<int>(reader, "Estado"),
                        IdSucursal = DataAccess.GetValue<int>(reader, "IdSucursal"),
                        FechaPago = DataAccess.GetValue<DateTime>(reader, "FechaPago").ToString("dd/MM/yyyy")
                    };

                    lstOrderResponse.Add(objTemp);
                }

                sqlConnection.Close();
            }

            return lstOrderResponse;
        }

        public List<OrderBE> GetAllOrdersByBank(int idBank)
        {
            var lstOrderResponse = new List<OrderBE>();
            var sqlCommandText = "[dbo].[GetAllOrders]";

            using (var sqlConnection = DataAccess.GetSqlConnection())
            using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@IdBanco", SqlDbType.Int).Value = idBank;
                sqlConnection.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    var objTemp = new OrderBE
                    {
                        IdOrden = DataAccess.GetValue<int>(reader, "IdOrden"),
                        Monto = DataAccess.GetValue<decimal>(reader, "Monto"),
                        Moneda = DataAccess.GetValue<int>(reader, "Moneda"),
                        Estado = DataAccess.GetValue<int>(reader, "Estado"),
                        IdSucursal = DataAccess.GetValue<int>(reader, "IdSucursal"),
                        TxtSucursal = DataAccess.GetValue<string>(reader, "TxtSucursal"),
                        IdBanco = DataAccess.GetValue<int>(reader, "IdBanco"),
                        FechaPago = DataAccess.GetValue<DateTime>(reader, "FechaPago").ToString("dd/MM/yyyy")
                    };

                    lstOrderResponse.Add(objTemp);
                }

                sqlConnection.Close();
            }

            return lstOrderResponse;
        }
    }
}
