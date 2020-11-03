using System;
using System.Data;

namespace Calculator2
{
    
    internal class Program
    {
        public static void Main(string[] args)
        {
          Console.WriteLine("İslemi giriniz");
          string islem = Console.ReadLine();
            
            string deger = new DataTable().Compute(islem, null).ToString();
            Console.WriteLine(deger);
        }
    }
}