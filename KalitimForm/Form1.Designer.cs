namespace KalitimForm
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
            this.rbCalisan = new System.Windows.Forms.RadioButton();
            this.rbMudur = new System.Windows.Forms.RadioButton();
            this.rbSatisci = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSskNo = new System.Windows.Forms.TextBox();
            this.txtMaasi = new System.Windows.Forms.TextBox();
            this.txtZamMiktari = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartman = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Tipleri";
            // 
            // rbCalisan
            // 
            this.rbCalisan.AutoSize = true;
            this.rbCalisan.Location = new System.Drawing.Point(148, 74);
            this.rbCalisan.Name = "rbCalisan";
            this.rbCalisan.Size = new System.Drawing.Size(73, 20);
            this.rbCalisan.TabIndex = 1;
            this.rbCalisan.TabStop = true;
            this.rbCalisan.Text = "Çalışan";
            this.rbCalisan.UseVisualStyleBackColor = true;
            this.rbCalisan.CheckedChanged += new System.EventHandler(this.rbCalisan_CheckedChanged);
            // 
            // rbMudur
            // 
            this.rbMudur.AutoSize = true;
            this.rbMudur.Location = new System.Drawing.Point(273, 74);
            this.rbMudur.Name = "rbMudur";
            this.rbMudur.Size = new System.Drawing.Size(65, 20);
            this.rbMudur.TabIndex = 2;
            this.rbMudur.TabStop = true;
            this.rbMudur.Text = "Müdür";
            this.rbMudur.UseVisualStyleBackColor = true;
            this.rbMudur.CheckedChanged += new System.EventHandler(this.rbMudur_CheckedChanged);
            // 
            // rbSatisci
            // 
            this.rbSatisci.AutoSize = true;
            this.rbSatisci.Location = new System.Drawing.Point(410, 74);
            this.rbSatisci.Name = "rbSatisci";
            this.rbSatisci.Size = new System.Drawing.Size(68, 20);
            this.rbSatisci.TabIndex = 3;
            this.rbSatisci.TabStop = true;
            this.rbSatisci.Text = "Satışçı";
            this.rbSatisci.UseVisualStyleBackColor = true;
            this.rbSatisci.CheckedChanged += new System.EventHandler(this.rbSatisci_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ssk No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maaşı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zam Miktarı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(129, 119);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(117, 22);
            this.txtAdi.TabIndex = 8;
            // 
            // txtSskNo
            // 
            this.txtSskNo.Location = new System.Drawing.Point(129, 146);
            this.txtSskNo.Name = "txtSskNo";
            this.txtSskNo.Size = new System.Drawing.Size(117, 22);
            this.txtSskNo.TabIndex = 9;
            // 
            // txtMaasi
            // 
            this.txtMaasi.Location = new System.Drawing.Point(129, 182);
            this.txtMaasi.Name = "txtMaasi";
            this.txtMaasi.Size = new System.Drawing.Size(117, 22);
            this.txtMaasi.TabIndex = 10;
            // 
            // txtZamMiktari
            // 
            this.txtZamMiktari.Location = new System.Drawing.Point(129, 215);
            this.txtZamMiktari.Name = "txtZamMiktari";
            this.txtZamMiktari.Size = new System.Drawing.Size(117, 22);
            this.txtZamMiktari.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Departman Karı:";
            // 
            // txtDepartman
            // 
            this.txtDepartman.Location = new System.Drawing.Point(129, 251);
            this.txtDepartman.Name = "txtDepartman";
            this.txtDepartman.Size = new System.Drawing.Size(117, 22);
            this.txtDepartman.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(44, 323);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(449, 212);
            this.listBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(44, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Personel Listesi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(300, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 16;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtDepartman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtZamMiktari);
            this.Controls.Add(this.txtMaasi);
            this.Controls.Add(this.txtSskNo);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSatisci);
            this.Controls.Add(this.rbMudur);
            this.Controls.Add(this.rbCalisan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCalisan;
        private System.Windows.Forms.RadioButton rbMudur;
        private System.Windows.Forms.RadioButton rbSatisci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSskNo;
        private System.Windows.Forms.TextBox txtMaasi;
        private System.Windows.Forms.TextBox txtZamMiktari;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepartman;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}

