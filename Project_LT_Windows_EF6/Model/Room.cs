using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LT_Windows_EF6.Model
{
	public class Room
	{
		//Primary Key: Id INT
		[Key]
		public int Id { get; set; }
		
		//Field: Name CHAR(10) NOT NULL
		[Required]
		[StringLength(10)]
		[Column(TypeName = "char")]
		public string name { get; set; }
		
		//Field: Count_seats INT NOT NULL
		[Required]
		public int Count_seats { get; set; }
		
		//Field: Status BYTE NOT NULL
		[Required]
		public bool Status { get; set; }

		public Room()
		{

		}
		//Define one to many with ScheduledMovie
		public ICollection<ScheduledMovie> scheduledMovies { get; set; }
	}
}
