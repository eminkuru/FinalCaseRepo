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
	public class ExpenseFileConfiguration: ExpenseFileMap
	{

		public override void Configure(EntityTypeBuilder<ExpenseFile> builder)
		{
			base.Configure(builder);


			builder.Property(e => e.Name).IsRequired().HasMaxLength(255);
			builder.Property(a => a.FileType).IsRequired().HasMaxLength(255);
			builder.Property(a => a.Data).IsRequired().HasColumnType("varbinary(max)");
			


		}

	}
}
