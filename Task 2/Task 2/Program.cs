using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

        }
       static int[] Method(int[] numbers) 
        {
            int[] newnumbers = { };

            for(int i = 0; i < numbers.Length; i++) 
            {

                if (numbers[i] % 2 == 0) 
                
               { newnumbers[i] = numbers[i]; }
            }
        return newnumbers;
        
        }
        
        

}
    }
}
