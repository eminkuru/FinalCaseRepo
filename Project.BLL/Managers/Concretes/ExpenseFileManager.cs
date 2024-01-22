using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
	public class ExpenseFileManager : BaseManager<ExpenseFile>, IExpenseFileManager
	{
		IExpenseFileRepository _efRepository;

		public ExpenseFileManager(IExpenseFileRepository efRepository) : base(efRepository)
		{
			_efRepository = efRepository;
		}
	}
}