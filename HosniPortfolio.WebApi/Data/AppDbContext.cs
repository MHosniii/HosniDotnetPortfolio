﻿using HosniPortfolio.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HosniPortfolio.WebApi.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
		{	}
		public DbSet<Lecture> Lectures { get; set; }
	}
}