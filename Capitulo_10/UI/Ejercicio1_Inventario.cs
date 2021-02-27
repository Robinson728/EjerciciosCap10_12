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
    public partial class Ejercicio1_Inventario : Form
    {
        public Ejercicio1_Inventario()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool paso = true;

            if (CodigoTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(CodigoTextBox, "No puede estar vacio");
                CodigoTextBox.Focus();
                paso = false;
            }
            if (DescripcionTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(DescripcionTextBox, "No puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (StockTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(StockTextBox, "No puede estar vacio");
                StockTextBox.Focus();
                paso = false;
            }
            if (CategoriaTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(CategoriaTextBox, "No puede estar vacio");
                CategoriaTextBox.Focus();
                paso = false;
            }
            if (CompraTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(CompraTextBox, "No puede estar vacio");
                CompraTextBox.Focus();
                paso = false;
            }
            if (VentaTextBox.Text == string.Empty)
            {
                ErrorProvider.SetError(VentaTextBox, "No puede estar vacio");
                VentaTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            int n = dataGridView1.Rows.Add();
            Inventario inventario = new Inventario();

            inventario.CodigoProducto = Convert.ToInt32(CodigoTextBox.Text);
            inventario.Descripcion = DescripcionTextBox.Text;
            inventario.Stock = Convert.ToInt32(StockTextBox.Text);
            inventario.Categoria = CategoriaTextBox.Text;
            inventario.PrecioCompra = Convert.ToSingle(CompraTextBox.Text);
            inventario.PrecioVenta = Convert.ToSingle(VentaTextBox.Text);

            dataGridView1.Rows[n].Cells[0].Value = CodigoTextBox.Text;
            dataGridView1.Rows[n].Cells[1].Value = DescripcionTextBox.Text;
            dataGridView1.Rows[n].Cells[2].Value = StockTextBox.Text;
            dataGridView1.Rows[n].Cells[3].Value = CategoriaTextBox.Text;
            dataGridView1.Rows[n].Cells[4].Value = CompraTextBox.Text;
            dataGridView1.Rows[n].Cells[5].Value = VentaTextBox.Text;

            Limpiar();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            CodigoTextBox.Clear();
            DescripcionTextBox.Clear();
            StockTextBox.Clear();
            CategoriaTextBox.Clear();
            CompraTextBox.Clear();
            VentaTextBox.Clear();
            ErrorProvider.Clear();
        }
    }
}
