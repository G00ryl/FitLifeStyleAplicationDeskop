using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitLifeStyleApp
{
	public partial class Exercises : Form
	{
		public static int whichpart { get; set; }
	
		
		public Exercises(String Training)
		{
			InitializeComponent();
			ExerciseBox.Text = Training;
		}
		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		private void label2_Click(object sender, EventArgs e)
		{

		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(ExerciseBox.Text);
			
		}
		

		private void ExerciseBox_TextChanged(object sender, EventArgs e)
		{ 
		}

		private void button2_Click(object sender, EventArgs e)
		{
		
		}
	}
}