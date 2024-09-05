using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.DAL.Querys
{
	public class OrderQuerys
	{
		public const string AddOrderQuery = $"INSERT INTO \"Order\"(\"Date\", \"AdminId\", \"StatusId\", \"ShopId\")VALUES (@name, @date, @adminid, @statusid, @shopid)";

		//public const string 
	}
}
