using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCalculadora
{
    public partial class Form1 : Form
    {
        double primero;
        double segundo;
        string operador;
        public Form1()
        {
            InitializeComponent();
        }
        Clases.ClaseSuma obj1 = new Clases.ClaseSuma();
        Clases.ClaseResta obj2 = new Clases.ClaseResta();
        Clases.ClaseMultiplicacion obj3 = new Clases.ClaseMultiplicacion();
        Clases.ClaseDivision obj4 = new Clases.ClaseDivision();

        private void agregarnum(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            if(Pantalla.Text == "0")
            {
                Pantalla.Text = "";

            }
            Pantalla.Text = Pantalla.Text + boton.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void BotonN0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void BotonN1_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void BotonN2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void BotonN3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void BotonN4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void BotonN5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void BotonN6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void BotonN8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void BotonN9_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void BotonPunto_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ".";
        }

        private void BotonSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void BotonResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void BotonMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void BotonDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Pantalla.Text);
            Pantalla.Clear();
        }

        private void BotonResultado_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj1.Suma((primero), (segundo));
                    Pantalla.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj2.Resta((primero), (segundo));
                    Pantalla.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicacion((primero), (segundo));
                    Pantalla.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Division((primero), (segundo));
                    Pantalla.Text = Div.ToString();
                    break;
            }
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
            Pantalla.Text = "0";
        }

        private void BotonBorrar_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length == 1)
            {
                Pantalla.Text = "0";
            }
            else
            {
                Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
                
            }
        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
