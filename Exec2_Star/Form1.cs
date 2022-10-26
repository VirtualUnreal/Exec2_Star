using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ButtonMiddle_Click(object sender, EventArgs e)
		{
			try
			{
				int result1 = Input();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			int push = Input();
			string star = string.Empty;
			for (int i = 1; i <= Input(); i++)
			{
				string space = new string(' ', push - i);
				star += space + new string('*', i) + "\r\n";
				TextBoxOutput.Text = star;
			}
		}

		private void ButtonLeft_Click(object sender, EventArgs e)
		{
			try
			{
				int result1 = Input();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			string star = string.Empty;
			for (int i = 1; i <= Input(); i++)
			{
				star += new string('*', i) + "\r\n";
				TextBoxOutput.Text = star;
			}

		}
		private int Input()
		{
			string get = TextBoxInput.Text;
			bool isInt = int.TryParse(get, out int input);
			if (isInt == false)
			{
				throw new Exception("您輸入的值不符，請重新輸入");
			}

			if (input >= 1 && input <= 10)
			{
				return input;
			}
			else
			{
				throw new Exception("您輸入的不在範圍內，請重新輸入");
			}
		}

		private void ButtonRight_Click(object sender, EventArgs e)
		{//todo 解決字型無法讓結果正確顯示的問題
			try
			{
				int result1 = Input();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			int push = Input();
			string star = string.Empty;
			for (int i = 1; i <= Input(); i++)
			{
				string space = new string(' ',(push-i) );

				star +=  (space +new string('*', i) + "\r\n");
				
				TextBoxOutput.Text = star;
			}
		}
	}
}
