using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class Report: BaseEntity
	{
		

		public virtual List<Expense>? Expenses { get; set; }


		public int PersonelID { get; set; }
		public virtual Personel Personel { get; set; }


 


        //Masraf: Raporlar, belirli tarih aralıklarında yapılan masrafları içerebilir.

    }
}
