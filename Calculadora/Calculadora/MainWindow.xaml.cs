using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Height = 650;
        }
        double a;
        double b;
        string c;

        private void _1_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "1";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "1";
            }
            Operacion.AppendText("1");
        }

        private void _2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "2";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "2";
            }
            Operacion.AppendText("2");
        }

        private void _3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "3";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
            Operacion.AppendText("3");
        }

        private void _4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
            Operacion.AppendText("4");
        }

        private void _5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
            Operacion.AppendText("5");
        }

        private void _6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "6";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
            Operacion.AppendText("6");
        }

        private void _7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "7";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
            Operacion.AppendText("7");
        }

        private void _8_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "8";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
            Operacion.AppendText("8");
        }

        private void _9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "9";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
            Operacion.AppendText("9");
        }

        private void _0_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "0";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
            Operacion.AppendText("0");
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "/";
            Operacion.AppendText(" / ");
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void btnmultiplicacion_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "*";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
            Operacion.AppendText(" x ");
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "-";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
            Operacion.AppendText(" - ");
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "+";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
            Operacion.AppendText(" + ");
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            if (this.txtpantalla.Text.Contains('.') == false)
            {
                this.txtpantalla.Text = this.txtpantalla.Text + ".";
            }
            Operacion.AppendText(".");
        }
        public double factorial_Recursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * factorial_Recursion(number - 1);
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.txtpantalla.Text);
            switch (c)
            {
                case "+":
                    this.txtpantalla.Text = Convert.ToString(b + a);
                    break;

                case "-":
                    txtpantalla.Text = (a - Double.Parse(txtpantalla.Text)).ToString();

                    break;

                case "*":
                    this.txtpantalla.Text = Convert.ToString(b * a);
                    break;

                case "/":
                    this.txtpantalla.Text = Convert.ToString(b / a);
                    break;
                case "^":
                    txtpantalla.Text = Math.Pow(a, Double.Parse(txtpantalla.Text)).ToString();
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            StreamWriter Archivo = new StreamWriter("Ruta\\archivo.txt");
            Archivo.WriteLine("Operaciones: " + a + c + b + "=" + this.txtpantalla.Text);
            Archivo.Flush();
            Archivo.Close();

            System.Diagnostics.Process.Start("Ruta\\archivo.txt");
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(null);
            b = Convert.ToDouble(null);
            this.txtpantalla.Text = "";
            Operacion.Text = "";
        }
        private void setHigh(double valor)
        {
            valor = this.Height;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (this.Height == 650)
            {
                this.Height = 825;
                potencia.Visibility= Visibility.Visible;
                log.Visibility = Visibility.Visible;
                cos.Visibility = Visibility.Visible;
                sen.Visibility = Visibility.Visible;
                tan.Visibility = Visibility.Visible;
                raiz.Visibility = Visibility.Visible;
                fact.Visibility = Visibility.Visible;
                pi.Visibility = Visibility.Visible;
            }
            else
            {
                this.Height = 650;
                potencia.Visibility = Visibility.Hidden;
                log.Visibility = Visibility.Hidden;
                cos.Visibility = Visibility.Hidden;
                sen.Visibility = Visibility.Hidden;
                tan.Visibility = Visibility.Hidden;
                raiz.Visibility = Visibility.Hidden;
                fact.Visibility = Visibility.Hidden;
                pi.Visibility = Visibility.Hidden;
            }
            
        }
        private void btnpotencia_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "^";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
            Operacion.AppendText(" ^ ");
        }
        private void btnlog_Click(object sender, EventArgs e)
        {
            Operacion.AppendText(" log ");
            a = Convert.ToDouble(this.txtpantalla.Text);
            this.txtpantalla.Text = Math.Log(a).ToString();
        }
        private void btncos_Click(object sender, EventArgs e)
        {
            Operacion.AppendText(" cos ");
            a = Convert.ToDouble(this.txtpantalla.Text);
            this.txtpantalla.Text = Math.Cos(a).ToString();
            this.txtpantalla.Focus();
        }
        private void btnsen_Click(object sender, EventArgs e)
        {
            Operacion.AppendText(" sen ");
            a = Convert.ToDouble(this.txtpantalla.Text);
            this.txtpantalla.Text = Math.Sin(a).ToString();
            this.txtpantalla.Focus();
        }
        private void btntan_Click(object sender, EventArgs e)
        {
            Operacion.AppendText(" tan ");
            a = Convert.ToDouble(this.txtpantalla.Text);
            this.txtpantalla.Text = Math.Tan(a).ToString();
            this.txtpantalla.Focus();
        }
        private void btnraiz_Click(object sender, EventArgs e)
        {
            Operacion.AppendText(" raiz ");

            a = Convert.ToDouble(this.txtpantalla.Text);
            this.txtpantalla.Text = Math.Sqrt(a).ToString();
            this.txtpantalla.Focus();
        }
        private void btnfact_Click(object sender, EventArgs e)
        {
            Operacion.AppendText(" ! ");
            a = Convert.ToDouble(this.txtpantalla.Text);
            this.txtpantalla.Text = (factorial_Recursion((int)a)).ToString();
            this.txtpantalla.Focus();
        }
        private void btnpi_Click(object sender, EventArgs e)
        {
            Operacion.AppendText(" pi ");
            this.txtpantalla.Text = (Math.PI).ToString();
            a = Convert.ToDouble(this.txtpantalla.Text);

        }

    }

    
}
