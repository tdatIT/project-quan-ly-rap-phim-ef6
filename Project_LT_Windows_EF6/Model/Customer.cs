using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LT_Windows_EF6.Model
{
	public class Customer
	{
		//Primary Key: C_phone_number CHAR(11)
		[Key]
		[Column(TypeName ="char")]
		[StringLength(11)]
		public string C_phone_number { get; set; }

		//Field: Name NVARCHAR(40) NOT NULL
		[Required]
		[MaxLength(40)]
		public string Name { get; set; }

		//Field: Birthday DATE 
		public DateTime? Birthday { get; set; }

		//Field: Sex BYTE
		public bool Sex { get; set; }

		public Customer()
		{

		}
		//Define relationship One to Many (Customer - Ticket)
		public ICollection<Ticket> tickets { get; set; }
	}
}
