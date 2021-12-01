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

			Variables.roundsAmount = menu.roundsAmount;
			Variables.difficultyLevel = menu.difficulty;
			Variables.numberOfBots = menu.botsAmount;
			GameLogic.drawRandomIndexes(Variables.roundsAmount); 
			for (int i = 0; i < Variables.roundsAmount; i++)
			{
				Variables.currentRoundNumber = i + 1;
				Variables.answersGivenByBots.Clear();
				Variables.allGivenAnswers.Clear(); 
				GameLogic.fillList(i);
				GameLogic.botsWork(); 

				// testing bots work

				for (int j = 0; j < Variables.numberOfBots; j++)
				{
					Console.WriteLine("Bot " + (j+1)); 
					for (int k = 0; k < 6; k++)
					{
						Console.WriteLine(k + ": " + Variables.answersGivenByBots[j][k]); 
					}
					Console.WriteLine("");
				}



				Variables.currentLetterIndex = Variables.randomIndexes[i]; 
				Game game = new Game();
				Application.Run(game);
			}
		}
	}
}
