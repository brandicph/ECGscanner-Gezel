using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinToHex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                char[] charsToTrim = { ' ', '\t' };
                string str = richTextBox1.Text;
                str = str.Replace(" ", "");
                str = str.Replace("\t", "");
                string[] arr = str.Split('\n');

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < arr.Length; i++)
                {
                    string bin = arr[i].Substring(arr[i].IndexOf(@"00") + @"00".Length);
                    string hex = HexConverted(bin);
                    string line = string.Format("{0} {1} \n", i.ToString("X"), hex);
                    sb.Append(line);
                }

                richTextBox2.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                richTextBox2.Text = "ERROR!!!!!";
                //Console.Write(ex.ToString());
            }

        }

        string HexConverted(string strBinary)
        {
            string strHex = Convert.ToInt32(strBinary, 2).ToString("X8");
            return strHex;
        }
    }
}
