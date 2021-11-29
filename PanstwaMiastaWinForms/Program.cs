using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanstwaMiastaWinForms
{
	static class Program
	{
		/// <summary>
		/// Główny punkt wejścia dla aplikacji.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form1 menu = new Form1(); 
			Application.Run(menu);
			int iloscBotow = menu.botsAmount, iloscRund = menu.roundsAmount;
			string imie = menu.playerName; 
			Console.WriteLine(imie);
			Console.WriteLine("Ilosc botow: " + iloscBotow);
			Console.WriteLine("Ilosc rund: " + iloscRund);
			Console.ReadLine();
		}
	}
}
