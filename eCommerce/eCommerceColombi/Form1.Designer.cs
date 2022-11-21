namespace eCommerceColombi
{
    partial class Form1
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.nomeAggiungi = new System.Windows.Forms.TextBox();
            this.carrelloButton = new System.Windows.Forms.Button();
            this.prodottiButton = new System.Windows.Forms.Button();
            this.aggiungiButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rimuoviBox = new System.Windows.Forms.TextBox();
            this.rimuoviButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.svuotaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(474, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 426);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // nomeAggiungi
            // 
            this.nomeAggiungi.Location = new System.Drawing.Point(12, 32);
            this.nomeAggiungi.Name = "nomeAggiungi";
            this.nomeAggiungi.Size = new System.Drawing.Size(100, 20);
            this.nomeAggiungi.TabIndex = 1;
            // 
            // carrelloButton
            // 
            this.carrelloButton.Location = new System.Drawing.Point(326, 124);
            this.carrelloButton.Name = "carrelloButton";
            this.carrelloButton.Size = new System.Drawing.Size(75, 23);
            this.carrelloButton.TabIndex = 2;
            this.carrelloButton.Text = "Carrello";
            this.carrelloButton.UseVisualStyleBackColor = true;
            this.carrelloButton.Click += new System.EventHandler(this.carrelloButton_Click);
            // 
            // prodottiButton
            // 
            this.prodottiButton.Location = new System.Drawing.Point(326, 287);
            this.prodottiButton.Name = "prodottiButton";
            this.prodottiButton.Size = new System.Drawing.Size(75, 23);
            this.prodottiButton.TabIndex = 3;
            this.prodottiButton.Text = "Prodotti";
            this.prodottiButton.UseVisualStyleBackColor = true;
            this.prodottiButton.Click += new System.EventHandler(this.prodottiButton_Click);
            // 
            // aggiungiButton
            // 
            this.aggiungiButton.Location = new System.Drawing.Point(12, 58);
            this.aggiungiButton.Name = "aggiungiButton";
            this.aggiungiButton.Size = new System.Drawing.Size(75, 23);
            this.aggiungiButton.TabIndex = 4;
            this.aggiungiButton.Text = "Aggiungi";
            this.aggiungiButton.UseVisualStyleBackColor = true;
            this.aggiungiButton.Click += new System.EventHandler(this.aggiungiButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inserisci l\'ID del prodotto per aggiungerlo al carrello";
            // 
            // rimuoviBox
            // 
            this.rimuoviBox.Location = new System.Drawing.Point(15, 290);
            this.rimuoviBox.Name = "rimuoviBox";
            this.rimuoviBox.Size = new System.Drawing.Size(100, 20);
            this.rimuoviBox.TabIndex = 6;
            // 
            // rimuoviButton
            // 
            this.rimuoviButton.Location = new System.Drawing.Point(15, 316);
            this.rimuoviButton.Name = "rimuoviButton";
            this.rimuoviButton.Size = new System.Drawing.Size(75, 23);
            this.rimuoviButton.TabIndex = 7;
            this.rimuoviButton.Text = "Rimuovi";
            this.rimuoviButton.UseVisualStyleBackColor = true;
            this.rimuoviButton.Click += new System.EventHandler(this.rimuoviButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Inserisci l\'ID del prodotto per rimuoverlo dal carrello";
            // 
            // svuotaButton
            // 
            this.svuotaButton.Location = new System.Drawing.Point(12, 365);
            this.svuotaButton.Name = "svuotaButton";
            this.svuotaButton.Size = new System.Drawing.Size(100, 30);
            this.svuotaButton.TabIndex = 9;
            this.svuotaButton.Text = "Svuota Carrello";
            this.svuotaButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.svuotaButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rimuoviButton);
            this.Controls.Add(this.rimuoviBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aggiungiButton);
            this.Controls.Add(this.prodottiButton);
            this.Controls.Add(this.carrelloButton);
            this.Controls.Add(this.nomeAggiungi);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Carrello";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox nomeAggiungi;
        private System.Windows.Forms.Button carrelloButton;
        private System.Windows.Forms.Button prodottiButton;
        private System.Windows.Forms.Button aggiungiButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rimuoviBox;
        private System.Windows.Forms.Button rimuoviButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button svuotaButton;
    }
}

