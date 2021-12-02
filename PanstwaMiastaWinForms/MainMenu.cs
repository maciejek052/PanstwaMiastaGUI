using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanstwaMiastaWinForms
{
	public partial class MainMenu : Form
	{
		public int roundsAmount
		{
			get { return roundAmountBox.SelectedIndex + 1;  }
		}
		public int botsAmount
		{
			get { return botAmountBox.SelectedIndex + 1;  }
		}
		public int difficulty
		{
			get { return difficultyBox.SelectedIndex;  }
		}

		bool isPaused = false;
		public MainMenu()
		{
			InitializeComponent();
			axWindowsMediaPlayer1.settings.playCount = 1000;
			backFromSettingsButton.Visible = false;
			difficultyBox.SelectedIndex = 0;
			botAmountBox.SelectedIndex = 2;
			roundAmountBox.SelectedIndex = 2;
		}
		private void toggleAnimationButton_Click(object sender, EventArgs e)
		{
			if (isPaused == false)
			{
				isPaused = true;
				axWindowsMediaPlayer1.Ctlcontrols.pause();
				toggleAnimationButton.Text = "Włącz animacje"; 
			}
			else
			{
				isPaused = false;
				axWindowsMediaPlayer1.Ctlcontrols.play();
				toggleAnimationButton.Text = "Wyłącz animacje";
			}
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Czy na pewno chcesz wyjść z gry?", ":(", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				Application.Exit();
		}

		private void backFromSettingsButton_Click(object sender, EventArgs e)
		{
			playButton.Visible = true;
			settingsButton.Visible = true;
			exitButton.Visible = true;
			backFromSettingsButton.Visible = false;
			difficultyBox.Visible = false;
			botAmountBox.Visible = false;
			roundAmountBox.Visible = false;
			nameBox.Visible = false;
			label1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
		}

		private void settingsButton_Click(object sender, EventArgs e)
		{
			playButton.Visible = false;
			settingsButton.Visible = false;
			exitButton.Visible = false;
			backFromSettingsButton.Visible = true;
			difficultyBox.Visible = true;
			botAmountBox.Visible = true;
			roundAmountBox.Visible = true;
			nameBox.Visible = true;
			label1.Visible = true; 
			label2.Visible = true; 
			label3.Visible = true; 
			label4.Visible = true; 
		}

		private void aboutButton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Państwa Miasta GUI\nAutor: Maciej Czech\nProgram na zaliczenie z przedmiotu Komunikacja Człowiek-Komputer", "Informacje", MessageBoxButtons.OK, MessageBoxIcon.Information); 
		}

		private void playButton_Click(object sender, EventArgs e)
		{
			// this.Close();
			starting1.Visible = true;
			Model.playerName = nameBox.Text; 
			starting1.diffLabelText = "Poziom trudności: " + difficultyBox.Text;
			starting1.roundsLabelText = "Liczba rund: " + roundAmountBox.Text;
			starting1.botsLabelText = "Liczba botów: " + botAmountBox.Text; 
			timer1.Enabled = true;

		}
		int i = 5; 
		private void timer1_Tick(object sender, EventArgs e)
		{
			i--; 
			starting1.labelText = "Gra rozpocznie się za " + i + "...";
			if (i == 0)
			{
				timer1.Enabled = false;
				this.Close(); 
			}
		}
	}
}
