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
	public partial class CaloriesCalc : Form
	{
		public static double weight { get; set; }
		public static double age { get; set; }
		public static double height { get; set; }
		public static double BMI { get; set; }
		public static double gender_value { get; set; }
		public static double training_times { get; set; }
		public static double basic_meta{ get; set; }
		public static double total_meta { get; set; }

		public CaloriesCalc()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			weight = Convert.ToDouble(Weight_CC_TextBox.Text);
			height = Convert.ToDouble(height_CC_TextBox.Text);
			age = Convert.ToDouble(Age_CC_TextBox.Text);
			if(SexMenRadioB.Checked)
			{
				gender_value = 66;
				basic_meta = gender_value + ((13.7 * weight) + (5 * height) - (4.7 * age));
				BasicMetaTB.Text = basic_meta.ToString();
			}
			else if(SexWomenRadioButton.Checked)
			{
				gender_value = 665;
				basic_meta = gender_value + ((9.6 * weight) + (1.8 * height) - (6.67 * age));
				BasicMetaTB.Text = basic_meta.ToString();
			}
			if (RarelyTrainRB.Checked && SexMenRadioB.Checked)
			{
				gender_value = 66;
				training_times = 1.3;
				total_meta = (gender_value + ((13.7 * weight) + (5 * height) - (4.7 * age)))*training_times;
				Total_metabTB.Text = total_meta.ToString();
			}
			else if (OftenTrainRB.Checked && SexMenRadioB.Checked)
			{
				gender_value = 66;
				training_times = 1.6;
				total_meta = (gender_value + ((13.7 * weight) + (5 * height) - (4.7 * age))) * training_times;
				Total_metabTB.Text = total_meta.ToString();
			}
			else if (EverydayTrainRB.Checked && SexMenRadioB.Checked)
			{
				gender_value = 66;
				training_times = 2;
				total_meta = (gender_value + ((13.7 * weight) + (5 * height) - (4.7 * age))) * training_times;
				Total_metabTB.Text = total_meta.ToString();
			}
			else if (RarelyTrainRB.Checked && SexWomenRadioButton.Checked)
			{
				gender_value = 665;
				training_times = 1.3;
				total_meta = (gender_value + ((9.6 * weight) + (1.8 * height) - (6.67 * age))) * training_times;
				Total_metabTB.Text = total_meta.ToString();
			}
			else if (OftenTrainRB.Checked && SexWomenRadioButton.Checked)
			{
				gender_value = 665;
				training_times = 1.6;
				total_meta = (gender_value + ((9.6 * weight) + (1.8 * height) - (6.67 * age))) * training_times;
				Total_metabTB.Text = total_meta.ToString();

			}
			else if (EverydayTrainRB.Checked && SexWomenRadioButton.Checked)
			{
				gender_value = 665;
				training_times = 2;
				total_meta = (gender_value + ((9.6 * weight) + (1.8 * height) - (6.67 * age))) * training_times;
				Total_metabTB.Text = total_meta.ToString();
			}




		}
	}
}
