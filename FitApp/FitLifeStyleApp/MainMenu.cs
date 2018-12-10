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
	public partial class MainMenu : Form
	{
		public MainMenu()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void OptionsPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void CompanyNameLabel_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			CaloriesCalc CC = new CaloriesCalc();
			CC.ShowDialog();
		}

		private void BMI_Calc_Click(object sender, EventArgs e)
		{
			BMI_Calc BMIC = new BMI_Calc();
			BMIC.ShowDialog();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{

			this.WindowState = FormWindowState.Minimized;
		}

		private void ExerciseButton_Click(object sender, EventArgs e)
		{
			FindExercises Ex = new FindExercises();
			Ex.ShowDialog();
		}

		private void TrainingButton_Click(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
