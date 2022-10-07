using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace integer_ikililerin_toplamı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı dizisi giriniz: ");
            string numbers = Console.ReadLine();
            intCount(numbers);
            Console.ReadKey();
        }

        static void intCount(string numbers)
        {
            int count = 0 , extent = 0;
            bool isSingle = false;
            string[] numberList = numbers.Split(' ');

            extent = numberList.Length;

            while(numberList.Length % 2 != 0)
            {
                extent = numberList.Length - 1;
                isSingle = true;
                break;
            }

            for (int i = 0; i < extent; i+=2)
            {
                if (numberList[i] == numberList[i+1])
                {
                    count = int.Parse(numberList[i]) + int.Parse(numberList[i + 1]);
                    Console.Write(count * count + " ");
                }
                else
                { 
                    count = int.Parse(numberList[i]) + int.Parse(numberList[i+1]);
                    Console.Write(count + " ");
                }
            }

            if (isSingle == true)
            {
                Console.WriteLine(numberList.Last());
                Console.WriteLine("Dizi tek sayılı bir uzunluğa sahip olduğu için son eleman kendi değeriyle yazıldı.");
            }
            
           

        }
    }
}
