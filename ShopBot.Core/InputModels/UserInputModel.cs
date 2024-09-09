using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.Core.InputModels
{
	public class UserInputModel
	{
		public string UserName { get; set; }

		public string Phone { get; set; }

		public int RoleId { get; set; }

		public int ShopId { get; set; }
	}
}

