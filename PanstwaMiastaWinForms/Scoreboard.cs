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
			this.DoubleBuffered = true;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			InitializeComponent();
			this.DoubleBuffered = true; 
			roundNo.Text = "Koniec rundy " + Model.currentRoundNumber;
			for (int i = 0; i < Model.numberOfBots + 1; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Label lbl = new Label();
					this.Controls.Add(lbl);
					lbl.BringToFront();
					lbl.BackColor = Color.Transparent;
					lbl.MaximumSize = new Size(120, 0);
					lbl.AutoSize = true; 
					lbl.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
					lbl.Location = new System.Drawing.Point(7 + (j * 131), 183 + (i*50));
					int whichPlayer = Model.sortedPoints[i].Item1;
					int points = Model.sortedPoints[i].Item2;
					if (j == 0)
					{
						if (whichPlayer == Model.numberOfBots)
							lbl.Text = Model.playerName; 
						else
							lbl.Text = "Bot " + (whichPlayer + 1); 

					}

					else if (j != 7)
					{
						if (whichPlayer != Model.numberOfBots)
						{
							int answerPoints = Model.botAnwerPoints[whichPlayer, j - 1];
							if (answerPoints == 15)
								lbl.ForeColor = Color.Green;
							else if (answerPoints == 10)
								lbl.ForeColor = Color.Yellow;
							else
								lbl.ForeColor = Color.Red; 
							lbl.Text = Model.answersGivenByBots[whichPlayer][j-1] + " " + answerPoints;
						}
						else
						{
							yourPlace.Text = "Zajmujesz " + (i+1) + " miejsce";
							int answerPoints = Model.playerAnswerPoints[j - 1];
							if (answerPoints == 15)
								lbl.ForeColor = Color.Green;
							else if (answerPoints == 10)
								lbl.ForeColor = Color.Yellow;
							else
								lbl.ForeColor = Color.Red;
							if (Model.answersGivenByPlayer[j - 1] == "")
								lbl.Text = "- " + answerPoints;
							else
								lbl.Text = Model.answersGivenByPlayer[j - 1] + " " + answerPoints;
						}

					}
					else
					{
						lbl.Text = points.ToString();
					}
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Application.OpenForms["Game"].Close();  
		}

		private void Scoreboard_Load(object sender, EventArgs e)
		{

		}
	}
}
