using System;

namespace Stepan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
                if (i != 0)
                {
                    while (true)
                    {
                        if (names[i] == names[i - 1])
                        {
                            Console.WriteLine("Такое уже было.");
                            names[i] = Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
