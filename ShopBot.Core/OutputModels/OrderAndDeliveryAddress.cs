using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.Core.OutputModels
{
	public class OrderAndDeliveryAddress
	{
		public int OrderId { get; set; }
		public int StatusId { get; set; }
		public int PickUpPointId { get; set; }
	}
}
