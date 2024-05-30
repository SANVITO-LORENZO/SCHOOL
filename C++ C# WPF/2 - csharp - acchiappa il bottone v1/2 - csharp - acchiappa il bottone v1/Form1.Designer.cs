namespace _2___csharp___acchiappa_il_bottone_v1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_punteggio = new System.Windows.Forms.Label();
            this.label_tempo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_punteggio
            // 
            this.label_punteggio.AutoSize = true;
            this.label_punteggio.ForeColor = System.Drawing.Color.HotPink;
            this.label_punteggio.Location = new System.Drawing.Point(12, 9);
            this.label_punteggio.Name = "label_punteggio";
            this.label_punteggio.Size = new System.Drawing.Size(61, 13);
            this.label_punteggio.TabIndex = 0;
            this.label_punteggio.Text = "Punteggio: ";
            this.label_punteggio.Click += new System.EventHandler(this.label_punteggio_Click);
            // 
            // label_tempo
            // 
            this.label_tempo.AutoSize = true;
            this.label_tempo.ForeColor = System.Drawing.Color.HotPink;
            this.label_tempo.Location = new System.Drawing.Point(688, 9);
            this.label_tempo.Name = "label_tempo";
            this.label_tempo.Size = new System.Drawing.Size(100, 13);
            this.label_tempo.TabIndex = 1;
            this.label_tempo.Text = "Tempo Rimanente: ";
            this.label_tempo.Click += new System.EventHandler(this.label_tempo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(345, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 81);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.label_punteggio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_tempo);
            this.Controls.Add(this.label_punteggio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_punteggio;
        private System.Windows.Forms.Label label_tempo;
        private System.Windows.Forms.Button button1;
    }
}

