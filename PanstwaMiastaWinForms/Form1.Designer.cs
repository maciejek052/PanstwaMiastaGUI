
namespace PanstwaMiastaWinForms
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.playButton = new System.Windows.Forms.Button();
			this.settingsButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.toggleAnimationButton = new System.Windows.Forms.Button();
			this.aboutButton = new System.Windows.Forms.Button();
			this.backFromSettingsButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.difficultyBox = new System.Windows.Forms.ComboBox();
			this.botAmountBox = new System.Windows.Forms.ComboBox();
			this.roundAmountBox = new System.Windows.Forms.ComboBox();
			this.nameBox = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.starting1 = new PanstwaMiastaWinForms.Starting();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1028, 656);
			this.axWindowsMediaPlayer1.TabIndex = 0;
			// 
			// playButton
			// 
			this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.playButton.Location = new System.Drawing.Point(429, 419);
			this.playButton.Name = "playButton";
			this.playButton.Size = new System.Drawing.Size(170, 58);
			this.playButton.TabIndex = 3;
			this.playButton.Text = "Zagraj";
			this.playButton.UseVisualStyleBackColor = true;
			this.playButton.Click += new System.EventHandler(this.playButton_Click);
			// 
			// settingsButton
			// 
			this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.settingsButton.Location = new System.Drawing.Point(429, 483);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(170, 58);
			this.settingsButton.TabIndex = 4;
			this.settingsButton.Text = "Opcje";
			this.settingsButton.UseVisualStyleBackColor = true;
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.exitButton.Location = new System.Drawing.Point(429, 547);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(170, 58);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Wyjdź";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// toggleAnimationButton
			// 
			this.toggleAnimationButton.Location = new System.Drawing.Point(12, 582);
			this.toggleAnimationButton.Name = "toggleAnimationButton";
			this.toggleAnimationButton.Size = new System.Drawing.Size(113, 23);
			this.toggleAnimationButton.TabIndex = 7;
			this.toggleAnimationButton.Text = "Zatrzymaj animację";
			this.toggleAnimationButton.UseVisualStyleBackColor = true;
			this.toggleAnimationButton.Click += new System.EventHandler(this.toggleAnimationButton_Click);
			// 
			// aboutButton
			// 
			this.aboutButton.Location = new System.Drawing.Point(887, 582);
			this.aboutButton.Name = "aboutButton";
			this.aboutButton.Size = new System.Drawing.Size(113, 23);
			this.aboutButton.TabIndex = 16;
			this.aboutButton.Text = "O grze";
			this.aboutButton.UseVisualStyleBackColor = true;
			this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
			// 
			// backFromSettingsButton
			// 
			this.backFromSettingsButton.BackColor = System.Drawing.SystemColors.Control;
			this.backFromSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.backFromSettingsButton.Location = new System.Drawing.Point(429, 547);
			this.backFromSettingsButton.Name = "backFromSettingsButton";
			this.backFromSettingsButton.Size = new System.Drawing.Size(170, 58);
			this.backFromSettingsButton.TabIndex = 17;
			this.backFromSettingsButton.Text = "Powrót do menu";
			this.backFromSettingsButton.UseVisualStyleBackColor = false;
			this.backFromSettingsButton.Click += new System.EventHandler(this.backFromSettingsButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label1.Location = new System.Drawing.Point(309, 393);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(161, 25);
			this.label1.TabIndex = 18;
			this.label1.Text = "Poziom trudności";
			this.label1.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label2.Location = new System.Drawing.Point(355, 432);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 25);
			this.label2.TabIndex = 19;
			this.label2.Text = "Ilość botów:";
			this.label2.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label3.Location = new System.Drawing.Point(368, 471);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 25);
			this.label3.TabIndex = 20;
			this.label3.Text = "Ilość rund:";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.label4.Location = new System.Drawing.Point(359, 513);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(111, 25);
			this.label4.TabIndex = 21;
			this.label4.Text = "Twoje imię:";
			this.label4.Visible = false;
			// 
			// difficultyBox
			// 
			this.difficultyBox.BackColor = System.Drawing.SystemColors.Window;
			this.difficultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.difficultyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.difficultyBox.FormattingEnabled = true;
			this.difficultyBox.Items.AddRange(new object[] {
            "Łatwy",
            "Średni",
            "Trudny"});
			this.difficultyBox.Location = new System.Drawing.Point(476, 390);
			this.difficultyBox.Name = "difficultyBox";
			this.difficultyBox.Size = new System.Drawing.Size(229, 33);
			this.difficultyBox.TabIndex = 22;
			this.difficultyBox.Visible = false;
			// 
			// botAmountBox
			// 
			this.botAmountBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.botAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.botAmountBox.FormattingEnabled = true;
			this.botAmountBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.botAmountBox.Location = new System.Drawing.Point(476, 429);
			this.botAmountBox.Name = "botAmountBox";
			this.botAmountBox.Size = new System.Drawing.Size(229, 33);
			this.botAmountBox.TabIndex = 23;
			this.botAmountBox.Visible = false;
			// 
			// roundAmountBox
			// 
			this.roundAmountBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.roundAmountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.roundAmountBox.FormattingEnabled = true;
			this.roundAmountBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.roundAmountBox.Location = new System.Drawing.Point(476, 468);
			this.roundAmountBox.Name = "roundAmountBox";
			this.roundAmountBox.Size = new System.Drawing.Size(229, 33);
			this.roundAmountBox.TabIndex = 24;
			this.roundAmountBox.Visible = false;
			// 
			// nameBox
			// 
			this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.nameBox.Location = new System.Drawing.Point(476, 510);
			this.nameBox.Name = "nameBox";
			this.nameBox.Size = new System.Drawing.Size(229, 30);
			this.nameBox.TabIndex = 25;
			this.nameBox.Text = "Gracz";
			this.nameBox.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// starting1
			// 
			this.starting1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("starting1.BackgroundImage")));
			this.starting1.botsLabelText = "Liczba botów:";
			this.starting1.diffLabelText = "Poziom trudności:";
			this.starting1.labelText = "Gra rozpocznie się za 5...";
			this.starting1.Location = new System.Drawing.Point(0, 0);
			this.starting1.Name = "starting1";
			this.starting1.roundsLabelText = "Liczba rund:";
			this.starting1.Size = new System.Drawing.Size(1012, 617);
			this.starting1.TabIndex = 26;
			this.starting1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1012, 617);
			this.Controls.Add(this.starting1);
			this.Controls.Add(this.nameBox);
			this.Controls.Add(this.roundAmountBox);
			this.Controls.Add(this.botAmountBox);
			this.Controls.Add(this.difficultyBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.backFromSettingsButton);
			this.Controls.Add(this.aboutButton);
			this.Controls.Add(this.toggleAnimationButton);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.playButton);
			this.Controls.Add(this.settingsButton);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Państwa Miasta - Menu główne";
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
		private System.Windows.Forms.Button playButton;
		private System.Windows.Forms.Button settingsButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button toggleAnimationButton;
		private System.Windows.Forms.Button aboutButton;
		private System.Windows.Forms.Button backFromSettingsButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox nameBox;
		private Starting starting1;
		private System.Windows.Forms.Timer timer1;
		public System.Windows.Forms.ComboBox difficultyBox;
		public System.Windows.Forms.ComboBox botAmountBox;
		public System.Windows.Forms.ComboBox roundAmountBox;
	}
}

