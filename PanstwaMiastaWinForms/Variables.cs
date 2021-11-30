using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanstwaMiastaWinForms
{
	class Variables
	{
		public static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'z' };
		public static List<List<string>> test;
		public static List<int> randomIndexes = new List<int>();
		public static int currentLetterIndex = 0;
		public static int currentRoundNumber = 0;
		public static int roundsAmount = 0;
	}
}
