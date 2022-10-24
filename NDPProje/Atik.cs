using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProje
{
    public interface IAtik
    {   
        int Hacim { get; }
        Image Image { get; }
    }
    public class Atik : IAtik
    {
        public int Hacim { get; }
        public Image Image { get; }
        public int AtikID { get; set; }
        public string tur { get; set; }
        public string isim { get; set; }
        public Atik() 
        {
            Random rand = new Random();
            AtikID = rand.Next(1 , 9);
            switch(AtikID)
            {
                case 1:
                    Hacim = 600; 
                    this.Image = Image.FromFile("camsise.jpg");
                    this.tur = "cam"; this.isim = "Cam Şİşe";
                    break;
                case 2:

                    Hacim = 250; this.isim = "bardak";
                    this.Image = Image.FromFile("bardak.png"); this.tur = "cam";
                    break;
                case 3:
                    Hacim = 250; this.isim = "gazete";
                    this.Image = Image.FromFile("gazete.jpg"); this.tur = "kagit";
                    break;
                case 4:
                    Hacim = 200; this.isim = "dergi";
                    this.Image = Image.FromFile("dergi.jpg"); this.tur = "kagit";
                    break;
                case 5:
                    Hacim = 150; this.isim = "domates";
                    this.Image = Image.FromFile("domates.jpg"); this.tur = "organik";
                    break;
                case 6:
                    Hacim = 120; this.isim = "salatalık";
                    this.Image = Image.FromFile("salatalik.jpg"); this.tur = "organik";
                    break;
                case 7:
                    Hacim = 350; this.isim = "kutu kola ";
                    this.Image = Image.FromFile("kolakutusu.jpg"); this.tur = "metal";
                    break;
                case 8:
                    Hacim = 550; this.isim = "salça";
                    this.Image = Image.FromFile("salca.png"); this.tur = "metal";
                    break;
            }
        }
    }
}
