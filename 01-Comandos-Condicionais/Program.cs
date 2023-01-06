using System;

namespace _01_Comandos_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            string aluno1 = "1";
            string aluno2 = "2";

            double a1n1 = 7;
            double a1n2 = 8;
            double a2n1 = 6; 

            double a2n2 = 5;

            double ma1 = (a1n1+a1n2)/ 2;
            double ma2 = (a2n1+a2n2)/ 2;

            if (ma1 > 6) { } else { }
            if (ma2 > 6) { } else { }

            Console.WriteLine($"Média aluno: {aluno1} - {ma1}");
            Console.WriteLine($"Média aluno: {aluno2} - {ma2}");
        }
    }
}
