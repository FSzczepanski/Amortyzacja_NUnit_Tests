using Amortyzacja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmortyzacjaAplikacja
{
    public partial class Amortyzacja : Form
    {
        public Amortyzacja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SrodekTrwały srodektrwaly = new SrodekTrwały();
            List<double[]> odpisyMiesieczne = new List<double[]>();
            try
            {

                warningLb.Text = "";
                listViewWynik.Clear();


                if (checkBoxLiniowa.Checked && checkBoxDegresywna.Checked)
                {
                     warningLb.Text = "tylko 1 checkbox może być zaznaczony";
                  
                }
                else if (checkBoxLiniowa.Checked)
                {
                    
                    ListViewItem miesiace = new ListViewItem("miesiąc");
                    ListViewItem wartosci = new ListViewItem("wartość");
                    ListViewItem odpisy = new ListViewItem("odpis");
                    listViewWynik.Items.AddRange(new ListViewItem[] { miesiace, wartosci, odpisy });
                    odpisyMiesieczne = srodektrwaly.amortyzacjaLiniowa(double.Parse(wartoscPoczatkowaTV.Text), double.Parse(stawkaAmortyzacjiTV.Text));
                }
                else if (checkBoxDegresywna.Checked)
                {
                    ListViewItem miesiace = new ListViewItem("miesiąc");
                    ListViewItem wartosci = new ListViewItem("wartość");
                    ListViewItem odpisy = new ListViewItem("odpis");
                    listViewWynik.Items.AddRange(new ListViewItem[] { miesiace, wartosci, odpisy });
                    odpisyMiesieczne = srodektrwaly.amortyzacjaDegresywna(double.Parse(wartoscPoczatkowaTV.Text), double.Parse(stawkaAmortyzacjiTV.Text), double.Parse(wspPodwyzszajacyTV.Text));
                }
                
                else
                {
                    warningLb.Text = "zaznacz odpowiedni checkbox";
                }
            

                foreach (var odpis in odpisyMiesieczne)
                {
                    ListViewItem miesiace1 = new ListViewItem(odpis[0].ToString());
                    ListViewItem wartosci1 = new ListViewItem(odpis[1].ToString());
                    ListViewItem odpisy1 = new ListViewItem(odpis[2].ToString());

                    listViewWynik.Items.AddRange(new ListViewItem[] { miesiace1, wartosci1, odpisy1 });
                }
            
                }
            catch (Exception ex)
            {
                warningLb.Text = ex.Message;
            }

            

        }
    }
}
