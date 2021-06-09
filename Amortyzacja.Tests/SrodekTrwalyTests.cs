using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using Amortyzacja;

namespace Amortyzacja.Tests
{

    [TestFixture]
    public class SrodekTrwalyTests
    {
        SrodekTrwały srodekTrwaly = null;

        [OneTimeSetUp]
        public void setUp()
        {
            srodekTrwaly = new SrodekTrwały();

        }

        [OneTimeTearDown] 
        public void tearDown()
        {
            srodekTrwaly = new SrodekTrwały();
            srodekTrwaly = null;
        }


        [TestCase(100000, 0.1, 10000)]
        [TestCase(230000, 0.3, 69000)]
        public void amortyzacjaLiniowa_Calculated(double wartoscPoczatkowa, double stawkaAmortyzacji, double wartoscOdniesienia)

        {
            List<double[]> odpisyMiesieczne = new List<double[]>();

            odpisyMiesieczne = srodekTrwaly.amortyzacjaLiniowa(wartoscPoczatkowa, stawkaAmortyzacji);

            Assert.AreEqual(Math.Round(odpisyMiesieczne[1][2]), Math.Round(wartoscOdniesienia, 6));

        }


        [TestCase(100000, 0.1, 10)]
        [TestCase(230000, 0.3, 3)]
        public void amortyzacjaLiniowa_Okresy_Calculated(double wartoscPoczatkowa, double stawkaAmortyzacji, double liczbaOkresow)

        {
            List<double[]> odpisyMiesieczne = new List<double[]>();

            odpisyMiesieczne = srodekTrwaly.amortyzacjaLiniowa(wartoscPoczatkowa, stawkaAmortyzacji);

            int size = odpisyMiesieczne.Count();

            Assert.AreEqual(size-1, liczbaOkresow);

        }

        [Test]
        public void amortyzacjaLiniowa_wartoscPoczatkowa_rownaZero_Calculated()
        {

            Assert.Throws(Is.TypeOf<ArgumentException>()
               .And.Message.EqualTo("wartosc nie może być równa 0"),
               delegate
               {
                   srodekTrwaly.amortyzacjaLiniowa(0, 0.1);
               });

        }

        [Test]
        public void amortyzacjaLiniowa_stawkaAmortyzacji_rownaZero()
        {

            Assert.Throws(Is.TypeOf<ArgumentException>()
               .And.Message.EqualTo("wartosc nie może być równa 0"),
               delegate
               {
                   srodekTrwaly.amortyzacjaLiniowa(10000, 0);
               });
           
        }

        [Test]
        public void amortyzacjaLiniowa_stawkaAmortyzacji_mniejsza_od_zera()
        {

            Assert.Throws(Is.TypeOf<ArgumentException>()
               .And.Message.EqualTo("stawka amortyzacji nie moze byc ujemna"),
               delegate
               {
                   srodekTrwaly.amortyzacjaLiniowa(10000, -2);
               });

        }

        [Test]
        public void amortyzacjaLiniowa_wartosc_mniejsza_od_zera()
        {

            Assert.Throws(Is.TypeOf<ArgumentException>()
               .And.Message.EqualTo("wartosc nie moze byc ujemna"),
               delegate
               {
                   srodekTrwaly.amortyzacjaLiniowa(-10000, 2);
               });

        }




        [TestCase(100000, 0.1,2)]
        [TestCase(230000, 0.3,2)]
        public void amortyzacjaDegresywna_Suma_Calculated(double wartoscPoczatkowa, double stawkaAmortyzacji, double wspolczynnikPodwyzszajacy)

        {
            List<double[]> odpisyMiesieczne = new List<double[]>();

            odpisyMiesieczne = srodekTrwaly.amortyzacjaDegresywna(wartoscPoczatkowa, stawkaAmortyzacji, wspolczynnikPodwyzszajacy);

            double calkowitaWartoscOdpisow = 0;
            foreach(var item in odpisyMiesieczne)
            {
                calkowitaWartoscOdpisow += item[2];
            }

            Assert.AreEqual(Math.Round(calkowitaWartoscOdpisow), Math.Round(wartoscPoczatkowa, 6));
        }


        [TestCase(100000, 0.1,2, 10)]
        [TestCase(230000, 0.3,3, 3)]
        public void amortyzacjaDegresywna_Okresy_Calculated(double wartoscPoczatkowa, double stawkaAmortyzacji,double wspolczynnikPodwyzszajacy, double liczbaOkresow)

        {
            List<double[]> odpisyMiesieczne = new List<double[]>();

            odpisyMiesieczne = srodekTrwaly.amortyzacjaDegresywna(wartoscPoczatkowa, stawkaAmortyzacji, wspolczynnikPodwyzszajacy);

            int size = odpisyMiesieczne.Count();
            Assert.AreEqual(size, liczbaOkresow);

        }

        [Test]
        public void amortyzacjaDegresywna_wartoscPoczatkowa_rownaZero_Calculated()
        {

            Assert.Throws(Is.TypeOf<ArgumentException>()
               .And.Message.EqualTo("wartosc nie może być równa 0"),
               delegate
               {
                   srodekTrwaly.amortyzacjaDegresywna(0, 0.1, 2);
               });

        }



        [Test]
        public void amortyzacjaDegresywna_stawkaAmortyzacji_rownaZero_Calculated()
        {

            Assert.Throws(Is.TypeOf<ArgumentException>()
               .And.Message.EqualTo("wartosc nie może być równa 0"),
               delegate
               {
                   srodekTrwaly.amortyzacjaDegresywna(10000, 0,2);
               });

        }

        [Test]
        public void amortyzacjaDegresywna_wartosc_mniejsza_od_zera()
        {

            Assert.Throws(Is.TypeOf<ArgumentException>()
               .And.Message.EqualTo("wartosc nie moze byc ujemna"),
               delegate
               {
                   srodekTrwaly.amortyzacjaDegresywna(-10000, 0.2,2);
               });

        }

        [Test]
        public void amortyzacjaDegresywna_stawka_mniejsza_od_zera()
        {

            Assert.Throws(Is.TypeOf<ArgumentException>()
               .And.Message.EqualTo("stawka amortyzacji nie moze byc ujemna"),
               delegate
               {
                   srodekTrwaly.amortyzacjaDegresywna(10000, -0.2, 2);
               });

        }

        [Test]
        public void amortyzacjaDegresywna_wsp_podwyzszajacy_mniejszy_od_zera()
        {

            Assert.Throws(Is.TypeOf<ArgumentException>()
               .And.Message.EqualTo("wspolczynnikPodwyzszajacy nie moze byc ujemny"),
               delegate
               {
                   srodekTrwaly.amortyzacjaDegresywna(10000, 0.2, -2);
               });

        }
    }
}
