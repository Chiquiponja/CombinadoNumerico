using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coleccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeros Combinados");
           
            

            int[] C1 =new int[7] { 1, 2, 3, 4, 5,6,7 };
            int[] C2 =new int[5] {  20, 30, 40, 50,60};
            int[] C3 =new int[8] { 100 ,200, 300, 400, 500,600,700,800 };
            Console.WriteLine("Numeros de 1 cifra");
            for (int contador = 0; contador < C1.Length; contador++)
            {
                Console.WriteLine(C1[contador]);
            }
            Console.WriteLine("Numeros de 2 cifras");
            for (int contador = 0; contador < C2.Length; contador++)
            {
                Console.WriteLine(C2[contador]);
            }
            Console.WriteLine("Numeros de 3 cifras");
            for (int contador = 0; contador < C3.Length; contador++)
            {
                Console.WriteLine(C3[contador]);
            }
            Console.WriteLine("Combinacion de Tres Listas");
            List<String> list = new List<string>();
            List<String> list2 = new List<string>();
            List<String> list3 = new List<string>();
            list.Add("1,2,3,4,5,6,7");

            list2.Add("20,30,40,50,60");
            list3.Add("100,200,300,400,500,600,700,800");


            List<string> query = list.Concat(list2).Concat(list3).ToList();

            query.ForEach(item => System.Console.WriteLine(item));
            Console.WriteLine("Combinacion ");
            
            Console.WriteLine(" " + C1[0] + "-" + C2[0] + "-" + C3[0]);
            
            Console.WriteLine(" " + C1[1] + "-" + C2[1] + "-" + C3[1]);
            
            Console.WriteLine(" " + C1[2] + "-" + C2[2] + "-" + C3[2]);
            Console.WriteLine(" " + C1[3] + "-" + C2[3] + "-" + C3[3]);


            Console.WriteLine("C1 sin Combinar ");
            Console.WriteLine(" " + "" + C1[4] + "-" + C1[5] + "-" + C1[6]);

            Console.WriteLine("C2 sin Combinar ");
            Console.WriteLine(" "  + "" + C2[4] );

            Console.WriteLine("C3 sin Combinar ");
            Console.WriteLine(" " + "" + C3[4] + "-" + C3[6]+ "-"+ C3[7]);








            Console.Read();

            }
        }
    }


