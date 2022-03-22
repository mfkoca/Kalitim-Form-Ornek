using KalitimForm.Sınıflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalitimForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbCalisan.Checked)
            {
                Calisan calisan = new Calisan();
                calisan.Adi = txtAdi.Text;
                calisan.Maasi = Convert.ToInt32(txtMaasi.Text);
                calisan.sskNo = Convert.ToInt32(txtSskNo.Text);
                calisan.ZamYap(double.Parse(txtZamMiktari.Text));
                listBox1.Items.Add(calisan.BilgiVer());
                listBox1.Items.Add(calisan.sskNo);
            }

            else if (rbMudur.Checked)
            {
                Mudur mudur = new Mudur();
                mudur.sskNo = Convert.ToInt32(txtSskNo.Text);
                mudur.Adi = txtAdi.Text;
                mudur.Maasi = Convert.ToInt32(txtMaasi.Text);
                mudur.DepertmanKar = double.Parse(txtDepartman.Text);
                mudur.ZamYap(double.Parse(txtZamMiktari.Text));
                listBox1.Items.Add(mudur.BilgiVer());
                listBox1.Items.Add(mudur.Maasi);
            }

            else if (rbSatisci.Checked)
            {
                SatisElamani satis = new SatisElamani();
                satis.Adi = txtAdi.Text;
                satis.Maasi = Convert.ToInt32(txtMaasi.Text);
                satis.SatisSayisi = Convert.ToInt32(txtDepartman.Text);
                satis.ZamYap(double.Parse(txtZamMiktari.Text));
                listBox1.Items.Add(satis.BilgiVer());
                listBox1.Items.Add(satis.Maasi);
            }
            
        }

        private void rbCalisan_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;

            txtAdi.Visible = true;
            txtSskNo.Visible = true;
            txtZamMiktari.Visible = true;
            txtMaasi.Visible = true;
            txtDepartman.Visible = false;
        }

        private void rbMudur_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Text = "Departman Karı:";
            label6.Visible = true;

            txtAdi.Visible = true;
            txtSskNo.Visible = true;
            txtZamMiktari.Visible = true;
            txtMaasi.Visible = true;
            txtDepartman.Visible = true;
        }

        private void rbSatisci_CheckedChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Text = "Satış Sayısı:";
            label6.Visible = true;

            txtAdi.Visible = true;
            txtSskNo.Visible = true;
            txtZamMiktari.Visible = true;
            txtMaasi.Visible = true;
            txtDepartman.Visible = true;
        }
    }
}
