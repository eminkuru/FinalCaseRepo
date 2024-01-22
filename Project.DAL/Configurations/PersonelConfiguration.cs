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
	public class PersonelConfiguration : PersonelMap
	{
		public override void Configure(EntityTypeBuilder<Personel> builder)
		{
			base.Configure(builder);


			builder.Property(a => a.UserName).IsRequired();
			builder.Property(a => a.Password).IsRequired();
			builder.Property(a => a.Email).IsRequired();
			builder.Property(a => a.FirstName).IsRequired().HasMaxLength(50);
			builder.Property(a => a.LastName).IsRequired().HasMaxLength(50);
			builder.Property(a => a.Title).IsRequired().HasMaxLength(50);

			builder.HasIndex(a => a.UserName).IsUnique();
			builder.HasIndex(a => a.Email).IsUnique();



			builder.HasData(
				new Personel { Email = "personel@personel.com", Password = "personel", UserName = "personel", FirstName ="John" 
				, LastName ="Doe", Title= "Concstructor", ID = 1}
			);


		}
	}
}
