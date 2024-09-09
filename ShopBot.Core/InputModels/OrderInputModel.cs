using ShopBot.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopBot.Core.InputModels
{
	public class OrderInputModel
	{
        public string Date { get; set; }

		public int AdminId { get; set; } //пока ещё ни разу не пригодился данный столбец в таблице)))) (но походу нужен,пока его никто не взял
										 //в обработку,что бы связать с таблицей юзеров и уже подвязать Шопайди. Ну и вывести не выполненные заказы))

		//public int StatusId { get; set; } или как то автоматом пускай выставляет после отправки в Телегу

		public List<OrderProductDto>? ProductAndCount { get; set; } //список продуктов и кол-ва
	}
}
