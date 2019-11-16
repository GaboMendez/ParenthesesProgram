using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancingParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bucle = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Escriba su expresion o escriba -1 para salir: ");
                string input = Console.ReadLine();

                if (input.Equals("-1"))
                {
                    Console.Clear();
                    Console.WriteLine("Muchas Gracias! Pase feliz resto de Dia!");
                    bucle = false;
                    Console.ReadKey();
                    continue;
                }

                bool result = CheckParentesis(input);

                if (result)
                {
                    Console.WriteLine("Su expresion tiene los parentesis balanceados!");
                }
                else
                {
                    bool found = false;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if(input[i].Equals('(') || input[i].Equals(')'))
                        {
                            found = true;
                        }     
                    }

                    if (!found)
                    {
                        Console.WriteLine("Expresión sin paréntesis");
                        Console.ReadKey();
                        continue;
                    }
                    Console.WriteLine("Los parentesis no estan balanceados, intente de nuevo...");
                }
                Console.ReadKey();
            } while (bucle);
           

            Console.ReadKey();
        }

        public static bool CheckParentesis(string mensaje)
        {
            bool output = false;

            Stack myStack = new Stack();

            int count = 0;
            for (int i = 0; i < mensaje.Length; i++)
            {
                if (mensaje[i].Equals('('))
                {
                    myStack.Push(mensaje[i]);
                }
                if (mensaje[i].Equals(')'))
                {
                    if (myStack.Count.Equals(0))
                    {
                        output = false;
                        break;
                    }
                    else
                    {
                        var x = myStack.Pop();

                        if (count.Equals(mensaje.Length - 1) && myStack.Count.Equals(0))
                        {
                            output = true;
                        }
                    }
                }

                count++;
            }
            return output;
        }
    }
}
