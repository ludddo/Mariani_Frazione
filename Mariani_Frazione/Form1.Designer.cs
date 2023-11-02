namespace Mariani_Frazione
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
            this.attivazioneEstesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // attivazioneEstesa
            // 
            this.attivazioneEstesa.Location = new System.Drawing.Point(655, 2);
            this.attivazioneEstesa.Name = "attivazioneEstesa";
            this.attivazioneEstesa.Size = new System.Drawing.Size(133, 23);
            this.attivazioneEstesa.TabIndex = 1;
            this.attivazioneEstesa.Text = "Funzioni Estese";
            this.attivazioneEstesa.UseVisualStyleBackColor = true;
            this.attivazioneEstesa.Click += new System.EventHandler(this.attivazioneEstesa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.attivazioneEstesa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button attivazioneEstesa;
    }
}

