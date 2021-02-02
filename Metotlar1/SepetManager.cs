using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar1
{
    class SepetManager
    {
        //naming convention

        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikle. Sepete eklendi : "+ urunAdi);
        }

    }
}
