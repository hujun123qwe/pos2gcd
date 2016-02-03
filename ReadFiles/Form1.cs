using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace ReadFiles
{
    public partial class MainForm : Form
    {
        string pos_file_name;
        string gsd_file_name;
        StreamReader pos_reader;
        StreamWriter gsd_writer;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            if(open_pos.ShowDialog() == DialogResult.OK)
            {
                pos_file_name = open_pos.FileName;
                pos_reader = new StreamReader(pos_file_name);
            }
            else
            {
                MessageBox.Show("请选择文件");
            }
            string line_reader;
            while ((line_reader = pos_reader.ReadLine()) != null)
            {
                txt_pos.AppendText(line_reader);
                txt_pos.AppendText("\r\n");
            }
        }

        private void open_pos_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("文件加载成功");
        }

        private void txt_file_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (txt_file_name.Text == String.Empty)
            {
                MessageBox.Show("请输入文件名");
            }
            pos_reader = new StreamReader(pos_file_name);
            string file_name = txt_file_name.Text;
            string line = "";
            int start_line_num = 0;
            int file_number = int.Parse(txt_file_number.Text);
            int file_name_start = int.Parse(txt_file_name_start.Text);
            int end_file_name = file_name_start + file_number;
            string[] plan_some = new string[3];
            while ((line = pos_reader.ReadLine()) != null)
            {
                for (int j = 0; j < 4; j++)
                {
                    start_line_num = line.IndexOf(',');
                    line = line.Remove(0, start_line_num + 1);
                }
                start_line_num = line.LastIndexOf(',');
                line = line.Remove(start_line_num, line.Length - start_line_num);
                
                for(int i = 0; i < 3; i++)
                {
                    start_line_num = line.LastIndexOf(',');
                    plan_some[i] = line.Substring(start_line_num, line.Length - start_line_num);
                    line = line.Remove(start_line_num, line.Length - start_line_num);
                }
                for(int k = 0; k < 3; k++)
                {
                    start_line_num = line.LastIndexOf(',');
                    line = line.Remove(start_line_num, line.Length - start_line_num);
                }
                line += line + plan_some[0] + plan_some[1] + plan_some[2];
                if (file_name_start > end_file_name)
                {
                    MessageBox.Show("文件名大于文件数");
                }
                if (file_name_start < 10)
                {
                    line = file_name + "0000" + file_name_start + ".jpg," + line;
                }
                else if (file_name_start < 100)
                {
                    line = file_name + "000" + file_name_start + ".jpg," + line;
                }else if (file_name_start < 1000)
                {
                    line = file_name + "00" + file_name_start + ".jpg," + line;
                }else if (file_name_start < 10000)
                {
                    line = file_name + "0" + file_name_start + ".jpg," + line;
                }
                file_name_start++;
                txt_gsd.AppendText(line);
                txt_gsd.AppendText("\r\n");
            }
        }

        private void btn_gsd_Click(object sender, EventArgs e)
        {
            if(save_gsd.ShowDialog() == DialogResult.OK)
            {
                gsd_file_name = save_gsd.FileName;
                gsd_writer = new StreamWriter(gsd_file_name);
                gsd_writer.Write(txt_gsd.Text);
                gsd_writer.Flush();
                gsd_writer.Close();
                MessageBox.Show("保存成功");
            }
        }
    }
}
