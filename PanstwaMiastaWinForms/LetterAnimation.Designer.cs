
namespace PanstwaMiastaWinForms
{
	partial class LetterAnimation
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
			this.components = new System.ComponentModel.Container();
			this.letter = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// letter
			// 
			this.letter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.letter.BackColor = System.Drawing.Color.Transparent;
			this.letter.Font = new System.Drawing.Font("Azeret Mono", 249.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.letter.ForeColor = System.Drawing.Color.Red;
			this.letter.Location = new System.Drawing.Point(0, -69);
			this.letter.Name = "letter";
			this.letter.Size = new System.Drawing.Size(1012, 617);
			this.letter.TabIndex = 0;
			this.letter.Text = "A";
			this.letter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
			this.button1.Location = new System.Drawing.Point(403, 465);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(206, 101);
			this.button1.TabIndex = 1;
			this.button1.Text = "Dalej";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// LetterAnimation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::PanstwaMiastaWinForms.Properties.Resources.bg;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.letter);
			this.Name = "LetterAnimation";
			this.Size = new System.Drawing.Size(1012, 617);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label letter;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
	}
}
