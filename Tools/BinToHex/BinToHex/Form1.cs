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

        private void btnBinHex_Click(object sender, EventArgs e)
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
                    if (arr[i].Length == 0)
                        continue;
                    string bin = arr[i].Substring(arr[i].IndexOf(@"00") + @"00".Length);
                    string hex = BinToHex(bin, 8);
                    string line = string.Format("{0} {1}\n", (i+1).ToString("X"), hex);
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

        string BinToHex(string strBinary, int length)
        {
            string strHex = Convert.ToInt32(strBinary, 2).ToString(string.Format("X{0}",length));
            return strHex;
        }

        string HexToBin(string strHex, int length)
        {
            string strBinary = Convert.ToString(Convert.ToInt64(strHex, 16), 2).PadLeft(length, '0');
            return strBinary;
        }

        private void btnHexBin_Click(object sender, EventArgs e)
        {

            try
            {
                string str = richTextBox2.Text;
                string[] arr = str.Split('\n');

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i].Length == 0)
                        continue;

                    arr[i] = arr[i].Replace("\t", "");
                    string[] lineval = arr[i].Split(' ');

                    string hex = "";
                    if (lineval.Length > 1)
                    {
                        hex = lineval[1].Replace(" ", "");
                    }
                    else
                    {
                        hex = lineval[0].Replace(" ", ""); ;
                    }

                    string bin = HexToBin(hex, 32);
                    string line = string.Format("{0}\n", bin);
                    sb.Append(line);
                }

                richTextBox1.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "ERROR!!!!!";
                //Console.Write(ex.ToString());
            }
        }
    }
}
