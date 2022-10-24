using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje
{
    public interface IAtikKutusu : IDolabilen
    {
        /// <summary>
        /// Atık kutusu boşaltıldığında oyun puanına kaç puan ekleneceğini döndürür.
        /// </summary>
        int BosaltmaPuani { get; }
        /// <summary>
        /// Atık kutusunda gönderilen atığı alacak kadar boş yer varsa atığı kutuya ekler.
        /// </summary>
        /// <param name="atik">Eklenecek Atık</param>
        /// <returns>Atığın kutuya eklenip eklenmediğini döndürür.</returns>
        bool Ekle(Atik atik);

        /// <summary>
        /// Atık kutusunun doluluk oranı %75'in üstündeyse atık kutusunu boşaltır.
        /// </summary>
        /// <returns>Atık kutusunun boşaltılıp boşaltılmadığını döndürür.</returns>
        bool Bosalt();
    }
    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; set; }
        float DolulukOrani { get; set; }
    }
    class AtikKutusu : IAtikKutusu
    {
        public string Tur { get; set; }

        public int BosaltmaPuani { get; }
        public BindingList<string> Atiklar { get; set; }
        public int Kapasite { get; set; }
        public int DoluHacim { get; set; }
        public float DolulukOrani { get; set; }

        public AtikKutusu(string Tur,int Kapasite,int BosaltmaPuani)
        {
            this.DoluHacim = 0;
            this.Tur = Tur;
            this.Kapasite = Kapasite;
            this.Atiklar = new BindingList<string>();
            this.BosaltmaPuani = BosaltmaPuani;
        }

        public bool Bosalt()
        {

            if (this.DolulukOrani >= 0.75)
            {
                this.Atiklar.Clear();
                this.DoluHacim = 0;
               // this.DolulukOrani = 0f;
                return true;

            }
            return false;
        }

        public bool Ekle(Atik atik)
        {
            if (this.Tur == atik.tur &&this.Kapasite-atik.Hacim >=0)
            {
                this.DoluHacim += atik.Hacim;
                Atiklar.Add(atik.isim + "("+ atik.Hacim.ToString()+ ")");
                this.DolulukOrani = this.DoluHacim / (float)this.Kapasite;
                return true;
            }
            return false;
        }
    }
}
