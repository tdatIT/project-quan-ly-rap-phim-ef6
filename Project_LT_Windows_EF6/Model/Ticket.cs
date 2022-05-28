using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LT_Windows_EF6.Model
{
	public class Ticket
	{
		//PrimaryKey: Ticket INT
		[Key]
		public int Id { get; set; }

		//Feild: No_seat INT NOT NULL
		[Required]
		public int No_seat { get; set; }

		//ForeignKey: C_phone_number CHAR(11)
		[StringLength(11,MinimumLength =11)]
		[Column(TypeName ="char")]
		public string C_phone_number { get; set; }

		//ForeignKey: ScheduledMovieId INT NOT NULL
		[Required]
		public int ScheduledMovideId { get; set; }

		public Ticket()
		{

		}
		//Define relationship one - to - many (Customer - Ticket)
		public Customer customer { get; set; }
		//Define relationship one - to - many (ScheduledMovie - Ticket)
		public ScheduledMovie scheduledMovie { get; set; }
	}
}
