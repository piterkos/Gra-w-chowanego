using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mieszkanie_s._338
{
    public partial class Form1 : Form
    {
        Lokacja ObecnaLokacja;

        LokacjaWewnetrznazDrzwiami salon;
        LokacjaWewnetrznazDrzwiami kuchnia;
        Pomieszczenie jadalnia;

        LokacjaZewnetrznaZdrzwiami podworkoPrzedDomem;
        LokacjaZewnetrznaZdrzwiami podworkoZaDomem;
        Zewnatrz ogrod;


        public Form1()
        {
            InitializeComponent();
            StworzObjekty();            
            Przejdz(ogrod);
        }

        public void StworzObjekty()
        {
            // inicjalizacja obiektów - pomieszczeń

            salon = new LokacjaWewnetrznazDrzwiami("Salon", "dębowe drzwi z mosiężną klamką", "antyczny dywan");
            kuchnia = new LokacjaWewnetrznazDrzwiami("Kuchnia", "drzwi zasuwane", "nierdzewne stalowe sztućce");
            jadalnia = new Pomieszczenie("Jadalnia", "kryształowy żyrandol");

            podworkoPrzedDomem = new LokacjaZewnetrznaZdrzwiami("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką");
            podworkoZaDomem = new LokacjaZewnetrznaZdrzwiami("Podwórko za domem", true, "rozsuwane drzwi");
            ogrod = new Zewnatrz("Ogród", false);

            // ustawiamy dla każdego pomieszczenia, pomieszczenia sąsiednie

            salon.Wyjscia = new Lokacja[] { jadalnia };
            jadalnia.Wyjscia = new Lokacja[] { salon, kuchnia };
            kuchnia.Wyjscia = new Lokacja[] { jadalnia };

            podworkoPrzedDomem.Wyjscia = new Lokacja[] {  ogrod, podworkoZaDomem };
            podworkoZaDomem.Wyjscia = new Lokacja[] { podworkoPrzedDomem, ogrod };
            ogrod.Wyjscia = new Lokacja[] { podworkoZaDomem, podworkoPrzedDomem };

            salon.LokacjaDrzwi = podworkoPrzedDomem;
            podworkoPrzedDomem.LokacjaDrzwi = salon;

            kuchnia.LokacjaDrzwi = podworkoZaDomem;
            podworkoZaDomem.LokacjaDrzwi = kuchnia;
        }
        void Przejdz(Lokacja przechodzeDo)
        {
            this.ObecnaLokacja = przechodzeDo;
            Wyjscia_cbox.Items.Clear();
            for (int i = 0; i < ObecnaLokacja.Wyjscia.Length; i++)
            {
                Wyjscia_cbox.Items.Add(ObecnaLokacja.Wyjscia[i].Nazwa);
            }
            Wyjscia_cbox.SelectedIndex = 0;
            Opis_tb.Text = ObecnaLokacja.Opis;
            if (ObecnaLokacja is IPosiadaDrzwiZewnetrzne)
            {
                PrzejdzPrzezDrzwi_btn.Visible = true;                
            }
            else
            {
                PrzejdzPrzezDrzwi_btn.Visible = false;                
            }

        }

        private void IdzTutaj_btn_Click(object sender, EventArgs e)
        {
            Przejdz(ObecnaLokacja.Wyjscia[Wyjscia_cbox.SelectedIndex]);
        }

        private void PrzejdzPrzezDrzwi_btn_Click(object sender, EventArgs e)
        {
            if (ObecnaLokacja is IPosiadaDrzwiZewnetrzne)
            {
                // aby mieć dostęp do lokacjdrzwi trzeba rzutować w dół

                IPosiadaDrzwiZewnetrzne zaDrzwiami = ObecnaLokacja as IPosiadaDrzwiZewnetrzne;
                Przejdz(zaDrzwiami.LokacjaDrzwi);
            }
        }
    }
}
