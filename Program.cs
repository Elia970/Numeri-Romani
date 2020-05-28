using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cesaretti.elia._3j.numeriromani
{
    class Program
    {
        static void Main(string[] args)
        {
            int anno, migl, cent, dec, uni, migl2 = 0, cent2 = 0, dec2 = 0;
            string stranno, strmi = "", strcent = "", strdec = "", struni = "";
            Console.WriteLine("________________Convertitore da numeri decimali a numeri romani________________");
            Console.WriteLine();
            Console.WriteLine("Inserisci l'anno");
            stranno = Console.ReadLine();
            anno = Convert.ToInt32(stranno);
            if (anno >= 4000)
            {
                do
                {
                    Console.WriteLine("Inserisci un anno minore di 4000");
                    stranno = Console.ReadLine();
                    anno = Convert.ToInt32(stranno);

                } while (anno >= 4000);

            }

            migl = anno / 1000;
            //Migliaia
            switch (migl)
            {
                case 1:
                    strmi = "M";
                    migl2 = 1000;
                    break;
                case 2:
                    strmi = "MM";
                    migl2 = 2000;
                    break;
                case 3:
                    strmi = "MMM";
                    migl2 = 3000;
                    break;
            }
            //Centinaia
            cent = (anno - migl2) / 100;
            switch (cent)
            {
                case 1:
                    strcent = "C";
                    cent2 = 100;
                    break;
                case 2:
                    strcent = "CC";
                    cent2 = 200;
                    break;
                case 3:
                    strcent = "CCC";
                    cent2 = 300;
                    break;
                case 4:
                    strcent = "CD";
                    cent2 = 400;
                    break;
                case 5:
                    strcent = "D";
                    cent2 = 500;
                    break;
                case 6:
                    strcent = "DC";
                    cent2 = 600;
                    break;
                case 7:
                    strcent = "DCC";
                    cent2 = 700;
                    break;
                case 8:
                    strcent = "DCCC";
                    cent2 = 800;
                    break;
                case 9:
                    strcent = "CM";
                    cent2 = 900;
                    break;
            }
            //Decine
            dec = (anno - migl2 - cent2) / 10;
            switch (dec)
            {
                case 1:
                    strdec = "X";
                    dec2 = 10;
                    break;
                case 2:
                    strdec = "XX";
                    dec2 = 20;
                    break;
                case 3:
                    strdec = "XXX";
                    dec2 = 30;
                    break;
                case 4:
                    strdec = "XL";
                    dec2 = 40;
                    break;
                case 5:
                    strdec = "L";
                    dec2 = 50;
                    break;
                case 6:
                    strdec = "LX";
                    dec2 = 60;
                    break;
                case 7:
                    strdec = "LXX";
                    dec2 = 70;
                    break;
                case 8:
                    strdec = "LXXX";
                    dec2 = 80;
                    break;
                case 9:
                    strdec = "XC";
                    dec2 = 90;
                    break;
            }
            //Unità
            uni = (anno - migl2 - cent2 - dec2);
            switch (uni)
            {
                case 1:
                    struni = "I";
                    break;
                case 2:
                    struni = "II";
                    break;
                case 3:
                    struni = "III";
                    break;
                case 4:
                    struni = "IV";
                    break;
                case 5:
                    struni = "V";
                    break;
                case 6:
                    struni = "VI";
                    break;
                case 7:
                    struni = "VII";
                    break;
                case 8:
                    struni = "VIII";
                    break;
                case 9:
                    struni = "IX";
                    break;
            }
            Console.WriteLine("L'anno " + anno + " risulta essere " + strmi + strcent + strdec + struni + " in numeri romani");
            Console.ReadLine();
        }
    }
}
