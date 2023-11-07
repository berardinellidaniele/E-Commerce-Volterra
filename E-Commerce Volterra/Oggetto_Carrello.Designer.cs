namespace E_Commerce_Volterra
{
    partial class Oggetto_Carrello
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oggetto_Carrello));
            this.pcbIcon = new System.Windows.Forms.PictureBox();
            this.lblQuantita = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPrezzo = new System.Windows.Forms.Label();
            this.lblCifra = new System.Windows.Forms.Label();
            this.pcbRimuovi = new System.Windows.Forms.PictureBox();
            this.pcbAggiungi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRimuovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAggiungi)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbIcon
            // 
            this.pcbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pcbIcon.Image")));
            this.pcbIcon.Location = new System.Drawing.Point(3, 6);
            this.pcbIcon.Name = "pcbIcon";
            this.pcbIcon.Size = new System.Drawing.Size(44, 38);
            this.pcbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbIcon.TabIndex = 0;
            this.pcbIcon.TabStop = false;
            // 
            // lblQuantita
            // 
            this.lblQuantita.AutoSize = true;
            this.lblQuantita.Location = new System.Drawing.Point(146, 17);
            this.lblQuantita.Name = "lblQuantita";
            this.lblQuantita.Size = new System.Drawing.Size(19, 13);
            this.lblQuantita.TabIndex = 5;
            this.lblQuantita.Text = "(1)";
            this.lblQuantita.Click += new System.EventHandler(this.lblQuantita_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(53, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 15);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Testo qui";
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezzo.Location = new System.Drawing.Point(300, 15);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(51, 15);
            this.lblPrezzo.TabIndex = 7;
            this.lblPrezzo.Text = "Prezzo";
            // 
            // lblCifra
            // 
            this.lblCifra.AutoSize = true;
            this.lblCifra.Location = new System.Drawing.Point(355, 18);
            this.lblCifra.Name = "lblCifra";
            this.lblCifra.Size = new System.Drawing.Size(40, 13);
            this.lblCifra.TabIndex = 8;
            this.lblCifra.Text = "12.00$";
            // 
            // pcbRimuovi
            // 
            this.pcbRimuovi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbRimuovi.Image = ((System.Drawing.Image)(resources.GetObject("pcbRimuovi.Image")));
            this.pcbRimuovi.Location = new System.Drawing.Point(215, 13);
            this.pcbRimuovi.Name = "pcbRimuovi";
            this.pcbRimuovi.Size = new System.Drawing.Size(24, 22);
            this.pcbRimuovi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRimuovi.TabIndex = 9;
            this.pcbRimuovi.TabStop = false;
            this.pcbRimuovi.Click += new System.EventHandler(this.pcbRimuovi_Click);
            // 
            // pcbAggiungi
            // 
            this.pcbAggiungi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAggiungi.Image = ((System.Drawing.Image)(resources.GetObject("pcbAggiungi.Image")));
            this.pcbAggiungi.Location = new System.Drawing.Point(185, 13);
            this.pcbAggiungi.Name = "pcbAggiungi";
            this.pcbAggiungi.Size = new System.Drawing.Size(24, 22);
            this.pcbAggiungi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAggiungi.TabIndex = 10;
            this.pcbAggiungi.TabStop = false;
            this.pcbAggiungi.Click += new System.EventHandler(this.pcbAggiungi_Click);
            // 
            // Oggetto_Carrello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pcbAggiungi);
            this.Controls.Add(this.pcbRimuovi);
            this.Controls.Add(this.lblCifra);
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblQuantita);
            this.Controls.Add(this.pcbIcon);
            this.Name = "Oggetto_Carrello";
            this.Size = new System.Drawing.Size(413, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pcbIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRimuovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAggiungi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbIcon;
        private System.Windows.Forms.Label lblQuantita;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPrezzo;
        private System.Windows.Forms.Label lblCifra;
        private System.Windows.Forms.PictureBox pcbRimuovi;
        private System.Windows.Forms.PictureBox pcbAggiungi;
    }
}
