namespace Telefonrehberi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TelefonNumarasiKaydet = new System.Windows.Forms.Button();
            this.btn_TelefonNumarasiSil = new System.Windows.Forms.Button();
            this.btn_TelefonNumarasiGuncelle = new System.Windows.Forms.Button();
            this.btn_RehberListeleme = new System.Windows.Forms.Button();
            this.btn_RehberArama = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Magneto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(228, 18);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon Rehberi";
            // 
            // btn_TelefonNumarasiKaydet
            // 
            this.btn_TelefonNumarasiKaydet.Location = new System.Drawing.Point(273, 71);
            this.btn_TelefonNumarasiKaydet.Name = "btn_TelefonNumarasiKaydet";
            this.btn_TelefonNumarasiKaydet.Size = new System.Drawing.Size(186, 52);
            this.btn_TelefonNumarasiKaydet.TabIndex = 1;
            this.btn_TelefonNumarasiKaydet.Text = "Telefon Numarasi Kaydet";
            this.btn_TelefonNumarasiKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_TelefonNumarasiKaydet.UseVisualStyleBackColor = true;
            this.btn_TelefonNumarasiKaydet.Click += new System.EventHandler(this.btn_TelefonNumarasiKaydet_Click);
            // 
            // btn_TelefonNumarasiSil
            // 
            this.btn_TelefonNumarasiSil.Location = new System.Drawing.Point(273, 138);
            this.btn_TelefonNumarasiSil.Name = "btn_TelefonNumarasiSil";
            this.btn_TelefonNumarasiSil.Size = new System.Drawing.Size(186, 49);
            this.btn_TelefonNumarasiSil.TabIndex = 2;
            this.btn_TelefonNumarasiSil.Text = "Telefon Numarasi Sil";
            this.btn_TelefonNumarasiSil.UseVisualStyleBackColor = true;
            this.btn_TelefonNumarasiSil.Click += new System.EventHandler(this.btn_TelefonNumarasiSil_Click);
            // 
            // btn_TelefonNumarasiGuncelle
            // 
            this.btn_TelefonNumarasiGuncelle.Location = new System.Drawing.Point(273, 212);
            this.btn_TelefonNumarasiGuncelle.Name = "btn_TelefonNumarasiGuncelle";
            this.btn_TelefonNumarasiGuncelle.Size = new System.Drawing.Size(186, 43);
            this.btn_TelefonNumarasiGuncelle.TabIndex = 3;
            this.btn_TelefonNumarasiGuncelle.Text = "Telefon Numarasi Guncelle";
            this.btn_TelefonNumarasiGuncelle.UseVisualStyleBackColor = true;
            this.btn_TelefonNumarasiGuncelle.Click += new System.EventHandler(this.btn_TelefonNumarasiGuncelle_Click);
            // 
            // btn_RehberListeleme
            // 
            this.btn_RehberListeleme.Location = new System.Drawing.Point(273, 272);
            this.btn_RehberListeleme.Name = "btn_RehberListeleme";
            this.btn_RehberListeleme.Size = new System.Drawing.Size(186, 43);
            this.btn_RehberListeleme.TabIndex = 4;
            this.btn_RehberListeleme.Text = "Rehber Listeleme";
            this.btn_RehberListeleme.UseVisualStyleBackColor = true;
            this.btn_RehberListeleme.Click += new System.EventHandler(this.btn_RehberListeleme_Click);
            // 
            // btn_RehberArama
            // 
            this.btn_RehberArama.Location = new System.Drawing.Point(273, 337);
            this.btn_RehberArama.Name = "btn_RehberArama";
            this.btn_RehberArama.Size = new System.Drawing.Size(186, 43);
            this.btn_RehberArama.TabIndex = 5;
            this.btn_RehberArama.Text = "Rehber Arama";
            this.btn_RehberArama.UseVisualStyleBackColor = true;
            this.btn_RehberArama.Click += new System.EventHandler(this.btn_RehberArama_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(273, 395);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 43);
            this.button6.TabIndex = 6;
            this.button6.Text = "Cikis";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_RehberArama);
            this.Controls.Add(this.btn_RehberListeleme);
            this.Controls.Add(this.btn_TelefonNumarasiGuncelle);
            this.Controls.Add(this.btn_TelefonNumarasiSil);
            this.Controls.Add(this.btn_TelefonNumarasiKaydet);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TelefonNumarasiKaydet;
        private System.Windows.Forms.Button btn_TelefonNumarasiSil;
        private System.Windows.Forms.Button btn_TelefonNumarasiGuncelle;
        private System.Windows.Forms.Button btn_RehberListeleme;
        private System.Windows.Forms.Button btn_RehberArama;
        private System.Windows.Forms.Button button6;
    }
}

