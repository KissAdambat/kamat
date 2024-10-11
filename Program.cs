using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamat
{
    internal class Program
    {

        static void kamat()
        {
            Console.WriteLine("Adja meg hány évre szeretné berakni a pénzét: ");
            int ev = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mekkora összeget szeretne berakni:");
            double mennyiseg = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Mennyi a kamat?");
            double kmat = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Kamatozási periódusok: ");

            double vegsoosszeg = mennyiseg * Math.Pow(1 + kmat / 100, ev);

            Console.WriteLine($"{ev} év múlva: {vegsoosszeg:F2}Ft");
        }

        static void Main(string[] args)
        {
            kamat();
        }
    }
}
