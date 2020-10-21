using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }
        Double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }
        Double tan(double x)
        {
            return (Math.Tan(x * Math.PI / 180.0));
        }

        double atan(double x)
        {
            return (Math.Atan(x) * 180 / Math.PI);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //use try-catch to avoid input errors
            try
            {
                //read values for force and angle from textboxes
                double Force = double.Parse(textBox1.Text);
                double Angle = double.Parse(textBox2.Text);
                //calculate Fx and Fy using equations Fx = Fcos and Fy = Fsin
                double Fx = Force * cos(Angle);
                double Fy = Force * sin(Angle);
                //Output solutions to label1 amd label2
                label1.Text = "Fx = " + Fx;
                label2.Text = "Fy = " + Fy;
            }
            catch
            {
                MessageBox.Show("Error on imput");
            }

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //use try-catch to avoid input errors
            try
            {
                //read values for force and angle from textboxes
                double Fx = double.Parse(textBox3.Text);
                double Fy = double.Parse(textBox4.Text);
                //calculate Fx and Fy using equations Fx = Fcos and Fy = Fsin
                double Force = Math.Sqrt(Fx * Fx + Fy * Fy);
                double Angle = atan(Fy/Fx);
                //Output solutions to label1 amd label2
                label5.Text = "Angle = " + Angle;
                label6.Text = "Force = " + Force;
            }
            catch
            {
                MessageBox.Show("Error on imput");
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
