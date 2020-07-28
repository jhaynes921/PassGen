namespace PassGen
{
	partial class Form1
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
			this.cbLowerCase = new System.Windows.Forms.CheckBox();
			this.cbUpperCase = new System.Windows.Forms.CheckBox();
			this.cbNumber = new System.Windows.Forms.CheckBox();
			this.cbSpecialChar = new System.Windows.Forms.CheckBox();
			this.tbSpecialChars = new System.Windows.Forms.TextBox();
			this.lbSpecialChar = new System.Windows.Forms.Label();
			this.nudMaxLength = new System.Windows.Forms.NumericUpDown();
			this.nudMinLength = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbPassword = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbNoRepeats = new System.Windows.Forms.CheckBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinLength)).BeginInit();
			this.SuspendLayout();
			// 
			// cbLowerCase
			// 
			this.cbLowerCase.AutoSize = true;
			this.cbLowerCase.Location = new System.Drawing.Point(33, 31);
			this.cbLowerCase.Name = "cbLowerCase";
			this.cbLowerCase.Size = new System.Drawing.Size(82, 17);
			this.cbLowerCase.TabIndex = 0;
			this.cbLowerCase.Text = "Lower Case";
			this.cbLowerCase.UseVisualStyleBackColor = true;
			// 
			// cbUpperCase
			// 
			this.cbUpperCase.AutoSize = true;
			this.cbUpperCase.Location = new System.Drawing.Point(33, 54);
			this.cbUpperCase.Name = "cbUpperCase";
			this.cbUpperCase.Size = new System.Drawing.Size(82, 17);
			this.cbUpperCase.TabIndex = 0;
			this.cbUpperCase.Text = "Upper Case";
			this.cbUpperCase.UseVisualStyleBackColor = true;
			// 
			// cbNumber
			// 
			this.cbNumber.AutoSize = true;
			this.cbNumber.Location = new System.Drawing.Point(33, 77);
			this.cbNumber.Name = "cbNumber";
			this.cbNumber.Size = new System.Drawing.Size(68, 17);
			this.cbNumber.TabIndex = 0;
			this.cbNumber.Text = "Numbers";
			this.cbNumber.UseVisualStyleBackColor = true;
			// 
			// cbSpecialChar
			// 
			this.cbSpecialChar.AutoSize = true;
			this.cbSpecialChar.Location = new System.Drawing.Point(33, 100);
			this.cbSpecialChar.Name = "cbSpecialChar";
			this.cbSpecialChar.Size = new System.Drawing.Size(110, 17);
			this.cbSpecialChar.TabIndex = 0;
			this.cbSpecialChar.Text = "Special Character";
			this.cbSpecialChar.UseVisualStyleBackColor = true;
			this.cbSpecialChar.CheckedChanged += new System.EventHandler(this.cbSpecialChar_CheckedChanged);
			// 
			// tbSpecialChars
			// 
			this.tbSpecialChars.Location = new System.Drawing.Point(33, 141);
			this.tbSpecialChars.Name = "tbSpecialChars";
			this.tbSpecialChars.Size = new System.Drawing.Size(275, 20);
			this.tbSpecialChars.TabIndex = 1;
			this.tbSpecialChars.Text = "@ % + \\ / \' ! # $ ^ ? : , ( ) { } [ ] ~ - _ .";
			// 
			// lbSpecialChar
			// 
			this.lbSpecialChar.AutoSize = true;
			this.lbSpecialChar.Location = new System.Drawing.Point(33, 125);
			this.lbSpecialChar.Name = "lbSpecialChar";
			this.lbSpecialChar.Size = new System.Drawing.Size(257, 13);
			this.lbSpecialChar.TabIndex = 2;
			this.lbSpecialChar.Text = "Possible Special Characters (separated with a space)";
			// 
			// nudMaxLength
			// 
			this.nudMaxLength.Location = new System.Drawing.Point(369, 51);
			this.nudMaxLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudMaxLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMaxLength.Name = "nudMaxLength";
			this.nudMaxLength.Size = new System.Drawing.Size(50, 20);
			this.nudMaxLength.TabIndex = 3;
			this.nudMaxLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudMaxLength.ValueChanged += new System.EventHandler(this.nudMaxLength_ValueChanged);
			// 
			// nudMinLength
			// 
			this.nudMinLength.Location = new System.Drawing.Point(258, 51);
			this.nudMinLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudMinLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMinLength.Name = "nudMinLength";
			this.nudMinLength.Size = new System.Drawing.Size(50, 20);
			this.nudMinLength.TabIndex = 3;
			this.nudMinLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.nudMinLength.ValueChanged += new System.EventHandler(this.nudMinLength_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(204, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Minimum";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(314, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Maximum";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(204, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password Length:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// tbPassword
			// 
			this.tbPassword.Location = new System.Drawing.Point(207, 269);
			this.tbPassword.Name = "tbPassword";
			this.tbPassword.Size = new System.Drawing.Size(500, 20);
			this.tbPassword.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Must Include:";
			this.label4.Click += new System.EventHandler(this.label3_Click);
			// 
			// cbNoRepeats
			// 
			this.cbNoRepeats.AutoSize = true;
			this.cbNoRepeats.Location = new System.Drawing.Point(33, 167);
			this.cbNoRepeats.Name = "cbNoRepeats";
			this.cbNoRepeats.Size = new System.Drawing.Size(126, 17);
			this.cbNoRepeats.TabIndex = 6;
			this.cbNoRepeats.Text = "No repeat characters";
			this.cbNoRepeats.UseVisualStyleBackColor = false;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(852, 25);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 7;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(953, 503);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.cbNoRepeats);
			this.Controls.Add(this.tbPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudMinLength);
			this.Controls.Add(this.nudMaxLength);
			this.Controls.Add(this.lbSpecialChar);
			this.Controls.Add(this.tbSpecialChars);
			this.Controls.Add(this.cbSpecialChar);
			this.Controls.Add(this.cbNumber);
			this.Controls.Add(this.cbUpperCase);
			this.Controls.Add(this.cbLowerCase);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudMaxLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinLength)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox cbLowerCase;
		private System.Windows.Forms.CheckBox cbUpperCase;
		private System.Windows.Forms.CheckBox cbNumber;
		private System.Windows.Forms.CheckBox cbSpecialChar;
		private System.Windows.Forms.TextBox tbSpecialChars;
		private System.Windows.Forms.Label lbSpecialChar;
		private System.Windows.Forms.NumericUpDown nudMaxLength;
		private System.Windows.Forms.NumericUpDown nudMinLength;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbPassword;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbNoRepeats;
		private System.Windows.Forms.Button btnGenerate;
	}
}

