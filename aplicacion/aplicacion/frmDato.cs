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
    public partial class frmDato : Form
    {
        frmConsulta forma;
        Validaciones v = new Validaciones();
        public frmDato(frmConsulta f)
        {
            InitializeComponent();
            forma = f;
        }
        private void frmDato_Load(object sender, EventArgs e)
        {
            text_nombre.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string m = "";
            if (text_nombre.Text == "") { m += "Ingresar Nombre\n"; }
            if (text_descrip.Text == "") { m += "Ingresar Descripción\n"; }
            if (text_compra.Text == "") { m += "Ingresar Precio de Compra\n"; }
            if (text_venta.Text == "") { m += "Ingresar Precio de Venta\n"; }

            if (m != "")
            {
                MessageBox.Show(m);
                return;
            }
            else
            {
                try
                {
                    var datos = new Producto();
                    string mensaje;
                    datos.nombre = text_nombre.Text;
                    datos.descripcion = text_descrip.Text;
                    datos.precio_compra = float.Parse(text_compra.Text);
                    datos.fecha_ingreso = text_fecha.Value;
                    datos.precio_venta = float.Parse(text_venta.Text);
                    if (Program.idproducto == 0)
                    {
                        mensaje = datos.Grabar();
                        if (mensaje == null)
                        {
                            MessageBox.Show("Producto Registrado");
                        }
                        else
                        {
                            MessageBox.Show(mensaje);
                        }
                    }
                    else
                    {
                        datos.idproducto = Program.idproducto;
                        mensaje = datos.Modificar();
                        if (mensaje == null)
                        {
                            MessageBox.Show("Producto Modificado");
                        }
                        else
                        {
                            MessageBox.Show(mensaje);
                        }
                    }
                    forma.mostrarDatos("");
                    btnCancelar_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDato_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.semaforo = 0;
            Program.idproducto = 0;
        }

        private void text_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = v.validarTexto(e.KeyChar);
            if(e.KeyChar == 13)
            {
                text_descrip.Focus();
            }
        }

        private void text_descrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = v.validarTexto(e.KeyChar);
            if (e.KeyChar == 13)
            {
                text_compra.Focus();
            }
        }

        private void text_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = v.validarDecimal(e.KeyChar);
            if (e.KeyChar == 13)
            {
                text_fecha.Focus();
            }
        }

        private void text_fecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                text_venta.Focus();
            }
        }

        private void text_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = v.validarDecimal(e.KeyChar);
            if (e.KeyChar == 13)
            {
                btnAceptar.Focus();
            }
        }
    }
}
