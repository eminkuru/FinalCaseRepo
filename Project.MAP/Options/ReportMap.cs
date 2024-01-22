using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.ENTITIES.Models;

namespace Project.MAP.Options
{
	public class ReportMap: BaseMap<Report>
	{

		public override void Configure(EntityTypeBuilder<Report> builder)
		{
			base.Configure(builder);


			builder.HasOne(r => r.Personel)
			  .WithOne(p => p.Report)
			  .HasForeignKey<Report>(r => r.PersonelID)
			  .IsRequired(); 
		}
	}
}
