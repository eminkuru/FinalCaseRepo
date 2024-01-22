using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class PaymentMethod:BaseEntity
	{
		public string MethodName { get; set; }

		public virtual List<Payment> Payments { get; set; }

	}
}
