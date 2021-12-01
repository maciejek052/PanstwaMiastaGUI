using System;
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
			MainMenu menu = new MainMenu();
			Application.Run(menu);

			Model.roundsAmount = menu.roundsAmount;
			Model.difficultyLevel = menu.difficulty;
			Model.numberOfBots = menu.botsAmount;
			GameLogic.drawRandomIndexes(Model.roundsAmount); 
			for (int i = 0; i < Model.roundsAmount; i++)
			{
				Model.currentRoundNumber = i + 1;
				Model.answersGivenByBots.Clear();
				Model.allGivenAnswers.Clear(); 
				GameLogic.fillList(i);
				GameLogic.botsWork(); 

				// testing bots work

				for (int j = 0; j < Model.numberOfBots; j++)
				{
					Console.WriteLine("Bot " + (j+1)); 
					for (int k = 0; k < 6; k++)
					{
						Console.WriteLine(k + ": " + Model.answersGivenByBots[j][k]); 
					}
					Console.WriteLine("");
				}



				Model.currentLetterIndex = Model.randomIndexes[i]; 
				Game game = new Game();
				Application.Run(game);
			}
		}
	}
}
