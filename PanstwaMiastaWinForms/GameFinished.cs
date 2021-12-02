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
	public partial class GameFinished : Form
	{
		public GameFinished()
		{
			InitializeComponent();
			if (Model.sortedPoints[0].Item2 == Model.playerPoints)
			{
				label1.Text = "Wygrałeś!";
				this.BackColor = Color.Green;
				this.Text = "Winner winner chicken dinner";
			}
			else
			{
				label1.Text = "Przegrałeś!";
				this.BackColor = Color.Red;
				this.Text = "Kompletna porażka";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close(); 
		}
	}
}
