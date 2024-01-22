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
	public class PaymentMethodManager : BaseManager<PaymentMethod>, IPaymentMethodManager
	{
		IPaymentMethodRepository _pmRepository;

		public PaymentMethodManager(IPaymentMethodRepository pmRepository) : base(pmRepository)
		{
			_pmRepository = pmRepository;
		}
	}
}