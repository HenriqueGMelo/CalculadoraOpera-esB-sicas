using CalculadoraOperaçõesBásicas;
using System;

namespace CalculadoraOperaçõesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;
            int escolha, operação;

            Soma somar = new Soma();
            Subtracao subtrair = new Subtracao();
            Divisao dividir = new Divisao();
            Multiplicacao multiplicar = new Multiplicacao();

            // 1 e Enter simboliza o botão de ligar.
            // 0 simboliza o botão de desligar, porém se a calculadora já estiver desliga ele não realiza nenhuma ação,
            // por este motivo caso desista de utilizar a calculadora antes de ser ligada, deve-se fechar a aplicação. 
            Console.WriteLine("Calculadora \n");
            Console.Write("tecle '1' e Enter para Ligar: ");
            int acao = int.Parse(Console.ReadLine());
            Console.Clear();

            do
            {
                if (acao != 1)
                {
                    do
                    {
                        Console.Write("Ação incorreta, Tecle '1' e Enter para Ligar: ");
                        acao = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                    while (acao != 1);
                }

                Console.WriteLine();
                Console.Write("Digite o 1º valor: ");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();
               
                do
                {
                    Console.WriteLine("Escolha a operação desejada: ");
                    Console.WriteLine("Tecle 1 - Soma");
                    Console.WriteLine("Tecle 2 - Subtração");
                    Console.WriteLine("Tecle 3 - Multiplicação");
                    Console.WriteLine("Tecle 4 - Divisão");
                    operação = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.Clear();

                    if (operação >= 5 || operação <= 0)
                    {
                        Console.WriteLine("Escolha uma opção válida: ");
                        Console.Clear();
                    }
                }
                while (operação >= 5 || operação <= 0);

                Console.Write("Digite o 2º valor: ");
                double n2 = double.Parse(Console.ReadLine());
                Console.Clear();

                double resultado;

                switch (operação)
                {
                    case 1:
                        resultado = somar.Somar(n1, n2);
                        Console.WriteLine($"{n1} + {n2} = {Math.Round(resultado, 2)}");
                       break;
                    case 2:
                        resultado = subtrair.Subtrair(n1, n2);
                        Console.WriteLine($"{n1} - {n2} = {Math.Round(resultado, 2)}");
                        break;
                    case 3:
                        resultado = multiplicar.Multiplicar(n1, n2);
                        Console.WriteLine($"{n1} x {n2} = {Math.Round(resultado, 2)}");
                        break;
                    case 4:
                        try
                        {
                            resultado = dividir.Dividir(n1, n2);
                            Console.WriteLine($"{n1} / {n2} = {Math.Round(resultado, 2)}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Erro: " + e.Message);
                        }
                        break;
                }

                Console.WriteLine();
                Console.Write("Tecle 1 para continuar ou 0 para Desligar a Calculadora: ");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();

                do
                {
                    if (escolha == 0 || escolha == 1)
                    {
                        
                    }
                    else if (operação < 0 || operação > 1)
                    {
                        Console.WriteLine("Opção inválida");
                        Console.Write("Escolha 1 para continuar ou 0 para Desligar a Calculadora: ");
                        escolha = int.Parse(Console.ReadLine());
                        Console.Clear();
                    }
                } while (escolha < 0 || escolha > 1);  
            }
            while (escolha == continuar);
        }
    }
}