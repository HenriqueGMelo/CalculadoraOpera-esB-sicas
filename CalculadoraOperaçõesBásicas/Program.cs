using System;

namespace CalculadoraOperaçõesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {

            int iniciar;
            
            Console.WriteLine("Calculadora \n");
            Console.Write("tecle '1' e Enter para Ligar: ");
            double ação = double.Parse(Console.ReadLine());

            do
            {
                if (ação != 1)
                {
                    do
                    {
                        Console.Write("Ação incorreta, Tecle '1' e Enter para Ligar: ");
                        ação = double.Parse(Console.ReadLine());
                    } 
                    while (ação != 1);
                }

                Console.WriteLine();
                Console.Write("Digite o 1º valor: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Escolha a operação desejada: ");
                Console.WriteLine("Tecle 1 - Soma");
                Console.WriteLine("Tecle 2 - Subtração");
                Console.WriteLine("Tecle 3 - Multiplicação");
                Console.WriteLine("Tecle 4 - Divisão");
                int operação = int.Parse(Console.ReadLine());
                Console.WriteLine();

                do
                {
                    if (operação >= 5 || operação == 0)
                    {
                        Console.Write("Escolha uma opção valida: ");
                        operação = int.Parse(Console.ReadLine());
                    }
                }
                while (operação >= 5 || operação == 0);

 
                Console.Write("Digite o 2º valor: ");
                double n2 = double.Parse(Console.ReadLine());
 
                Console.Clear();

                double resultado;

                switch (operação)
                {
                    case 1:
                        resultado = Somar(n1, n2);
                        Console.WriteLine($"{n1} + {n2} = {Math.Round(resultado, 2)}");
                        break;
                    case 2:
                        resultado = Subtração(n1, n2);
                        Console.WriteLine($"{n1} - {n2} = {Math.Round(resultado, 2)}");
                        break;
                    case 3:
                        resultado = Multiplicação(n1, n2);
                        Console.WriteLine($"{n1} x {n2} = {Math.Round(resultado, 2)}");
                        break;
                    case 4:
                        try
                        {
                            resultado = Divisão(n1, n2);
                            Console.WriteLine($"{n1} / {n2} = {Math.Round(resultado, 2)}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro: " + e.Message);
                        }
                        break;

                }               
                    Console.WriteLine();
                    Console.Write("Tecle 1 para continuar e 0 para Desligar a Calculadora: ");
                    iniciar = int.Parse(Console.ReadLine());
                    Console.Clear();   
            }
            while (iniciar != 0);
        }


        public static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtração(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiplicação(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Divisão(double n1, double n2)
        {
            if (DivisãoPorZero(n2)) throw new Exception("Impossível dividir por 0");

            return n1 / n2;

            bool DivisãoPorZero(double n2)
            {
                if (n2 == 0) return true;

                return false;
            }
        }
    }
}