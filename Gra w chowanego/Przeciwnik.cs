using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra_w_chowanego
{
    class Przeciwnik
    {
        Lokal mojaLokalizacja;
        Random losuj;

        public Przeciwnik( Lokal _mojaLokalizacja)
        {
            this.mojaLokalizacja = _mojaLokalizacja;
                                
        }
        public void PrzesunSie()
        {
            losuj = new Random();
            //System.Windows.Forms.MessageBox.Show(mojaLokalizacja.Opis);
            if (mojaLokalizacja is IPosiadaDrzwiZewnetrzne)
            {
                IPosiadaDrzwiZewnetrzne LokacjaZdrzwiami = mojaLokalizacja as IPosiadaDrzwiZewnetrzne;
                if (losuj.Next(1, 2) == 1)
                {
                   // System.Windows.Forms.MessageBox.Show("posiada drzwi i jest wylosowana 1");
                    this.mojaLokalizacja = LokacjaZdrzwiami.PomieszczenieZaDrzwiamiWejsciowymi;
                }

            }
            //System.Windows.Forms.MessageBox.Show(losuj + mojaLokalizacja.Nazwa);
            bool czyJestKryjowka = true;
                while (czyJestKryjowka)
                {
               // System.Windows.Forms.MessageBox.Show("Test");
                mojaLokalizacja = mojaLokalizacja.Wyjscia[losuj.Next(0, mojaLokalizacja.Wyjscia.Length)];
                    if (mojaLokalizacja is IKryjowka)
                    {
                        czyJestKryjowka = false;
                    }

                }
            
        }
        public bool Sprawdz(Lokal lokacjaDosprawdzenia)
        {
            if (lokacjaDosprawdzenia == mojaLokalizacja)
            {
                return true;
            }
            else return false;
        }
    }
}
