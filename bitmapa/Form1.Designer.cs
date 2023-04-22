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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zielony = new System.Windows.Forms.Button();
            this.NEGATYW = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WYSZUKAJ
            // 
            this.WYSZUKAJ.BackColor = System.Drawing.Color.Transparent;
            this.WYSZUKAJ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WYSZUKAJ.BackgroundImage")));
            this.WYSZUKAJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WYSZUKAJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WYSZUKAJ.Location = new System.Drawing.Point(23, 348);
            this.WYSZUKAJ.Name = "WYSZUKAJ";
            this.WYSZUKAJ.Size = new System.Drawing.Size(200, 65);
            this.WYSZUKAJ.TabIndex = 0;
            this.WYSZUKAJ.Text = "WYSZUKAJ";
            this.WYSZUKAJ.UseVisualStyleBackColor = false;
            this.WYSZUKAJ.Click += new System.EventHandler(this.WYSZUKAJ_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 318);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // zielony
            // 
            this.zielony.BackColor = System.Drawing.Color.Transparent;
            this.zielony.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zielony.BackgroundImage")));
            this.zielony.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zielony.Location = new System.Drawing.Point(519, 24);
            this.zielony.Name = "zielony";
            this.zielony.Size = new System.Drawing.Size(215, 63);
            this.zielony.TabIndex = 2;
            this.zielony.Text = "TYLKO ZIELONY";
            this.zielony.UseVisualStyleBackColor = false;
            this.zielony.Click += new System.EventHandler(this.zielony_Click);
            // 
            // NEGATYW
            // 

            this.odbicie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("odbicie.BackgroundImage")));
            this.odbicie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odbicie.Location = new System.Drawing.Point(554, 192);
            this.odbicie.Name = "odbicie";
            this.odbicie.Size = new System.Drawing.Size(191, 53);
            this.odbicie.TabIndex = 3;
            this.odbicie.Text = "ODBICIE LUSTRZANE I";
            this.odbicie.UseVisualStyleBackColor = true;
            this.odbicie.Click += new System.EventHandler(this.odbicie_Click);
            // 
            // DWAODBICIE
            // 
            this.DWAODBICIE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DWAODBICIE.BackgroundImage")));
            this.DWAODBICIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DWAODBICIE.Location = new System.Drawing.Point(553, 267);
            this.DWAODBICIE.Name = "DWAODBICIE";
            this.DWAODBICIE.Size = new System.Drawing.Size(192, 54);
            this.DWAODBICIE.TabIndex = 4;
            this.DWAODBICIE.Text = "ODBICIE LUSTRZANE II";
            this.DWAODBICIE.UseVisualStyleBackColor = true;
            this.DWAODBICIE.Click += new System.EventHandler(this.DWAODBICIE_Click);

            this.NEGATYW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NEGATYW.BackgroundImage")));
            this.NEGATYW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NEGATYW.Location = new System.Drawing.Point(519, 348);
            this.NEGATYW.Name = "NEGATYW";
            this.NEGATYW.Size = new System.Drawing.Size(215, 63);
            this.NEGATYW.TabIndex = 3;
            this.NEGATYW.Text = "NEGATYW";
            this.NEGATYW.UseVisualStyleBackColor = true;
            this.NEGATYW.Click += new System.EventHandler(this.NEGATYW_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NEGATYW);
            this.Controls.Add(this.zielony);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WYSZUKAJ);
            this.Name = "Form1";
            this.Text = "BITMAPA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WYSZUKAJ;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button zielony;
        private System.Windows.Forms.Button NEGATYW;
    }
}

