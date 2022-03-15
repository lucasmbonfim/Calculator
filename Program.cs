using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a Calculadora");
            Console.WriteLine("Digite o primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Operações:\nDigite 1 para soma\nDigite 2 para subtração\nDigite 3 para divisão\nDigite 4 para multiplicação");
            int operation = int.Parse(Console.ReadLine());
            if (operation == 1)

                Sum(value1, value2);

            else if (operation == 2)

                Subtraction(value1, value2);

            else if (operation == 3)

                Division(value1, value2);

            else if (operation == 4)
                Multiplication(value1, value2);
            else
                Console.WriteLine("Operação inválida!");
        }

        /* Será utilizado futuramente. Conforme o código for evoluindo.
            enum ECalculations
        {
            Sum = 1,
            Subtraction = 2,
            Division = 3,

            Multiplication = 4
        }
        */

        static void Sum(float number1, float number2)
        {
            float result = number1 + number2;
            Console.WriteLine("Resultado da operação: " + result);
        }
        static void Subtraction(float number1, float number2)
        {
            float result = number1 - number2;
            Console.WriteLine("Resultado da operação: " + result);
        }
        static void Division(float number1, float number2)
        {
            float result = number1 / number2;
            Console.WriteLine("Resultado da operação: " + result);
        }
        static void Multiplication(float number1, float number2)
        {
            float result = number1 * number2;
            Console.WriteLine("Resultado da operação: " + result);
        }
    }
}
