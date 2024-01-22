using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class Payment: BaseEntity
	{

		
		public string PaymentLocation { get; set; }


		//Masraf: Her masraf, bir ödeme kategorisine aittir.

		public int ExpenseID { get; set; }
		public virtual Expense Expense { get; set; }

		public int PaymentCategoryID { get; set; }

		public virtual PaymentCategory PaymentCategory { get; set; }


		public int PaymentMethodID { get; set; }

		public virtual PaymentMethod PaymentMethod { get; set; }



	}
}
