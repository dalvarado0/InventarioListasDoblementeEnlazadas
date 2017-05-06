using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvetarioDoblementeEnlazado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inventario almacen = new Inventario();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto item = new Producto();
            try
            {
                item.codigo = Convert.ToInt32(txbCodigo.Text);
                item.setNombre(txbNombre.Text);
                item.catidad = Convert.ToInt32(txbCandidad.Text);
                item.costo = Convert.ToInt32(txbPrecio.Text);
            }
            catch
            {
                MessageBox.Show("Revise los datos ingresados.");
            }

            almacen.agregar(item);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Producto item = almacen.buscar(Convert.ToInt32(txbBuscar.Text));

            if (item == null)
            {
                txbReporte.Text = "Producto no encontrado";
            }
            else
                txbReporte.Text = item.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            almacen.borrar(Convert.ToInt32(txbCodigo.Text));
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            Producto item = new Producto();
            try
            {
                item.codigo = Convert.ToInt32(txbCodigo.Text);
                item.setNombre(txbNombre.Text);
                item.catidad = Convert.ToInt32(txbCandidad.Text);
                item.costo = Convert.ToInt32(txbPrecio.Text);
            }
            catch
            {
                MessageBox.Show("Revise los datos ingresados.");
            }
            almacen.agregarInicio(item);
        }

        private void btnDeleteFirst_Click(object sender, EventArgs e)
        {
            almacen.borrarInicio();
        }

        private void btnDeleteLast_Click(object sender, EventArgs e)
        {
            almacen.borrarUltimo();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Producto item = new Producto();
            try
            {
                item.codigo = Convert.ToInt32(txbCodigo.Text);
                item.setNombre(txbNombre.Text);
                item.catidad = Convert.ToInt32(txbCandidad.Text);
                item.costo = Convert.ToInt32(txbPrecio.Text);
            }
            catch
            {
                MessageBox.Show("Revise los datos ingresados.");
            }

            almacen.insertarProducto(item, Convert.ToInt32(txbPosicion.Text));
            
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txbReporte.Text = almacen.reporte();
        }

        private void btnReporteInv_Click(object sender, EventArgs e)
        {
            txbReporte.Text = almacen.reporteInvertido();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            //almacen.datos();
        }
    }
}
