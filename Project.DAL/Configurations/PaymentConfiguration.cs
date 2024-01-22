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
	public class PaymentConfiguration : PaymentMap
	{
		public override void Configure(EntityTypeBuilder<Payment> builder)
		{
			base.Configure(builder);


			builder.Property(e => e.PaymentLocation).IsRequired().HasMaxLength(255);

			



		}
	}
}
