using System;

namespace ArrayLigeEllerUlige
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Enter how many numbers you want to put in array ( max 10): ");
         int num1 = int.Parse(Console.ReadLine());
         int[] arr1 = new int[num1];
         int[] resultEven = new int[num1];
         int[] resultOdd = new int[num1];
         int i, j = 0, k = 0;
             for (i = 0; i < num1; i++){
                    Console.WriteLine("Enter " + (num1 - i) + " numbers");
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
