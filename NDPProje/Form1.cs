using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        oyun oyn = new oyun();

        private void Form1_Load(object sender, EventArgs e)
        {
           
            YeniAtik();

            AtikKutusu oAK = new AtikKutusu( "organik", 700, 0);
            AtikKutusu kAK = new AtikKutusu( "kagit", 1200, 1000);
            AtikKutusu mAK = new AtikKutusu( "metal", 2300, 800);
            AtikKutusu cAK = new AtikKutusu( "cam", 2200, 600);

            lbCamAtik.DataSource = cAK.Atiklar;
            lbMetalAtik.DataSource = mAK.Atiklar;
            lbOrganikAtik.DataSource = oAK.Atiklar;
            lbKagitAtik.DataSource = kAK.Atiklar;

            camAtikKutusuBS.DataSource = cAK;
            kagitAtikKutusuBS.DataSource = kAK;
            metalAtikKutusuBS.DataSource = mAK;
            organikAtikKutusuBS.DataSource = oAK;
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }
        private void YeniAtik()
        {

            //lbKagitAtik.DataSource = a;
            Atik atik = new Atik();
            atikDataBindingSource.DataSource = atik;
            pbAtikResmi.Image = atik.Image;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (oyn.oyunSuresi >= 0)
            {
                int sayac = oyn.oyunSuresi--;
                lbSure.Text = sayac.ToString();
            }
            else
            {
                timer1.Enabled = false;
            }
        }


        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            YeniAtik();
            oyn.oyunSuresi = 60;
            timer1.Interval = 1000;
            timer1.Enabled = true;

        }

        private void btnBosaltCam_Click(object sender, EventArgs e)
        {
            AtikKutusu ak = (AtikKutusu)camAtikKutusuBS.DataSource;
            if (ak.Bosalt())
            {
                progCam.Value = 0;
                oyn.puan += ak.BosaltmaPuani;
                oyn.oyunSuresi += 3;
            }
        }

        private void btnBosaltMetal_Click(object sender, EventArgs e)
        {
            AtikKutusu ak = (AtikKutusu)metalAtikKutusuBS.DataSource;
            if (ak.Bosalt())
            {
                progMetal.Value = 0;
                oyn.puan += ak.BosaltmaPuani;
                oyn.oyunSuresi += 3;
            }
        }

        private void btnBosaltOrganik_Click(object sender, EventArgs e)
        {
            AtikKutusu ak = (AtikKutusu)organikAtikKutusuBS.DataSource; ak.Bosalt();
            if (ak.Bosalt())
            {
                progOrganik.Value = 0;
                oyn.puan += ak.BosaltmaPuani;
                oyn.oyunSuresi += 3;
            }
        }

        private void btnBosaltKagit_Click(object sender, EventArgs e)
        {
            AtikKutusu ak = (AtikKutusu)kagitAtikKutusuBS.DataSource; ak.Bosalt();

            if (ak.Bosalt())
            {
                progKagit.Value = 0;
                oyn.puan += ak.BosaltmaPuani;
                oyn.oyunSuresi += 3;
            }
        }
        //////////////////////
        ///////////////////////
        ////////////////////////
        private void btnAtOrganik_Click_1(object sender, EventArgs e)
        {
            Atik a = (Atik)atikDataBindingSource.DataSource;
            AtikKutusu ak = (AtikKutusu)organikAtikKutusuBS.DataSource;
            if (a.tur == ak.Tur)
            {             
                ak.Ekle(a);
                oyn.puan += a.Hacim;
                lbPuan.Text = oyn.puan.ToString();
                if (Convert.ToInt16(100 * ak.DolulukOrani) >= progMetal.Maximum)
                {
                    MessageBox.Show("ATIK KUTUSU TAŞTI!!! KAYBETTİN...", "bozgun");
                    btnYeniOyun.PerformClick();
                }
                progOrganik.Value = Convert.ToInt16(100 * ak.DolulukOrani);
                
                YeniAtik();

            }

        }

        private void btnAtKagit_Click_1(object sender, EventArgs e)
        {

            Atik a = (Atik)atikDataBindingSource.DataSource;
            AtikKutusu ak = (AtikKutusu)kagitAtikKutusuBS.DataSource;
            if (a.tur == ak.Tur)
            {
                
                ak.Ekle(a);
                oyn.puan += a.Hacim;
                lbPuan.Text = oyn.puan.ToString();
                if (Convert.ToInt16(100 * ak.DolulukOrani) >= progMetal.Maximum)
                {
                    MessageBox.Show("ATIK KUTUSU TAŞTI!!! KAYBETTİN...");
                    btnYeniOyun.PerformClick();
                }
                progKagit.Value = Convert.ToInt16(100 * ak.DolulukOrani);
                
                YeniAtik();
            }

        }

        private void btnAtCam_Click(object sender, EventArgs e)
        {
            Atik a = (Atik)atikDataBindingSource.DataSource;
            AtikKutusu ak = (AtikKutusu)camAtikKutusuBS.DataSource;
            if (a.tur == ak.Tur)
            { 
                ak.Ekle(a);
                oyn.puan += a.Hacim;
                lbPuan.Text = oyn.puan.ToString();
                if (Convert.ToInt16(100 * ak.DolulukOrani) >= progMetal.Maximum)
                {
                    MessageBox.Show("ATIK KUTUSU TAŞTI!!! KAYBETTİN...");
                    btnYeniOyun.PerformClick();
                }
                progCam.Value = Convert.ToInt16(100 * ak.DolulukOrani);
                
                YeniAtik();
                testtb.Text = ak.DolulukOrani.ToString();
            }

        }

        private void btnAtMetal_Click_1(object sender, EventArgs e)
        {

            Atik a = (Atik)atikDataBindingSource.DataSource;
            AtikKutusu ak = (AtikKutusu)metalAtikKutusuBS.DataSource;
            if (a.tur == ak.Tur)
            {
                
                ak.Ekle(a);
                oyn.puan += a.Hacim;
                lbPuan.Text = oyn.puan.ToString();
                if (Convert.ToInt16(100 * ak.DolulukOrani) >= progMetal.Maximum)
                {
                    MessageBox.Show("ATIK KUTUSU TAŞTI!!! KAYBETTİN...");
                    btnYeniOyun.PerformClick();
                }
                progMetal.Value = Convert.ToInt16(100 * ak.DolulukOrani);
                

                lbPuan.Text = oyn.puan.ToString();

                YeniAtik();
            }

        }
    }
}
