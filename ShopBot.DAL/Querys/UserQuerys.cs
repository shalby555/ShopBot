using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.DAL.Querys
{
	public class UserQuerys
	{
		public const string AddUserQuery = $"INSERT INTO \"User\"(\"Name\",\"Phone\",\"RoleId\",\"ShopId\") VALUES (@name, @phone, @roleid, @shopid);";

		public const string UpdateUserQuary = $"update \"User\"set \"Name\" = @name where \"Id\"= @id";

		public const string GetAllUsersQuary = $"SELECT \"Id\" \"Name\" FROM public. \"User\";";

		public const string GetUserByIdQuary = $"SELECT \"Id\" \"Name\" FROM public. \"User\" where \"Id\"= @id";

		public const string DeleteUserByIdQuery =  $"delete  FROM \"User\" where \"Id\"= @id";
	}
}
