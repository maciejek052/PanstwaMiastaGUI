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
	public partial class Scoreboard : UserControl
	{
		public Scoreboard()
		{
			InitializeComponent();
			Console.Clear(); 
			
			for (int i = 0; i < Model.numberOfBots + 1; i++)
			{
				for (int j = -1; j < 7; j++)
				{
					Label lbl = new Label();
					this.Controls.Add(lbl); 
					lbl.Top = (i + 1) * 60; // 87
					lbl.Left = (j + 1) * 100; // 415
					int whichPlayer = Model.sortedPoints[i].Item1;
					int points = Model.sortedPoints[i].Item2;
					
					if (j == -1)
					{
						if (whichPlayer == Model.numberOfBots)
							lbl.Text = "Gracz";
						else
							lbl.Text = "Bot " + (whichPlayer + 1); 

						//Console.WriteLine("Gracz " + whichPlayer);
					}

					else if (j != 6)
					{
						if (whichPlayer != Model.numberOfBots)
						{
							lbl.Text = Model.answersGivenByBots[whichPlayer][j];
							//Console.WriteLine(Model.answersGivenByBots[whichPlayer][j]);
						}
						else
						{
							lbl.Text = Model.answersGivenByPlayer[j];
							//Console.WriteLine(Model.answersGivenByPlayer[j]);
						}

					}
					else
					{
						lbl.Text = points.ToString();
						//Console.WriteLine(points); 
					}
				}
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.OpenForms["Game"].Close();  
		}
	}
}
