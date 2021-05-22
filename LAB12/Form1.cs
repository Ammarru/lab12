using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double ProbabilityofGoalsbyBarcelona;
        double ProbabilityofGoalsbyTexas;
        double ProbabilityofGoalsbyManchester;
        double ProbabilityofGoalsbyLiverpool;

        int k1 = 5; 
        int k2 = 5; 
        int k3 = 3; 
        int k4 = 3; 


        int rollingtime = 0;

        public double factorial_Recursion(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rollingtime++;

            textBox14.Text = rollingtime.ToString();
            int newroll = 0;

            double lambda1 = Convert.ToDouble(numericUpDown1.Value);
            double lambda2 = Convert.ToDouble(numericUpDown2.Value);
            double lambda3 = Convert.ToDouble(numericUpDown3.Value);
            double lambda4 = Convert.ToDouble(numericUpDown4.Value);

            textBox1.Text = "Barcelona";
            textBox2.Text = "Texas";
            textBox3.Text = "Manchester City";
            textBox4.Text = "Liverpool";



            double numerator1 = Math.Pow(lambda1, k1);
            double denominator1 = factorial_Recursion(k1);
            double MultiplierNum1 = Math.Exp(-lambda1);

            ProbabilityofGoalsbyBarcelona = (numerator1 / denominator1) * MultiplierNum1;



            double numerator2 = Math.Pow(lambda2, k2);
            double denominator2 = factorial_Recursion(k2);
            double MultiplierNum2 = Math.Exp(-lambda2);

            ProbabilityofGoalsbyTexas = (numerator2 / denominator2) * MultiplierNum2;




            double numerator3 = Math.Pow(lambda3, k3);
            double denominator3 = factorial_Recursion(k3);
            double MultiplierNum3 = Math.Exp(-lambda3);

            ProbabilityofGoalsbyManchester = (numerator3 / denominator3) * MultiplierNum3;



            double numerator4 = Math.Pow(lambda4, k4);
            double denominator4 = factorial_Recursion(k4);
            double MultiplierNum4 = Math.Exp(-lambda4);

            ProbabilityofGoalsbyLiverpool = (numerator4 / denominator4) * MultiplierNum4;


            if (textBox14.Text == "40")
            {


                if (ProbabilityofGoalsbyBarcelona > ProbabilityofGoalsbyTexas)
                {
                    textBox5.Text = "Barcelona";
                    textBox7.Text = "Barcelona";


                }
                else
                {
                    textBox5.Text = "Texas";
                    textBox7.Text = "Texas";

                }

                if (ProbabilityofGoalsbyManchester > ProbabilityofGoalsbyLiverpool)
                {
                    textBox6.Text = "Manchester";
                    textBox8.Text = "Manchester";

                }

                else
                {
                    textBox6.Text = "Liverpool";
                    textBox8.Text = "Liverpool";

                }

            }

            if (textBox14.Text == "70")
            {
                timer1.Stop();
                rollingtime = newroll;
                if (textBox7.Text == "Barcelona" && textBox8.Text == "Manchester")
                {
                    if (ProbabilityofGoalsbyBarcelona > ProbabilityofGoalsbyManchester)
                    {
                        textBox9.Text = "Barcelona";
                    }
                    else
                    {
                        textBox9.Text = "Manchester";

                    }

                }

                if (textBox7.Text == "Barcelona" && textBox8.Text == "Liverpool")
                {
                    if (ProbabilityofGoalsbyBarcelona > ProbabilityofGoalsbyLiverpool)
                    {
                        textBox9.Text = "Barcelona";
                    }
                    else
                    {
                        textBox9.Text = "Liverpool";

                    }

                }


                if (textBox7.Text == "Texas" && textBox8.Text == "Manchester")
                {
                    if (ProbabilityofGoalsbyTexas > ProbabilityofGoalsbyManchester)
                    {
                        textBox9.Text = "Texas";
                    }
                    else
                    {
                        textBox9.Text = "Manchester";

                    }

                }

                if (textBox7.Text == "Texas" && textBox8.Text == "Liverpool")
                {
                    if (ProbabilityofGoalsbyTexas > ProbabilityofGoalsbyLiverpool)
                    {
                        textBox9.Text = "Texas";
                    }
                    else
                    {
                        textBox9.Text = "Liverpool";

                    }

                }

            }

        }
    }
}
    
