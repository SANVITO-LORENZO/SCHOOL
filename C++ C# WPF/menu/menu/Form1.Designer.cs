namespace menu
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
            this.ORDINA = new System.Windows.Forms.Button();
            this.CANCELLA = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.RIEPILOGO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PRIMI = new System.Windows.Forms.Label();
            this.SECONDI = new System.Windows.Forms.Label();
            this.CONTORNI = new System.Windows.Forms.Label();
            this.PIZZE = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ORDINA
            // 
            this.ORDINA.Location = new System.Drawing.Point(12, 254);
            this.ORDINA.Name = "ORDINA";
            this.ORDINA.Size = new System.Drawing.Size(75, 23);
            this.ORDINA.TabIndex = 0;
            this.ORDINA.Text = "ORDINA";
            this.ORDINA.UseVisualStyleBackColor = true;
            this.ORDINA.Click += new System.EventHandler(this.ORDINA_Click);
            // 
            // CANCELLA
            // 
            this.CANCELLA.Location = new System.Drawing.Point(102, 254);
            this.CANCELLA.Name = "CANCELLA";
            this.CANCELLA.Size = new System.Drawing.Size(75, 23);
            this.CANCELLA.TabIndex = 1;
            this.CANCELLA.Text = "CANCELLA";
            this.CANCELLA.UseVisualStyleBackColor = true;
            this.CANCELLA.Click += new System.EventHandler(this.CANCELLA_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(577, 100);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 316);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(577, 197);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RIEPILOGO
            // 
            this.RIEPILOGO.AutoSize = true;
            this.RIEPILOGO.Location = new System.Drawing.Point(9, 290);
            this.RIEPILOGO.Name = "RIEPILOGO";
            this.RIEPILOGO.Size = new System.Drawing.Size(113, 13);
            this.RIEPILOGO.TabIndex = 4;
            this.RIEPILOGO.Text = "RIEPILOGO ORDINE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "INDIRIZZO:";
            // 
            // PRIMI
            // 
            this.PRIMI.AutoSize = true;
            this.PRIMI.Location = new System.Drawing.Point(12, 29);
            this.PRIMI.Name = "PRIMI";
            this.PRIMI.Size = new System.Drawing.Size(37, 13);
            this.PRIMI.TabIndex = 6;
            this.PRIMI.Text = "PRIMI";
            // 
            // SECONDI
            // 
            this.SECONDI.AutoSize = true;
            this.SECONDI.Location = new System.Drawing.Point(164, 29);
            this.SECONDI.Name = "SECONDI";
            this.SECONDI.Size = new System.Drawing.Size(55, 13);
            this.SECONDI.TabIndex = 7;
            this.SECONDI.Text = "SECONDI";
            // 
            // CONTORNI
            // 
            this.CONTORNI.AutoSize = true;
            this.CONTORNI.Location = new System.Drawing.Point(318, 29);
            this.CONTORNI.Name = "CONTORNI";
            this.CONTORNI.Size = new System.Drawing.Size(64, 13);
            this.CONTORNI.TabIndex = 8;
            this.CONTORNI.Text = "CONTORNI";
            // 
            // PIZZE
            // 
            this.PIZZE.AutoSize = true;
            this.PIZZE.Location = new System.Drawing.Point(465, 29);
            this.PIZZE.Name = "PIZZE";
            this.PIZZE.Size = new System.Drawing.Size(38, 13);
            this.PIZZE.TabIndex = 9;
            this.PIZZE.Text = "PIZZE";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 81);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "CONSEGNA A DOMICILIO";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pasta al pomodoro",
            "Pappardelle al sugo",
            "Risotto ai funghi",
            "Zuppa di orzo"});
            this.comboBox1.Location = new System.Drawing.Point(12, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Bistecca ai ferri",
            "Sogliola alla mugnaia",
            "Cotoletta alla",
            "milanese",
            "Punta ripiena"});
            this.comboBox2.Location = new System.Drawing.Point(167, 45);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Patate fritte",
            "Spinaci pasticciati",
            "Verdura lessata",
            "Insalata verde"});
            this.comboBox3.Location = new System.Drawing.Point(321, 45);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 13;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Calzone farcito",
            "Margherita",
            "Napoletana",
            "Capricciosa",
            "Quattro stagioni",
            "Prosciutto e funghi"});
            this.comboBox4.Location = new System.Drawing.Point(468, 45);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 525);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PIZZE);
            this.Controls.Add(this.CONTORNI);
            this.Controls.Add(this.SECONDI);
            this.Controls.Add(this.PRIMI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RIEPILOGO);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CANCELLA);
            this.Controls.Add(this.ORDINA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ORDINA;
        private System.Windows.Forms.Button CANCELLA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label RIEPILOGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PRIMI;
        private System.Windows.Forms.Label SECONDI;
        private System.Windows.Forms.Label CONTORNI;
        private System.Windows.Forms.Label PIZZE;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

