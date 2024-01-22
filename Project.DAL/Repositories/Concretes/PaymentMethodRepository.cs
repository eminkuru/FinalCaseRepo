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
	public class PaymentMethodRepository : BaseRepository<PaymentMethod>, IPaymentMethodRepository
	{
		public PaymentMethodRepository(OrgContext db) : base(db)
		{

		}
	}
}