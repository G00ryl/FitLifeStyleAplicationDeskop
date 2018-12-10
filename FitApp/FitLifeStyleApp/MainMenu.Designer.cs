namespace FitLifeStyleApp
{
	partial class MainMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
			this.OptionsPanel = new System.Windows.Forms.Panel();
			this.ExerciseButton = new System.Windows.Forms.Button();
			this.CaloriesButton = new System.Windows.Forms.Button();
			this.BMI_CalcButton = new System.Windows.Forms.Button();
			this.logopanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.CompanyNameLabel = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ExitButton = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.InformationLabel = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.OptionsPanel.SuspendLayout();
			this.logopanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// OptionsPanel
			// 
			this.OptionsPanel.BackColor = System.Drawing.Color.MidnightBlue;
			this.OptionsPanel.Controls.Add(this.pictureBox5);
			this.OptionsPanel.Controls.Add(this.button2);
			this.OptionsPanel.Controls.Add(this.pictureBox4);
			this.OptionsPanel.Controls.Add(this.pictureBox6);
			this.OptionsPanel.Controls.Add(this.pictureBox3);
			this.OptionsPanel.Controls.Add(this.ExerciseButton);
			this.OptionsPanel.Controls.Add(this.CaloriesButton);
			this.OptionsPanel.Controls.Add(this.BMI_CalcButton);
			this.OptionsPanel.Controls.Add(this.logopanel);
			this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.OptionsPanel.Location = new System.Drawing.Point(0, 0);
			this.OptionsPanel.Name = "OptionsPanel";
			this.OptionsPanel.Size = new System.Drawing.Size(200, 641);
			this.OptionsPanel.TabIndex = 0;
			this.OptionsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.OptionsPanel_Paint);
			// 
			// ExerciseButton
			// 
			this.ExerciseButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ExerciseButton.Location = new System.Drawing.Point(0, 241);
			this.ExerciseButton.Name = "ExerciseButton";
			this.ExerciseButton.Size = new System.Drawing.Size(206, 76);
			this.ExerciseButton.TabIndex = 5;
			this.ExerciseButton.Text = "     Find exercises";
			this.ExerciseButton.UseVisualStyleBackColor = true;
			this.ExerciseButton.Click += new System.EventHandler(this.ExerciseButton_Click);
			// 
			// CaloriesButton
			// 
			this.CaloriesButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CaloriesButton.Location = new System.Drawing.Point(0, 159);
			this.CaloriesButton.Name = "CaloriesButton";
			this.CaloriesButton.Size = new System.Drawing.Size(206, 76);
			this.CaloriesButton.TabIndex = 4;
			this.CaloriesButton.Text = "            Calories Calculator";
			this.CaloriesButton.UseVisualStyleBackColor = true;
			this.CaloriesButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// BMI_CalcButton
			// 
			this.BMI_CalcButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.BMI_CalcButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.BMI_CalcButton.Location = new System.Drawing.Point(0, 77);
			this.BMI_CalcButton.Name = "BMI_CalcButton";
			this.BMI_CalcButton.Size = new System.Drawing.Size(206, 76);
			this.BMI_CalcButton.TabIndex = 3;
			this.BMI_CalcButton.Text = "     BMI Calculator";
			this.BMI_CalcButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.BMI_CalcButton.UseVisualStyleBackColor = true;
			this.BMI_CalcButton.Click += new System.EventHandler(this.BMI_Calc_Click);
			// 
			// logopanel
			// 
			this.logopanel.BackColor = System.Drawing.Color.SeaGreen;
			this.logopanel.Controls.Add(this.panel1);
			this.logopanel.Controls.Add(this.pictureBox2);
			this.logopanel.Controls.Add(this.CompanyNameLabel);
			this.logopanel.Location = new System.Drawing.Point(0, 0);
			this.logopanel.Name = "logopanel";
			this.logopanel.Size = new System.Drawing.Size(200, 71);
			this.logopanel.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(200, 71);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(813, 90);
			this.panel1.TabIndex = 3;
			// 
			// CompanyNameLabel
			// 
			this.CompanyNameLabel.AutoSize = true;
			this.CompanyNameLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CompanyNameLabel.Location = new System.Drawing.Point(3, 21);
			this.CompanyNameLabel.Name = "CompanyNameLabel";
			this.CompanyNameLabel.Size = new System.Drawing.Size(152, 33);
			this.CompanyNameLabel.TabIndex = 0;
			this.CompanyNameLabel.Text = "FitLifestyle";
			this.CompanyNameLabel.Click += new System.EventHandler(this.CompanyNameLabel_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.ExitButton);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(200, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(813, 71);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(767, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(25, 25);
			this.button1.TabIndex = 12;
			this.button1.Text = "-";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(36, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Dashboard";
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(788, 0);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(25, 25);
			this.ExitButton.TabIndex = 0;
			this.ExitButton.Text = "X";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.InformationLabel);
			this.panel3.Location = new System.Drawing.Point(200, 71);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(813, 90);
			this.panel3.TabIndex = 3;
			// 
			// InformationLabel
			// 
			this.InformationLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.InformationLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.InformationLabel.Location = new System.Drawing.Point(24, 14);
			this.InformationLabel.Name = "InformationLabel";
			this.InformationLabel.Size = new System.Drawing.Size(746, 76);
			this.InformationLabel.TabIndex = 0;
			this.InformationLabel.Text = resources.GetString("InformationLabel.Text");
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(0, 505);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(200, 76);
			this.button2.TabIndex = 12;
			this.button2.Text = "Exit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FitLifeStyleApp.Properties.Resources._123;
			this.pictureBox1.Location = new System.Drawing.Point(200, 159);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(813, 494);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.White;
			this.pictureBox5.Image = global::FitLifeStyleApp.Properties.Resources.ddd;
			this.pictureBox5.Location = new System.Drawing.Point(9, 527);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(40, 34);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 13;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.Image = global::FitLifeStyleApp.Properties.Resources.cardio;
			this.pictureBox4.Location = new System.Drawing.Point(9, 254);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(40, 34);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 11;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::FitLifeStyleApp.Properties.Resources.kcal1;
			this.pictureBox6.Location = new System.Drawing.Point(9, 174);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(40, 34);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 10;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::FitLifeStyleApp.Properties.Resources.dasx;
			this.pictureBox3.Location = new System.Drawing.Point(9, 94);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(40, 34);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 7;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::FitLifeStyleApp.Properties.Resources.strong;
			this.pictureBox2.Location = new System.Drawing.Point(157, 22);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(40, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1013, 641);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.OptionsPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.OptionsPanel.ResumeLayout(false);
			this.logopanel.ResumeLayout(false);
			this.logopanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel OptionsPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel logopanel;
		private System.Windows.Forms.Label CompanyNameLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button BMI_CalcButton;
		private System.Windows.Forms.Button ExerciseButton;
		private System.Windows.Forms.Button CaloriesButton;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label InformationLabel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button button2;
	}
}

