using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace ReadFiles
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        //static void Main(string[] args)
        //{
        //    StreamWriter myWriter = new StreamWriter("pix4d.txt");
        //    StreamReader myReader = new StreamReader("test.txt");
        //    string line = "";
        //    int start_line_num = 0;
        //    string file_name = "IMG";
        //    int file_name_ad = 0;
        //    while ((line = myReader.ReadLine()) != null)
        //    {
        //        for (int j = 0; j < 4; j++)
        //        {
        //            start_line_num = line.IndexOf(',');
        //            line = line.Remove(0, start_line_num + 1);
        //        }
        //        for (int i = 0; i < 6; i++)
        //        {
        //            start_line_num = line.LastIndexOf(',');
        //            line = line.Remove(start_line_num, line.Length - start_line_num);
        //        }
        //        file_name_ad++;
        //        line = file_name + file_name_ad + ".jpg," + line;
        //        myWriter.WriteLine(line);
        //    }
        //    myWriter.Flush();
        //    myWriter.Close();
        //}
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
