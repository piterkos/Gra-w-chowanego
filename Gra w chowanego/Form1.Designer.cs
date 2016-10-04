namespace Mieszkanie_s._338
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
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Opis_tb = new System.Windows.Forms.TextBox();
            this.IdzTutaj_btn = new System.Windows.Forms.Button();
            this.Wyjscia_cbox = new System.Windows.Forms.ComboBox();
            this.PrzejdzPrzezDrzwi_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Opis_tb
            // 
            this.Opis_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opis_tb.Location = new System.Drawing.Point(12, 12);
            this.Opis_tb.Multiline = true;
            this.Opis_tb.Name = "Opis_tb";
            this.Opis_tb.Size = new System.Drawing.Size(516, 153);
            this.Opis_tb.TabIndex = 0;
            // 
            // IdzTutaj_btn
            // 
            this.IdzTutaj_btn.Location = new System.Drawing.Point(13, 172);
            this.IdzTutaj_btn.Name = "IdzTutaj_btn";
            this.IdzTutaj_btn.Size = new System.Drawing.Size(75, 23);
            this.IdzTutaj_btn.TabIndex = 1;
            this.IdzTutaj_btn.Text = "Idź tutaj";
            this.IdzTutaj_btn.UseVisualStyleBackColor = true;
            this.IdzTutaj_btn.Click += new System.EventHandler(this.IdzTutaj_btn_Click);
            // 
            // Wyjscia_cbox
            // 
            this.Wyjscia_cbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Wyjscia_cbox.FormattingEnabled = true;
            this.Wyjscia_cbox.Location = new System.Drawing.Point(94, 172);
            this.Wyjscia_cbox.Name = "Wyjscia_cbox";
            this.Wyjscia_cbox.Size = new System.Drawing.Size(178, 21);
            this.Wyjscia_cbox.TabIndex = 2;
            // 
            // PrzejdzPrzezDrzwi_btn
            // 
            this.PrzejdzPrzezDrzwi_btn.Location = new System.Drawing.Point(13, 202);
            this.PrzejdzPrzezDrzwi_btn.Name = "PrzejdzPrzezDrzwi_btn";
            this.PrzejdzPrzezDrzwi_btn.Size = new System.Drawing.Size(259, 23);
            this.PrzejdzPrzezDrzwi_btn.TabIndex = 3;
            this.PrzejdzPrzezDrzwi_btn.Text = "Przejdź przez drzwi";
            this.PrzejdzPrzezDrzwi_btn.UseVisualStyleBackColor = true;
            this.PrzejdzPrzezDrzwi_btn.Click += new System.EventHandler(this.PrzejdzPrzezDrzwi_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 261);
            this.Controls.Add(this.PrzejdzPrzezDrzwi_btn);
            this.Controls.Add(this.Wyjscia_cbox);
            this.Controls.Add(this.IdzTutaj_btn);
            this.Controls.Add(this.Opis_tb);
            this.Name = "Form1";
            this.Text = "Gra w chowanego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Opis_tb;
        private System.Windows.Forms.Button IdzTutaj_btn;
        private System.Windows.Forms.ComboBox Wyjscia_cbox;
        private System.Windows.Forms.Button PrzejdzPrzezDrzwi_btn;
    }
}

