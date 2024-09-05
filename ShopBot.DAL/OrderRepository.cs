using Dapper;
using Npgsql;
using ShopBot.Core;
using ShopBot.Core.Dtos;
using ShopBot.DAL.Querys;

namespace ShopBot.DAL
{
	public class OrderRepository
	{
		public void AddOrder(OrderDto order)
		{

			string connectionString = Options.ConnectionString;
			using (var connection = new NpgsqlConnection(connectionString))
			{

				string query = UserQuerys.AddUserQuery;
				var args = new { date = order.Date };

				connection.Open();
				connection.Query(query,args);



			}

		}
	}
}
