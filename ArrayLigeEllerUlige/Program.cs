using System;

namespace ArrayLigeEllerUlige
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Indtast antal tal du ønsker at lægge i dit array ( max 10): ");          
             int num1 = int.Parse(Console.ReadLine());
             int number;
             int[] resultEven = new int[num1];
             int[] resultOdd = new int[num1];

             for (int i = 0; i < num1; i++)
             {
                 Console.WriteLine("Indtast " + (num1 - i) + " numre");

                     number = int.Parse(Console.ReadLine());

                 if (number % 2 == 0)
                 {
                     resultEven[i] = number;
                 }
                 else
                 {
                     resultOdd[i] = number;                    
                 }                
             }

             foreach (int x in resultEven)
             {
                 Console.WriteLine(resultEven[num1]);
             }

             foreach (int y in resultOdd)
             {
                 Console.WriteLine(resultOdd[num1]);
             }
             Console.ReadLine();*/

         Console.WriteLine("Indtast antal tal du ønsker at lægge i dit array ( max 10): ");
         int num1 = int.Parse(Console.ReadLine());
         int[] arr1 = new int[num1];
         int[] resultEven = new int[num1];
         int[] resultOdd = new int[num1];
         int i, j = 0, k = 0;
         for (i = 0; i < num1; i++)
            {
                Console.WriteLine("Indtast " + (num1 - i) + " numre");

                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0) {
               resultEven[j] = number;
               j++;
            } else {
               resultOdd[k] = number;
               k++;
            }
         }
         Console.WriteLine("Even numbers...");
         for (i = 0; i < j; i++) {
            Console.WriteLine(resultEven[i]);
         }
        Console.WriteLine("Odd numbers...");
         for (i = 0; i < k; i++) {
            Console.WriteLine(resultOdd[i]);
         }
        }
    }
}
