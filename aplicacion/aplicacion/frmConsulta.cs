using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace aplicacion
{
    public partial class frmConsulta : Form
    {
        Validaciones v = new Validaciones();
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            mostrarDatos(txtTexto.Text);
        }

        public void mostrarDatos(string texto)
        {
            var datos = new Producto();
            var ds = new DataSet();
            datos.nombre = texto;
            ds = datos.Consultar();
            dgvDatos.Rows.Clear();
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                dgvDatos.Rows.Add(null, null, fila[0], fila[1], fila[2], fila[3], fila[4], fila[5]);
            }
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            mostrarDatos("");
        }
        
        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = v.validarTexto(e.KeyChar);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmDato f = new frmDato(this);
            f.ShowDialog();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvDatos.Rows[dgvDatos.CurrentRow.Index];
            Program.idproducto = int.Parse(fila.Cells[2].Value.ToString());
            if (e.ColumnIndex == 0)
            {
                Program.semaforo = 1;
                var f = new frmDato(this);
                f.text_nombre.Text = fila.Cells[3].Value.ToString();
                f.text_descrip.Text = fila.Cells[4].Value.ToString();
                f.text_compra.Text = fila.Cells[5].Value.ToString();
                f.text_fecha.Text = fila.Cells[6].Value.ToString();
                f.text_venta.Text = fila.Cells[7].Value.ToString();
                f.ShowDialog();
            }
            else if (e.ColumnIndex == 1)
            {
                DialogResult res = MessageBox.Show("¿Está Seguro?", "ELIMINAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var obj = new Producto();
                    obj.idproducto = Program.idproducto;
                    string mensaje = obj.Eliminar();
                    if (mensaje == null)
                    {
                        MessageBox.Show("Producto Eliminado", "ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(mensaje);
                    }
                    mostrarDatos("");
                }
            }
        }
    }
}
