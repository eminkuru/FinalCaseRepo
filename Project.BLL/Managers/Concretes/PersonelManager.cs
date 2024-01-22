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
	public class PersonelManager : BaseManager<Personel>, IPersonelManager
	{
		IPersonelRepository _prRepository;

		public PersonelManager(IPersonelRepository prRepository) : base(prRepository)
		{
			_prRepository = prRepository;
		}
	}
}