using Microsoft.EntityFrameworkCore;
using Project.DAL.Context;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Concretes
{
	public class ExpenseFileRepository : BaseRepository<ExpenseFile>, IExpenseFileRepository
	{
		public ExpenseFileRepository(OrgContext db) : base(db)
		{

		}
	}
}