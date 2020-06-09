using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Fibonacci
    {
        class Program
        {
            public static void Main(string[] args)
            {
                List<int> listaSequencia = new List<int>();            
                int a = 0;
                int b = 1;            
                for (int counter = 0; counter <= 12; counter++)
                {
                    int c = a + b;
                    a = b;
                    b = c;                
                    listaSequencia.Add(c);
                }
                foreach(int numero in listaSequencia)
                {
                    Console.WriteLine(numero);
                }
                IsFibonacci(1, listaSequencia);
                Console.ReadLine();
            }
            static bool IsFibonacci(int numero, List<int> lista)
            {
                int numInterno = numero;          
                    if (lista.Contains(numInterno))
                    {
                        Console.WriteLine("O número está na sequência de Fibonacci.");
                        return true;
                    }
                return false;
            }
        }    
    }
