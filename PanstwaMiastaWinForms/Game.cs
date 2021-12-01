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
	public partial class Game : Form
	{
		public Game()
		{
			InitializeComponent();
			letter.Text = "Litera: " + Char.ToUpper(Variables.alphabet[Variables.randomIndexes[Variables.currentRoundNumber-1]]);
			roundLabel.Text = "Runda: " + Variables.currentRoundNumber + "/" + Variables.roundsAmount;
			this.Text = "Panstwa-miasta - runda " + Variables.currentRoundNumber + "/" + Variables.roundsAmount; 
		}

		private void button1_Click(object sender, EventArgs e)
		{
			addAnswersToList();
			lockTextboxes();
			if (Variables.possibleAnswers[0].Contains(panstwo.Text))
				panstwo.BackColor = Color.LightGreen;
			else
				panstwo.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[1].Contains(miasto.Text))
				miasto.BackColor = Color.LightGreen;
			else
				miasto.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[2].Contains(zwierze.Text))
				zwierze.BackColor = Color.LightGreen;
			else
				zwierze.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[3].Contains(zawod.Text))
				zawod.BackColor = Color.LightGreen;
			else
				zawod.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[4].Contains(owoc.Text))
				owoc.BackColor = Color.LightGreen;
			else
				owoc.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[5].Contains(kolor.Text))
				kolor.BackColor = Color.LightGreen;
			else
				kolor.BackColor = Color.OrangeRed;
			button1.Visible = false;
			button2.Visible = true; 
		}
		
		private void button2_Click(object sender, EventArgs e)
		{
			// construct new scoreboard
			hideStuff();
			scoreboard(); 

		}
		private void addAnswersToList()
		{
			Variables.allGivenAnswers.Add(panstwo.Text);
			Variables.allGivenAnswers.Add(miasto.Text);
			Variables.allGivenAnswers.Add(zwierze.Text);
			Variables.allGivenAnswers.Add(zawod.Text);
			Variables.allGivenAnswers.Add(owoc.Text);
			Variables.allGivenAnswers.Add(kolor.Text);
		}
		private void lockTextboxes()
		{
			panstwo.ReadOnly = true;
			miasto.ReadOnly = true;
			zwierze.ReadOnly = true;
			zawod.ReadOnly = true;
			owoc.ReadOnly = true;
			kolor.ReadOnly = true;
		}
		private void hideStuff()
		{
			// I can't make new userform to appear in front so I make every element invisible

		}
		private void scoreboard()
		{
			Scoreboard scoreboard = new Scoreboard();
			scoreboard.BringToFront();
			scoreboard.Location = new System.Drawing.Point(0, 0);
			scoreboard.Name = "scoreboard";
			scoreboard.Size = new System.Drawing.Size(1012, 617);
			scoreboard.TabIndex = 26;

			Controls.Add(scoreboard);
		}
		Random rd = new Random(); 
		private string useCheat(int category)
		{
			int possibilities = Variables.possibleAnswers[category].Count;
			if (possibilities != 0)
			{
				cheatPanstwo.Visible = false;
				cheatMiasto.Visible = false;
				cheatZwierze.Visible = false;
				cheatZawod.Visible = false;
				cheatOwoc.Visible = false;
				cheatKolor.Visible = false;
				int idx = rd.Next(possibilities);
				string answer = Variables.possibleAnswers[category][idx];
				return answer;
			}
			else
				return ""; 
		}
		
		private void cheatPanstwo_Click(object sender, EventArgs e)
		{
			panstwo.Text = useCheat(0);
		}

		private void cheatMiasto_Click(object sender, EventArgs e)
		{
			miasto.Text = useCheat(1);
		}

		private void cheatZwierze_Click(object sender, EventArgs e)
		{
			zwierze.Text = useCheat(2);
		}

		private void cheatZawod_Click(object sender, EventArgs e)
		{
			zawod.Text = useCheat(3);
		}

		private void cheatOwoc_Click(object sender, EventArgs e)
		{
			owoc.Text = useCheat(4);
		}

		private void cheatKolor_Click(object sender, EventArgs e)
		{
			kolor.Text = useCheat(5);
		}
	}
}
