using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalitimForm.Sınıflar
{
    internal class SatisElamani : Calisan
    {
        private int _satisSayisi;
        public int SatisSayisi
        {
            get { return _satisSayisi; }
            set { _satisSayisi = value; }
        }
        public override void ZamYap(double zamMiktari)
        {
            double ekstraZam = 0;

            if (Maasi > 0)
            {
                if ((SatisSayisi > 0) && (SatisSayisi < 50))
                {
                    ekstraZam = 30;
                }
                else if ((SatisSayisi > 50) && (SatisSayisi < 150))
                {
                    ekstraZam = 60;
                }
            }
            else
            {
                MessageBox.Show("Maaş Bilgisi Yoktur.");
                return;
            }
            Maasi += (zamMiktari + zamMiktari);
        }
        public override string BilgiVer()
        {
            // base ile en temel sınıfa ulaşırız.
            // en temel sınıf en üstteki sınıftır.
            string temelBilgi = base.BilgiVer();
            temelBilgi += "/" + this.SatisSayisi;
            return temelBilgi;
        }
    }
}
