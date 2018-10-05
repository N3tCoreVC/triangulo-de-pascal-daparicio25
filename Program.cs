using System;
using System.Collections.Generic;

namespace triangulo_de_pascal_daparicio25
{
    class Program
    {
        public static List<int> lista1 = new List<int>();
        public static List<int> lista2 = new List<int>();
        static void Main(string[] args)
        {            
            Console.Write("Ingresa la base: ");
            int num = 0;

            if (Int32.TryParse(Console.ReadLine(), out num)) {
                metodo(num);
            } else {
                Console.WriteLine("No ingresaste un numero");
            }
        }

        public static void metodo(int num) {
            lista1.Add(1);

            for (int i=1; i<num; i++) {
                Console.Write(" ");
            }

            Console.WriteLine(lista1[0]);

            for (int i=0; i<num-1; i++) {
                for (int j=i+1; j<num-1; j++) {
                    Console.Write(" ");
                }
                triangulo();
            }
        }

        public static void triangulo() {
            lista2.Add(1);

            for (int i=0; i<=lista1.Count-2; i++) {
                lista2.Add(lista1[i] + lista1[i+1]);
            }
            
            lista2.Add(1);

            lista1.Clear();
            foreach (int num in lista2) {
                Console.Write(num + " ");
                lista1.Add(num);
            }
            Console.WriteLine();
            lista2.Clear();
        }
    }
}
