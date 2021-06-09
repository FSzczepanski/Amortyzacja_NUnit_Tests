using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amortyzacja
{
    public class SrodekTrwały
    {
        public List<double[]> amortyzacjaLiniowa(double wartoscPoczatkowa, double stawkaAmortyzacji)
        {
            List<double[]> odpisyMiesieczne = new List<double[]>();


            double odpis;
            double miesiac = 0;

            if (wartoscPoczatkowa < 0)
            {
                throw new ArgumentException("wartosc nie moze byc ujemna");
            }
            else if (stawkaAmortyzacji == 0 || wartoscPoczatkowa ==0)
            {
                throw new ArgumentException("wartosc nie może być równa 0");
            }
            else if (stawkaAmortyzacji < 0)
            {
                throw new ArgumentException("stawka amortyzacji nie moze byc ujemna");
            }
            else
            {
                odpis = wartoscPoczatkowa * stawkaAmortyzacji;



                while (wartoscPoczatkowa >= 0)
                {
                    double[] dane = { miesiac, wartoscPoczatkowa, odpis };
                    odpisyMiesieczne.Add(dane);
                    wartoscPoczatkowa -= odpis;
                    miesiac++;
                }
            }

            return odpisyMiesieczne;

        }

        public List<double[]> amortyzacjaDegresywna(double wartoscPoczatkowa, double stawkaAmortyzacji, double wspolczynnikPodwyzszajacy)
        {
            List<double[]> odpisyMiesieczne = new List<double[]>();


            double odpis;
            double odpisPodwyzszony;
            double miesiac = 0;

            if (wartoscPoczatkowa < 0)
            {
                throw new ArgumentException("wartosc nie moze byc ujemna");

            }
            else if (stawkaAmortyzacji == 0 || wartoscPoczatkowa == 0 || wspolczynnikPodwyzszajacy == 0)
            {
                throw new ArgumentException("wartosc nie może być równa 0");
            }
            else if (stawkaAmortyzacji < 0)
            {
                throw new ArgumentException("stawka amortyzacji nie moze byc ujemna");
            }
            else if (wspolczynnikPodwyzszajacy < 0)
            {
                throw new ArgumentException("wspolczynnikPodwyzszajacy nie moze byc ujemny");
            }

            odpis = wartoscPoczatkowa * stawkaAmortyzacji;

                double[] danePierwszaIteracja = { miesiac, wartoscPoczatkowa, 0 };
                odpisyMiesieczne.Add(danePierwszaIteracja);
                miesiac++;

                while (wartoscPoczatkowa > odpis)
                {
                    odpisPodwyzszony = wartoscPoczatkowa * stawkaAmortyzacji * wspolczynnikPodwyzszajacy;

                    if (odpisPodwyzszony > odpis)
                    {
                        wartoscPoczatkowa -= odpisPodwyzszony;
                        double[] dane = { miesiac, wartoscPoczatkowa, odpisPodwyzszony };
                        odpisyMiesieczne.Add(dane);
                        miesiac++;
                    }
                    else
                    {
                        wartoscPoczatkowa -= odpis;
                        double[] dane = { miesiac, wartoscPoczatkowa, odpis };
                        odpisyMiesieczne.Add(dane);
                        miesiac++;
                    }
                }
                if (wartoscPoczatkowa > 0)
                {
                    wartoscPoczatkowa -= odpis;
                
                double[] dane1 = { miesiac, 0, wartoscPoczatkowa + odpis };
                
                    odpisyMiesieczne.Add(dane1);
                }
            

            return odpisyMiesieczne;

        }

    }
}
