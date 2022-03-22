using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalitimForm.Sınıflar
{
    internal class Mudur : Calisan
    {
        private double _depertmanKar;
        public double DepertmanKar
        {
            get { return _depertmanKar; }
            set { _depertmanKar = value; }
        }
        // Bu durumada çok biçimlilik diyoruz.

        public override void ZamYap(double zamMiktari) // çok biçimlilik polimorfizm
        {
            double ekstraZam = 0;
            if (Maasi > 0)
            {
                if ((DepertmanKar > 0) && (DepertmanKar <= 50))
                {
                    ekstraZam = 300;
                }
                else if ((DepertmanKar < 50) && (DepertmanKar < 150))
                {
                    ekstraZam = 600;
                }
            }
            else
            {
                MessageBox.Show("Maaş Bilgisi Yoktur.");
                return;
            }
            Maasi += (zamMiktari + ekstraZam);
        }
    }
}
