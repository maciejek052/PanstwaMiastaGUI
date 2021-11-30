using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanstwaMiastaWinForms
{
	static class possibleAnwsers
	{
		static List<List<string>> _possibleAnswers;
		static possibleAnwsers()
		{
			_possibleAnswers = new List<List<string>>();
		}
		public static void Add(List<string> list)
		{
			_possibleAnswers.Add(list); 
		}
		public static void Clear()
		{
			_possibleAnswers.Clear();
		}
		public static bool Find(int index, string data)
		{
			return _possibleAnswers[index].Contains(data); 
		}
		public static string Print(int category, int index)
		{
			return _possibleAnswers[category][index]; 
		}
	}
}
