using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EjerciciosCap10_12.Capitulo_10.Clases;

namespace EjerciciosCap10_12.Capitulo_10.UI
{
    public partial class Ejercicio3_Poligonos : Form
    {
        public Ejercicio3_Poligonos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            LadosTextBox.Clear();
            ApotematextBox.Clear();
            ErrorProvider.Clear();
        }
        private bool Validar()
        {
            bool paso = true;

            if (LadosTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(LadosTextBox, "No puede estar vacio");
                LadosTextBox.Focus();
                paso = false;
            }
            if (ApotematextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(ApotematextBox, "No puede estar vacio");
                ApotematextBox.Focus();
                paso = false;
            }

            return paso;
        }
        private void CalcularButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            Poligonos poligonos = new Poligonos
            (
                    lados: Convert.ToSingle(LadosTextBox.Text),
                    apotema2: Convert.ToSingle(ApotematextBox.Text)
            );

            ResultadotextBox.AppendText(Convert.ToString(poligonos.TOString()) + "\t");

            Limpiar();
        }
    }
}
