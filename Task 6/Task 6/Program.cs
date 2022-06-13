using System;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        
        static void Method(int[] numbers, int num)
        {
          
            Array.Resize(ref numbers,numbers.Length + 1);

            numbers[numbers.Length - 1] = num;

         
        }
    }
}
