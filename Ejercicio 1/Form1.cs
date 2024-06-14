using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {

        static double[] numeros = new double[100];
        static int contador;
        static double promedio, num;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            num = Convert.ToInt32(tbIngresar.Text);
            guardarnumero(num);
            tbIngresar.Clear();
        }

        static void guardarnumero(double numero)
        {
            numeros[contador] = numero;
            contador++;
        }

        static void calcularpromedio()
        {

            double acum = 0;
            for (int i = 0; i < contador; i++)
            {
                acum += numeros[i];
            }

            promedio = acum / (contador - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (contador == 1)
            {
                lbpromedio.Text = Convert.ToString(num);
            }
            else
            {
                calcularpromedio();
                lbpromedio.Text = Convert.ToString(promedio);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(tbbuscar.Text);
            if (rbsecuencial.Checked)
            {
                int pos;
                pos = busquedasecuencial(num); 
                if (pos != -1)
                {
                    lbresultados.Items.Clear();
                    lbresultados.Items.Add($"Numero: {numeros[pos]}");
                    lbresultados.Items.Add ($"Posicion: {pos+1} de la lista");

                }
                else
                {
                    lbresultados.Items.Clear();
                    lbresultados.Items.Add($"¡El numero no se encontro!");
                }
                
            }
            else if (rbbinario.Checked)
            {
                Burbuja(numeros);
                int ret = -1;
                ret = BusquedaBiseccion(numeros, num);
                if (ret != -1)
                {
                    lbresultados.Items.Clear();
                    lbresultados.Items.Add($"Numero: {numeros[ret]}");
                    lbresultados.Items.Add($"Posicion: {ret+1} de la lista");
                }
                else
                {
                    lbresultados.Items.Clear();
                    lbresultados.Items.Add($"¡El numero no se encontro!");
                }
            }
        }

        static int busquedasecuencial(int num)
        {
            int pos = -1;
            for (int i=0; i<contador; i++)
            {
                if (numeros[i] == num)
                {
                    pos = i;
                }
            }

            return pos;
        }

        private void Burbuja(double[] valores)
        {
            int i, j;
            double aux;
            for (i = 0; i < contador - 1; i++)
            {
                for (j = i + 1; j < contador; j++)
                {
                    if (valores[i] > valores[j])
                    {
                        aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbresultados.Items.Clear();
            for(int i = 0; i<contador; i++)
            {
                lbresultados.Items.Add(numeros[i]);
            }
        }

        public int BusquedaBiseccion(double[] datos, double buscado)
        {
            int izq, der, medio, ret = -1;
            bool encontrado = false;
            izq = 0;
            der = contador-1;
            do
            {
                medio = (izq + der) / 2; //índice del medio
                if (datos[medio] == buscado)
                {
                    encontrado = true;
                }
                else if (datos[medio] < buscado)
                {
                    izq = medio + 1; //Cambio limite izquierdo
                }
                else
                {
                    der = medio - 1; //Cambio limite derecho
                }
            } while ((izq <= der) && (!encontrado));
            if (encontrado)
                ret = medio;
            return ret;
        }
    }
}
