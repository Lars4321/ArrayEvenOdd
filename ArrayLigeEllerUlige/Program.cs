using System;

namespace ArrayLigeEllerUlige
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast antal tal du ønsker at lægge i dit array ( max 10): ");

           int num1 = int.Parse(Console.ReadLine());

           
            //int[] result = new int[num1];

            for (int i = 0; i < num1; i++)
            {
                Console.WriteLine("Indtast " + (num1 - i) + " numre");
                int number;
                
                    number = int.Parse(Console.ReadLine());
                    //result[i] = number;
                    
                
                if (number % 2 == 0)
                {
                    Console.WriteLine("lige tal : ", number);
                }
                else
                {
                    Console.WriteLine("ulige tal : ", number);
                }                
            }
         Console.ReadLine();
        }
    }
}
