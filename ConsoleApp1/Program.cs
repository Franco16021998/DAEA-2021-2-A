using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static bool esPrimo(double n)
        {

            int divisor = 3;
            if (n % 2 == 0 && n != 2)
            {
                return false;
            }
            else
            {
                while (divisor <= Math.Sqrt(n))
                {
                    if (n % divisor == 0)
                        return false;
                    divisor += 2;

                }

            }

            return true;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Suma(int a, int b )
        {
            return a + b;
        }
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raiz cuadrada de {0} es {1}", i, Math.Sqrt(i));
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] SUMA DE DOS NUMEROS");
                Console.WriteLine("[2] IMPRIMIR LA RAIZ CUADRADA DE LOS DIEZ PRIMEROS NUMEROS ENTEROS");
                Console.WriteLine("[3] RESTA DE DOS NUMEROS");
                Console.WriteLine("[4] MULTIPLICACÍÓN DE DOS NUMEROS");
                Console.WriteLine("[5] DIVISIÓN DE DOS NUMEROS");
                Console.WriteLine("[6] MOSTRAR 10 PRIMEROS NUMEROS PRIMOS");
                Console.WriteLine("[0] SALIR");
                Console.WriteLine("Ingrese una opcion y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int b = Convert.ToInt32(Console.ReadLine());                        
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a,b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando .....");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo numero");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Los 10 primeros numeros son:");
                        int n = 1;
                        for (int i = 0; i < 11; i++)
                        {
                            if (esPrimo(i))
                            {
                                Console.WriteLine(i);
                                i++;
                            }
                        }
                        Console.ReadKey();
                        break;
                }                
            } while (!opcion.Equals("0"));
        }
    }
}
