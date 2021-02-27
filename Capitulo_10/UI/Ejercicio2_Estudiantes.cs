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
    public partial class Ejercicio2_Estudiantes : Form
    {
        public Ejercicio2_Estudiantes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MatriculatextBox.Clear();
            NombreTextBox.Clear();
            SemestreTextBox.Clear();
            IndicetextBox.Clear();
            CarreraTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            ErrorProvider.Clear();
        }
        private bool Validar()
        {
            bool paso = true;

            if (MatriculatextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(MatriculatextBox, "No puede estar vacio");
                MatriculatextBox.Focus();
                paso = false;
            }
            if (NombreTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(NombreTextBox, "No puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }
            if (SemestreTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(SemestreTextBox, "No puede estar vacio");
                SemestreTextBox.Focus();
                paso = false;
            }
            if (IndicetextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(IndicetextBox, "No puede estar vacio");
                IndicetextBox.Focus();
                paso = false;
            }
            if (CarreraTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(CarreraTextBox, "No puede estar vacio");
                CarreraTextBox.Focus();
                paso = false;
            }
            if (TelefonomaskedTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(TelefonomaskedTextBox, "No puede estar vacio");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            int n = dataGridView1.Rows.Add();
            Estudiantes estudiante = new Estudiantes();
            
            estudiante.Matricula = Convert.ToInt32(MatriculatextBox.Text);
            estudiante.NombreCompleto = NombreTextBox.Text;
            estudiante.Semestre = Convert.ToInt32(SemestreTextBox.Text);
            estudiante.Indice = Convert.ToSingle(IndicetextBox.Text);
            estudiante.Carrera = CarreraTextBox.Text;
            estudiante.Telefono = TelefonomaskedTextBox.Text;
            estudiante.FechaNacimiento = FechadateTimePicker.Value;

            dataGridView1.Rows[n].Cells[0].Value = MatriculatextBox.Text;
            dataGridView1.Rows[n].Cells[1].Value = NombreTextBox.Text;
            dataGridView1.Rows[n].Cells[2].Value = SemestreTextBox.Text;
            dataGridView1.Rows[n].Cells[3].Value = IndicetextBox.Text;
            dataGridView1.Rows[n].Cells[4].Value = CarreraTextBox.Text;
            dataGridView1.Rows[n].Cells[5].Value = TelefonomaskedTextBox.Text;
            dataGridView1.Rows[n].Cells[6].Value = FechadateTimePicker.Text;

            Limpiar();
        }
    }
}
