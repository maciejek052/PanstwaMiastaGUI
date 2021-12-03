﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanstwaMiastaWinForms
{
	public partial class Game : Form
	{
		bool timerWork = false;
		int timeLeft;
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (new StackTrace().GetFrames().Any(x => x.GetMethod().Name == "Close"))
				return; 
			else
				System.Environment.Exit(0);
		}
		public Game()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			letter.Text = "Litera: " + Char.ToUpper(Model.alphabet[Model.randomIndexes[Model.currentRoundNumber-1]]);
			roundLabel.Text = "Runda: " + Model.currentRoundNumber + "/" + Model.roundsAmount;
			this.Text = "Panstwa-miasta - runda " + Model.currentRoundNumber + "/" + Model.roundsAmount;
			switch (Model.difficultyLevel)
			{
				case 0:
					timeLeft = 40;
					break;
				case 1:
					timeLeft = 30;
					break;
				case 2:
					timeLeft = 20;
					hideCheats();
					break;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			lockRound();
		}
		
		private void button2_Click(object sender, EventArgs e)
		{
			// construct new scoreboard
			GameLogic.countPoints(); 
			scoreboard(); 

		}
		private void addAnswersToList()
		{
			Model.allGivenAnswers.Add(panstwo.Text);
			Model.allGivenAnswers.Add(miasto.Text);
			Model.allGivenAnswers.Add(zwierze.Text);
			Model.allGivenAnswers.Add(zawod.Text);
			Model.allGivenAnswers.Add(owoc.Text);
			Model.allGivenAnswers.Add(kolor.Text);
			Model.answersGivenByPlayer[0] = panstwo.Text;
			Model.answersGivenByPlayer[1] = miasto.Text;
			Model.answersGivenByPlayer[2] = zwierze.Text;
			Model.answersGivenByPlayer[3] = zawod.Text;
			Model.answersGivenByPlayer[4] = owoc.Text;
			Model.answersGivenByPlayer[5] = kolor.Text;

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
		private void scoreboard()
		{
			Scoreboard scoreboard = new Scoreboard();
			scoreboard.Location = new System.Drawing.Point(0, 0);
			scoreboard.Name = "scoreboard";
			scoreboard.Size = new System.Drawing.Size(1012, 617);
			// scoreboard.TabIndex = 26;
			Controls.Add(scoreboard);
			scoreboard.BringToFront();
			
		}
		Random rd = new Random(); 
		private string useCheat(int category)
		{
			int possibilities = Model.possibleAnswers[category].Count;
			if (possibilities != 0)
			{
				hideCheats();
				int idx = rd.Next(possibilities);
				string answer = Model.possibleAnswers[category][idx];
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
		public void endRound()
		{
			this.Close(); 
		}
		public void hideCheats()
		{
			cheatPanstwo.Visible = false;
			cheatMiasto.Visible = false;
			cheatZwierze.Visible = false;
			cheatZawod.Visible = false;
			cheatOwoc.Visible = false;
			cheatKolor.Visible = false;
		}
		private void gameTimer_Tick(object sender, EventArgs e)
		{
			if (letterAnimation1.gameStart)
			{
				letterAnimation1.gameStart = false;
				timerWork = true;
				timeLeftLabel.Visible = true; 
			}
			if (timerWork)
			{
				timeLeft--;
				if (timeLeft <= 5)
					timeLeftLabel.ForeColor = Color.Red; 
				timeLeftLabel.Text = "Pozostały czas: " + timeLeft;
			}
			if (timeLeft == 0)
			{
				lockRound();
			}
		}
		void lockRound()
		{
			gameTimer.Enabled = false;
			timeLeftLabel.Visible = false; 
			addAnswersToList();
			hideCheats();
			lockTextboxes();
			if (Model.possibleAnswers[0].Contains(panstwo.Text, StringComparer.OrdinalIgnoreCase))
				panstwo.BackColor = Color.LightGreen;
			else
				panstwo.BackColor = Color.OrangeRed;
			if (Model.possibleAnswers[1].Contains(miasto.Text, StringComparer.OrdinalIgnoreCase))
				miasto.BackColor = Color.LightGreen;
			else
				miasto.BackColor = Color.OrangeRed;
			if (Model.possibleAnswers[2].Contains(zwierze.Text, StringComparer.OrdinalIgnoreCase))
				zwierze.BackColor = Color.LightGreen;
			else
				zwierze.BackColor = Color.OrangeRed;
			if (Model.possibleAnswers[3].Contains(zawod.Text, StringComparer.OrdinalIgnoreCase))
				zawod.BackColor = Color.LightGreen;
			else
				zawod.BackColor = Color.OrangeRed;
			if (Model.possibleAnswers[4].Contains(owoc.Text, StringComparer.OrdinalIgnoreCase))
				owoc.BackColor = Color.LightGreen;
			else
				owoc.BackColor = Color.OrangeRed;
			if (Model.possibleAnswers[5].Contains(kolor.Text, StringComparer.OrdinalIgnoreCase))
				kolor.BackColor = Color.LightGreen;
			else
				kolor.BackColor = Color.OrangeRed;
			button1.Visible = false;
			button2.Visible = true;
		}
	}
}
