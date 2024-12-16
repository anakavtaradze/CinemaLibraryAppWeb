using CinemaLibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CinemaLibraryApp.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}
		public DbSet<Actor> Actors { get; set; }
		public DbSet<Director> Directors { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Movies> Movies { get; set; }
	}
}

