using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace aplicacion
{
    class Producto
    {
        public int idproducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float precio_compra { get; set; }
        public DateTime fecha_ingreso { get; set; }
        public float precio_venta { get; set; }

        SqlCommand comando = new SqlCommand();
        public string Grabar()
        {
            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "insertar_producto";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio_compra", precio_compra);
                comando.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
                comando.Parameters.AddWithValue("@precio_venta", precio_venta);
                comando.Connection = Conexion.variableConex;
                Conexion.Conectar();
                comando.ExecuteReader();
                Conexion.Desconectar();
                return null;
            }
            catch (Exception ex)
            {
                Conexion.Desconectar();
                return ex.Message;
            }
        }

        public string Modificar()
        {
            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "modificar_producto";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idproducto", idproducto);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
                comando.Parameters.AddWithValue("@precio_compra", precio_compra);
                comando.Parameters.AddWithValue("@fecha_ingreso", fecha_ingreso);
                comando.Parameters.AddWithValue("@precio_venta", precio_venta);
                comando.Connection = Conexion.variableConex;
                Conexion.Conectar();
                comando.ExecuteReader();
                Conexion.Desconectar();
                return null;
            }
            catch (Exception ex)
            {
                Conexion.Desconectar();
                return ex.Message;
            }
        }

        public string Eliminar()
        {
            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "eliminar_producto";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idproducto", idproducto);
                comando.Connection = Conexion.variableConex;
                Conexion.Conectar();
                comando.ExecuteReader();
                Conexion.Desconectar();
                return null;
            }
            catch (Exception ex)
            {
                Conexion.Desconectar();
                return ex.Message;
            }
        }

        public DataSet Consultar()
        {
            try
            {
                var datos = new DataSet();
                var adaptador = new SqlDataAdapter();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "consultar_producto";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Connection = Conexion.variableConex;
                Conexion.Conectar();
                comando.ExecuteReader();
                Conexion.Desconectar();
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                return datos;
            }
            catch (Exception ex)
            {
                Conexion.Desconectar();
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
