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
					lbl.Top = i+j + 1 * 30; // 87
					lbl.Left = i+j + 1 * 160; // 415
					int whichPlayer = Model.sortedPoints[i].Item1;
					int points = Model.sortedPoints[i].Item2;
					
					if (j == -1)
						// lbl.Text = "Gracz" + whichPlayer;
						Console.WriteLine("Gracz " + whichPlayer);
					else if (j != 6)
					{
						if (i != Model.numberOfBots)
							//lbl.Text = Model.answersGivenByBots[whichPlayer][j];
							Console.WriteLine(Model.answersGivenByBots[whichPlayer][j]);
						else
							// lbl.Text = Model.answersGivenByPlayer[j];
							Console.WriteLine(Model.answersGivenByPlayer[j]);
					}
					else
						// lbl.Text = points.ToString(); 
						Console.WriteLine(points); 
					

				}
			}
			
		}
	}
}
