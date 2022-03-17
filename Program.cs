using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a Calculadora de 2 valores!");
            Menu();
        }
        static void SairDoPrograma()
        {
            Console.Clear();
            Console.WriteLine("\nObrigado por utilizar a nossa calculadora!\n");
            System.Environment.Exit(0);
        }
        static void Menu()
        {
            Console.WriteLine("\nSelecione uma opção abaixo:\n1 - Soma\n2 - Subtração\n3 - Divisão\n4 - Multiplicação\n5 - Sair da calculadora");
            short operation = short.Parse(Console.ReadLine());
            switch (operation) // Switch para estruturar melhor 
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: SairDoPrograma(); break;
                default: Menu(); break;
            }
        }
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("\nPrimeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nSegundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            float result = value1 + value2;
            Console.WriteLine("\nResultado da operação: " + result);
            Console.ReadKey(); // pra não parar a execução do programa 
            Menu();
        }
        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("\nPrimeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nSegundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            float result = value1 - value2;
            Console.WriteLine("\nResultado da operação: " + result);
            Console.ReadKey();
            Menu();
        }
        static void Division()
        {
            Console.Clear();
            Console.WriteLine("\nPrimeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nSegundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            float result = value1 / value2;
            Console.WriteLine("\nResultado da operação: " + result);
            Console.ReadKey();
            Menu();
        }
        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("\nPrimeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("\nSegundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            float result = value1 * value2;
            Console.WriteLine("\nResultado da operação: " + result);
            Console.ReadKey();
            Menu();
        }
    }
}
