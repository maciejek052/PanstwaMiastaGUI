using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanstwaMiastaWinForms
{
	class CheckAssets
	{
		public static void checkAssets()
		{
			string[] path =
			{
				@"assets\\dictionary\\panstwa.txt",
				@"assets\\dictionary\\miasta.txt",
				@"assets\\dictionary\\zwierzeta.txt",
				@"assets\\dictionary\\zawody.txt",
				@"assets\\dictionary\\owoce_warzywa.txt",
				@"assets\\dictionary\\kolory.txt",

			}; 
			for (int i = 0; i < 6; i++)
			{
				if (!File.Exists(path[i]))
				{
					MessageBox.Show("Nie można otworzyć pliku ze słownikiem. Program zakończy działanie.", "Państwa-Miasta", MessageBoxButtons.OK, MessageBoxIcon.Error);
					System.Environment.Exit(0);
				}
			}
			if (!File.Exists(@"assets\\video\mainmenu.mp4"))
			{
				MessageBox.Show("Nie można otworzyć pliku z tłem w menu głównym. Program się uruchomi, jednak w menu głównym nie będzie tła.", "Państwa-Miasta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
