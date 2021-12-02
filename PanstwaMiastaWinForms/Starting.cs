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
	public partial class Starting : UserControl
	{
		public string labelText
		{
			get { return startingText.Text; }
			set { startingText.Text = value; }
		}
		public string diffLabelText
		{
			get { return diffLabel.Text; }
			set { diffLabel.Text = value; }
		}
		public string botsLabelText
		{
			get { return botsLabel.Text; }
			set { botsLabel.Text = value; }
		}
		public string roundsLabelText
		{
			get { return roundsLabel.Text; }
			set { roundsLabel.Text = value; }
		}

		public Starting()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		}
	}
}
