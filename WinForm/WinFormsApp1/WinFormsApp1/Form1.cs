using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        string[] operators = {".","+", "-", "*","/", "√"};
        string valuesTxt = "";
        int count = 0;
        public Form1()
        {

            Text = "Calculadora";
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;

            CenterToScreen();


            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            InitializeComponent();
        }


        static Double Eval(String expression)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }
        private void sendValue(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            string value = btn.Text;
            string txtStr = txtResult.Text;
            if (count > 0)
            {
                txtStr = "";
                txtResult.Clear();
                Console.WriteLine(txtResult.Text.ToString());

                count--;
            }
            if (txtStr.Length > 0)
            {
                string lastChar = txtStr[txtStr.Length - 1].ToString();
                if (value == "√")
                {
                    if(operators.Contains(lastChar) && lastChar != "√")
                    {
                        txtResult.Text += value;
                    }
                }
                    else
                    {
                        if (!operators.Contains(lastChar))
                        {
                            txtResult.Text += value;
                        }
                        else
                        {
                            try
                            {
                                double nummer = Convert.ToDouble(value);
                                txtResult.Text += value;
                            }
                            catch
                            {
                                MessageBox.Show("Must ein Nummer sein");
                            }
                        }
                    }
            }
            else if(value != "0" && !operators.Contains(value) || value == "√")
            {
                
                txtResult.Text += value;
            }
        }
        private void clean(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void calculate(object sender, EventArgs e)
        {
            string txtStr = txtResult.Text;
            int length = txtStr.Length;
            if(length > 1)
            {
                if (!operators.Contains(txtStr[length - 1].ToString()))
                {
                    string copy = txtResult.Text.ToString();
                    int nummerSquare = 0;
                    string squareResult = "";
                    for (int i = 0; i < copy.Length; i++)
                    {
                    
                        if(copy[i].ToString() == "√" || nummerSquare != 0)
                        {
                            if(!operators.Contains(copy[i].ToString()) || copy[i].ToString() == "√")
                            {
                                nummerSquare++;
                                squareResult += copy[i];
                                if(i == copy.Length - 1 && !operators.Contains(copy[i].ToString()) )
                                {
                                    nummerSquare = 0;
                                    string c = squareResult.Replace("√", "");
                                    double q = Math.Sqrt(Convert.ToDouble(c));
                                    copy = copy.Replace(squareResult, q.ToString());
                                    squareResult = "";
                                }
                            }
                            else
                            {
                                nummerSquare = 0;
                                string c = squareResult.Replace("√", "");
                                double q = Math.Sqrt(Convert.ToDouble(c));
                                copy = copy.Replace(squareResult, q.ToString());
                                squareResult = "";
                            }

                        }
                    }
                    double result = Eval(copy);
                    txtResult.Text = result.ToString();
                    count++;
                }
            }
        }
    }
}
