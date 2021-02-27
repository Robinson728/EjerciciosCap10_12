using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosCap10_12.Capitulo_10;
using EjerciciosCap10_12.Capitulo_12;

namespace EjerciciosCap10_12
{
    public partial class MainForms : Form
    {
        public MainForms()
        {
            InitializeComponent();
        }

        private void Capitulo10Button_Click(object sender, EventArgs e)
        {
            Capitulo10 ejercicios = new Capitulo10();
            ejercicios.Show();
        }

        private void Capitulo12Button_Click(object sender, EventArgs e)
        {
            Capitulo12 capitulo12 = new Capitulo12();
            capitulo12.Show();
        }
    }
}
