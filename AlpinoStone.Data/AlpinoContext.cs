using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;


namespace AlpinoStone.Data
{
	public class AlpinoContext : DbContext
	{
		public AlpinoContext(DbContextOptions options) 
			: base(options)
		{
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=fsk-hp10;Database=AlpinoStone; Trusted_Connection= True;");
		}

	}
}
