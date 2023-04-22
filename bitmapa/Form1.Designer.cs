namespace bitmapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WYSZUKAJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WYSZUKAJ
            // 
            this.WYSZUKAJ.BackColor = System.Drawing.Color.Transparent;
            this.WYSZUKAJ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WYSZUKAJ.BackgroundImage")));
            this.WYSZUKAJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WYSZUKAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WYSZUKAJ.Location = new System.Drawing.Point(52, 322);
            this.WYSZUKAJ.Name = "WYSZUKAJ";
            this.WYSZUKAJ.Size = new System.Drawing.Size(200, 65);
            this.WYSZUKAJ.TabIndex = 0;
            this.WYSZUKAJ.Text = "WYSZUKAJ";
            this.WYSZUKAJ.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WYSZUKAJ);
            this.Name = "Form1";
            this.Text = "BITMAPA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WYSZUKAJ;
    }
}

