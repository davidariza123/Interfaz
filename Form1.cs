using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazP
{
    public partial class Form1 : Form
    {
        private double Value1;
        private double Value2;
        private int Option;
        private string ValueText;
        public Form1()
        {
            InitializeComponent();


            ValueText = "";
            button13.Visible = false;
            textBoard2.Visible = false;
            button12.Visible = false;
            listBox1.Visible = false;
            button14.Visible = false;
            button15.Visible = false;

        }

        private void getButtonValue(Button button)
        {

            ValueText += button.Text;

            textBoard.Text = ValueText;

        }
        private void getOption(int Value)
        {

            try
            {

                Option = Value;
                Value1 = Double.Parse(textBoard.Text);
                ValueText = "";
                textBoard.Clear();

            }
            catch (Exception ex)
            {
                textBoard.Text = ex.Message;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getButtonValue(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getButtonValue(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getButtonValue(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getButtonValue(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            getButtonValue(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            getButtonValue(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            getButtonValue(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            getButtonValue(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            getButtonValue(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            getButtonValue(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ValueText = "";
            textBoard.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Value1 = double.Parse(textBoard.Text);
                textBoard.Text = (Value1*0, Value1 * 1, Value1 * 2, Value1 * 3, Value1 * 4, Value1 * 5, Value1 * 6, Value1 * 7, Value1 * 8, Value1 * 9).ToString();

            }
            catch (Exception ex)
            {
                textBoard.Text = ex.Message;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int x, s = 1;
            x = Convert.ToInt32(textBoard.Text); 
            if (x == 0)
            {
                textBoard.Text = s.ToString();
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    s = s * i;
                    textBoard2.Text = s.ToString();
                   
                }
            }



        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            Value1 = double.Parse(textBoard.Text);

            int a = 0;
            int b = 1;
            int c = 1;

           
            for (int i = 0; i <= Value1; i++)
            {
                listBox1.Items.Add(a.ToString());
                a = b;
                b = c;
                c = a + b;

            }

        }


      

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {

            button13.Visible = true;
            textBoard2.Visible = true;
            button12.Visible = false;
            listBox1.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            textBoard2.Visible = false;
            button12.Visible = false;
            listBox1.Visible = true;
            button14.Visible = true;
            button15.Visible = false;
        }

        private void multiplosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            textBoard2.Visible = false;
            button12.Visible = true;
            listBox1.Visible = false;
            button14.Visible = false;
            button15.Visible = false;

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                Value1 = double.Parse(textBoard.Text);

                Value2 = Math.Pow(Value1, 2);

                textBoard.Text = (Value2 * 0, Value2 * 1, Value2 * 2, Value2 * 3, Value2* 4, Value2 * 5, Value2 * 6, Value2 * 7, Value2 * 8, Value2 * 9).ToString();

            }
            catch (Exception ex)
            {
                textBoard.Text = ex.Message;

            }




        }


        

        private void divisoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            textBoard2.Visible = false;
            button12.Visible = false;
            listBox1.Visible = false;
            button14.Visible = false;
            button15.Visible = true;

        }
    }
}
