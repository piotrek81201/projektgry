namespace GraGUI
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.komunikat = new System.Windows.Forms.Label();
            this.wprowadzanie_liczby = new System.Windows.Forms.TextBox();
            this.sprawdz = new System.Windows.Forms.Button();
            this.Wynik = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.poddaj = new System.Windows.Forms.Button();
            this.Historia = new System.Windows.Forms.Button();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(26, 25);
            this.buttonNowaGra.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(150, 44);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxOd);
            this.groupBoxLosuj.Controls.Add(this.label2);
            this.groupBoxLosuj.Controls.Add(this.label1);
            this.groupBoxLosuj.Location = new System.Drawing.Point(26, 106);
            this.groupBoxLosuj.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxLosuj.Size = new System.Drawing.Size(558, 215);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(370, 106);
            this.buttonLosuj.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(150, 44);
            this.buttonLosuj.TabIndex = 4;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(136, 140);
            this.textBoxDo.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(196, 31);
            this.textBoxDo.TabIndex = 3;
            this.textBoxDo.Text = "100";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(136, 54);
            this.textBoxOd.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(196, 31);
            this.textBoxOd.TabIndex = 2;
            this.textBoxOd.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "zakres do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "zakres od:";
            // 
            // komunikat
            // 
            this.komunikat.AutoSize = true;
            this.komunikat.Location = new System.Drawing.Point(36, 44);
            this.komunikat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.komunikat.Name = "komunikat";
            this.komunikat.Size = new System.Drawing.Size(450, 25);
            this.komunikat.TabIndex = 4;
            this.komunikat.Text = "Liczba została wylosowana, teraz ją odgadnij!";
            this.komunikat.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // wprowadzanie_liczby
            // 
            this.wprowadzanie_liczby.Location = new System.Drawing.Point(41, 116);
            this.wprowadzanie_liczby.Margin = new System.Windows.Forms.Padding(6);
            this.wprowadzanie_liczby.Name = "wprowadzanie_liczby";
            this.wprowadzanie_liczby.Size = new System.Drawing.Size(176, 31);
            this.wprowadzanie_liczby.TabIndex = 5;
            this.wprowadzanie_liczby.Text = "0";
            this.wprowadzanie_liczby.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sprawdz
            // 
            this.sprawdz.Location = new System.Drawing.Point(244, 116);
            this.sprawdz.Margin = new System.Windows.Forms.Padding(6);
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.Size = new System.Drawing.Size(136, 38);
            this.sprawdz.TabIndex = 6;
            this.sprawdz.Text = "Sprawdź";
            this.sprawdz.UseVisualStyleBackColor = true;
            this.sprawdz.Click += new System.EventHandler(this.button1_Click);
            // 
            // Wynik
            // 
            this.Wynik.AutoSize = true;
            this.Wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wynik.Location = new System.Drawing.Point(21, 182);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(0, 120);
            this.Wynik.TabIndex = 8;
            this.Wynik.Click += new System.EventHandler(this.Wynik_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.poddaj);
            this.groupBox2.Controls.Add(this.wprowadzanie_liczby);
            this.groupBox2.Controls.Add(this.sprawdz);
            this.groupBox2.Controls.Add(this.komunikat);
            this.groupBox2.Controls.Add(this.Wynik);
            this.groupBox2.Location = new System.Drawing.Point(26, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 327);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gra";
            this.groupBox2.Visible = false;
            // 
            // poddaj
            // 
            this.poddaj.Location = new System.Drawing.Point(399, 116);
            this.poddaj.Margin = new System.Windows.Forms.Padding(6);
            this.poddaj.Name = "poddaj";
            this.poddaj.Size = new System.Drawing.Size(136, 38);
            this.poddaj.TabIndex = 9;
            this.poddaj.Text = "Poddaj";
            this.poddaj.UseVisualStyleBackColor = true;
            this.poddaj.Click += new System.EventHandler(this.poddaj_Click);
            // 
            // Historia
            // 
            this.Historia.Location = new System.Drawing.Point(419, 25);
            this.Historia.Name = "Historia";
            this.Historia.Size = new System.Drawing.Size(142, 44);
            this.Historia.TabIndex = 9;
            this.Historia.Text = "Historia";
            this.Historia.UseVisualStyleBackColor = true;
            this.Historia.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 865);
            this.Controls.Add(this.Historia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.buttonNowaGra);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Za Dużo Za Mało";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label komunikat;
        private System.Windows.Forms.TextBox wprowadzanie_liczby;
        private System.Windows.Forms.Button sprawdz;
        private System.Windows.Forms.Label Wynik;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Historia;
        private System.Windows.Forms.Button poddaj;
    }
}

