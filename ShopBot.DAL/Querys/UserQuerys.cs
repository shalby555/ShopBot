using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.DAL.Querys
{
	public class UserQuerys
	{
		public const string AddUserQuery = $"INSERT INTO \"User\"(\"Name\",\"Phone\",\"RoleId\",\"ShopId\")" +
			                               $" VALUES (@name, @phone, @roleid, @shopid);";

		public const string UpdateUserQuary = $"update \"User\"set \"RoleId\" = @roleid where \"Id\"= @id"; 
		                                                            //\"ShopId\" = @shopid 
	                                                               //\"Phone\" = @phone
		public const string DeleteUserByIdQuery =  $"delete  FROM \"User\" where \"Id\"= @id";

		public const string GetAllUsersQuary = $"SELECT \"Id\" \"Name\" FROM \"User\";";

		public const string GetUserByIdQuary = $"SELECT \"Id\" \"Name\" FROM \"User\" where \"Id\"= @id";


		public const string GetAllUsersWithOrdersQuery = $" SELECT FROM  \"User\" as U left join \"Order\" as O on O.\"ShopId\" = U.\"ShopId\";";

		//public const string select U."Id",U."Name",O."Id",O."Date"from "User" as U left join "Order" as O on O."ShopId" = U."ShopId" 

		//public const string GetAllUsersFullInfoQuery = $" 
	}
}
