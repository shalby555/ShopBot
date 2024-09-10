using ShopBot.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.Core.OutputModels
{
	public class UserOutputModelcs
	{
		public string Name { get; set; }

		public int RoleId { get; set; }

		public List<OrderDto> Order { get; set; }
	}
}
