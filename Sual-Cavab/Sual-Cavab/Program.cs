using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sual_Cavab
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string cvb;
            int k = 0;
            int duzSay = 0;
            int sehvSay = 0;
            string[] suallar = { "Mozambikin paytaxti haradir?", "2+2=?", "3+3=?", "1+1=?", "2+2=?", "3+3=?", "1+1=?", "2+2=?", "3+3=?", "1+1=?" };
            string[] abc = { "A)", "B)", "C)" };
            string[] var1 = { "Baki", "Atananirinvu", "Maputo" };
            string[] var2 = { "8", "5", "4" };
            string[] var3 = { "9", "6", "1" };
            string[] var4 = { "2", "3", "4" };
            string[] var5 = { "8", "5", "4" };
            string[] var6 = { "9", "6", "1" };  
            string[] var7 = { "2", "3", "4" };
            string[] var8 = { "8", "5", "4" };
            string[] var9 = { "9", "6", "1" };
            string[] var10 = { "2", "3", "4" };
            string[] duzCvb = { "C", "C", "B", "A", "C", "B", "A", "C", "B", "A", "C", "B","A" };

            Console.WriteLine(suallar[0]);
            for (int i = 0; i < var1.Length; i++)
            {
                Console.WriteLine(abc[i] + var1[i]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[0])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                sehvSay++;
                Console.WriteLine("Sehvdir");
            }
            Console.WriteLine(suallar[1]);
            for (int i = 0; i < var2.Length; i++)
            {
                Console.WriteLine(abc[i] + var2[i]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[1])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                Console.WriteLine("Sehvdir");
                sehvSay++;
            }
            Console.WriteLine(suallar[2]);
            for (int i = 0; i < var3.Length; i++)
            {
                Console.WriteLine(abc[i] + var3[rand.Next(0, 3)]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[2])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                Console.WriteLine("Sehvdir");
                sehvSay++;
            }


            Console.WriteLine(suallar[3]);
            for (int i = 0; i < var1.Length; i++)
            {
                Console.WriteLine(abc[i] + var4[i]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[3])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                sehvSay++;
                Console.WriteLine("Sehvdir");
            }
            Console.WriteLine(suallar[4]);
            for (int i = 0; i < var2.Length; i++)
            {
                Console.WriteLine(abc[i] + var5[i]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[4])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                Console.WriteLine("Sehvdir");
                sehvSay++;
            }
            Console.WriteLine(suallar[5]);
            for (int i = 0; i < var3.Length; i++)
            {
                Console.WriteLine(abc[i] + var6[i]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[5])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                Console.WriteLine("Sehvdir");
                sehvSay++;
            }




            Console.WriteLine(suallar[6]);
            for (int i = 0; i < var1.Length; i++)
            {
                Console.WriteLine(abc[i] + var7[i]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[6])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                sehvSay++;
                Console.WriteLine("Sehvdir");
            }
            Console.WriteLine(suallar[7]);
            for (int i = 0; i < var2.Length; i++)
            {
                Console.WriteLine(abc[i] + var8[i]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[7])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                Console.WriteLine("Sehvdir");
                sehvSay++;
            }
            Console.WriteLine(suallar[8]);
            for (int i = 0; i < var3.Length; i++)
            {
                Console.WriteLine(abc[i] + var9[i]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[8])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                Console.WriteLine("Sehvdir");
                sehvSay++;
            }
            Console.WriteLine(suallar[9]);
            for (int i = 0; i < var3.Length; i++)
            {
                Console.WriteLine(abc[i] + var10[i]);
            }
            cvb = Console.ReadLine();
            if (cvb == duzCvb[9])
            {
                Console.WriteLine("Duzdur");
                k += 10;
                duzSay++;
            }
            else
            {
                Console.WriteLine("Sehvdir");
                sehvSay++;
            }

            Console.WriteLine("Baliniz: {0} \nDuz Cavablarin Sayi: {1} \nSehv Cavablarin sayi: {2}",k,duzSay,sehvSay);
            Console.ReadKey();
        }

        }
    }