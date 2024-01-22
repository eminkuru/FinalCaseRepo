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
	public class PaymentMethodConfiguration : PaymentMethodMap
	{
		public override void Configure(EntityTypeBuilder<PaymentMethod> builder)
		{
			base.Configure(builder);


			builder.Property(e => e.MethodName).IsRequired();

			builder.HasIndex(e => e.MethodName).IsUnique();



		}
	}
}
