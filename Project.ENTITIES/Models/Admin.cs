using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class Admin: BaseEntity
	{

		public string? FirstName { get; set; }
		public string? LastName { get; set; }

		public string UserName { get; set; }
		public string Email { get; set; }

		public string Password { get; set; }

		public bool IsFirstAdmin { get; set; }



        //Masraf Onaylama/Reddetme: Admin sınıfı, Masraf sınıfıyla ilişkili olup, masraf taleplerini onaylayabilir veya reddedebilir.

        public Admin()
        {
            IsFirstAdmin = false;
        }


    }
}
