using Project_LT_Windows_EF6.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LT_Windows_EF6
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		//[STAThread]
		static void Main()
		{
			//Application.EnableVisualStyles();
			//Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new Form1());
			Console.WriteLine("Start!!!");
			CreateDB();
			Console.WriteLine("Complete!!!");

		}
		static void CreateDB()
		{
			using(MovieTheaterContext db = new MovieTheaterContext())
			{
				try
				{
					db.Database.CreateIfNotExists();
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
				
			}
		}
	}
}
