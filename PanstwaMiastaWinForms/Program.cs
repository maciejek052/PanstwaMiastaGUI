﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanstwaMiastaWinForms
{
	static class Program
	{
		[STAThread] 
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			CheckAssets.checkAssets();
			while (true)
			{
				Model.initGame();
				MainMenu menu = new MainMenu();
				Application.Run(menu);
				Model.roundsAmount = menu.roundsAmount;
				Model.difficultyLevel = menu.difficulty;
				Model.numberOfBots = menu.botsAmount;
				GameLogic.drawRandomIndexes(Model.roundsAmount);
				for (int i = 0; i < Model.roundsAmount; i++)
				{
					Model.currentRoundNumber = i + 1;
					Model.initRound();
					GameLogic.fillList(i);
					GameLogic.botsWork();
					Model.currentLetterIndex = Model.randomIndexes[i];
					Game game = new Game();
					Application.Run(game);
				}
				GameFinished finished = new GameFinished();
				Application.Run(finished);
			}

		}
	}
}
