using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.DAL.Configurations;
using Project.ENTITIES.Models;

namespace Project.DAL.Context
{
	public class OrgContext: DbContext
	{
		public OrgContext(DbContextOptions<OrgContext> options) : base(options)
		{

		}
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Expense> Expense { get; set; }
		public DbSet<Payment> Payments { get; set; }
		public DbSet<PaymentCategory> PaymentCategories { get; set; }
		public DbSet<PaymentMethod> PaymentMethods { get; set; }
		public DbSet<Personel> Personels { get; set; }
		public DbSet<Report> Reports { get; set; }

		public DbSet<ExpenseFile> ExpenseFiles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AdminConfiguration());
			modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
			modelBuilder.ApplyConfiguration(new PaymentConfiguration());
			modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());
			modelBuilder.ApplyConfiguration(new PaymentCategoryConfiguration());
			modelBuilder.ApplyConfiguration(new PersonelConfiguration());
			modelBuilder.ApplyConfiguration(new ReportConfiguration());
			modelBuilder.ApplyConfiguration(new ExpenseFileConfiguration());

			base.OnModelCreating(modelBuilder);
		}

	




	}
}
