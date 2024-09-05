using Dapper;
using Npgsql;
using ShopBot.Core;
using ShopBot.Core.Dtos;
using ShopBot.DAL.Querys;
using System.ComponentModel.DataAnnotations;

namespace ShopBot.DAL
{
	public class UserRepository
	{
		public void AddUser(UserDto user)
		{

			string connectionString = Options.ConnectionString;
			using (var connection = new NpgsqlConnection(connectionString))
			{

				string query = UserQuerys.AddUserQuery;
				var args = new { name = user.Name, phone = user.Phone, roleid = user.RoleId, shopid = user.ShopId };

				connection.Open();
				connection.Query(query, args);



			}

		}
		
		public void UpdateUser(UserDto user)
		{

				string connectionString = Options.ConnectionString;
				using (var connection = new NpgsqlConnection(connectionString))
				{

					string query = UserQuerys.UpdateUserQuary;
					var args = new { name = user.Name, id = user.Id };

					connection.Open();
					connection.Query(query, args);
				}
		}
		

		public void DeleteUserById (UserDto user)
		{
			string connectionString = Options.ConnectionString;
			using (var connection = new NpgsqlConnection(connectionString))
			{
				string query = UserQuerys.DeleteUserByIdQuery;
				var args = new { id = user.Id };

				connection.Open();
				connection.Query(query, args);
			}
		}

		public List<UserDto> GetAllUsers()
		{
			string connectionString = Options.ConnectionString;
			using (var connection = new NpgsqlConnection(connectionString))
			{

				string query = UserQuerys.GetAllUsersQuary;


				connection.Open();
				return connection.Query<UserDto>(query).ToList();
			}
		}

		public void GetUserById(UserDto user)
		{
			string connectionString = Options.ConnectionString;
			using (var connection = new NpgsqlConnection(connectionString))
			{
				string query = UserQuerys.GetUserByIdQuary;
				var args = new { id = user.Id };

				connection.Open();
				connection.Query(query, args);
			}
		}
	} 
}
