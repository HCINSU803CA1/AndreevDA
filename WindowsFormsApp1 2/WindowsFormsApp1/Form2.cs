using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pol
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        


        private char GetSign(char character)
        {

                

            return character;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            char ch = ' ';

            if ((!textBox1.Text.Equals("")) && (!textBox1.Text.EndsWith("=")))
            {
                List<double> list = new List<double>();
                first.Replace(" ", "");

                var s = first;
                
                foreach (var sign in s)
                {
                    
                    if (sign == '+')
                    {
                        ch = '+';
                    }
                    if (sign == '*')
                    {
                        ch ='*';
                    }
                    if (sign == '/')
                    {
                        ch= '/';
                    }
                    if (sign == '-')
                    {
                        ch = '-';
                    }
                    if (sign == '=')
                    {
                        ch = '=';
                    }
                    var stringArray = s.Split(new char[] { '+', '-', '*', '/' });
                    foreach (var text in stringArray)
                    {
                        if (!text.Equals(""))
                        {
                            Console.WriteLine("ret" + ch);
                            double number = double.Parse(text);
                            Console.WriteLine(number);

                            list.Add(number);
                            //if (Array[0] == 0)
                            //{
                            //    Array[0] = number;
                            //}
                            //else
                            //{
                            //    Array[1] = number;
                            //}
                        }
                        
                           
                    }
                    
                }
                Console.WriteLine("ret" + ch);
                label1.Text = "0";
                if (ch == '+')

                {

                    double sum = list[0] + list[1];
                    label1.Text = (Convert.ToString(sum));


                }

                if (ch == '-')
                {

                    double minus = list[0] - list[1];
                    label1.Text = (Convert.ToString(minus));


                }

                if (ch == '*')
                {

                    double multiply = list[0] * list[1];
                    label1.Text = (Convert.ToString(multiply));


                }

                if (ch == '/')
                {

                    double devide = list[0] / list[1];
                    label1.Text = (Convert.ToString(devide));


                }
            }
                 
                
            
            
        }
    }
}
