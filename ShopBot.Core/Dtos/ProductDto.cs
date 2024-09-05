using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.Core.Dtos
{
	public class ProductDto
	{
		public int? Id { get; set; }

		public string? Name { get; set; }

		public bool? IsActive { get; set; }

		public bool? IsDelited { get; set; }

	}
}
