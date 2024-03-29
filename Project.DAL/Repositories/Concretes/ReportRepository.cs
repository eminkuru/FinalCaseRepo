﻿using Microsoft.EntityFrameworkCore;
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
	public class ReportRepository : BaseRepository<Report>, IReportRepository
	{
		public ReportRepository(OrgContext db) : base(db)
		{

		}
	}
}