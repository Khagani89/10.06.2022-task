using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Names = { "Samir", "Xaliq", " Ali", "Rauf", "Hikmet" };
            {
                int count = 0;
                for (int i = 0; i < Names.Length; i++)
                {
                    if (Names[i].Length >= 5)
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
