using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanstwaMiastaWinForms
{
	static class Program
	{
		
		static List<List<string>> answersGivenByBots = new List<List<string>>();
		[STAThread] 
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form1 menu = new Form1();
			Application.Run(menu);
			Variables.roundsAmount = menu.roundsAmount;
			drawRandomIndexes(Variables.roundsAmount); 
			for (int i = 0; i < Variables.roundsAmount; i++)
			{
				Variables.currentRoundNumber = i + 1;
				possibleAnwsers.Clear();
				answersGivenByBots.Clear();
				fillList(i);
				// Console.WriteLine(possibleAnwsers.Print(2,0)); 
				Variables.currentLetterIndex = Variables.randomIndexes[i]; 
				Game game = new Game();
				Application.Run(game);
			}
		}
		static void drawRandomIndexes(int rounds)
		{
			while (Variables.randomIndexes.Count < rounds)
			{
				Random rnd = new Random();
				int index = rnd.Next(22);
				if (!(Variables.randomIndexes.Contains(index)))
				{
					Variables.randomIndexes.Add(index);
				}
			}
		}
		static void fillList(int round)
		{
			for (int j = 0; j < 6; j++)
			{
				string location = "";
				List<string> temp = new List<string>();
				switch (j)
				{
					case 0:
						location = "assets\\dictionary\\panstwa.txt";
						break;
					case 1:
						location = "assets\\dictionary\\miasta.txt";
						break;
					case 2:
						location = "assets\\dictionary\\zwierzeta.txt";
						break;
					case 3:
						location = "assets\\dictionary\\zawody.txt";
						break;
					case 4:
						location = "assets\\dictionary\\owoce_warzywa.txt";
						break;
					case 5:
						location = "assets\\dictionary\\kolory.txt";
						break;
				}
				foreach (string line in System.IO.File.ReadLines(location))
				{
					if (line[0] == Variables.alphabet[Variables.randomIndexes[round]] || line[0] == Char.ToUpper(Variables.alphabet[Variables.randomIndexes[round]]))
					{
						temp.Add(line);
					}
				}
				possibleAnwsers.Add(temp);
			}
		}
	}
}
