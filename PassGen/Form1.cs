using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PassGen;

namespace PassGen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			ShowHideSpecialCharBox();
		}
	
		private string[] Uppers = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
		private string[] Lowers = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
		private string[] Numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

		private void cbSpecialChar_CheckedChanged(object sender, EventArgs e)
		{
			ShowHideSpecialCharBox();
		}
		private void ShowHideSpecialCharBox()

		{
			if (cbSpecialChar.Checked == true)
			{
				lbSpecialChar.Visible = true;
				tbSpecialChars.Visible = true;
			}
			else
			{
				lbSpecialChar.Visible = false;
				tbSpecialChars.Visible = false;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			GeneratePassword();
		}

		private void GeneratePassword()
		{
			tbPassword.Clear();
			int maxPwLength = Helpers.C_INT(nudMaxLength.Value.ToString());
			int minPwLength = Helpers.C_INT(nudMinLength.Value.ToString());
			bool incUpper = cbUpperCase.Checked;
			bool incLower = cbLowerCase.Checked;
			bool incNumbers = cbNumber.Checked;
			bool incSpecChar = cbSpecialChar.Checked;
			string[] specChars = tbSpecialChars.Text.Split(' ');
			bool noRepeats = cbNoRepeats.Checked;

			List<string> AvailableCharacters = new List<string>();
			if (incUpper == true) { foreach (string character in Uppers){ AvailableCharacters.Add(character); } }
			if (incLower == true) { foreach (string character in Lowers) { AvailableCharacters.Add(character); } }
			if (incNumbers == true) { foreach (string character in Numbers) { AvailableCharacters.Add(character); } }
			if (incSpecChar == true) { foreach (string character in specChars) { AvailableCharacters.Add(character); } }




		}

		private void nudMinLength_ValueChanged(object sender, EventArgs e)
		{
			int maxPwLength = Helpers.C_INT(nudMaxLength.Value.ToString());
			int minPwLength = Helpers.C_INT(nudMinLength.Value.ToString());
			if (minPwLength > maxPwLength) { nudMaxLength.Value = minPwLength; }
		}

		private void nudMaxLength_ValueChanged(object sender, EventArgs e)
		{
			int maxPwLength = Helpers.C_INT(nudMaxLength.Value.ToString());
			int minPwLength = Helpers.C_INT(nudMinLength.Value.ToString());
			if (minPwLength > maxPwLength) { nudMinLength.Value = maxPwLength; }
		}
	}
}
