using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.Core.Dtos
{
	public class ShopDto
	{
		public int? Id { get; set; }

		public string? StoreAddress { get; set; }

		public int? PickUpPointId { get; set; }

		public List<UserDto>? Users { get; set; }

	}
}
