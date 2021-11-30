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
		public string litera
		{
			set { this.letter.Text = value; }
		}
		public string panstwo
		{
			get { return textBox1.Text; }
		}
		public string miasto
		{
			get { return textBox2.Text; }
		}
		public string zwierze
		{
			get { return textBox3.Text; }
		}
		public string zawod
		{
			get { return textBox4.Text; }
		}
		public string owoc
		{
			get { return textBox5.Text; }
		}
		public string kolor
		{
			get { return textBox6.Text; }
		}


		public Game()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (possibleAnwsers.Find(2, textBox3.Text))
				textBox3.BackColor = Color.LightGreen;
			else
				textBox3.BackColor = Color.OrangeRed;
			if (possibleAnwsers.Find(3, textBox4.Text))
				textBox4.BackColor = Color.LightGreen;
			else
				textBox4.BackColor = Color.OrangeRed;
			if (possibleAnwsers.Find(4, textBox5.Text))
				textBox5.BackColor = Color.LightGreen;
			else
				textBox5.BackColor = Color.OrangeRed;
			if (possibleAnwsers.Find(5, textBox6.Text))
				textBox6.BackColor = Color.LightGreen;
			else
				textBox6.BackColor = Color.OrangeRed;

		}
	}
}
