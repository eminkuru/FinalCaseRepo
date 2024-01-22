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
	public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
	{

		public virtual void Configure(EntityTypeBuilder<T> builder)
		{

			builder.HasKey(be => be.ID);
			builder.Property(be => be.ID)
			.ValueGeneratedOnAdd(); // This configures the ID as auto-increment

		}
	}
}
