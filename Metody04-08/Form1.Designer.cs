namespace Metody04_08
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Mocnina = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_Faktorial = new System.Windows.Forms.Button();
            this.button_CifLichSoucet = new System.Windows.Forms.Button();
            this.button_JePrvocislo = new System.Windows.Forms.Button();
            this.button_PocetDeliteluSud = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_Mocnina
            // 
            this.button_Mocnina.Location = new System.Drawing.Point(12, 38);
            this.button_Mocnina.Name = "button_Mocnina";
            this.button_Mocnina.Size = new System.Drawing.Size(64, 23);
            this.button_Mocnina.TabIndex = 0;
            this.button_Mocnina.Text = "Mocnina";
            this.button_Mocnina.UseVisualStyleBackColor = true;
            this.button_Mocnina.Click += new System.EventHandler(this.button_Mocnina_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(29, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(47, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(29, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "-3";
            // 
            // button_Faktorial
            // 
            this.button_Faktorial.Location = new System.Drawing.Point(82, 38);
            this.button_Faktorial.Name = "button_Faktorial";
            this.button_Faktorial.Size = new System.Drawing.Size(64, 23);
            this.button_Faktorial.TabIndex = 3;
            this.button_Faktorial.Text = "Faktoriál";
            this.button_Faktorial.UseVisualStyleBackColor = true;
            this.button_Faktorial.Click += new System.EventHandler(this.button_Faktorial_Click);
            // 
            // button_CifLichSoucet
            // 
            this.button_CifLichSoucet.Location = new System.Drawing.Point(152, 38);
            this.button_CifLichSoucet.Name = "button_CifLichSoucet";
            this.button_CifLichSoucet.Size = new System.Drawing.Size(89, 23);
            this.button_CifLichSoucet.TabIndex = 4;
            this.button_CifLichSoucet.Text = "CifLichSoučet";
            this.button_CifLichSoucet.UseVisualStyleBackColor = true;
            this.button_CifLichSoucet.Click += new System.EventHandler(this.button_CifLichSoucet_Click);
            // 
            // button_JePrvocislo
            // 
            this.button_JePrvocislo.Location = new System.Drawing.Point(247, 38);
            this.button_JePrvocislo.Name = "button_JePrvocislo";
            this.button_JePrvocislo.Size = new System.Drawing.Size(74, 23);
            this.button_JePrvocislo.TabIndex = 5;
            this.button_JePrvocislo.Text = "Je prvočíslo";
            this.button_JePrvocislo.UseVisualStyleBackColor = true;
            this.button_JePrvocislo.Click += new System.EventHandler(this.button_JePrvocislo_Click);
            // 
            // button_PocetDeliteluSud
            // 
            this.button_PocetDeliteluSud.Location = new System.Drawing.Point(327, 38);
            this.button_PocetDeliteluSud.Name = "button_PocetDeliteluSud";
            this.button_PocetDeliteluSud.Size = new System.Drawing.Size(116, 23);
            this.button_PocetDeliteluSud.TabIndex = 6;
            this.button_PocetDeliteluSud.Text = "Počet sudých dělitelů";
            this.button_PocetDeliteluSud.UseVisualStyleBackColor = true;
            this.button_PocetDeliteluSud.Click += new System.EventHandler(this.button_PocetDeliteluSud_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(100, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(29, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(168, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(57, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "1234";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(262, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(45, 20);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(327, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(116, 20);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 70);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button_PocetDeliteluSud);
            this.Controls.Add(this.button_JePrvocislo);
            this.Controls.Add(this.button_CifLichSoucet);
            this.Controls.Add(this.button_Faktorial);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_Mocnina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Mocnina;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_Faktorial;
        private System.Windows.Forms.Button button_CifLichSoucet;
        private System.Windows.Forms.Button button_JePrvocislo;
        private System.Windows.Forms.Button button_PocetDeliteluSud;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

