using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"G:\ТОИ_КЛИМОВ_ДЗ1.txt", FileMode.Open, FileAccess.Read))
            {
                int a = 0;
                int[] ints = new int[256];
                {
                    while (a != -1)
                    {
                        a = fs.ReadByte();
                        if (a < 0 || a > 255)
                            break;
                        ints[a]++;
                    }
                    Console.WriteLine("ФАЙЛ 1\n\n");
                    for (int i = 0; i < 256; i++)
                    {
                        Console.WriteLine(ints[i]);
                    }
                    Console.WriteLine("\n\n");
                }
            }


            using (FileStream fs = new FileStream(@"G:\ТОИ_КЛИМОВ_ДЗ1.wav", FileMode.Open, FileAccess.Read))
                {
                    int a = 0;
                    int[] ints = new int[256];
                    {
                        while (a != -1)
                        {
                            a = fs.ReadByte();
                            if (a < 0 || a > 255)
                                break;
                            ints[a]++;
                        }
                        Console.WriteLine("ФАЙЛ 2\n\n");
                        for (int i = 0; i < 256; i++)
                        {
                            Console.WriteLine(ints[i]);
                        }
                        Console.WriteLine("\n\n");
                    }
                }

                Console.ReadKey();
        }
    }
}
