using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Enums;

namespace Project.ENTITIES.Models
{
	public class Expense: BaseEntity
	{

	

		public string Category { get; set; }

		public decimal Cost { get; set; }

		public DateTime ExpenseDate { get; set; }

		public ExpenseStatus ExpenseStatus { get; set; }
		public string ApprovmentDescription { get; set; }

		public string PersonelDescription { get; set; }

		


		//Personel: Her masraf, bir personel tarafından yapılmıştır.
		//Admin: Masraflar yönetici tarafından onaylanabilir veya reddedilebilir.

		public int PersonelID { get; set; }
		public virtual Personel Personel { get; set; }

		
		public virtual Payment? Payment { get; set; }


		public int ReportID { get; set; }
		public virtual Report Report { get; set; }


		public List<ExpenseFile> ExpenseFiles { get; set; }



        public Expense()
        {
            ExpenseStatus = ExpenseStatus.Pending;
			ApprovmentDescription = "The expense in waiting for response from an admin user";
        }










    }
}
