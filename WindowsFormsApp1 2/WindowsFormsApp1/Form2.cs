using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

       

        public Form2()
        {
            InitializeComponent();
        }


        string [] textSplit;
        bool CompleteEqual = false;
        //string text = "5+2";
        //void check()
        //{
        //    var s = text.Split('+');
        //    foreach (string text in s)
        //    {
        //        var number = Int32.Parse(text);
        //    }
        //}
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string [] checkTextSplit = textBox1.Text.Split(new char[] { '+', '-', '*', '/', '=' });
            if (textBox1.Text == "")
            {
                CompleteEqual = false;
            }
            if (!textBox1.Text.Equals("") && CompleteEqual == false)
            {
                string text = textBox1.Text;
                textSplit = text.Split(new char[] { '+', '-', '*', '/', '=' });
                string textEqual = textBox1.Text;
                textEqual.Split('=');
                int i = 0;
                char sign = '#';
                char CheckQueryEqual = '#';

                foreach (var symbol in text)
                {
                    try
                    {
                        int number = Int32.Parse(symbol + "");
                        Console.WriteLine(symbol);
                        Console.WriteLine(number);
                    }


                    catch (FormatException ex)
                    {

                        if (symbol == '+')
                        {
                            sign = '+';
                        }
                        if (symbol == '-')
                        {
                            sign = '-';
                        }
                        if (symbol == '*')
                        {
                            sign = '*';
                        }
                        if (symbol == '/')
                        {
                            sign = '/';
                        }
                        if (symbol == '=')
                        {
                            CheckQueryEqual = '=';
                        }
                        Console.WriteLine(ex);
                    }

                    if (CheckQueryEqual == '=')
                    {
                        if (sign == '+')
                        {
                            double sum = Convert.ToDouble(textSplit[0]) + Convert.ToDouble(textSplit[1]);
                            CompleteEqual = true;
                            textBox1.Text += sum.ToString();
                            sign = '#';
                        }
                        if (sign == '-')
                        {
                            double sum = Convert.ToDouble(textSplit[0]) - Convert.ToDouble(textSplit[1]);
                            CompleteEqual = true;
                            textBox1.Text += sum.ToString();
                            sign = '#';
                        }
                        if (sign == '*')
                        {
                            double sum = Convert.ToDouble(textSplit[0]) * Convert.ToDouble(textSplit[1]);
                            CompleteEqual = true;
                            textBox1.Text += sum.ToString();
                            sign = '#';
                        }
                        if (sign == '/')
                        {
                            double sum = Convert.ToDouble(textSplit[0]) / Convert.ToDouble(textSplit[1]);
                            CompleteEqual = true;
                            textBox1.Text += sum.ToString();
                            sign = '#';
                        }

                    }
                }
            }


        }
 

private void Form2_Load(object sender, EventArgs e)
{

}
    }
}
