using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanstwaMiastaWinForms
{
	class Variables
	{
		public static List<int> randomIndexes = new List<int>();
		public static List<string> allGivenAnswers = new List<string>();
		public static List<List<string>> possibleAnswers = new List<List<string>>();
		public static List<List<string>> answersGivenByBots = new List<List<string>>();
		
		public static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'z' };
		public static int currentLetterIndex = 0;
		public static int currentRoundNumber = 0;
		public static int roundsAmount = 0;
		public static int difficultyLevel = 0;
		public static int numberOfBots = 0; 

	}
}
