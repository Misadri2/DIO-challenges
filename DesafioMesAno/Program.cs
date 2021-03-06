using System;

namespace DesafioDio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, anos, meses, dias;

            Console.Write("Informe valor de n: ");
            n = int.Parse(Console.ReadLine());
            anos = n/365;
            meses = (n % 365)/30;
            dias = ((n % 365)% 30);

            Console.WriteLine("Resultado: " + anos);
            Console.WriteLine("Resultado: " + meses);
            Console.WriteLine("Resultado: " + dias );
        }
    }
}
