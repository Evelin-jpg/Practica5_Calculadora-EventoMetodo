using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoMetodo
{
    public partial class Form1 : Form
    {
        //Var Globales
        double valor1, valor2;
        string operacion = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // private void btn0_Click(object sender, EventArgs e)
        //{
        // lblNumeros.Text += "0";

        //}

        // private void btn1_Click(object sender, EventArgs e)
        // {
        //    lblNumeros.Text += "1";
        // }

        private void MiMetodo_Click(object sender, EventArgs e)
        {
            string textoBoton = ((Button)sender).Text;
            switch (textoBoton)
               
            {
                case "Sign":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado17 = Math.Sign(valor1);
                    lblNumeros.Text = resultado17 + "";
                    break;

                case "Round":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado16 = Math.Log(valor1);
                    lblNumeros.Text = resultado16 + "";
                    break;

                case "Abs":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado15 = Math.Abs(valor1);
                    lblNumeros.Text = resultado15 + "";
                    break;

                case "Atan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado14 = Math.Atan(valor1);
                    lblNumeros.Text = resultado14 + "";
                    break;

                case "Acos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado13 = Math.Acos(valor1);
                    lblNumeros.Text = resultado13 + "";
                    break;

                case "Asin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado12 = Math.Asin(valor1);
                    lblNumeros.Text = resultado12 + "";
                    break;

                case "Floor":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado11 = Math.Floor(valor1);
                    lblNumeros.Text = resultado11 + "";
                    break;

                case "Ceiling":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado10 = Math.Ceiling(valor1);
                    lblNumeros.Text = resultado10 + "";
                    break;

                case "Truncate":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado9 = Math.Truncate(valor1);
                    lblNumeros.Text = resultado9 + "";
                    break;

                case "Tanh":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado8 = Math.Tanh(valor1);
                    lblNumeros.Text = resultado8 + "";
                    break;

                case "Cosh":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado7 = Math.Cosh(valor1);
                    lblNumeros.Text = resultado7 + "";
                    break;

                case "Exp":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado6 = Math.Exp(valor1);
                    lblNumeros.Text = resultado6 + "";
                    break;

                case "Log10":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado5 = Math.Log10(valor1);
                    lblNumeros.Text = resultado5 + "";
                    break;

                case "Log":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado4 = Math.Log(valor1);
                    lblNumeros.Text = resultado4 + "";
                    break;

                case "Tan":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado3 = Math.Tan(valor1);
                    lblNumeros.Text = resultado3 + "";
                    break;

                case "Cos":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado2 = Math.Cos(valor1);
                    lblNumeros.Text = resultado2 + "";
                    break;

                case "Sin":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado1 = Math.Sin(valor1);
                    lblNumeros.Text = resultado1 + "";
                    break;

                case "R":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultadoR = Math.Sqrt(valor1);
                    lblNumeros.Text = "";
                    break;

                case "+":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                case "-":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                case "X":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                case "/":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                case "=":
                    if (lblNumeros.Text =="")
                    {
                        break;
                    }
                    switch (operacion)
                    {
                     case "+":
                     valor2 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = (valor1 + valor2) + "";
                     break;
                     case "-":
                     valor2 = double.Parse(lblNumeros.Text);
                     lblNumeros.Text = (valor1 - valor2) + "";
                     break;
                     case "X":
                     valor2 = double.Parse(lblNumeros.Text);
                     lblNumeros.Text = (valor1 * valor2) + "";
                     break;
                     case "/":
                     valor2 = double.Parse(lblNumeros.Text);
                     lblNumeros.Text = (valor1 / valor2) + "";                          
                     break;
                    }
                    break;
                    case "AC":
                    lblNumeros.Text = "";
                    break;
                case ".":
                    if (lblNumeros.Text.IndexOf(".") == -1)
                    {
                      lblNumeros.Text += textoBoton;
                    }
                    break;

                default:
                    lblNumeros.Text += textoBoton;
                    break;
            }





        }
    }
}
