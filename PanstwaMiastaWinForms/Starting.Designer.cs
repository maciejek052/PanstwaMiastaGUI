
namespace PanstwaMiastaWinForms
{
	partial class Starting
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

		#region Kod wygenerowany przez Projektanta składników

		/// <summary> 
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.startingText = new System.Windows.Forms.Label();
			this.diffLabel = new System.Windows.Forms.Label();
			this.roundsLabel = new System.Windows.Forms.Label();
			this.botsLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// startingText
			// 
			this.startingText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.startingText.BackColor = System.Drawing.Color.Transparent;
			this.startingText.Font = new System.Drawing.Font("Poppins", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.startingText.ForeColor = System.Drawing.Color.Indigo;
			this.startingText.Location = new System.Drawing.Point(12, 447);
			this.startingText.Name = "startingText";
			this.startingText.Size = new System.Drawing.Size(988, 40);
			this.startingText.TabIndex = 1;
			this.startingText.Text = "Gra rozpocznie się za 5...";
			this.startingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// diffLabel
			// 
			this.diffLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.diffLabel.BackColor = System.Drawing.Color.Transparent;
			this.diffLabel.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.diffLabel.ForeColor = System.Drawing.Color.Indigo;
			this.diffLabel.Location = new System.Drawing.Point(12, 297);
			this.diffLabel.Name = "diffLabel";
			this.diffLabel.Size = new System.Drawing.Size(988, 40);
			this.diffLabel.TabIndex = 2;
			this.diffLabel.Text = "Poziom trudności:";
			this.diffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundsLabel
			// 
			this.roundsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.roundsLabel.BackColor = System.Drawing.Color.Transparent;
			this.roundsLabel.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.roundsLabel.ForeColor = System.Drawing.Color.Indigo;
			this.roundsLabel.Location = new System.Drawing.Point(12, 337);
			this.roundsLabel.Name = "roundsLabel";
			this.roundsLabel.Size = new System.Drawing.Size(988, 40);
			this.roundsLabel.TabIndex = 3;
			this.roundsLabel.Text = "Liczba rund:";
			this.roundsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// botsLabel
			// 
			this.botsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.botsLabel.BackColor = System.Drawing.Color.Transparent;
			this.botsLabel.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.botsLabel.ForeColor = System.Drawing.Color.Indigo;
			this.botsLabel.Location = new System.Drawing.Point(12, 377);
			this.botsLabel.Name = "botsLabel";
			this.botsLabel.Size = new System.Drawing.Size(988, 40);
			this.botsLabel.TabIndex = 4;
			this.botsLabel.Text = "Liczba botów:";
			this.botsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Starting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PanstwaMiastaWinForms.Properties.Resources.bg_logo;
			this.Controls.Add(this.botsLabel);
			this.Controls.Add(this.roundsLabel);
			this.Controls.Add(this.diffLabel);
			this.Controls.Add(this.startingText);
			this.Name = "Starting";
			this.Size = new System.Drawing.Size(1012, 617);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label startingText;
		private System.Windows.Forms.Label diffLabel;
		private System.Windows.Forms.Label roundsLabel;
		private System.Windows.Forms.Label botsLabel;
	}
}
