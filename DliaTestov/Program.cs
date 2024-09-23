using Dapper;
using Npgsql;
using ShopBot.DAL;
using ShopBot.Core.Dtos;


namespace DliaTestov
{
	internal class Program
	{
		static void Main(string[] args)
		{


			UserRepository userRepository = new UserRepository();
			userRepository.AddUser("Boriska");


			//Console.WriteLine(Environment.GetEnvironmentVariable("TGReyShopBot"));



			
			//string ConnectionString = "Server=localhost;port=5432;User Id = postgres;Password=123;Database=qqq;";
			//using (var connection = new NpgsqlConnection(ConnectionString))
			//{
			//	string query = "INSERT INTO  \"User\"(\"Name\") VALUES ('jija');";
			//	connection.Open();
			//	connection.Query(query);
			//}

		}
	}
}
