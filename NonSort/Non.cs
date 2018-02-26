using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.IO;

namespace NonSort
{
    class Non
    {
      public const  string path = @"D:\Nonesort.txt";
        public void Roks()
        {
            for (int ii = 0; ii < 5; ii++)
            {
                Random rand = new Random();
                List<string> list = new List<string>() {"A","B" ,"C", "D", "E", "F", "G","H","I","J","K","L","M","N","O","P","Q",
            "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g",
            "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "w", "z", " ","y"};
                list = list.OrderBy(v => rand.Next()).ToList();
                StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Append));
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        sw.Write(list[i] );
                    }
                    // sw.Write(" ");
                    sw.WriteLine();
                }
                Thread.Sleep(4);
                sw.Close();
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            using (FileStream rs = File.OpenRead(path))
            {
                byte[] array = new byte[rs.Length];
                rs.Read(array, 0, array.Length);
                string text1 = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine("Текст из файла: {0}", text1);
            }
        }
    }
}
