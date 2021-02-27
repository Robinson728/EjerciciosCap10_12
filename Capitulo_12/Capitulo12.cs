using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace EjerciciosCap10_12.Capitulo_12
{
    public partial class Capitulo12 : Form
    {
        public Capitulo12()
        {
            InitializeComponent();
        }

        private void Ejercicio1button_Click(object sender, EventArgs e)
        {
            Ejercicio1_2_Factorial ejercicio1 = new Ejercicio1_2_Factorial();
            ejercicio1.Show();
        }
    }
}
