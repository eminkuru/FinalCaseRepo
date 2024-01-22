using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;

namespace Project.MAP.Options
{
	public class ExpenseMap: BaseMap<Expense>
	{
			
		public override void Configure(EntityTypeBuilder<Expense> builder)
		{

			base.Configure(builder);

			// Define a one-to-one relationship with Payment
			builder.HasOne(e => e.Payment) // Expense has one Payment
				   .WithOne(p => p.Expense) // Payment has one Expense
				   .HasForeignKey<Payment>(p => p.ExpenseID)
				   .IsRequired(false);


			// One-to-many relationship with Personel (Personel has a collection of Expenses)
			builder.HasOne(e => e.Personel)
				   .WithMany(p => p.Expenses) // Personel has a collection property named Expenses
				   .HasForeignKey(e => e.PersonelID)
				   .IsRequired();

			// One-to-many relationship with Report (Report has a collection of Expenses)
			builder.HasOne(e => e.Report)
				   .WithMany(r => r.Expenses) //  Report has a collection property named Expenses
				   .HasForeignKey(e => e.ReportID)
				   .OnDelete(DeleteBehavior.NoAction)
				   .IsRequired();

	

		} 
              
    }
}
