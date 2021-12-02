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
			this.ControlBox = false;
			this.DoubleBuffered = true;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			if (Model.sortedPoints[0].Item2 == Model.playerPoints)
			{
				this.BackgroundImage = global::PanstwaMiastaWinForms.Properties.Resources.bg_logo_green;
				label1.Text = "Wygrałeś! Twój wynik to " + Model.playerPoints;
				label1.ForeColor = Color.Green;
				winGif.Visible = true; 
				this.Text = "Winner winner chicken dinner";
			}
			else
			{
				this.BackgroundImage = global::PanstwaMiastaWinForms.Properties.Resources.bg_logo_red;
				label1.Text = "Przegrałeś! Twój wynik to " + Model.playerPoints;
				label1.ForeColor = Color.Red;
				loseGif.Visible = true;
				this.Text = "Kompletna porażka";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close(); 
		}
	}
}
