using Productos.DAO;
using Productos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{
    public partial class Form1 : Form
    {
        ProductoDAO dao = new ProductoDAO();
        public Form1()
        {
            InitializeComponent();
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            this.dgvRegistros.DataSource = dao.VerCarrito();
            this.dgvRegistros.Refresh();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            try
            {
                prod.Nombre = this.tbNombre.Text.ToUpper();
                prod.Codigo = this.tbCodigo.Text.ToUpper();
                prod.Precio = double.Parse(this.tbPrecio.Text);
                prod.IVA = this.chkIVA.Checked;
                dao.Agregar(prod);
            }
            catch (FormatException)
            {
                MessageBox.Show("No se puede agregar texto en el precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            LlenarGrid();
        }
    }


}
