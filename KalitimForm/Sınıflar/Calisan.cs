using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimForm.Sınıflar
{
    internal class Calisan
    {
        private int _sskNo; // alanlar

        public int sskNo // özellikler
        {
            get { return _sskNo; }
            set { _sskNo = value; }
        }
        private string _adi;
        public string Adi // özellikler
        {
            get { return _adi; }
            set { _adi = value; }
        }

        protected double _maasi;
        public double Maasi // özellikler
        {
            get { return _maasi; }
            set { _maasi = value; }
        }

        // virtual ile bu sınıftan türeyen sınıfta bu metot değiştirilebilir.

        public virtual void ZamYap(double zamMiktari)
        {
            // Atama, doğrudan temel sınıftaki üyeye yapılır.
            _maasi = zamMiktari;
        }
        // this ile kullanılan alanın o sınıfta ait olduğunu belirtiyoruz.
        // Aynı alan isimli parametrede olabilir.
        // public virtual string BilgiVer(int SskNo)
        public virtual string BilgiVer()
        {
            // this ile sınıftaki özelliğe ulaşıyoruz.
            return this.sskNo + "/" + Adi + "/" + this.Maasi;
        }
    }
}
