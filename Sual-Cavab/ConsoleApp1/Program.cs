using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class variantlar
    {
        public string first { get; set; }
        public string second { get; set; }
        public string third { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string cvb;
            Random r = new Random();
            int duzSay = 0, sehvSay = 0, bal = 0;
            string[] abc = { "A)", "B)", "C)" };
            string[] suallar =
            {
                "Mozambikin paytaxti?",
                "Karvan hansi sheherin Klubudur?",
                "Xalq cumhuriyyetinin yaranmasi?",
                "Azerbaycanin musteqilliyi?",
                "Adnsu-nun yaranma ili?",
                "Led Zeppelinin solo gitaracisi",
                "Amerikanin nece dene shtati var?",
                "Ne keshf etmek isterdin?",
                "Ulu onderin dogum ili",
                "Dogasi ile meshur rayon?",
                "Suretin dusturu?",
                "Shutter Islandin bash rolunun ifacisi?",
                 "Bakinin en boyuk rayonu?",
                 "Ay ve qara qepik romaninin muellifi?"


            };
            Dictionary<int, string> duzCvb = new Dictionary<int, string>()
            {
                {0,"C" },
                {1,"C" },
                {2,"C" },
                {3,"B"},
                {4,"B" },
                {5,"A" },
                {6,"A" },
                {7,"C" },
                {8,"A" },
                {9,"A" },
                {10,"A" },
                {11,"B" },
                {12,"B" },
                {13,"A" }
            };
            Dictionary<int, string> duzCvbLower = new Dictionary<int, string>()
            {
                {0,"c" },
                {1,"c" },
                {2,"c" },
                {3,"b"},
                {4,"b" },
                {5,"a" },
                {6,"a" },
                {7,"c" },
                {8,"a" },
                {9,"a" },
                {10,"a" },
                {11,"b" },
                {12,"b" },
                {13,"a" }
            };
            Dictionary<int, variantlar> dic = new Dictionary<int, variantlar>()
            {
                { 0,new variantlar{ first="Baki", second="Atananirinvu",third="Mapila"} } ,
                { 1,new variantlar{ first="Baki", second="Kurdemir",third="Yevlax"} },
                {2, new variantlar{first="1910",second="1923", third="1918"} },
                {3 ,new variantlar{first="1990", second="1992",third="1995" } },
                {4,new variantlar{first="1917",second="1920",third="1919"} },
                {5,new variantlar{first="Jimmy Page", second="David Gilmour",third="Kurt Cobain" } },
                {6,new variantlar{first="Ash", second="Bmt",third="Mtn"} },
                {7,new variantlar{first="Mashin", second="Teyyare",third="yuruyen ucaq"} },
                {8,new variantlar{first="1923",second="e.ə 4 cü əsr",third="1900"} },
                {9,new variantlar{first="Gence",second="Naxchivan",third="Neftcala"} },
                {10,new variantlar{first="v=s/t",second="a=v/t",third="f=ma"} },
                {11,new variantlar{first="Tom Hanks",second="Leo Di Caprio",third="Ryan Gosling"} },
                {12,new variantlar{first="Sabuncu",second="Bineqedi",third="Nizami"} },
                {13,new variantlar{first="Somester Moem",second="Jack London",third="Ernst Heminquey"} }
            };
            do
            {
                foreach (int keyt in dic.Keys)
                {
                    Console.WriteLine(suallar[keyt]);
                    Console.WriteLine(abc[0] + " " + dic[keyt].first);
                    Console.WriteLine(abc[1] + " " + dic[keyt].second);
                    Console.WriteLine(abc[2] + " " + dic[keyt].third);
                    cvb = Console.ReadLine();
                    if (cvb == "")
                    {
                        Console.WriteLine("Cavab daxil etmediz! \nYeniden daxil edin:");
                        cvb = Console.ReadLine();
                    }
                    if (cvb == duzCvb[keyt] || cvb == duzCvbLower[keyt])
                    {
                        Console.WriteLine("Duzdur");
                        bal += 10;
                        duzSay++;
                    }
                    else
                    {
                        sehvSay++;
                        Console.WriteLine("Sehvdir");
                    }
                    if (sehvSay >= 3)
                    {
                        Console.WriteLine("Uduzdun.");
                        Console.WriteLine("Yeniden bashlamaq uchun entere chixmaq ucun escape bas!");
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            System.Environment.Exit(1);
                        }
                        else
                        {
                            sehvSay = 0;
                            continue;
                        }
                    }
                }
                Console.WriteLine("Baliniz: {0} \nDuz Cavablarin sayi: {1} \nSehv cavablarin sayi: {2}", bal, duzSay, sehvSay);
                if (bal > 110)
                {
                    Console.WriteLine("Daaaahiii");
                }
                else if (bal>60)
                {
                    Console.WriteLine("Tupoy deyilsen :D");
                }
                else
                {
                    Console.WriteLine("Hesh ne");
                }
                Console.WriteLine("Oyuna davam etmek ucun entere basin!\nChixmaq ucun escape basin!");
              
            } while (Console.ReadKey(true).Key == ConsoleKey.Enter);
        }
    }
}
