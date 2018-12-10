namespace FitLifeStyleApp
{
	partial class BMI_Calc
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
			this.BMI_CALC_PANEL = new System.Windows.Forms.Panel();
			this.MinimizeButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.BMI_CALC_LABEL = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.Height_Panel = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.Height_TextBox = new System.Windows.Forms.TextBox();
			this.Height_Label = new System.Windows.Forms.Label();
			this.Weight_Panel = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.WeightLabel = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.Weight_Box = new System.Windows.Forms.TextBox();
			this.BMI_LABEL = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.ResultBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.BMI_CALC_PANEL.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.Height_Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.Weight_Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// BMI_CALC_PANEL
			// 
			this.BMI_CALC_PANEL.BackColor = System.Drawing.Color.SeaGreen;
			this.BMI_CALC_PANEL.Controls.Add(this.MinimizeButton);
			this.BMI_CALC_PANEL.Controls.Add(this.ExitButton);
			this.BMI_CALC_PANEL.Controls.Add(this.pictureBox1);
			this.BMI_CALC_PANEL.Controls.Add(this.BMI_CALC_LABEL);
			this.BMI_CALC_PANEL.Controls.Add(this.panel1);
			this.BMI_CALC_PANEL.ForeColor = System.Drawing.Color.Cyan;
			this.BMI_CALC_PANEL.Location = new System.Drawing.Point(0, 0);
			this.BMI_CALC_PANEL.Name = "BMI_CALC_PANEL";
			this.BMI_CALC_PANEL.Size = new System.Drawing.Size(745, 100);
			this.BMI_CALC_PANEL.TabIndex = 0;
			// 
			// MinimizeButton
			// 
			this.MinimizeButton.ForeColor = System.Drawing.Color.Black;
			this.MinimizeButton.Location = new System.Drawing.Point(701, -3);
			this.MinimizeButton.Name = "MinimizeButton";
			this.MinimizeButton.Size = new System.Drawing.Size(25, 25);
			this.MinimizeButton.TabIndex = 13;
			this.MinimizeButton.Text = "-";
			this.MinimizeButton.UseVisualStyleBackColor = true;
			this.MinimizeButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.ForeColor = System.Drawing.Color.Black;
			this.ExitButton.Location = new System.Drawing.Point(722, -3);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(25, 25);
			this.ExitButton.TabIndex = 8;
			this.ExitButton.Text = "X";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::FitLifeStyleApp.Properties.Resources.icons_bmi;
			this.pictureBox1.Location = new System.Drawing.Point(403, -7);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(342, 107);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// BMI_CALC_LABEL
			// 
			this.BMI_CALC_LABEL.AllowDrop = true;
			this.BMI_CALC_LABEL.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.BMI_CALC_LABEL.ForeColor = System.Drawing.Color.Black;
			this.BMI_CALC_LABEL.Location = new System.Drawing.Point(24, 23);
			this.BMI_CALC_LABEL.Name = "BMI_CALC_LABEL";
			this.BMI_CALC_LABEL.Size = new System.Drawing.Size(372, 58);
			this.BMI_CALC_LABEL.TabIndex = 0;
			this.BMI_CALC_LABEL.Text = "BMI CALULATOR";
			this.BMI_CALC_LABEL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Location = new System.Drawing.Point(0, 96);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 362);
			this.panel1.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Location = new System.Drawing.Point(197, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(200, 362);
			this.panel4.TabIndex = 6;
			// 
			// Height_Panel
			// 
			this.Height_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Height_Panel.Controls.Add(this.pictureBox3);
			this.Height_Panel.Controls.Add(this.Height_TextBox);
			this.Height_Panel.Controls.Add(this.Height_Label);
			this.Height_Panel.Location = new System.Drawing.Point(200, 99);
			this.Height_Panel.Name = "Height_Panel";
			this.Height_Panel.Size = new System.Drawing.Size(200, 359);
			this.Height_Panel.TabIndex = 6;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::FitLifeStyleApp.Properties.Resources.Height;
			this.pictureBox3.Location = new System.Drawing.Point(-3, 140);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(203, 219);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// Height_TextBox
			// 
			this.Height_TextBox.Location = new System.Drawing.Point(55, 87);
			this.Height_TextBox.Name = "Height_TextBox";
			this.Height_TextBox.Size = new System.Drawing.Size(100, 20);
			this.Height_TextBox.TabIndex = 1;
			// 
			// Height_Label
			// 
			this.Height_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.Height_Label.Location = new System.Drawing.Point(6, 39);
			this.Height_Label.Name = "Height_Label";
			this.Height_Label.Size = new System.Drawing.Size(181, 19);
			this.Height_Label.TabIndex = 0;
			this.Height_Label.Text = "Enter your height [m]:";
			// 
			// Weight_Panel
			// 
			this.Weight_Panel.BackColor = System.Drawing.SystemColors.Highlight;
			this.Weight_Panel.Controls.Add(this.pictureBox2);
			this.Weight_Panel.Controls.Add(this.WeightLabel);
			this.Weight_Panel.Controls.Add(this.panel2);
			this.Weight_Panel.Controls.Add(this.Weight_Box);
			this.Weight_Panel.Location = new System.Drawing.Point(0, 99);
			this.Weight_Panel.Name = "Weight_Panel";
			this.Weight_Panel.Size = new System.Drawing.Size(200, 359);
			this.Weight_Panel.TabIndex = 5;
			this.Weight_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Weight_Panel_Paint);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::FitLifeStyleApp.Properties.Resources.weight;
			this.pictureBox2.Location = new System.Drawing.Point(0, 140);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(200, 219);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// WeightLabel
			// 
			this.WeightLabel.AutoSize = true;
			this.WeightLabel.BackColor = System.Drawing.SystemColors.Highlight;
			this.WeightLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.WeightLabel.Location = new System.Drawing.Point(3, 39);
			this.WeightLabel.Name = "WeightLabel";
			this.WeightLabel.Size = new System.Drawing.Size(186, 19);
			this.WeightLabel.TabIndex = 3;
			this.WeightLabel.Text = "Enter your weight [kg]:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(197, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(218, 359);
			this.panel2.TabIndex = 2;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// Weight_Box
			// 
			this.Weight_Box.Location = new System.Drawing.Point(47, 87);
			this.Weight_Box.Name = "Weight_Box";
			this.Weight_Box.Size = new System.Drawing.Size(100, 20);
			this.Weight_Box.TabIndex = 4;
			this.Weight_Box.TextChanged += new System.EventHandler(this.Weight_Box_TextChanged);
			// 
			// BMI_LABEL
			// 
			this.BMI_LABEL.AutoSize = true;
			this.BMI_LABEL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.BMI_LABEL.Location = new System.Drawing.Point(529, 138);
			this.BMI_LABEL.Name = "BMI_LABEL";
			this.BMI_LABEL.Size = new System.Drawing.Size(79, 19);
			this.BMI_LABEL.TabIndex = 7;
			this.BMI_LABEL.Text = "Your BMI:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(529, 306);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 19);
			this.label2.TabIndex = 8;
			this.label2.Text = "Result:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(471, 186);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(198, 20);
			this.textBox1.TabIndex = 9;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// ResultBox
			// 
			this.ResultBox.BackColor = System.Drawing.Color.White;
			this.ResultBox.Location = new System.Drawing.Point(471, 328);
			this.ResultBox.Name = "ResultBox";
			this.ResultBox.Size = new System.Drawing.Size(198, 20);
			this.ResultBox.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(507, 239);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 31);
			this.button1.TabIndex = 11;
			this.button1.Text = "Calculate!";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BMI_Calc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(745, 449);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ResultBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BMI_LABEL);
			this.Controls.Add(this.Height_Panel);
			this.Controls.Add(this.Weight_Panel);
			this.Controls.Add(this.BMI_CALC_PANEL);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BMI_Calc";
			this.Text = "BMI_CALC";
			this.BMI_CALC_PANEL.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.Height_Panel.ResumeLayout(false);
			this.Height_Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.Weight_Panel.ResumeLayout(false);
			this.Weight_Panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel BMI_CALC_PANEL;
		private System.Windows.Forms.Label BMI_CALC_LABEL;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label WeightLabel;
		private System.Windows.Forms.TextBox Weight_Box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel Weight_Panel;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel Height_Panel;
		private System.Windows.Forms.TextBox Height_TextBox;
		private System.Windows.Forms.Label Height_Label;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Label BMI_LABEL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox ResultBox;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button MinimizeButton;
	}
}