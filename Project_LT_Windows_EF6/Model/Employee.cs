using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LT_Windows_EF6.Model
{
	public class Employee
	{
		//Primary Key
		[Key]
		public int Id { get; set; }

		//Field: Name varchar(50) NOT NULL
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }

		//Field: Birthday date NOT NULL
		[Required]
		public DateTime Birthday { get; set; }


		//Field: Sex bit NOT NULL
		[Required]
		public bool sex { get; set; }

		//Field: Username char(50) NOT NULL
		[Required]
		[StringLength(50,MinimumLength = 5)]
		[Column(TypeName = "char")]
		public string Username { get; set; }

		//Field: Username char(50) NOT NULL
		[Required]
		[StringLength(50, MinimumLength = 5)]
		[Column(TypeName = "char")]
		public string Password { get; set; }

		//Field: Job char(20) NOT NULL
		[Required]
		[MaxLength(20)]
		[Column(TypeName="char")]
		public string Job { get; set; }

		//Field: Salary real NOT NULL
		[Required]
		public double Salary { get; set; }

		public Employee()
		{

		}


	}
}
