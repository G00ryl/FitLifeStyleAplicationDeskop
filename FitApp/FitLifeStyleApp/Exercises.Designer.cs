namespace FitLifeStyleApp
{
	partial class Exercises
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
			this.ExitButton = new System.Windows.Forms.Button();
			this.MinimizeButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.ExerciseBox = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// ExitButton
			// 
			this.ExitButton.ForeColor = System.Drawing.Color.Black;
			this.ExitButton.Location = new System.Drawing.Point(422, 0);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(25, 25);
			this.ExitButton.TabIndex = 1;
			this.ExitButton.Text = "X";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MinimizeButton
			// 
			this.MinimizeButton.ForeColor = System.Drawing.Color.Black;
			this.MinimizeButton.Location = new System.Drawing.Point(400, 0);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.Size = new System.Drawing.Size(25, 25);
			this.MinimizeButton.TabIndex = 15;
			this.MinimizeButton.Text = "-";
			this.MinimizeButton.UseVisualStyleBackColor = true;
			this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.ExitButton);
			this.panel1.Controls.Add(this.MinimizeButton);
			this.panel1.ForeColor = System.Drawing.Color.Gold;
			this.panel1.Location = new System.Drawing.Point(-4, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(450, 83);
			this.panel1.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(110, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(245, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Here is your exercises hyperlink:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Location = new System.Drawing.Point(-4, 135);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(447, 125);
			this.panel2.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(156, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(306, 101);
			this.label2.TabIndex = 1;
			this.label2.Text = "Remember not to overload yourself. Sometimes it is better to raise less to avoid " +
    "injury.";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FitLifeStyleApp.Properties.Resources.info;
			this.pictureBox1.Location = new System.Drawing.Point(4, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(128, 119);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Red;
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.pictureBox2);
			this.panel3.Controls.Add(this.ExerciseBox);
			this.panel3.Location = new System.Drawing.Point(0, 81);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(446, 60);
			this.panel3.TabIndex = 18;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(168, 28);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 28);
			this.button1.TabIndex = 2;
			this.button1.Text = "Copy!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::FitLifeStyleApp.Properties.Resources.axdddasd12;
			this.pictureBox2.Location = new System.Drawing.Point(249, 28);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(54, 29);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// ExerciseBox
			// 
			this.ExerciseBox.BackColor = System.Drawing.Color.Yellow;
			this.ExerciseBox.Location = new System.Drawing.Point(45, 3);
			this.ExerciseBox.Name = "ExerciseBox";
			this.ExerciseBox.Size = new System.Drawing.Size(348, 20);
			this.ExerciseBox.TabIndex = 0;
			this.ExerciseBox.TextChanged += new System.EventHandler(this.ExerciseBox_TextChanged);
			// 
			// Exercises
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(442, 254);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Exercises";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button MinimizeButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox ExerciseBox;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button1;
	}
}