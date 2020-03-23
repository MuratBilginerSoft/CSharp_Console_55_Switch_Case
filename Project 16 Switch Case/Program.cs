using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_16_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;

            Console.WriteLine("Sayısal Olarak Hangi Günde Olduğunuzu Giriniz:");
            i = Convert.ToInt32(Console.ReadLine());



            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("Pazartesi");
                        break;
                    }

                case 2: Console.WriteLine("Salı"); break;
                case 3: Console.WriteLine("Çarşamba"); break;
                case 4: Console.WriteLine("Perşembe"); break;
                case 5: Console.WriteLine("Cuma"); break;
                case 6: Console.WriteLine("Çumartesi"); break;
                case 7: Console.WriteLine("Pazar"); break;
                default: Console.WriteLine("Aralık Dışında Bir Değer Girdiniz"); break;

            } // Haftanın Günlerini Kontrol Ettim.

            Console.ReadKey();

        }
    }
}
