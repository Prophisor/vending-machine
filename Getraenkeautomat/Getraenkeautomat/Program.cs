using System;

namespace Getränkautomat
{
    class Program
    {
        // Getränknamen

        static int cola = 1;
        static int fanta = 2;
        static int colazero = 3;
        static int redbull = 4;
        static int wasser = 5;
        static int eistee = 6;

        // Getränkpreis

        static int colap = 250;
        static int fantap = 200;
        static int colazerop = 200;
        static int redbullp = 300;
        static int wasserp = 100;
        static int eisteep = 150;
        //Menge
        static int colam = 10;
        static int fantam = 10;
        static int colazerom = 10;
        static int redbullm = 10;
        static int wasserm = 10;
        static int eisteem = 10;
        static void Main(string[] args)
        {
           
            bool wiederholung = true;

            while (wiederholung == true)
            {
                bool cancel = false;
                bool isCorrect = false;
                int inputGetraenk = 0;
                while (isCorrect == false)
                {
                    Console.Write(" Bitte wählen Sie ein Getränk: ");
                    string inputString = Console.ReadLine();
                    if (inputString == "c" || inputString == "")
                    {
                        cancel = true;
                        break;
                    }
                    inputGetraenk = Convert.ToInt32(inputString);
                   
                    if (inputGetraenk > 6)
                    {
                        Console.WriteLine("Bitte geben Sie einen Zahl zwischen 1 und 6   Danke!");

                    }

                    else if (inputGetraenk > 0)
                    {
                        Console.WriteLine("Warten Sie bitte kurz!");
                        isCorrect = true;
                    }
                }       // Ende der Schleife von While isCorect

                if (cancel == true)
                {
                    break;
                }

                int preis = SuchePreisFuerGetraenk(inputGetraenk);
                if (preis == 0)
                {
                    continue;  // damit das Programm weiter funktionieren kann und nicht aufhöhrt, weil kein getränk mehr da ist. 
                }
                Console.WriteLine("und es kostet:" + preis);
                // Zahlen

                Console.WriteLine("Bitte geben Sie Ihren Betrag an, achten Sie drauf, dass die Maschine max 10 (als 1000 Cent) Euro nehmen kann");
                bool isMoney = false;
                int inputZahlen = 0;
                while (isMoney == false)
                {
                    string inputString2 = Console.ReadLine();

                    if (inputString2 == "c" || inputString2 == "")
                    {
                        Console.WriteLine("Nehmen Sie das Geld bitte zurück");
                    }
                    inputZahlen = inputZahlen + Convert.ToInt32(inputString2);
                    if (inputZahlen > 1000)
                    {
                        Console.WriteLine("Bitte geben Sie einen Zahl zwischen 100 und 1000 Danke!");
                        inputZahlen = 0;
                    }
                    else if (inputZahlen < preis)
                    {
                        Console.WriteLine("Das Geld reicht nicht für den kauf! oder c um abzurechen");


                    }
                    else
                    {
                        isMoney = true;
                    }

                }
                int Rueckgeld = berechneRueckgeld(preis, inputZahlen);
                Console.WriteLine(" Ihr Rückgeld ist :" + Rueckgeld);
                ZieheGetraenkAb(inputGetraenk);

                Geldrueckgabe(Rueckgeld);

                Console.WriteLine("--------------");

            } //while Scleife 


        }

        

        static int berechneRueckgeld(int verkaufspreis, int gezahlt)
        {
            return gezahlt - verkaufspreis;
        }

        static void ZieheGetraenkAb(int inputGetraenk)
        {
            switch (inputGetraenk)
            {
                case 1:
                    colam = colam - 1;
                    Console.WriteLine("verhandene Gertränke noch:" + colam);

                    break;

                case 2:
                    fantam = fantam - 1;
                    Console.WriteLine("verhandene Gertränke noch:" + fantam);
                    break;
                case 3:
                    colazerom = colazerom - 1;
                    Console.WriteLine("verhandene Gertränke noch:" + colazerom);
                    break;
                case 4:
                    redbullm = redbullm - 1;
                    Console.WriteLine("verhandene Gertränke noch:" + redbullm);
                    break;
                case 5:
                    wasserm = wasserm - 1;
                    Console.WriteLine("verhandene Gertränke noch:" + wasserm);
                    break;
                case 6:
                    eisteem = eisteem - 1;
                    Console.WriteLine("verhandene Gertränke noch:" + eisteem);
                    break;

                default:
                    break;
            }
        }

        static void Geldrueckgabe(int Rueckgeld)
        {
            int anzahlMuenze2EUR = 0;
            int anzahlMuenze1EUR = 0;
            int anzahlMuenze50Cent = 0;
            int anzahlMuenze20Cent = 0;
            int anzahlMuenze10Cent = 0;
            int anzahlMuenze5Cent = 0;
            // Rückgeld in Münzen/ 
            if (Rueckgeld >= 200)
            {
                Console.WriteLine("Sie bekommen " + Rueckgeld / 200 + " Mal 2 Euro  ");
                Console.WriteLine(" " + Rueckgeld % 200);
                anzahlMuenze2EUR = Rueckgeld / 200;
                Rueckgeld = Rueckgeld % 200;

            }
            if (Rueckgeld >= 100)
            {
                Console.WriteLine("Sie bekommen " + Rueckgeld / 100 + " Mal 1 Euro  ");
                Console.WriteLine(" " + Rueckgeld % 100);
                anzahlMuenze1EUR = Rueckgeld / 100;
                Rueckgeld = Rueckgeld % 100;
            }
            if (Rueckgeld >= 50)
            {
                Console.WriteLine("Sie bekommen " + Rueckgeld / 50 + " Mal 50 Cent  ");
                Console.WriteLine(" " + Rueckgeld % 50);
                anzahlMuenze50Cent = Rueckgeld / 50;
                Rueckgeld = Rueckgeld % 50;

            }
            if (Rueckgeld >= 20)
            {
                Console.WriteLine("Sie bekommen " + Rueckgeld / 20 + " Mal 20 Cent  ");
                Console.WriteLine(" " + Rueckgeld % 20);
                anzahlMuenze20Cent = Rueckgeld / 20;
                Rueckgeld = Rueckgeld % 20;
            }
            if (Rueckgeld >= 10)
            {
                Console.WriteLine("Sie bekommen " + Rueckgeld / 10 + " Mal 10 Cent  ");
                Console.WriteLine(" " + Rueckgeld % 10);
                anzahlMuenze10Cent = Rueckgeld / 10;
                Rueckgeld = Rueckgeld % 10;
            }
            if (Rueckgeld >= 5)
            {
                Console.WriteLine("Sie bekommen " + Rueckgeld / 5 + " Mal 5 Cent  ");
                Console.WriteLine(" " + Rueckgeld % 5);
                anzahlMuenze5Cent = Rueckgeld / 5;
                Rueckgeld = Rueckgeld % 5;
            }
            Console.WriteLine(anzahlMuenze2EUR + "x 2 Euro " + anzahlMuenze1EUR + "x 1 Euro " + anzahlMuenze50Cent + "x 50 Cent " + anzahlMuenze20Cent + "x 20 Cent " + anzahlMuenze10Cent + "x 10 Cent " + anzahlMuenze5Cent + "x 5 Cent ");
            Console.WriteLine(" Das war ihr Rückgeld");
        }

        static int SuchePreisFuerGetraenk(int inputGetraenk)
        {
            int preis = 0;
            switch (inputGetraenk)
            {
                case 1:

                    if (colam == 0)
                    {
                        Console.WriteLine(" Cola ist nicht mehr vorhanden");
                    }
                    else
                    {
                        Console.Write("Ihr Getränk ist Cola ");
                        preis = colap;
                    }
                    break;
                case 2:
                    if (fantam == 0)
                    {
                        Console.WriteLine(" Fanta ist nicht mehr vorhanden");
                    }
                    else
                    {
                        Console.Write("Ihr Getränk ist Fanta ");
                        preis = fantap;
                    }
                    break;
                case 3:
                    if (colazerom == 0)
                    {
                        Console.WriteLine("Cola zero ist nicht mehr vorhanden");
                    }
                    else
                    {
                        Console.Write("Ihr Getränk ist Cola Zero ");
                        preis = colazerop;
                    }
                    break;
                case 4:
                    if (redbullm == 0)
                    {
                        Console.WriteLine("RedBull ist nicht mehr vorhanden");
                    }
                    else
                    {
                        Console.Write("Ihr Getränk ist RedBull ");
                        preis = redbullp;
                    }
                    break;
                case 5:
                    if (wasserm == 0)
                    {
                        Console.WriteLine("Wasser ist nicht mehr vorhanden");
                    }
                    else
                    {
                        Console.Write("Ihr Getränk ist Wasser ");
                        preis = wasserp;
                    }
                    break;
                case 6:
                    if (eisteem == 0)
                    {
                        Console.WriteLine("Eistee ist nicht mehr vorhanden");
                    }
                    else
                    {
                        Console.Write("Ihr Getränk ist Eistee ");
                        preis = eisteep;
                    }
                    break;

                    // default:
                    // Console.WriteLine("");
                    //  break;

            }

            return preis;
        }
    }

}
