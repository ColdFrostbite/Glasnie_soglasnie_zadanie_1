using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlasSoglas
{
    class Program
    {
        static void Main(string[] args)
        {
            string Vstr;
            int iSl;
            int Glasnie;//количество гласных
            int Soglasnie;//количество согласных;      
            string[] Glas = new string[10] { "а", "е", "ё", "и", "о", "у", "ы", "э", "ю", "я" };
            string[] Soglas = { "б", "в", "г", "д", "ж", "з", "й", "к", "л", "м", "н", "п", "р", "с", "т", "ф", "х", "ц", "ч", "ш", "щ" };
           
            Console.Write("Введите любой текст: ");
            Vstr = Console.ReadLine();
            iSl = Vstr.Length;

            Glasnie = 0;
            Soglasnie = 0;

            for(int i=0;i<Vstr.Length;i++)
            {
               for(int n=0;n<10;n++)
               {
                  if  (string.Equals(Glas[n], Vstr.Substring(i,1)))
                  {
                     Glasnie++;
                  }
                    
               }
           
                for(int k=0; k<21;k++)
                {
                    if (string.Equals(Soglas[k], Vstr.Substring(i, 1)))
                    {
                        Soglasnie++;
                        Console.WriteLine();
                    }
                }
           
            }

            Console.WriteLine("Количество гласных : " + Glasnie);
            Console.WriteLine("Количество cогласных : " + Soglasnie);
            Console.ReadLine();
        }
    }
    
}
