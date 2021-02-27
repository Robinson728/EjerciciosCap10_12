using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EjerciciosCap10_12.Capitulo_12
{
    public partial class Ejercicio1_2_Factorial : Form
    {
        public Ejercicio1_2_Factorial()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(NumerotextBox.Text);
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            ResultadotextBox.AppendText(factorial.ToString());
            Debug.WriteLine(factorial.ToString());
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            NumerotextBox.Clear();
            ResultadotextBox.Clear();
        }
    }
}
