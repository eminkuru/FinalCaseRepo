using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class PaymentCategory: BaseEntity
	{

		public string CategoryName { get; set; }

		public virtual List<Payment> Payments { get; set; }

	
	}
}
