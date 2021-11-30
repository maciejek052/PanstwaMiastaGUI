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
	public partial class Game : Form
	{
		public Game()
		{
			InitializeComponent();
			letter.Text = "Litera: " + Char.ToUpper(Variables.alphabet[Variables.randomIndexes[Variables.currentRoundNumber-1]]);
			this.Text = "Panstwa-miasta - runda " + Variables.currentRoundNumber + "/" + Variables.roundsAmount; 
		}

		private void button1_Click(object sender, EventArgs e)
		{
			addAnswersToList();
			lockTextboxes();
			if (Variables.possibleAnswers[0].Contains(textBox1.Text))
				textBox1.BackColor = Color.LightGreen;
			else
				textBox1.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[1].Contains(textBox2.Text))
				textBox2.BackColor = Color.LightGreen;
			else
				textBox2.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[2].Contains(textBox3.Text))
				textBox3.BackColor = Color.LightGreen;
			else
				textBox3.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[3].Contains(textBox4.Text))
				textBox4.BackColor = Color.LightGreen;
			else
				textBox4.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[4].Contains(textBox5.Text))
				textBox5.BackColor = Color.LightGreen;
			else
				textBox5.BackColor = Color.OrangeRed;
			if (Variables.possibleAnswers[5].Contains(textBox6.Text))
				textBox6.BackColor = Color.LightGreen;
			else
				textBox6.BackColor = Color.OrangeRed;
			button1.Visible = false;
			button2.Visible = true; 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void addAnswersToList()
		{
			List<String> temp = new List<String>();
			temp.Add(textBox1.Text);
			temp.Add(textBox2.Text);
			temp.Add(textBox3.Text);
			temp.Add(textBox4.Text);
			temp.Add(textBox5.Text);
			temp.Add(textBox6.Text);
		}
		private void lockTextboxes()
		{
			textBox1.ReadOnly = true;
			textBox2.ReadOnly = true;
			textBox3.ReadOnly = true;
			textBox4.ReadOnly = true;
			textBox5.ReadOnly = true;
			textBox6.ReadOnly = true;
		}
	}
}
