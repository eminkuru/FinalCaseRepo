using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.IdentityModel.Tokens;
using Project.ENTITIES.Models;
using Project.MAP.Options;

namespace Project.DAL.Configurations
{
	public class AdminConfiguration : AdminMap
	{
		public override void Configure(EntityTypeBuilder<Admin> builder)
		{
			base.Configure(builder);

			builder.Property(a => a.UserName).IsRequired();
			builder.Property(a => a.Password).IsRequired();
			builder.Property(a => a.Email).IsRequired();
			builder.Property(a => a.FirstName).IsRequired(false).HasMaxLength(50);
			builder.Property(a => a.LastName).IsRequired(false).HasMaxLength(50);

			builder.HasIndex(a => a.UserName).IsUnique();
			builder.HasIndex(a => a.Email).IsUnique();

			builder.HasData(
				new Admin
				{
					Email = "admin@admin.com",
					Password = "admin", // Consider hashing this password
					UserName = "admin",
					IsFirstAdmin = true,
					ID = 1
				}
			);
		}

	}

}
