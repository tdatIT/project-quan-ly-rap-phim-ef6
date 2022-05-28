using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LT_Windows_EF6.Model
{
	public class ScheduledMovie
	{
		//Primary Key: Id INT
		[Key]
		public int Id { get; set; }

		//Field: BeginDate DATE NOT NULL
		[Required]
		public DateTime Begindate { get; set; }

		//ForeignKey: MovieId CHAR(10)
		[Column(TypeName = "char")]
		[StringLength(10, MinimumLength = 5)]
		public string MovieId { get; set; }

		//ForeignKey: RoomId INT
		public int RoomId { get; set; }

		public ScheduledMovie()
		{

		}
		//Relationship: One to Many (Movie - ScheduledMovie)
		public Movie movie { get; set; }
		//Relationship: One to Many (Room- ScheduledMovie)
		public Room room { get; set; }
		//Relationship:One to many (ScheduledMoive - Ticket)
		public ICollection<Ticket> tickets { get; set; }

	}
}
