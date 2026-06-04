using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafische_Automatoberflaeche
{
    public partial class Getraenkautomat : Form
    {
        // Getraenke Preis
        int guthaben = 0;
        int colap = 250;
        int fantap = 200;
        int colazerop = 200;
        int redbullp = 300;
        int wasserp = 100;
        int eisteep = 150;
        //Menge
        int colam = 10;
        int fantam = 10;
        int colazerom = 10;
        int redbullm = 10;
        int wasserm = 10;
        int eisteem = 10;
        int Rueckgeld =0;
        //Muenzenmenge 
        int M5euro = 10;
        int M10euro = 10;
        int M2euro = 10;
        int M1euro = 10;
        int M50cent = 10;
        int M20cent = 10;
        int M10cent = 10;
        int M5cent = 10;

        //Anzahl der Muenzen
        int anzahl5Euro = 0;
        int anzahl10Euro = 0;
        int anzahlMuenze2EUR = 0;
        int anzahlMuenze1EUR = 0;
        int anzahlMuenze50Cent = 0;
        int anzahlMuenze20Cent = 0;
        int anzahlMuenze10Cent = 0;
        int anzahlMuenze5Cent = 0;
        // Umsatz
        double Umsatzgeld = 0;
        // Geldwerfen
        double einwurf;

        public Getraenkautomat()
        {
            InitializeComponent();
        }

        private void Cola_Click(object sender, EventArgs e)
        {
            status.AppendText("\n\rIhr Getränk kostet: " + colap / 100.0 + "€");
            if(colam == 0)
            {
                status.AppendText("\n\rCola ist nicht mehr vorhanden, bitte ein anderes Getränk wählen!");
            }
            else
            {
                if (guthaben > 2000)
                {
                    status.AppendText("\n\rBitte werfen maximal 20 Euro in den Automat Danke!");                    
                }
                else if (guthaben < colap)
                {
                    status.AppendText("\n\rDas Geld reicht nicht für den kauf!");
                }
                else
                {
                    Rueckgeld = guthaben - colap;

                    if (GeldReicht() == true)
                    {
                        status.AppendText("\n\r Danke fuer den Kauf");
                        colam = colam - 1;
                        Geldrueckgabe(Rueckgeld);
                    }
                    else
                    {
                        status.AppendText("\r\n Der Kauf wurde abgebrochen"+ "\r\n kein Rückgeld vorhanden" + "\r\n Oder nur: " + colap/100f + "€ einwerfen");
                    }
                    if (Rueckgeld > 0)
                    {
                        status.AppendText("\n\r Ihr Rückgeld beträgt: " + Rueckgeld / 100.0 + " €");
                    }
                    guthaben = 0;
                }
                
            }
        }
        private bool GeldReicht()
        {
            int tempRueckgeld = Rueckgeld;
            anzahl10Euro = 0;
            anzahl5Euro = 0;
            anzahlMuenze2EUR = 0;
            anzahlMuenze1EUR = 0;
            anzahlMuenze50Cent = 0;
            anzahlMuenze20Cent = 0;
            anzahlMuenze10Cent = 0;
            anzahlMuenze5Cent = 0;
            if (tempRueckgeld>=1000)
            {
                anzahl10Euro = tempRueckgeld / 1000;
                if (anzahl10Euro<=M10euro)
                {
                    M10euro = M10euro - anzahl10Euro;
                }
                else
                {
                    anzahl10Euro = M10euro;
                    M10euro = 0;
                }
                tempRueckgeld = tempRueckgeld - anzahl10Euro * 1000;
            }
            if (tempRueckgeld>=500)
            {
                anzahl5Euro = tempRueckgeld / 500;
                if (anzahl5Euro<=M5euro)
                {
                    M5euro = M5euro - anzahl5Euro;
                }
                else
                {
                    anzahl5Euro = M5euro;
                    M5euro = 0;
                }
                tempRueckgeld = tempRueckgeld - anzahl5Euro * 500;
            }
            
            if (tempRueckgeld >= 200)
            {

                anzahlMuenze2EUR = tempRueckgeld / 200;
                if (anzahlMuenze2EUR <= M2euro)

                {

                    M2euro = M2euro - anzahlMuenze2EUR;

                }
                else
                {
                    anzahlMuenze2EUR = M2euro;
                    M2euro = 0;

                }
                //tempRueckgeld = tempRueckgeld % 200;
                tempRueckgeld = tempRueckgeld - anzahlMuenze2EUR * 200;


            }
            if (tempRueckgeld >= 100)
            {

                anzahlMuenze1EUR = tempRueckgeld / 100;
                if (anzahlMuenze1EUR <= M1euro)
                {
                    M1euro = M1euro - anzahlMuenze1EUR;
                }
                else
                {
                    anzahlMuenze1EUR = M1euro;
                    M1euro = 0;
                }
                //tempRueckgeld = tempRueckgeld % 100;
                tempRueckgeld = tempRueckgeld - anzahlMuenze1EUR * 100;
            }
            if (tempRueckgeld >= 50)
            {

                anzahlMuenze50Cent = tempRueckgeld / 50;
                if (anzahlMuenze50Cent <= M50cent)
                {
                    M50cent = M50cent - anzahlMuenze50Cent;
                }
                else
                {
                    anzahlMuenze50Cent = M50cent;
                    M50cent = 0;
                }
                //tempRueckgeld = tempRueckgeld % 50;
                tempRueckgeld = tempRueckgeld - anzahlMuenze50Cent * 50;
            }
            if (tempRueckgeld >= 20)
            {

                anzahlMuenze20Cent = tempRueckgeld / 20;
                if (anzahlMuenze20Cent <= M20cent)
                {
                    M20cent = M20cent - anzahlMuenze20Cent;
                }
                else
                {
                    anzahlMuenze20Cent = M20cent;
                    M20cent = 0;
                }
                //tempRueckgeld = tempRueckgeld % 20;
                tempRueckgeld = tempRueckgeld - anzahlMuenze20Cent * 20;
            }
            if (tempRueckgeld >= 10)
            {

                anzahlMuenze10Cent = tempRueckgeld / 10;
                if (anzahlMuenze10Cent <= M10cent)
                {
                    M10cent = M10cent - anzahlMuenze10Cent;
                }
                else
                {
                    anzahlMuenze10Cent = M10cent;
                    M10cent = 0;
                }
                //tempRueckgeld = tempRueckgeld % 10;
                tempRueckgeld = tempRueckgeld - anzahlMuenze10Cent * 10;
            }

            if (tempRueckgeld >= 5)
            {

                anzahlMuenze5Cent = tempRueckgeld / 5;
                if (anzahlMuenze5Cent <= M5cent)
                {
                    M5cent = M5cent - anzahlMuenze5Cent;
                }
                else
                {
                    anzahlMuenze5Cent = M5cent;
                    M5cent = 0;
                }
                //tempRueckgeld = tempRueckgeld % 5;
                tempRueckgeld = tempRueckgeld - anzahlMuenze5Cent * 5;
            }

            if (tempRueckgeld > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Enter_Click(object sender, EventArgs e)
        {
            EnterClickFunktion();
        }

        private void EnterClickFunktion()
        {
            try
            {
                einwurf = Convert.ToDouble(geldeingabe.Text);
                geldeingabe.Clear();

                if (einwurf != 20 && einwurf != 10 && einwurf != 5 && einwurf != 2 && einwurf != 1 && einwurf != 0.5 && einwurf != 0.2 && einwurf != 0.1 && einwurf != 0.05)
                {
                    status.AppendText("\n\rDas Geld ist nicht echt!");
                }
                else
                {
                    if (einwurf == 2)
                    {
                        M2euro = M2euro + 1;
                    }
                    else if (einwurf == 1)
                    {
                        M1euro = M1euro + 1;
                    }
                    if (einwurf == 0.5)
                    {
                        M50cent = M50cent + 1;
                    }
                    if (einwurf == 0.2)
                    {
                        M20cent = M20cent + 1;
                    }
                    if (einwurf == 0.1)
                    {
                        M10cent = M10cent + 1;
                    }
                    if (einwurf == 0.05)
                    {
                        M5cent = M5cent + 1;
                    }
                    guthaben = guthaben + (int)(einwurf * 100);

                    if (guthaben > 2000)
                    {
                        status.AppendText("\r\nBitte nur max 20 Euro einwerfen!");
                        status.AppendText("\r\nBitte nehmen Sie Ihr Geld zurück!");
                        guthaben = 0;
                    }

                    else
                    {
                        status.Text = "Ihr Guthaben beträgt " + guthaben / 100.0 + "€";

                    }
                }
            }
            catch (Exception ex)
            {
                if (einwurf == 0)
                {
                    status.AppendText("\r\n Sie sollten dafür Geld in der Maschine einwerfen");
                }
                else
                {
                    status.AppendText("\r\nBitte werfen Sie echtes Geld ein! ");
                }

                // status.AppendText("\r\nBitte geben Sie echtes Geld ein: " + ex.Message);
                //throw new Exception("Bist du blöd?");
            }
        }

        private void geldeingabe_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void geldeingabe_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Fanta_Click(object sender, EventArgs e)
        {
            status.AppendText("\n\rIhr Getränk kostet: " + fantap / 100.0 + "€");
            if (fantam == 0)
            {
                status.AppendText("\n\rFanta ist nicht mehr vorhanden, bitte ein anderes Getränk wählen!");
            }
            else
            {
                if (guthaben > 2000)
                {
                    status.AppendText("\n\rBitte werfen maximal 20 Euro in den Automat Danke!");
                }
                else if (guthaben < fantap)
                {
                    status.AppendText("\n\rDas Geld reicht nicht für den kauf!");
                }
                else
                {
                    Rueckgeld = guthaben - fantap;
                    if (GeldReicht() == true)
                    {
                        status.AppendText("\n\r Danke fuer den Kauf");
                        fantam = fantam - 1;
                    Geldrueckgabe(Rueckgeld);
                    }
                   
                    else
                    {
                        status.AppendText("\r\n Der Kauf wurde abgebrochen" + "\r\n kein Rückgeld vorhanden" + "\r\n Oder nur: " + fantap / 100f + "€ einwerfen");
                    }
                    if (Rueckgeld > 0)
                    {
                        status.AppendText("\n\r Ihr Rückgeld beträgt: " + Rueckgeld / 100.0 + "€");
                    }
                    guthaben = 0;
                }
                
            }
        }

        private void RedBull_Click(object sender, EventArgs e)
        {
            status.AppendText("\n\rIhr Getränk kostet: " + redbullp / 100.0 + "€");
            if (redbullm == 0)
            {
                status.AppendText("\n\rRedBull ist nicht mehr vorhanden, bitte ein anderes Getränk wählen!");
            }
            else
            {
                if (guthaben > 2000)
                {
                    status.AppendText("\n\rBitte werfen maximal 20 Euro in den Automat Danke!");
                }
                else if (guthaben < redbullp)
                {
                    status.AppendText("\n\rDas Geld reicht nicht für den kauf!");
                }
                else
                {
                    Rueckgeld = guthaben - redbullp;

                    if (GeldReicht() == true)
                    {
                        status.AppendText("\n\r Danke fuer den Kauf");
                        redbullm = redbullm - 1;
                    Geldrueckgabe(Rueckgeld);
                    }
                    else
                    {
                        status.AppendText("\r\n Der Kauf wurde abgebrochen" + "\r\n kein Rückgeld vorhanden" + "\r\n Oder nur: " + redbullp / 100f + "€ einwerfen");
                    }
                    if (Rueckgeld > 0)
                    {
                        status.AppendText("\n\r Ihr Rückgeld beträgt: " + Rueckgeld / 100.0 + "€");
                    }

                    guthaben = 0;
                }
                
            }
        }

        private void Cola_Zero_Click(object sender, EventArgs e)
        {
            status.AppendText("\n\rIhr Getränk kostet: " + colazerop / 100.0 + "€");
            if (colazerom == 0)
            {
                status.AppendText("\n\rCola Zero ist nicht mehr vorhanden, bitte ein anderes Getränk wählen!");
            }
            else
            {
                if (guthaben > 2000)
                {
                    status.AppendText("\n\rBitte werfen maximal 20 Euro in den Automat Danke!");
                }
                else if (guthaben < colazerop)
                {
                    status.AppendText("\n\rDas Geld reicht nicht für den kauf!");
                }
                else
                {
                    Rueckgeld = guthaben - colazerop;

                    if (GeldReicht() == true)
                    {
                        status.AppendText("\n\r Danke fuer den Kauf");
                        colazerom = colazerom - 1;
                    Geldrueckgabe(Rueckgeld);
                    }
                    else
                    {
                        status.AppendText("\r\n Der Kauf wurde abgebrochen" + "\r\n kein Rückgeld vorhanden" + "\r\n Oder nur: " + colazerop / 100f + "€ einwerfen");
                    }
                    if (Rueckgeld > 0)
                    {
                        status.AppendText("\n\r Ihr Rückgeld beträgt: " + Rueckgeld / 100.0 + "€");
                    }
                    guthaben = 0;
                }
               
            }
        }

        private void Eis_Tee_Click(object sender, EventArgs e)
        {
            status.AppendText("\n\rIhr Getränk kostet: " + eisteep / 100.0 + "€");
            if (eisteem == 0)
            {
                status.AppendText("\n\rEistee ist nicht mehr vorhanden, bitte ein anderes Getränk wählen!");
            }
            else
            {
                if (guthaben > 2000)
                {
                    status.AppendText("\n\rBitte werfen maximal 20 Euro in den Automat Danke!");
                }
                else if (guthaben < eisteep)
                {
                    status.AppendText("\n\rDas Geld reicht nicht für den kauf!");
                }
                else
                {
                    Rueckgeld = guthaben - eisteep;

                    if (GeldReicht() == true)
                    {
                        status.AppendText("\n\r Danke fuer den Kauf");
                        eisteem = eisteem - 1;
                    Geldrueckgabe(Rueckgeld);
                    }
                    else
                    {
                        status.AppendText("\r\n Der Kauf wurde abgebrochen" + "\r\n kein Rückgeld vorhanden" + "\r\n Oder nur: " + eisteep / 100f + "€ einwerfen");
                    }
                    if (Rueckgeld > 0)
                    {
                        status.AppendText("\n\r Ihr Rückgeld beträgt: " + Rueckgeld / 100.0 + "€");
                    }
                    guthaben = 0;
                }
               
            }
        }

        private void Wasser_Click(object sender, EventArgs e)
        {
            status.AppendText("\n\rIhr Getränk kostet: " + wasserp / 100.0 + "€");
            if (wasserm == 0)
            {
                status.AppendText("\n\rWasser ist nicht mehr vorhanden, bitte ein anderes Getränk wählen!");
            }
            else
            {
                if (guthaben > 2000)
                {
                    status.AppendText("\n\rBitte werfen maximal 20 Euro in den Automat Danke!");
                }
                else if (guthaben < wasserp)
                {
                    status.AppendText("\n\rDas Geld reicht nicht für den kauf!");
                }
                else
                {
                    Rueckgeld = guthaben - wasserp;

                    if (GeldReicht() == true)
                    {
                        status.AppendText("\n\r Danke fuer den Kauf");
                        wasserm = wasserm - 1;
                    Geldrueckgabe(Rueckgeld);
                    }
                   
                    else
                    {
                        status.AppendText("\r\n Der Kauf wurde abgebrochen" + "\r\n kein Rückgeld vorhanden" + "\r\n Oder nur: " + wasserp / 100f + "€ einwerfen");
                    }
                    if (Rueckgeld > 0)
                    {
                        status.AppendText("\n\r Ihr Rückgeld beträgt: " + Rueckgeld / 100.0 + "€");
                    }
                    guthaben = 0;
                }
                
            }
        }

        private void TX_FuenfzigCent(object sender, EventArgs e)
        {

        }

        private void TX_ZweiEuro(object sender, EventArgs e)
        {

        }

        private void TX_EinEuro(object sender, EventArgs e)
        {
            if (Rueckgeld >= 100)
            {
                Console.WriteLine("Sie bekommen " + Rueckgeld / 100 + " Mal 1 Euro  ");
                
                Rueckgeld = Rueckgeld / 100;
                Rueckgeld = Rueckgeld % 100;
            }
        }

        void Geldrueckgabe(int Rueckgeld)
        {

            // Rückgeld in Münzen/ 

            if (Rueckgeld > 0)
            {
                status.AppendText("\r\nBitte nehmen Sie ihr Rückgeld");
            }
            TxZehnEuro.Text = "0x 10 Euro";
            TxZehnEuro.Text = anzahl10Euro + "x 10 Euro";
            guthaben = 0;
            //if (Rueckgeld==0)                   // wenn Kein RÜckgeld gibt, dann werden alle Felder nicht mehr gezeigt 
            //{
            //TxZehnEuro.Clear();
            //}
            TxFuenfEuro.Text = "0x 5 Euro";
            TxFuenfEuro.Text = anzahl5Euro + "x 5 Euro";
            //if (Rueckgeld == 0)
            //{
            //    TxFuenfEuro.Clear();
            //}
            TXZweiEuro.Text = "0x 2 Euro";
            TXZweiEuro.Text = anzahlMuenze2EUR + "x 2 Euro";
            //if (Rueckgeld == 0)
            //{
            //    TXZweiEuro.Clear();
            //}
            TXEinEuro.Text = "0x 1 Euro";
            TXEinEuro.Text = anzahlMuenze1EUR + "x 1 Euro ";
            //if (Rueckgeld == 0)
            //{
            //    TXEinEuro.Clear();
            //}
            TXFuenfzigCent.Text = "0x 50 Cent";
            TXFuenfzigCent.Text = anzahlMuenze50Cent + "x 50 Cent ";
            //if (Rueckgeld == 0)
            //{
            //    TXFuenfzigCent.Clear();
            //}
            TXZwanzigCent.Text = "0x 20 Cent";
            TXZwanzigCent.Text = anzahlMuenze20Cent + "x 20 Cent ";
            //if (Rueckgeld == 0)
            //{
            //    TXZwanzigCent.Clear();
            //}
            TXZehnCent.Text = "0x 10 Cent";
            TXZehnCent.Text = anzahlMuenze10Cent + "x 10 Cent ";
            TXFuenfCent.Text= "0x 5 Cent";
            TXFuenfCent.Text = anzahlMuenze5Cent + "x 5 Cent ";
            //if (Rueckgeld ==0)                  // if (Rueckgeld ==5) hier wird den Feld mit Fünfcent trotzdem gezeigt 
            //{
            //    TXFuenfCent.Clear();
            //    guthaben = 0;
               
            //}
        }

        private void TXEinEuro_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cancel Knopf
            TxZehnEuro.Text = "0x 10 Euro";
            
            Rueckgeld = guthaben;
            if (Rueckgeld >= 1000)
            {
                anzahl10Euro = Rueckgeld / 1000;
                Rueckgeld = Rueckgeld - (anzahl10Euro * 1000);
               
                TxZehnEuro.Text = anzahl10Euro + "x 10 Euro";
            }
            TxFuenfEuro.Text = "0x 5 Euro";
            if (Rueckgeld >= 500)
            {
                anzahl5Euro = Rueckgeld / 500;
                Rueckgeld = Rueckgeld - anzahl5Euro * 500;
                
                TxFuenfEuro.Text = anzahl5Euro + "x 5 Euro";
            }
            TXZweiEuro.Text = "0x 2 Euro";
            if (Rueckgeld >= 200)
            {
                anzahlMuenze2EUR = Rueckgeld / 200;
                Rueckgeld = Rueckgeld - anzahlMuenze2EUR * 200;
                TXZweiEuro.Text = anzahlMuenze2EUR + "x 2 Euro";
            }
            TXEinEuro.Text = "0x 1 Euro";
            if (Rueckgeld >= 100)
            {
                anzahlMuenze1EUR = Rueckgeld / 100;
                Rueckgeld = Rueckgeld - anzahlMuenze1EUR * 100;
                TXEinEuro.Text = anzahlMuenze1EUR + "x 1 Euro";
            }
            TXFuenfzigCent.Text = "0x 50 Cent";
            if (Rueckgeld >= 50)
            {
                anzahlMuenze50Cent = Rueckgeld / 50;
                Rueckgeld = Rueckgeld - anzahlMuenze50Cent * 50;
                TXFuenfzigCent.Text = anzahlMuenze50Cent + "x 50 Cent";
            }
            TXZwanzigCent.Text = "0x 20 Cent";
            if (Rueckgeld >= 20)
            {
                anzahlMuenze20Cent = Rueckgeld / 20;
                Rueckgeld = Rueckgeld - anzahlMuenze20Cent * 20;
                TXZwanzigCent.Text = anzahlMuenze20Cent + "x 20 Cent";
            }
            TXZehnCent.Text = "0x 10 Cent";
            if (Rueckgeld >= 10)
            {
                anzahlMuenze10Cent = Rueckgeld / 10;
                Rueckgeld = Rueckgeld - anzahlMuenze10Cent * 10;
                TXZehnCent.Text = anzahlMuenze10Cent + "x 10 Cent";
            }
            TXFuenfCent.Text = "0x 5 Cent";
            if (Rueckgeld >= 5)
            {
                anzahlMuenze5Cent = Rueckgeld / 5;
                Rueckgeld = Rueckgeld - anzahlMuenze5Cent * 5;
                TXFuenfCent.Text = anzahlMuenze5Cent + "x 5 Cent";
            }
            //Geldrueckgabe(Rueckgeld);
            guthaben = 0;
        }

        private void Nachfuellen_Click(object sender, EventArgs e)
        {

            status.AppendText("\n\r " + (10 - colam) + " x Cola nachgefüllt");
            status.AppendText("\n\r " + (10 - fantam) + " x Fanta nachgefüllt");
            status.AppendText("\n\r " + (10 - colazerom) + " x Cola Zero nachgefüllt");
            status.AppendText("\n\r " + (10 - redbullm) + " x RedBull nachgefüllt");
            status.AppendText("\n\r " + (10 - wasserm) + " x Wasser nachgefüllt");
            status.AppendText("\n\r " + (10 - eisteem) + " x Eistee nachgefüllt");
            


        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Netto preise
            int colanetto = 100;
            int fantametto = 90;
            int colazeronetto = 100;
            int wassernetto = 50;
            int eisteenetto = 40;
            int redbullnetto = 150;

            Umsatzgeld = 0.81*( (10 - colam) * (colap-colanetto) + (10 - fantam) * (fantap-fantametto) + (10 - colazerom) * (colazerop-colazeronetto) + (10 - redbullm) * (redbullp-redbullnetto) + (10 - wasserm) * (wasserp-wassernetto) + (10 - eisteem) * (eisteep-eisteenetto) );
            status.AppendText("\r\n Der Umsatz beträgt: " + Umsatzgeld / 100f + "€");
            //ohne Mwst
           
        }

        private void KeyDownEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterClickFunktion();
            }
        }

        private void geldeingabe_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
