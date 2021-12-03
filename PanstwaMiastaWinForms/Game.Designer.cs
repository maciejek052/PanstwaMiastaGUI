
namespace PanstwaMiastaWinForms
{
	partial class Game
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
			this.panstwo = new System.Windows.Forms.TextBox();
			this.miasto = new System.Windows.Forms.TextBox();
			this.zwierze = new System.Windows.Forms.TextBox();
			this.zawod = new System.Windows.Forms.TextBox();
			this.owoc = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.kolor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.letter = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.roundLabel = new System.Windows.Forms.Label();
			this.cheatPanstwo = new System.Windows.Forms.Button();
			this.cheatMiasto = new System.Windows.Forms.Button();
			this.cheatZwierze = new System.Windows.Forms.Button();
			this.cheatZawod = new System.Windows.Forms.Button();
			this.cheatOwoc = new System.Windows.Forms.Button();
			this.cheatKolor = new System.Windows.Forms.Button();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.timeLeftLabel = new System.Windows.Forms.Label();
			this.letterAnimation1 = new PanstwaMiastaWinForms.LetterAnimation();
			this.SuspendLayout();
			// 
			// panstwo
			// 
			this.panstwo.BackColor = System.Drawing.SystemColors.Window;
			this.panstwo.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.panstwo.Location = new System.Drawing.Point(413, 140);
			this.panstwo.Name = "panstwo";
			this.panstwo.Size = new System.Drawing.Size(307, 43);
			this.panstwo.TabIndex = 0;
			// 
			// miasto
			// 
			this.miasto.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.miasto.Location = new System.Drawing.Point(413, 188);
			this.miasto.Name = "miasto";
			this.miasto.Size = new System.Drawing.Size(307, 43);
			this.miasto.TabIndex = 1;
			// 
			// zwierze
			// 
			this.zwierze.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.zwierze.Location = new System.Drawing.Point(413, 237);
			this.zwierze.Name = "zwierze";
			this.zwierze.Size = new System.Drawing.Size(307, 43);
			this.zwierze.TabIndex = 2;
			// 
			// zawod
			// 
			this.zawod.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.zawod.Location = new System.Drawing.Point(413, 286);
			this.zawod.Name = "zawod";
			this.zawod.Size = new System.Drawing.Size(307, 43);
			this.zawod.TabIndex = 3;
			// 
			// owoc
			// 
			this.owoc.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.owoc.Location = new System.Drawing.Point(413, 335);
			this.owoc.Name = "owoc";
			this.owoc.Size = new System.Drawing.Size(307, 43);
			this.owoc.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(390, 507);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(235, 59);
			this.button1.TabIndex = 6;
			this.button1.Text = "Zakończ rundę";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// kolor
			// 
			this.kolor.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.kolor.Location = new System.Drawing.Point(413, 384);
			this.kolor.Name = "kolor";
			this.kolor.Size = new System.Drawing.Size(307, 43);
			this.kolor.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Roboto Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(271, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 38);
			this.label1.TabIndex = 7;
			this.label1.Text = "Państwo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Roboto Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(288, 189);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 38);
			this.label2.TabIndex = 8;
			this.label2.Text = "Miasto";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Roboto Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(271, 238);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 38);
			this.label3.TabIndex = 9;
			this.label3.Text = "Zwierzę";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Roboto Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.ForeColor = System.Drawing.Color.Blue;
			this.label4.Location = new System.Drawing.Point(305, 287);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 38);
			this.label4.TabIndex = 10;
			this.label4.Text = "Zawód";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Roboto Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(186, 337);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(221, 38);
			this.label5.TabIndex = 11;
			this.label5.Text = "Owoc/warzywo";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Roboto Mono", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.Color.Blue;
			this.label6.Location = new System.Drawing.Point(305, 385);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 38);
			this.label6.TabIndex = 12;
			this.label6.Text = "Kolor";
			// 
			// letter
			// 
			this.letter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.letter.BackColor = System.Drawing.Color.Transparent;
			this.letter.Font = new System.Drawing.Font("Roboto Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.letter.ForeColor = System.Drawing.Color.Navy;
			this.letter.Location = new System.Drawing.Point(2, 67);
			this.letter.Name = "letter";
			this.letter.Size = new System.Drawing.Size(1012, 49);
			this.letter.TabIndex = 13;
			this.letter.Text = "Wylosowana litera: A";
			this.letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(390, 507);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(235, 59);
			this.button2.TabIndex = 14;
			this.button2.Text = "Dalej";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// roundLabel
			// 
			this.roundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.roundLabel.BackColor = System.Drawing.Color.Transparent;
			this.roundLabel.Font = new System.Drawing.Font("Roboto Mono", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.roundLabel.ForeColor = System.Drawing.Color.DarkGreen;
			this.roundLabel.Location = new System.Drawing.Point(2, 9);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(1012, 49);
			this.roundLabel.TabIndex = 16;
			this.roundLabel.Text = "Runda: 1/3";
			this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cheatPanstwo
			// 
			this.cheatPanstwo.BackColor = System.Drawing.Color.Gold;
			this.cheatPanstwo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cheatPanstwo.Location = new System.Drawing.Point(727, 140);
			this.cheatPanstwo.Name = "cheatPanstwo";
			this.cheatPanstwo.Size = new System.Drawing.Size(46, 43);
			this.cheatPanstwo.TabIndex = 17;
			this.cheatPanstwo.Text = "P";
			this.cheatPanstwo.UseVisualStyleBackColor = false;
			this.cheatPanstwo.Click += new System.EventHandler(this.cheatPanstwo_Click);
			// 
			// cheatMiasto
			// 
			this.cheatMiasto.BackColor = System.Drawing.Color.Gold;
			this.cheatMiasto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cheatMiasto.Location = new System.Drawing.Point(727, 189);
			this.cheatMiasto.Name = "cheatMiasto";
			this.cheatMiasto.Size = new System.Drawing.Size(46, 43);
			this.cheatMiasto.TabIndex = 18;
			this.cheatMiasto.Text = "P";
			this.cheatMiasto.UseVisualStyleBackColor = false;
			this.cheatMiasto.Click += new System.EventHandler(this.cheatMiasto_Click);
			// 
			// cheatZwierze
			// 
			this.cheatZwierze.BackColor = System.Drawing.Color.Gold;
			this.cheatZwierze.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cheatZwierze.Location = new System.Drawing.Point(727, 238);
			this.cheatZwierze.Name = "cheatZwierze";
			this.cheatZwierze.Size = new System.Drawing.Size(47, 43);
			this.cheatZwierze.TabIndex = 19;
			this.cheatZwierze.Text = "P";
			this.cheatZwierze.UseVisualStyleBackColor = false;
			this.cheatZwierze.Click += new System.EventHandler(this.cheatZwierze_Click);
			// 
			// cheatZawod
			// 
			this.cheatZawod.BackColor = System.Drawing.Color.Gold;
			this.cheatZawod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cheatZawod.Location = new System.Drawing.Point(727, 287);
			this.cheatZawod.Name = "cheatZawod";
			this.cheatZawod.Size = new System.Drawing.Size(46, 43);
			this.cheatZawod.TabIndex = 20;
			this.cheatZawod.Text = "P";
			this.cheatZawod.UseVisualStyleBackColor = false;
			this.cheatZawod.Click += new System.EventHandler(this.cheatZawod_Click);
			// 
			// cheatOwoc
			// 
			this.cheatOwoc.BackColor = System.Drawing.Color.Gold;
			this.cheatOwoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cheatOwoc.Location = new System.Drawing.Point(727, 336);
			this.cheatOwoc.Name = "cheatOwoc";
			this.cheatOwoc.Size = new System.Drawing.Size(47, 43);
			this.cheatOwoc.TabIndex = 21;
			this.cheatOwoc.Text = "P";
			this.cheatOwoc.UseVisualStyleBackColor = false;
			this.cheatOwoc.Click += new System.EventHandler(this.cheatOwoc_Click);
			// 
			// cheatKolor
			// 
			this.cheatKolor.BackColor = System.Drawing.Color.Gold;
			this.cheatKolor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.cheatKolor.Location = new System.Drawing.Point(727, 385);
			this.cheatKolor.Name = "cheatKolor";
			this.cheatKolor.Size = new System.Drawing.Size(47, 43);
			this.cheatKolor.TabIndex = 22;
			this.cheatKolor.Text = "P";
			this.cheatKolor.UseVisualStyleBackColor = false;
			this.cheatKolor.Click += new System.EventHandler(this.cheatKolor_Click);
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 1000;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
			// 
			// timeLeftLabel
			// 
			this.timeLeftLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.timeLeftLabel.BackColor = System.Drawing.Color.Transparent;
			this.timeLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.timeLeftLabel.ForeColor = System.Drawing.Color.SeaGreen;
			this.timeLeftLabel.Location = new System.Drawing.Point(0, 451);
			this.timeLeftLabel.Name = "timeLeftLabel";
			this.timeLeftLabel.Size = new System.Drawing.Size(1012, 33);
			this.timeLeftLabel.TabIndex = 23;
			this.timeLeftLabel.Text = "Pozostały czas: 50";
			this.timeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.timeLeftLabel.Visible = false;
			// 
			// letterAnimation1
			// 
			this.letterAnimation1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("letterAnimation1.BackgroundImage")));
			this.letterAnimation1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.letterAnimation1.Location = new System.Drawing.Point(0, 0);
			this.letterAnimation1.Name = "letterAnimation1";
			this.letterAnimation1.Size = new System.Drawing.Size(1012, 617);
			this.letterAnimation1.TabIndex = 15;
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PanstwaMiastaWinForms.Properties.Resources.bg_moreblur;
			this.ClientSize = new System.Drawing.Size(1012, 617);
			this.Controls.Add(this.timeLeftLabel);
			this.Controls.Add(this.letterAnimation1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.letter);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.kolor);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.owoc);
			this.Controls.Add(this.zawod);
			this.Controls.Add(this.zwierze);
			this.Controls.Add(this.miasto);
			this.Controls.Add(this.panstwo);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.cheatKolor);
			this.Controls.Add(this.cheatOwoc);
			this.Controls.Add(this.cheatZawod);
			this.Controls.Add(this.cheatZwierze);
			this.Controls.Add(this.cheatMiasto);
			this.Controls.Add(this.cheatPanstwo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Game";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Państwa Miasta - runda";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox miasto;
		private System.Windows.Forms.TextBox zwierze;
		private System.Windows.Forms.TextBox zawod;
		private System.Windows.Forms.TextBox owoc;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox kolor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox panstwo;
		public System.Windows.Forms.Label letter;
		private System.Windows.Forms.Label roundLabel;
		private LetterAnimation letterAnimation1;
		private System.Windows.Forms.Button cheatPanstwo;
		private System.Windows.Forms.Button cheatMiasto;
		private System.Windows.Forms.Button cheatZwierze;
		private System.Windows.Forms.Button cheatZawod;
		private System.Windows.Forms.Button cheatOwoc;
		private System.Windows.Forms.Button cheatKolor;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Label timeLeftLabel;
	}
}