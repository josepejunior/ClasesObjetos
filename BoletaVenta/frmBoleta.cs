using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoletaVenta
{
    public partial class frmBoleta : Form
    {
        //Vaariables globales
        int num;

        //Objeto de la clase Boleta
        Boleta objB = new();

        public frmBoleta()
        {
            InitializeComponent();
        }

        private void frmBoleta_Load(object sender, EventArgs e)
        {
            num++;
            lblNumero.Text = num.ToString("D5");
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            objB.descripcionProducto = cboProducto.Text;
            txtPrecio.Text = objB.DeterminaPrecio().ToString("C");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Agregar()
        {
            if (Valida() == "")
            {
                //Capturar los datos
                CapturarDatos();

                //Determinar los cálculos de la aplicación
                double precio = objB.DeterminaPrecio();
                double importe = objB.CalculaImporte();

                //Imprimir el detalle de la venta
                ImprimirDetalle(precio, importe);

                //Imprimir el total acumulado
                lblTotal.Text = DeterminaTotal().ToString("C");
            }
            else
                MessageBox.Show($"El error se encuentra en {Valida()}");
        }

        //Método que calcula el monto acumulado de los importes
        private double DeterminaTotal()
        {
            double total = 0;

            for (int i = 0; i < lvDetalle.Items.Count; i++)
            {
                total += double.Parse(lvDetalle.Items[i].SubItems[3].Text);
            }

            return total;
        }

        //Mandando a imprimir detalles del producto
        private void ImprimirDetalle(double precio, double importe)
        {
            ListViewItem fila = new ListViewItem(objB.cantidadProducto.ToString());
            fila.SubItems.Add(objB.descripcionProducto);
            fila.SubItems.Add(precio.ToString("0,00"));
            fila.SubItems.Add(importe.ToString("0,00"));
            lvDetalle.Items.Add(fila);
        }

        //Capturar datos del formulario
        private void CapturarDatos()
        {
            objB.numero = int.Parse(lblNumero.Text);
            objB.nombreCliente = txtCliente.Text;
            objB.direccionCliente = txtDireccion.Text;
            objB.cedulaCliente = txtCedula.Text;
            objB.fechaRegistro = DateTime.Parse(txtFecha.Text);
            objB.descripcionProducto = cboProducto.Text;
            objB.cantidadProducto = int.Parse(txtCantidad.Text);

        }

        //Validar el ingreso de los datos
        private string Valida()
        {
            if (txtCliente.Text.Trim().Length == 0)
            {
                txtCliente.Focus();
                return "Nombre del cliente";
            }
            else if (txtDireccion.Text.Trim().Length == 0)
            {
                txtDireccion.Focus();
                return "Direccion del cliente";
            }
            else if (txtCedula.Text.Trim().Length == 0)
            {
                txtCedula.Focus();
                return "Cédula del cliente";
            }
            else if (cboProducto.SelectedIndex == -1)
            {
                cboProducto.Focus();
                return "Descripcion del producto";
            }
            else if (txtCantidad.Text.Trim().Length == 0)
            {
                txtCantidad.Focus();
                return "Cantidad comprada";
            }

            return "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }

        //Mandando a imprimir estadisticas
        private void Registrar()
        {
            if (Valida() == "")
            {
                ListViewItem fila = new ListViewItem(lblNumero.Text);
                fila.SubItems.Add(txtFecha.Text);
                fila.SubItems.Add(TotalCantidad().ToString("0.00"));
                fila.SubItems.Add(DeterminaTotal().ToString("C"));
                lvEstadisticas.Items.Add(fila);
                LimpiarControles();
            }
            else
                MessageBox.Show($"El error se encuentra en {Valida()}");
        }

        private void LimpiarControles()
        {
            num++;
            lblNumero.Text = num.ToString("D5");
            txtCliente.Clear();
            txtDireccion.Clear();
            txtCedula.Clear();
            cboProducto.Text = "(Seleccione)";
            txtPrecio.Clear();
            txtCantidad.Clear();
            lvDetalle.Items.Clear();
        }

        private int TotalCantidad()
        {
            int total = 0;

            for (int i = 0; i < lvDetalle.Items.Count; i++)
            {
                total += int.Parse(lvDetalle.Items[i].SubItems[0].Text);
            }

            return total;
        }
    }
}
