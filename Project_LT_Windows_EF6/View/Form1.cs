using Project_LT_Windows_EF6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_LT_Windows_EF6
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			using (MovieTheaterContext db = new MovieTheaterContext())
			{
				try
				{
					db.Database.CreateIfNotExists();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				
				
				
			}
		}
		private byte[] ImageToByteArray(Image image)
		{
			MemoryStream ms = new MemoryStream();
			image.Save(ms, ImageFormat.Png);
			return ms.ToArray();
		}
		private Image ByteArrayToImage(byte[] byteArr)
		{
			MemoryStream ms = new MemoryStream(byteArr);
			Image image = Image.FromStream(ms);
			return image;
		}
		private void button1_Click(object sender, EventArgs e)
		{

		}
	
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			
		}
	}
}
