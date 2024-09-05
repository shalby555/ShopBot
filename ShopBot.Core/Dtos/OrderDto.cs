using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.Core.Dtos
{
	public class OrderDto
	{
		public int? Id { get; set; }

		public int? Date { get; set; }

		public int? AdminId { get; set; }

        public int? StatusId { get; set; }

		public int? ShopId { get; set; }

		public List<ProductDto>? Products { get; set; }

		public List<OrderProductDto>? Count { get; set; }

	}
}
