using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class Personel:BaseEntity
	{

		public string FirstName { get; set; } 
		public string LastName { get; set; }
		public string Title { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string UserName { get; set; }

		public virtual List<Expense>?  Expenses { get; set; }


		
		public virtual Report? Report { get; set; }


		// Masraf Talepleri: Personel sınıfı, Masraf sınıfıyla 1:n ilişkiye sahip (bir personel birden fazla masraf talebinde bulunabilir).
		// Eğer personellerin kendi masraf raporlarını oluşturabilmesi
		// veya geçmiş masraf taleplerini rapor olarak görüntüleyebilmesi isteniyorsa, Personel ile Rapor arasında bir ilişki kurmak gerekir.
	}
}
