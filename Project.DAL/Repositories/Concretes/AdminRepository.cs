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
	public class AdminRepository : BaseRepository<Admin>, IAdminRepository
	{
		public AdminRepository(OrgContext db) : base(db)
		{

		}
	}
}