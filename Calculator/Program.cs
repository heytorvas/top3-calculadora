using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> values = new List<double>();

            Console.WriteLine("DIGITE A QUANTIDADE DE NÚMEROS DESEJADOS: (2-5)");
            int qtdNumbers = Convert.ToInt32(Console.ReadLine());

            if (checkQtdNumbers(qtdNumbers))
            {
                Console.WriteLine("ESCOLHA O OPERADOR MATEMÁTICO: ");
                Console.WriteLine("1- SOMA");
                Console.WriteLine("2- SUBTRAÇÃO");
                Console.WriteLine("3- MULTIPLICAÇÃO");
                Console.WriteLine("4- DIVISÃO");

                int choiceOperator = Convert.ToInt32(Console.ReadLine());

                switch (choiceOperator)
                {
                    case 1:
                        while (qtdNumbers > 0)
                        {
                            Console.WriteLine("DIGITE O VALOR: ");
                            values.Add(Convert.ToDouble(Console.ReadLine()));
                            qtdNumbers--;
                        }
                        Console.WriteLine("SOMA: " + plus(values));
                        break;
                    case 2:
                        while (qtdNumbers > 0)
                        {
                            Console.WriteLine("DIGITE O VALOR: ");
                            values.Add(Convert.ToDouble(Console.ReadLine()));
                            qtdNumbers--;
                        }
                        Console.WriteLine("SUBTRAÇÃO: " + minus(values));
                        break;
                    case 3:
                        while (qtdNumbers > 0)
                        {
                            Console.WriteLine("DIGITE O VALOR: ");
                            values.Add(Convert.ToDouble(Console.ReadLine()));
                            qtdNumbers--;
                        }
                        Console.WriteLine("MULTIPLICACAO: " + times(values));
                        break;
                    case 4:
                        while (qtdNumbers > 0)
                        {
                            Console.WriteLine("DIGITE O VALOR: ");
                            values.Add(Convert.ToDouble(Console.ReadLine()));
                            qtdNumbers--;
                        }
                        Console.WriteLine("DIVISÃO: " + divide(values));
                        break;
                }
            }
            else
                Console.WriteLine("ERROU!");
        }

        static double divide(List<double> listValues)
        {
            int sizeList = listValues.Count;
            double result = 0.0;

            for (int i = 0; i < sizeList; i++)
            {
                double getValueList = listValues.ElementAt(i);
                if (i == 0)
                    result = getValueList;
                else
                    result /= getValueList;
            }
            return result;
        }

        static double times(List<double> listValues)
        {
            int sizeList = listValues.Count;
            double result = 0.0;

            for (int i = 0; i < sizeList; i++)
            {
                double getValueList = listValues.ElementAt(i);
                if (i == 0)
                    result = getValueList;
                else
                    result *= getValueList;
            }
            return result;
        }

        static double minus(List<double> listValues)
        {

            int sizeList = listValues.Count;
            double result = 0.0;

            for (int i = 0; i < sizeList; i++)
            {
                double getValueList = listValues.ElementAt(i);
                if (i == 0)
                    result = getValueList;
                else
                    result =- getValueList;
            }

            return result;
        }

        static double plus(List<double> listValues)
        {
            double result = 0.0;
            int sizeList = listValues.Count;

            for (int i = 0; i < sizeList; i++)
            {
                double getValueList = listValues.ElementAt(i);
                result += getValueList;
            }

            return result;
        }

        static bool checkQtdNumbers(int qtdNumbers)
        {
            if (qtdNumbers >= 2 && qtdNumbers <= 5)
                return true;
            else
                return false;
        }
    }
    
}
