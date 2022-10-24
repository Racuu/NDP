using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
namespace NDPProje
{
    class oyun
    {
        public int oyunSuresi { get; set; }
        public int puan { get; set; }
        public List<AtikKutusu> atikKutulari { get; set; }

        public oyun()
        {
            this.oyunSuresi = 60;
            this.puan = 0;
        }

        public void atikKutusuEkle(AtikKutusu aK)
        {
            this.atikKutulari.Add(aK);
        }
        public void puanEkle(int eklncPuan)
        {
            this.puan += eklncPuan;
        }
        public void sureEkle(int eklnckSure)
        {
            this.oyunSuresi += eklnckSure;
        }



    }
}
