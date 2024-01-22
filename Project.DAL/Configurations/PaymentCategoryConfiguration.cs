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
	public class PaymentCategoryConfiguration : PaymentCategoryMap
	{
		public override void Configure(EntityTypeBuilder<PaymentCategory> builder)
		{
			base.Configure(builder);


			builder.Property(e => e.CategoryName).IsRequired();
			
			builder.HasIndex(e => e.CategoryName).IsUnique();
		


		}
	}
}
