using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Пара_23._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string way = @"C:\Users\nebo5\OneDrive\Рабочий стол\VS\С#\Пара_23.03\2303.txt";
        //StreamReader sr = new StreamReader(way);
        const string way2 = @"C:\Users\nebo5\OneDrive\Рабочий стол\VS\С#\Пара_23.03\2305.txt";
        //StreamWriter sw = new StreamWriter(way2);
        //string str = "";

        StreamReader sr = new StreamReader(way);
        StreamWriter sw = new StreamWriter(way2);
        string str, str1, str2, str3, str4;

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Add(sr.ReadLine());
            //sr.WriteLine(str);

            //try
            //{
            //    str = sr.ReadLine();
            //    sw.WriteLine(str);
            //}
            //catch
            //{
            //    MessageBox.Show("Ошибка");
            //}

            str1 = sr.ReadLine();
            str2 = sr.ReadLine();

            sw.WriteLine("ghjgh");
            //sw.WriteLine(Convert.ToInt32(str3) + Convert.ToInt32(str4));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Закрыть?");
            sr.Close();
        }
    }
}
