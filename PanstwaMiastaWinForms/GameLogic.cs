// This file contains most of program's logic; bots work and function to fill
// list with correct answers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanstwaMiastaWinForms
{
	class GameLogic
	{
		public static void fillList(int round)
		{
			Model.possibleAnswers.Clear();
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
					if (line[0] == Model.alphabet[Model.randomIndexes[round]] || line[0] == Char.ToUpper(Model.alphabet[Model.randomIndexes[round]]))
					{
						temp.Add(line);
					}
				}
				Model.possibleAnswers.Add(temp);
			}
		}

		public static void drawRandomIndexes(int rounds)
		{
			while (Model.randomIndexes.Count < rounds)
			{
				Random rnd = new Random();
				int index = rnd.Next(22);
				if (!(Model.randomIndexes.Contains(index)))
				{
					Model.randomIndexes.Add(index);
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
			if (Model.difficultyLevel == 1)
				botPercentageChance = 70;
			else if (Model.difficultyLevel == 2)
				botPercentageChance = 80; 
			for (int i = 0; i < Model.numberOfBots; i++)
			{
				List<string> temp = new List<string>();
				for (int j = 0; j < 6; j++)
				{
					chanceForGuessing = rd.Next(101);
					if (chanceForGuessing <= botPercentageChance)
					{
						possibleAnswersAmount = Model.possibleAnswers[j].Count;
						if (possibleAnswersAmount == 0)
							temp.Add("-");
						else
						{
							randomAnswerIndex = rd.Next(possibleAnswersAmount);
							temp.Add(Model.possibleAnswers[j][randomAnswerIndex]);
							Model.allGivenAnswers.Add(temp.Last());
						}
					}
					else
						temp.Add("-"); 
				}
				Model.answersGivenByBots.Add(temp); 
			}
		}
		// here
		public static void countPoints()
		{
			for (int i = 0; i < Model.numberOfBots; i++)
			{
				for (int j = 0; j < 6; j++)
				{
					if (Model.answersGivenByBots[i][j] == "-")
						Model.botAnwerPoints[i,j] = 0;
					else
					{
						int repeats = Model.allGivenAnswers.Where(x => (x.ToLower() == Model.answersGivenByBots[i][j].ToLower())).Count();
						if (repeats == 1)
						{
							Model.botAnwerPoints[i,j] = 15;
							Model.botsPoints[i] += 15;
						}
						else
						{
							Model.botAnwerPoints[i, j] = 10;
							Model.botsPoints[i] += 10;
						}
					}
				}
			}
			for (int i = 0; i < 6; i++)
			{
				if (Model.possibleAnswers[i].Contains(Model.answersGivenByPlayer[i], StringComparer.OrdinalIgnoreCase))
				{
					int repeats = Model.allGivenAnswers.Where(x => (x.ToLower() == Model.answersGivenByPlayer[i].ToLower())).Count();
					if (repeats == 1)
					{
						Model.playerAnswerPoints[i] = 15;
						Model.playerPoints += 15;
					}
					else
					{
						Model.playerAnswerPoints[i] = 10;
						Model.playerPoints += 10;
					}
				}
				else
					Model.playerAnswerPoints[i] = 0;
			}

			// sort player results to show them in correct order in scoreboard
			for (int i = 0; i < Model.numberOfBots; i++)
				Model.sortedPoints.Add(Tuple.Create(i, Model.botsPoints[i]));
			Model.sortedPoints.Add(Tuple.Create(Model.numberOfBots, Model.playerPoints));
			Model.sortedPoints.Sort((a, b) => b.Item2.CompareTo(a.Item2));  
		}

	}
}
