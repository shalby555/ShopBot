using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.Core.Dtos
{
	public class UserDto
	{
		public int? Id { get; set; }

		public string? Name { get; set; }

		public int? Phone { get; set; }

		public int? RoleId { get; set; }

		public int? ShopId { get; set; }

		public int? OrderCount { get; set; }

		public int? PickUpPointId { get; set; }

		public List<OrderDto>? Orders { get; set; }
	}
}
