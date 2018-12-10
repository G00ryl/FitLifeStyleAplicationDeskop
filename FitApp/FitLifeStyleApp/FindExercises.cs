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
	

	public partial class FindExercises : Form	
	{
		public static int whichparta{ get; set; }
		public static String training { get; set; }
		public static String shoulders { get; set; }
		

		public FindExercises()
		{
			InitializeComponent();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MinimizeButton_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void LegsTrainBut_Click(object sender, EventArgs e)
		{
			training = "https://www.youtube.com/watch?v=SO_-adIUUFw&t=1096s";
			Exercises Ex = new Exercises(training);
			Ex.ShowDialog();
		}

		private void ShouldersTrainBut_Click(object sender, EventArgs e)
		{
			training = "https://www.youtube.com/watch?v=6bUYrhsS29Q";
			Exercises Ex = new Exercises(training);
			Ex.ShowDialog();
		}

		private void BackTrainBut_Click(object sender, EventArgs e)
		{
			training = "https://www.youtube.com/watch?v=DFbJ8CGAUNE";
			Exercises Ex = new Exercises(training);
			Ex.ShowDialog();
		}

		private void BicepsTrainBut_Click(object sender, EventArgs e)
		{
			training = "https://www.youtube.com/watch?v=4zL4i4zRHFg";
			Exercises Ex = new Exercises(training);
			Ex.ShowDialog();
			
		}

		private void TricepsTrainBut_Click(object sender, EventArgs e)
		{
			training = "https://www.youtube.com/watch?v=gq1TyEWMNus";
			Exercises Ex = new Exercises(training);
			Ex.ShowDialog();
		}

		private void ChestTrainBut_Click(object sender, EventArgs e)
		{
			training = "https://www.youtube.com/watch?v=y93U7xHagJc";
			Exercises Ex = new Exercises(training);
			Ex.ShowDialog();
		}
	}
}
