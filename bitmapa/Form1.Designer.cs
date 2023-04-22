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
            this.OBROT = new System.Windows.Forms.Button();
            this.odbicie = new System.Windows.Forms.Button();
            this.odbicie2 = new System.Windows.Forms.Button();
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
            // OBROT
            // 
            this.OBROT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OBROT.BackgroundImage")));
            this.OBROT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OBROT.Location = new System.Drawing.Point(523, 116);
            this.OBROT.Name = "OBROT";
            this.OBROT.Size = new System.Drawing.Size(207, 45);
            this.OBROT.TabIndex = 4;
            this.OBROT.Text = "OBRÓT O 90";
            this.OBROT.UseVisualStyleBackColor = true;
            this.OBROT.Click += new System.EventHandler(this.OBROT_Click);
            // 
            // odbicie
            // 
            this.odbicie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("odbicie.BackgroundImage")));
            this.odbicie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odbicie.Location = new System.Drawing.Point(523, 181);
            this.odbicie.Name = "odbicie";
            this.odbicie.Size = new System.Drawing.Size(207, 50);
            this.odbicie.TabIndex = 5;
            this.odbicie.Text = "ODBICIE LUSTRZANE 1";
            this.odbicie.UseVisualStyleBackColor = true;
            this.odbicie.Click += new System.EventHandler(this.odbicie_Click);
            // 
            // odbicie2
            // 
            this.odbicie2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("odbicie2.BackgroundImage")));
            this.odbicie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.odbicie2.Location = new System.Drawing.Point(523, 249);
            this.odbicie2.Name = "odbicie2";
            this.odbicie2.Size = new System.Drawing.Size(207, 52);
            this.odbicie2.TabIndex = 6;
            this.odbicie2.Text = "ODBICIE LUSTRZANE 2";
            this.odbicie2.UseVisualStyleBackColor = true;
            this.odbicie2.Click += new System.EventHandler(this.odbicie2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odbicie2);
            this.Controls.Add(this.odbicie);
            this.Controls.Add(this.OBROT);
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
        private System.Windows.Forms.Button OBROT;
        private System.Windows.Forms.Button odbicie;
        private System.Windows.Forms.Button odbicie2;
    }
}

