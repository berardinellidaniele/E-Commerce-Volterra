namespace E_Commerce_Volterra
{
    partial class Prodotto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prodotto));
            this.pcbCarrello = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.bunifuRecensioni = new Bunifu.UI.WinForms.BunifuRating();
            this.pcbProdotto = new System.Windows.Forms.PictureBox();
            this.lblPrezzo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrello)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProdotto)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCarrello
            // 
            this.pcbCarrello.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbCarrello.Image = ((System.Drawing.Image)(resources.GetObject("pcbCarrello.Image")));
            this.pcbCarrello.Location = new System.Drawing.Point(265, 9);
            this.pcbCarrello.Name = "pcbCarrello";
            this.pcbCarrello.Size = new System.Drawing.Size(28, 25);
            this.pcbCarrello.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCarrello.TabIndex = 0;
            this.pcbCarrello.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblNome.ForeColor = System.Drawing.Color.DimGray;
            this.lblNome.Location = new System.Drawing.Point(13, 159);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(99, 25);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Jeans Blue";
            // 
            // bunifuRecensioni
            // 
            this.bunifuRecensioni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuRecensioni.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRecensioni.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRecensioni.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.bunifuRecensioni.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRecensioni.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRecensioni.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRecensioni.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRecensioni.InnerRadius = 2F;
            this.bunifuRecensioni.Location = new System.Drawing.Point(12, 187);
            this.bunifuRecensioni.Name = "bunifuRecensioni";
            this.bunifuRecensioni.OuterRadius = 10F;
            this.bunifuRecensioni.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRecensioni.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRecensioni.ReadOnly = false;
            this.bunifuRecensioni.RightClickToClear = true;
            this.bunifuRecensioni.Size = new System.Drawing.Size(121, 22);
            this.bunifuRecensioni.TabIndex = 4;
            this.bunifuRecensioni.Text = "bunifuRating1";
            this.bunifuRecensioni.Value = 3;
            // 
            // pcbProdotto
            // 
            this.pcbProdotto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbProdotto.Image = ((System.Drawing.Image)(resources.GetObject("pcbProdotto.Image")));
            this.pcbProdotto.Location = new System.Drawing.Point(84, 18);
            this.pcbProdotto.Name = "pcbProdotto";
            this.pcbProdotto.Size = new System.Drawing.Size(114, 122);
            this.pcbProdotto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProdotto.TabIndex = 5;
            this.pcbProdotto.TabStop = false;
            // 
            // lblPrezzo
            // 
            this.lblPrezzo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrezzo.AutoSize = true;
            this.lblPrezzo.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.lblPrezzo.ForeColor = System.Drawing.Color.DimGray;
            this.lblPrezzo.Location = new System.Drawing.Point(194, 158);
            this.lblPrezzo.Name = "lblPrezzo";
            this.lblPrezzo.Size = new System.Drawing.Size(93, 41);
            this.lblPrezzo.TabIndex = 6;
            this.lblPrezzo.Text = "8.99€";
            // 
            // Prodotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.White;
            this.BorderRadius = 5;
            this.Controls.Add(this.lblPrezzo);
            this.Controls.Add(this.pcbProdotto);
            this.Controls.Add(this.bunifuRecensioni);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pcbCarrello);
            this.Name = "Prodotto";
            this.Size = new System.Drawing.Size(302, 235);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCarrello)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProdotto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCarrello;
        private System.Windows.Forms.Label lblNome;
        private Bunifu.UI.WinForms.BunifuRating bunifuRecensioni;
        private System.Windows.Forms.PictureBox pcbProdotto;
        private System.Windows.Forms.Label lblPrezzo;
    }
}
