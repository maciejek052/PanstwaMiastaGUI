using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanstwaMiastaWinForms
{
	class Model
	{
		public static List<int> randomIndexes = new List<int>();
		public static List<string> allGivenAnswers = new List<string>();
		public static List<List<string>> possibleAnswers = new List<List<string>>();
		public static List<List<string>> answersGivenByBots = new List<List<string>>();
		public static List<Tuple<int, int>> sortedPoints = new List<Tuple<int, int>>();

		public static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'z' };

		public static string[] answersGivenByPlayer = new string[6];
		public static string playerName; 

		public static int currentLetterIndex = 0;
		public static int currentRoundNumber = 0;
		public static int roundsAmount = 0;
		public static int difficultyLevel = 0;
		public static int numberOfBots = 0;
		public static int playerPoints = 0;
		public static int[,] botAnwerPoints = new int[6,6];
		public static int[] playerAnswerPoints = new int[6];
		public static int[] botsPoints = new int[5];

		public static void initRound()
		{
			answersGivenByBots.Clear();
			allGivenAnswers.Clear();
			sortedPoints.Clear();
			answersGivenByBots.Clear(); 
		}
		public static void initGame()
		{
			randomIndexes.Clear();
			Array.Clear(answersGivenByPlayer, 0, answersGivenByPlayer.Length);
			Array.Clear(botAnwerPoints, 0, botAnwerPoints.Length);
			Array.Clear(playerAnswerPoints, 0, playerAnswerPoints.Length);
			Array.Clear(botsPoints, 0, botsPoints.Length); 
		}

	}
}
