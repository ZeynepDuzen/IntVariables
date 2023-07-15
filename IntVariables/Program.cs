using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("Lütfen bir sayi giriniz : ");
            sayi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Girmis oldugunuz sayi : " + sayi);

            Console.Read();
        }
    }
}
