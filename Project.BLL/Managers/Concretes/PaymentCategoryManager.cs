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
	public class PaymentCategoryManager : BaseManager<PaymentCategory>, IPaymentCategoryManager
	{
		IPaymentCategoryRepository _pcRepository;

		public PaymentCategoryManager(IPaymentCategoryRepository pcRepository) : base(pcRepository)
		{
			_pcRepository = pcRepository;
		}
	}
}