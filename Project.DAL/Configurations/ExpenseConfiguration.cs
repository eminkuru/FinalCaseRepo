using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;
using Project.MAP.Options;

namespace Project.DAL.Configurations
{
	public class ExpenseConfiguration : ExpenseMap
	{
		public override void Configure(EntityTypeBuilder<Expense> builder)
		{
			base.Configure(builder);


			builder.Property(e => e.Category).IsRequired(false);
			builder.Property(a => a.Cost).IsRequired().HasPrecision(18, 4);
			builder.Property(a => a.ExpenseDate).IsRequired();
			builder.Property(a => a.ExpenseStatus).IsRequired();
			builder.Property(a => a.ApprovmentDescription).IsRequired().HasMaxLength(500);
			builder.Property(a => a.PersonelDescription).IsRequired(false).HasMaxLength(500);

			
		}
	}
}
