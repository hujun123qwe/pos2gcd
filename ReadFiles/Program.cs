using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                StreamReader myReader = new StreamReader("test.txt");
                string line = "";
                string cmd_line;
                int cmd_line_num = 0;
                Console.WriteLine("Please input line num");
                cmd_line = Console.ReadLine();
                cmd_line_num = int.Parse(cmd_line);
                for(int i=0; i<cmd_line_num-1; i++)
                {
                    line = myReader.ReadLine();           
                }
                line = myReader.ReadLine();
                Console.WriteLine(line);
                

            }
        }
    }
}
