using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LT_Windows_EF6.Model
{
	public class MovieTheaterContext : DbContext
	{
		public MovieTheaterContext() : base("name = DbConfig")
		{

		}

		public DbSet<Employee> Employees { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<ScheduledMovie> ScheduledMovies { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Ticket> Tickets { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//Configures one-to-many (Movie - ScheduledMovie)
			modelBuilder.Entity<Movie>()
				.HasMany<ScheduledMovie>(t => t.scheduledMovies)
				.WithOptional(s => s.movie)
				.HasForeignKey(g => g.MovieId);
			//Configures one-to-many (Room - ScheduledMovie)
			modelBuilder.Entity<Room>()
				.HasMany<ScheduledMovie>(t => t.scheduledMovies)
				.WithRequired(s => s.room)
				.HasForeignKey(g => g.RoomId);
			//Configures One-to-many (Customer - Ticket)
			modelBuilder.Entity<Customer>()
				.HasMany<Ticket>(t => t.tickets)
				.WithOptional(s => s.customer)
				.HasForeignKey(g => g.C_phone_number);
			//Configures One-to-many (Scheduled - Ticket)
			modelBuilder.Entity<ScheduledMovie>()
				.HasMany<Ticket>(t => t.tickets)
				.WithRequired(s => s.scheduledMovie)
				.HasForeignKey(g => g.ScheduledMovideId);

		}
	}
}
