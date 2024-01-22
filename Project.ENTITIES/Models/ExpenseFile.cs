using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
	public class ExpenseFile: BaseEntity
	{

		public string Name { get; set; }

		public string FileType { get; set; }

		public byte[] Data { get; set; }


		public int ExpenseID { get; set; }
		public Expense Expense { get; set; }
	}
}
