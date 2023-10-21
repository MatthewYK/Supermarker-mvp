using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Model;
using System.Data;
using Supermarket_mvp.Models;
using System.Data.SqlClient;

namespace Supermarket_mvp._Repositories
{
    internal class PayModeRepository : BaseRepository, IPayModeRepository
    {
        public PayModeRepository(string connectionString) {
            this.connectionString = connectionString;
        }
        public void Add(PaymodeModel paymodeModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(PaymodeModel paymodeModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymodeModel> GetAll()
        {
            var payModeList = new List<PaymodeModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PayMode ORDER BY Pay_Mode_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var payModeModel = new PaymodeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(payModeModel);
                    }
                }
            }
            return payModeList; 
        }

        public IEnumerable<PaymodeModel> GetByValue(string value)
        {

            var payModeList= new List<PaymodeModel>();
            int payModeId = int.TryParse(value, out _)? Convert.ToInt32(value) :0;
            string payModeName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM PAY MODE
                                      WHERE Pay_Mode_Id= @id or Pay_Mode_Name LIKE @name+'%'
                                      ORDER By Pay_Mode_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = payModeId;
                command.Parameters.Add("@name ", SqlDbType.NVarChar).Value = payModeName;
                using(var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var payModeModel = new PaymodeModel();
                        payModeModel.Id = (int)reader["Pay_Mode_Id"];
                        payModeModel.Name = reader["Pay_Mode_Name"].ToString();
                        payModeModel.Observation = reader["Pay_Mode_Observation"].ToString();
                        payModeList.Add(payModeModel) ;
                    }
                }
            }
            return payModeList;
        }
    }
}
