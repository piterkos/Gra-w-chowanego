using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gra_w_chowanego
{
    public partial class Form1 : Form
    {
        Lokal ObecnaLokacja;
        int LiczbaRuchow;

        PomieszczenieZdrzwiami salon;
        PomieszczenieZdrzwiami kuchnia;
        Pomieszczenie jadalnia;

        ZewnatrzZdrzwiami podworkoPrzedDomem;
        ZewnatrzZdrzwiami podworkoZaDomem;
        ZewnatrzZkryjowka ogrod;

        Pomieszczenie schody;
        PomieszczenieZkryjowka korytarz;
        PomieszczenieZkryjowka duzaSypialnia;
        PomieszczenieZkryjowka drugaSypialnia;
        PomieszczenieZkryjowka lazienka;

        ZewnatrzZkryjowka drogaDojazdowa;
        //Lokal[] listaWszystkichLokali;

        Przeciwnik przeciwnik;
        
        public Form1()
        {
            InitializeComponent();
            StworzObjekty();   
        }

        public void StworzObjekty()
        {
            // inicjalizacja obiektów - pomieszczeń

            salon = new PomieszczenieZdrzwiami("Salon", "dębowe drzwi z mosiężną klamką", "antyczny dywan", "pod dywanem");
            kuchnia = new PomieszczenieZdrzwiami("Kuchnia", "drzwi zasuwane", "nierdzewne stalowe sztućce", "za lodówką");
            jadalnia = new Pomieszczenie("Jadalnia", "kryształowy żyrandol");

            podworkoPrzedDomem = new ZewnatrzZdrzwiami("Podwórko przed domem", false, "dębowe drzwi z mosiężną klamką", "za budą");
            podworkoZaDomem = new ZewnatrzZdrzwiami("Podwórko za domem", true, "rozsuwane drzwi", "na drzewie");
            ogrod = new ZewnatrzZkryjowka("Ogród", false, "szopa");

            schody = new Pomieszczenie("Schody", "drewniana poręcz");
            korytarz = new PomieszczenieZkryjowka("Korytarz", "obrazek z psem", "szafa ścienna");
            duzaSypialnia = new PomieszczenieZkryjowka("Duża sypialnia", "duże łóżko", "pod łóżkiem");
            drugaSypialnia = new PomieszczenieZkryjowka("Druga Sypialnia", "małe łóżko", "za wielką donicą");
            lazienka = new PomieszczenieZkryjowka("Łazienka", "umywalka i toaleta", "pod prysznicem");

            drogaDojazdowa = new ZewnatrzZkryjowka("Droga dojazdowa", true, "garaż");

            // ustawiamy dla każdego pomieszczenia, pomieszczenia sąsiednie

            salon.Wyjscia = new Lokal[] { jadalnia, schody };
            jadalnia.Wyjscia = new Lokal[] { salon, kuchnia, schody };
            kuchnia.Wyjscia = new Lokal[] { jadalnia };

            podworkoPrzedDomem.Wyjscia = new Lokal[] {  ogrod, podworkoZaDomem,drogaDojazdowa };
            podworkoZaDomem.Wyjscia = new Lokal[] { podworkoPrzedDomem, ogrod, drogaDojazdowa };
            ogrod.Wyjscia = new Lokal[] { podworkoZaDomem, podworkoPrzedDomem };

            korytarz.Wyjscia = new Lokal[] { schody, duzaSypialnia, drugaSypialnia, lazienka };
            drogaDojazdowa.Wyjscia = new Lokal[] { podworkoPrzedDomem, podworkoZaDomem };
            lazienka.Wyjscia = new Lokal[] { korytarz };
            duzaSypialnia.Wyjscia = new Lokal[] { korytarz };
            drugaSypialnia.Wyjscia = new Lokal[] { korytarz };
            schody.Wyjscia = new Lokal[] { korytarz, salon };
            
            
            // ustawienie referencji do zmiany obiektu w momencie przejścia przez drzwi

            salon.PomieszczenieZaDrzwiamiWejsciowymi = podworkoPrzedDomem;
            podworkoPrzedDomem.PomieszczenieZaDrzwiamiWejsciowymi = salon;

            kuchnia.PomieszczenieZaDrzwiamiWejsciowymi = podworkoZaDomem;
            podworkoZaDomem.PomieszczenieZaDrzwiamiWejsciowymi = kuchnia;                       

            przeciwnik = new Przeciwnik(ogrod);
            /*
            listaWszystkichLokali = new Lokal[12];

            listaWszystkichLokali[0] = salon;
            listaWszystkichLokali[1] = jadalnia;
            listaWszystkichLokali[2] = kuchnia;
            listaWszystkichLokali[3] = podworkoPrzedDomem;
            listaWszystkichLokali[4] = podworkoZaDomem;
            listaWszystkichLokali[5] = ogrod;
            listaWszystkichLokali[6] = korytarz;
            listaWszystkichLokali[7] = drogaDojazdowa;
            listaWszystkichLokali[8] = lazienka;
            listaWszystkichLokali[9] = duzaSypialnia;
            listaWszystkichLokali[10] = drugaSypialnia;
            listaWszystkichLokali[11] = schody;
            */
        }
        void Przejdz(Lokal przechodzeDo)
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
            Odswiez();
        }

        private void IdzTutaj_btn_Click(object sender, EventArgs e)
        {
            Przejdz(ObecnaLokacja.Wyjscia[Wyjscia_cbox.SelectedIndex]);
            Odswiez();           
        }

        private void PrzejdzPrzezDrzwi_btn_Click(object sender, EventArgs e)
        {
            if (ObecnaLokacja is IPosiadaDrzwiZewnetrzne)
            {
                // aby mieć dostęp do lokacj drzwi trzeba rzutować w dół

                IPosiadaDrzwiZewnetrzne zaDrzwiami = ObecnaLokacja as IPosiadaDrzwiZewnetrzne;
                Przejdz(zaDrzwiami.PomieszczenieZaDrzwiamiWejsciowymi);
            }
            
        }

        private void KryjSie_btn_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i < 11; i++)
            {
                Opis_tb.Text = i.ToString();
                Application.DoEvents();
                przeciwnik.PrzesunSie();
                System.Threading.Thread.Sleep(10);
            }
            Opis_tb.Text = "Gotowy czy nie? --- Nadchodzę !";
            Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
            Przejdz(salon);
            Wyjscia_cbox.Visible = true;
            IdzTutaj_btn.Visible = true;
            
            Odswiez();
        }
        void Odswiez()
        {
            string txtSprawdz;
            IKryjowka obecnaLokacja;

            if (ObecnaLokacja is IKryjowka)
            {
                obecnaLokacja = ObecnaLokacja as IKryjowka;
                txtSprawdz = "Sprawdź " + obecnaLokacja.MiejsceDoUkrycia;
                Sprawdz_btn.Text = txtSprawdz;
                Sprawdz_btn.Visible = true;                
            }
            else
            {
                Sprawdz_btn.Visible = false;
            }
        }

        private void Sprawdz_btn_Click(object sender, EventArgs e)
        {

            if (przeciwnik.Sprawdz(ObecnaLokacja))
            {                
                Opis_tb.Text = "Do znalezienia ukrywacza potrzebowałeś " + LiczbaRuchow + " ruchów.";
                ResetGame();
            }
            else
            {
                Opis_tb.Text += "\n \n Nie ma tutaj nikogo!";
                Odswiez();
                LiczbaRuchow++;
            }
        }
        void ResetGame()
        {
            Wyjscia_cbox.Visible = false;
            IdzTutaj_btn.Visible = false;
            Sprawdz_btn.Visible = false;
            ObecnaLokacja = jadalnia;
            LiczbaRuchow = 0;
            
        }
    }
}
