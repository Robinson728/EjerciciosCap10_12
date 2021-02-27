using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosCap10_12.Capitulo_10.UI;

namespace EjerciciosCap10_12
{
    public partial class Capitulo10 : Form
    {
        public Capitulo10()
        {
            InitializeComponent();
        }

        private void Ejercicio1Button_Click(object sender, EventArgs e)
        {
            Ejercicio1_Inventario ejercicio1 = new Ejercicio1_Inventario();
            ejercicio1.Show();
        }

        private void Ejercicio2Button_Click(object sender, EventArgs e)
        {
            Ejercicio2_Estudiantes ejercicio2 = new Ejercicio2_Estudiantes();
            ejercicio2.Show();
        }

        private void Ejercicio3Button_Click(object sender, EventArgs e)
        {
            Ejercicio3_Poligonos ejercicio3 = new Ejercicio3_Poligonos();
            ejercicio3.Show();
        }
    }
}
