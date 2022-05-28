using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LT_Windows_EF6.Model
{
	public class Movie
	{
		//Primary key ID CHAR(10)
		[Key]
		[Column(TypeName = "char")]
		[StringLength(10, MinimumLength = 5)]
		public string Id { get; set; }

		//Field: Name NVARCHAR(50) NOT NULL
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }

		//Field: Catagory NVARCHAR(50) NOT NULL
		[Required]
		[MaxLength(50)]
		public string Catagory { get; set; }

		//Field: Description NVARCHAR(50) NOT NULL
		[Required]
		[MaxLength(1000)]
		public string Description { get; set; }

		//Field: Rating INT NOT NULL
		[Required]
		public double Rating { get; set; }
		
		//Field: Minutes NOT NULL
		[Required]
		public int Minutes { get; set; }

		//Field: Poster IMAGE NOT NULL
		[Required]
		[Column(TypeName ="image")]
		public byte[] Poster { get; set; }

		public Movie()
		{
			
		}
		//define one - to - many relationship
		public ICollection<ScheduledMovie> scheduledMovies { get; set; }

	}
}
