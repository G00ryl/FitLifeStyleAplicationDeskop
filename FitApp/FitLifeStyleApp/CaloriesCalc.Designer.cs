namespace FitLifeStyleApp
{
	partial class CaloriesCalc
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CaloriesPanel = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Weight_CC_TextBox = new System.Windows.Forms.TextBox();
			this.Age_CC_TextBox = new System.Windows.Forms.TextBox();
			this.height_CC_TextBox = new System.Windows.Forms.TextBox();
			this.Sex_GroupBox = new System.Windows.Forms.GroupBox();
			this.SexWomenRadioButton = new System.Windows.Forms.RadioButton();
			this.SexMenRadioB = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.EverydayTrainRB = new System.Windows.Forms.RadioButton();
			this.OftenTrainRB = new System.Windows.Forms.RadioButton();
			this.RarelyTrainRB = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.BasicMetaTB = new System.Windows.Forms.TextBox();
			this.Total_metabTB = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.button1 = new System.Windows.Forms.Button();
			this.CaloriesPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.Sex_GroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// CaloriesPanel
			// 
			this.CaloriesPanel.BackColor = System.Drawing.Color.LightSeaGreen;
			this.CaloriesPanel.Controls.Add(this.button2);
			this.CaloriesPanel.Controls.Add(this.ExitButton);
			this.CaloriesPanel.Controls.Add(this.pictureBox2);
			this.CaloriesPanel.Controls.Add(this.pictureBox1);
			this.CaloriesPanel.Controls.Add(this.label1);
			this.CaloriesPanel.Location = new System.Drawing.Point(2, 0);
			this.CaloriesPanel.Name = "CaloriesPanel";
			this.CaloriesPanel.Size = new System.Drawing.Size(743, 100);
			this.CaloriesPanel.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(697, -2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(25, 25);
			this.button2.TabIndex = 18;
			this.button2.Text = "-";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(718, -2);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(25, 25);
			this.ExitButton.TabIndex = 17;
			this.ExitButton.Text = "X";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::FitLifeStyleApp.Properties.Resources._11;
			this.pictureBox2.Location = new System.Drawing.Point(640, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 100);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FitLifeStyleApp.Properties.Resources._11;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(256, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(322, 41);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calories Calculator";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(44, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter your weight [KG]";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(44, 206);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(186, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "Enter your height [CM]";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(44, 291);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(122, 19);
			this.label3.TabIndex = 5;
			this.label3.Text = "Enter your age";
			// 
			// Weight_CC_TextBox
			// 
			this.Weight_CC_TextBox.Location = new System.Drawing.Point(66, 167);
			this.Weight_CC_TextBox.Name = "Weight_CC_TextBox";
			this.Weight_CC_TextBox.Size = new System.Drawing.Size(100, 20);
			this.Weight_CC_TextBox.TabIndex = 6;
			// 
			// Age_CC_TextBox
			// 
			this.Age_CC_TextBox.Location = new System.Drawing.Point(66, 325);
			this.Age_CC_TextBox.Name = "Age_CC_TextBox";
			this.Age_CC_TextBox.Size = new System.Drawing.Size(100, 20);
			this.Age_CC_TextBox.TabIndex = 7;
			// 
			// height_CC_TextBox
			// 
			this.height_CC_TextBox.Location = new System.Drawing.Point(66, 248);
			this.height_CC_TextBox.Name = "height_CC_TextBox";
			this.height_CC_TextBox.Size = new System.Drawing.Size(100, 20);
			this.height_CC_TextBox.TabIndex = 8;
			// 
			// Sex_GroupBox
			// 
			this.Sex_GroupBox.Controls.Add(this.SexWomenRadioButton);
			this.Sex_GroupBox.Controls.Add(this.SexMenRadioB);
			this.Sex_GroupBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Sex_GroupBox.Location = new System.Drawing.Point(247, 119);
			this.Sex_GroupBox.Name = "Sex_GroupBox";
			this.Sex_GroupBox.Size = new System.Drawing.Size(168, 100);
			this.Sex_GroupBox.TabIndex = 9;
			this.Sex_GroupBox.TabStop = false;
			this.Sex_GroupBox.Text = "Choose your sex:";
			// 
			// SexWomenRadioButton
			// 
			this.SexWomenRadioButton.AutoSize = true;
			this.SexWomenRadioButton.Location = new System.Drawing.Point(6, 57);
			this.SexWomenRadioButton.Name = "SexWomenRadioButton";
			this.SexWomenRadioButton.Size = new System.Drawing.Size(89, 23);
			this.SexWomenRadioButton.TabIndex = 1;
			this.SexWomenRadioButton.TabStop = true;
			this.SexWomenRadioButton.Text = "Women";
			this.SexWomenRadioButton.UseVisualStyleBackColor = true;
			this.SexWomenRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// SexMenRadioB
			// 
			this.SexMenRadioB.AutoSize = true;
			this.SexMenRadioB.Location = new System.Drawing.Point(6, 28);
			this.SexMenRadioB.Name = "SexMenRadioB";
			this.SexMenRadioB.Size = new System.Drawing.Size(62, 23);
			this.SexMenRadioB.TabIndex = 0;
			this.SexMenRadioB.TabStop = true;
			this.SexMenRadioB.Text = "Men";
			this.SexMenRadioB.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.EverydayTrainRB);
			this.groupBox1.Controls.Add(this.OftenTrainRB);
			this.groupBox1.Controls.Add(this.RarelyTrainRB);
			this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.groupBox1.Location = new System.Drawing.Point(456, 119);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(276, 126);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "How ofter do you train?";
			// 
			// EverydayTrainRB
			// 
			this.EverydayTrainRB.AutoSize = true;
			this.EverydayTrainRB.Location = new System.Drawing.Point(7, 83);
			this.EverydayTrainRB.Name = "EverydayTrainRB";
			this.EverydayTrainRB.Size = new System.Drawing.Size(96, 23);
			this.EverydayTrainRB.TabIndex = 2;
			this.EverydayTrainRB.TabStop = true;
			this.EverydayTrainRB.Text = "Everyday";
			this.EverydayTrainRB.UseVisualStyleBackColor = true;
			// 
			// OftenTrainRB
			// 
			this.OftenTrainRB.AutoSize = true;
			this.OftenTrainRB.Location = new System.Drawing.Point(7, 57);
			this.OftenTrainRB.Name = "OftenTrainRB";
			this.OftenTrainRB.Size = new System.Drawing.Size(252, 23);
			this.OftenTrainRB.TabIndex = 1;
			this.OftenTrainRB.TabStop = true;
			this.OftenTrainRB.Text = "Often(3-5 times in the week)";
			this.OftenTrainRB.UseVisualStyleBackColor = true;
			// 
			// RarelyTrainRB
			// 
			this.RarelyTrainRB.AutoSize = true;
			this.RarelyTrainRB.Location = new System.Drawing.Point(7, 28);
			this.RarelyTrainRB.Name = "RarelyTrainRB";
			this.RarelyTrainRB.Size = new System.Drawing.Size(255, 23);
			this.RarelyTrainRB.TabIndex = 0;
			this.RarelyTrainRB.TabStop = true;
			this.RarelyTrainRB.Text = "Rarely (1-3 times in the week)";
			this.RarelyTrainRB.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(323, 275);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(207, 19);
			this.label6.TabIndex = 12;
			this.label6.Text = "Your basic metabolism is:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(536, 275);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(206, 19);
			this.label7.TabIndex = 13;
			this.label7.Text = "Your total metabolism is:";
			// 
			// BasicMetaTB
			// 
			this.BasicMetaTB.Location = new System.Drawing.Point(327, 325);
			this.BasicMetaTB.Name = "BasicMetaTB";
			this.BasicMetaTB.Size = new System.Drawing.Size(203, 20);
			this.BasicMetaTB.TabIndex = 14;
			// 
			// Total_metabTB
			// 
			this.Total_metabTB.Location = new System.Drawing.Point(543, 325);
			this.Total_metabTB.Name = "Total_metabTB";
			this.Total_metabTB.Size = new System.Drawing.Size(202, 20);
			this.Total_metabTB.TabIndex = 15;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Location = new System.Drawing.Point(-7, 360);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(752, 100);
			this.panel1.TabIndex = 16;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::FitLifeStyleApp.Properties.Resources.info;
			this.pictureBox3.Location = new System.Drawing.Point(73, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(136, 94);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 1;
			this.pictureBox3.TabStop = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.Location = new System.Drawing.Point(228, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(427, 81);
			this.label8.TabIndex = 0;
			this.label8.Text = "The basic metabolism is calculated only on the basis of our height, weight, and a" +
    "ge. Total metabolism also includes how often we play sports.";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Maroon;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.button1.Location = new System.Drawing.Point(188, 291);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 54);
			this.button1.TabIndex = 17;
			this.button1.Text = "Calulate!";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// CaloriesCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.ForestGreen;
			this.ClientSize = new System.Drawing.Size(744, 457);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Total_metabTB);
			this.Controls.Add(this.BasicMetaTB);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.Sex_GroupBox);
			this.Controls.Add(this.height_CC_TextBox);
			this.Controls.Add(this.Age_CC_TextBox);
			this.Controls.Add(this.Weight_CC_TextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CaloriesPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CaloriesCalc";
			this.Text = "Form2";
			this.CaloriesPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.Sex_GroupBox.ResumeLayout(false);
			this.Sex_GroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel CaloriesPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Weight_CC_TextBox;
		private System.Windows.Forms.TextBox Age_CC_TextBox;
		private System.Windows.Forms.TextBox height_CC_TextBox;
		private System.Windows.Forms.GroupBox Sex_GroupBox;
		private System.Windows.Forms.RadioButton SexWomenRadioButton;
		private System.Windows.Forms.RadioButton SexMenRadioB;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton EverydayTrainRB;
		private System.Windows.Forms.RadioButton OftenTrainRB;
		private System.Windows.Forms.RadioButton RarelyTrainRB;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox BasicMetaTB;
		private System.Windows.Forms.TextBox Total_metabTB;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button button2;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.Button button1;
	}
}