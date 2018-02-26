using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace NonSort
{
  public  class GetText
    {
        public string Poisk()
        {      
            string testr = "sssss";
            using (StreamReader read = new StreamReader(Non.path))
            {
                //получение строки из всего файла
                //while(true)
                //{
                //    string temp = read.ReadLine();
                //    if (temp == null)
                //        break;
                //    testr += temp+"\n";
                //}
                char[] b = testr.ToCharArray();
                for (int i=0;i<testr.Length;i++)
                { 
                   // if (i==)
                    string aaa = File.ReadLines(Non.path).Skip(i).First();
                    

                    int position = aaa.IndexOf(Convert.ToString(testr[i]));
                    Console.WriteLine(position);               
                }  
            }       
            return testr;
        }
    }
}
