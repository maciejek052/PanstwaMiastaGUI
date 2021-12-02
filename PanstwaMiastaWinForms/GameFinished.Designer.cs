
namespace PanstwaMiastaWinForms
{
	partial class GameFinished
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameFinished));
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.winGif = new System.Windows.Forms.PictureBox();
			this.loseGif = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.winGif)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loseGif)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(12, 514);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(988, 65);
			this.label1.TabIndex = 0;
			this.label1.Text = "Przegrałeś, twój wynik to";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(447, 582);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(118, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Powrót do menu";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// winGif
			// 
			this.winGif.Image = ((System.Drawing.Image)(resources.GetObject("winGif.Image")));
			this.winGif.Location = new System.Drawing.Point(354, 191);
			this.winGif.Name = "winGif";
			this.winGif.Size = new System.Drawing.Size(320, 308);
			this.winGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.winGif.TabIndex = 2;
			this.winGif.TabStop = false;
			this.winGif.Visible = false;
			// 
			// loseGif
			// 
			this.loseGif.Image = global::PanstwaMiastaWinForms.Properties.Resources.gameover;
			this.loseGif.InitialImage = null;
			this.loseGif.Location = new System.Drawing.Point(354, 191);
			this.loseGif.Name = "loseGif";
			this.loseGif.Size = new System.Drawing.Size(320, 308);
			this.loseGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.loseGif.TabIndex = 3;
			this.loseGif.TabStop = false;
			this.loseGif.Visible = false;
			// 
			// GameFinished
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PanstwaMiastaWinForms.Properties.Resources.bg_logo_red;
			this.ClientSize = new System.Drawing.Size(1012, 617);
			this.Controls.Add(this.loseGif);
			this.Controls.Add(this.winGif);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "GameFinished";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GameFinished";
			((System.ComponentModel.ISupportInitialize)(this.winGif)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loseGif)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox winGif;
		private System.Windows.Forms.PictureBox loseGif;
	}
}