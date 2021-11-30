using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanstwaMiastaWinForms
{
	public partial class LetterAnimation : UserControl
	{
		public LetterAnimation()
		{
			InitializeComponent();
		}
		int i = 0; 
		private void timer1_Tick(object sender, EventArgs e)
		{
			letter.Text = Variables.alphabet[i].ToString().ToUpper();
			if (i == Variables.currentLetterIndex)
			{
				timer1.Enabled = false;
				button1.Visible = true;
				letter.ForeColor = Color.Lime; 
			}
			i++;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Visible = false; 
		}
	}
}
