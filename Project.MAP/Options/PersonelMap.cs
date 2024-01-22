using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;

namespace Project.MAP.Options
{
	public class PersonelMap: BaseMap<Personel>
	{
		public override void Configure(EntityTypeBuilder<Personel> builder)
		{
			base.Configure(builder);


			builder.HasOne(pe => pe.Report)
			  .WithOne(r => r.Personel)
			  .HasForeignKey<Report>(r => r.PersonelID)
			  .IsRequired(false); // Personel may not have a Report

		}
	}
}
