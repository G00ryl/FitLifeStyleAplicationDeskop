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
	public partial class BMI_Calc : Form
	{
		public static double weight { get; set; }
		public static double height { get; set; }
		public static double BMI { get; set; }
		public BMI_Calc()
		{
			InitializeComponent();
		}

		private void Weight_Box_TextChanged(object sender, EventArgs e)
		{

		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void Weight_Panel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		public static void BMI_CALC()
		{

		}
		private void button2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			weight = Convert.ToDouble(Weight_Box.Text);
			height = Convert.ToDouble(Height_TextBox.Text);
			BMI = (weight / (height * height));
			textBox1.Text = BMI.ToString();

			if (BMI < 18.5)
			{
				ResultBox.Text = "Underweight or even emaciation";
			}
			else if (BMI < 25 && BMI > 18.5)
			{
				ResultBox.Text = "The weight is correct";
			}
			else if(BMI >25)
			{
				ResultBox.Text = "Overweight or even obesity";
			}
		}

	}
}
