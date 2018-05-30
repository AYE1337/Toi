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
                double count = 0;
                double FRAGentropy = 0;
                double entropy = 0;
                int[] ints = new int[256];
                {
                    while (a != -1)
                    {
                        a = fs.ReadByte();
                        if (a < 0 || a > 255)
                            break;
                        ints[a]++;
                        count++;
                    }
                    Console.WriteLine("ФАЙЛ 2\n\n");
                    for (int i = 0; i < 256; i++)
                    {
                        Console.WriteLine(ints[i]);
                        FRAGentropy = ints[i] / count;
                        if (FRAGentropy != 0)
                             entropy = entropy + (FRAGentropy * (-Math.Log(FRAGentropy, 2)));
                    }
                    Console.WriteLine("\n\n");
                    Console.WriteLine("Энтропия файла равна " + entropy);
                }
            }


            using (FileStream fs = new FileStream(@"G:\ТОИ_КЛИМОВ_ДЗ1.wav", FileMode.Open, FileAccess.Read))
                {
                    int a = 0;
                    double count = 0;
                    double FRAGentropy = 0;
                    double entropy = 0;
                    int[] ints = new int[256];
                    {
                        while (a != -1)
                        {
                            a = fs.ReadByte();
                            if (a < 0 || a > 255)
                                break;
                            ints[a]++;
                            count++;
                        }
                        Console.WriteLine("ФАЙЛ 2\n\n");
                        for (int i = 0; i < 256; i++)
                        {
                            Console.WriteLine(ints[i]);
                        FRAGentropy = ints[i] / count;
                        if (FRAGentropy != 0)
                            entropy = entropy + (FRAGentropy * (-Math.Log(FRAGentropy, 2)));
                        }
                        Console.WriteLine("\n\n");
                    Console.WriteLine("Энтропия файла равна " + entropy);
                    }
                }

                Console.ReadKey();
        }
    }
}
