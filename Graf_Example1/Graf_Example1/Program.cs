using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;


namespace Graf_Example1
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            String[] cols = new string[20];
            int[,] grafs = new int[82 , 82];

            StreamReader graf = new StreamReader("C:\\Users\\Yagmur\\Documents\\Visual Studio 2012\\Projects\\Graf_Example\\Graf_Example1\\graf.txt");

            String full = graf.ReadToEnd();
            String[] rows = full.Split('\n');

            for (int i = 0; i < 82; i++)
            {
                for (int j = 0; j < 82; j++)
                {
                    grafs[i, j] = 0;
                }
            }

            for (int i = 0; i < rows.Length; i++)
            {
                cols = rows[i].Split(',');
                for (int j = 1; j < cols.Length-1; j++)
                {
                    grafs[i, Convert.ToInt32(cols[j]) - 1] = 1;
                }
                    
            }
            

            for (int i = 0; i < 82; i++)
            {
                for (int j = 0; j < 82; j++)
                {
                    Console.Write(grafs[i, j].ToString() + ' ' );
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
