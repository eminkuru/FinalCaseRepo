using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;

namespace Project.MAP.Options
{
	public class PaymentMap: BaseMap<Payment>
	{

		public override void Configure(EntityTypeBuilder<Payment> builder)
		{

			base.Configure(builder);


			builder.HasOne(e => e.Expense) // Expense has one Payment
			   .WithOne(p => p.Payment) // Payment has one Expense
			   .HasForeignKey<Payment>(p => p.ExpenseID)
			   .IsRequired();



			// One-to-many relationship with PaymentCategory (PaymentCategory has a collection of Payments)
			builder.HasOne(e => e.PaymentCategory)
				   .WithMany(p => p.Payments) // PaymentCategory has a collection property named Payments
				   .HasForeignKey(e => e.PaymentCategoryID)
				   .IsRequired(false);

			// One-to-many relationship with PaymentMethod (PaymentMethod has a collection of Payments)
			builder.HasOne(e => e.PaymentMethod)
				   .WithMany(p => p.Payments) // PaymentMethod has a collection property named Payments
				   .HasForeignKey(e => e.PaymentMethodID)
				   .IsRequired();






		}

	}
}
