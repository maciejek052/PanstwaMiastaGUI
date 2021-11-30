// This file contains most of program's logic; bots work and function to fill
// list with correct answers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanstwaMiastaWinForms
{
	class PrepareGame
	{
		public static void fillList(int round)
		{
			Variables.possibleAnswers.Clear();
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
				Variables.possibleAnswers.Add(temp);
			}
		}

		public static void drawRandomIndexes(int rounds)
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

		public static void botsWork()
		{
			Random rd = new Random(); 
			int botPercentageChance = 50;
			int chanceForGuessing = 0;
			int possibleAnswersAmount = 0;
			int randomAnswerIndex = 0; 
			if (Variables.difficultyLevel == 1)
				botPercentageChance = 70;
			else if (Variables.difficultyLevel == 2)
				botPercentageChance = 80; 
			for (int i = 0; i < Variables.numberOfBots; i++)
			{
				List<string> temp = new List<string>();
				for (int j = 0; j < 6; j++)
				{
					chanceForGuessing = rd.Next(101);
					if (chanceForGuessing <= botPercentageChance)
					{
						possibleAnswersAmount = Variables.possibleAnswers[j].Count;
						if (possibleAnswersAmount == 0)
							temp.Add("-");
						else
						{
							randomAnswerIndex = rd.Next(possibleAnswersAmount);
							temp.Add(Variables.possibleAnswers[j][randomAnswerIndex]);
							Variables.allGivenAnswers.Add(temp.Last());
						}
					}
					else
						temp.Add("-"); 
				}
				Variables.answersGivenByBots.Add(temp); 
			}

		}

	}
}
