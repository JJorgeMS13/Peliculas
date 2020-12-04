using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronMvc.Models;
using System.Data.SqlClient;
using System.Data;
using PatronMvc.Models.D;
using System.Windows.Forms;
using System.IO;

namespace PatronMvc.Controllers
{
    class MoviItemsControllers
    {
        SqlDataReader leerFilas;
        SqlCommand comando;
        
        public void AgregarPelicula( MoviItems items)
        {
            try
            {
                comando = new SqlCommand();
                using (SqlConnection conexion = new SqlConnection(DbContext.StringConeccion))
                {
                    string condicion = string.Empty;
                    comando.Connection = conexion;
                    comando.CommandText = "VerRegistros";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Tipo", "Insert");
                    comando.Parameters.AddWithValue("@Condicion", condicion);
                    comando.Parameters.AddWithValue("@Titulo", items.Titulo);
                    comando.Parameters.AddWithValue("@Genero", items.Genero);
                    comando.Parameters.AddWithValue("@Precio", items.Precio);
                    comando.Parameters.AddWithValue("@imagen", items.Imagen);
                    conexion.Open();
                    int num = comando.ExecuteNonQuery();

                    if (num > 0)
                    {
                        string message = "La pelicula " + items.Titulo + " se guardo con exito";
                        string caption = "Registra Guardado!";
                        MessageBox.Show(message, caption, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ActualizarPelicula(MoviItems items)
        {
            try
            {
                comando = new SqlCommand();
                using (SqlConnection conexion = new SqlConnection(DbContext.StringConeccion))
                {
                    comando.Connection = conexion;
                    comando.CommandText = "VerRegistros";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Tipo", "Update");
                    comando.Parameters.AddWithValue("@id", items.Id);
                    comando.Parameters.AddWithValue("@Titulo", items.Titulo);
                    comando.Parameters.AddWithValue("@Genero", items.Genero);
                    comando.Parameters.AddWithValue("@Precio", items.Precio);
                    conexion.Open();
                   int num = comando.ExecuteNonQuery();
                    if (num > 0)
                    {
                        string message = "La pelicula " + items.Titulo + " se actualizo con exito";
                        string caption = "Mensaje informativo!";
                        MessageBox.Show(message,caption,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EliminarRegistro(long id)
        {
            try
            {
                comando = new SqlCommand();
                using (SqlConnection conexion = new SqlConnection(DbContext.StringConeccion))
                {
                    comando.Connection = conexion;
                    comando.CommandText = "VerRegistros";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Tipo", "Eliminar");
                    comando.Parameters.AddWithValue("@id", id);
                    conexion.Open();
                    int num = comando.ExecuteNonQuery();

                    if (num > 0)
                    {
                        MessageBox.Show($"La pelicula " + id + " se Elimino con exito");
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public List<MoviItems> VerRegistros(string condicion)
        {
            List<MoviItems> ListaGenerica = new List<MoviItems>();
            try
            {
                comando = new SqlCommand();
                DataTable dt = new DataTable();
                using (SqlConnection conexion = new SqlConnection(DbContext.StringConeccion))
                {
                    comando.Connection = conexion;
                    comando.CommandText = "VerRegistros";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@Tipo", "Buscar");
                    comando.Parameters.AddWithValue("@Condicion", condicion);
                    conexion.Open();

                    using (leerFilas = comando.ExecuteReader())
                    {
                        dt.Load(leerFilas);
                    }
                }
                foreach (DataRow item in dt.Rows)
                {
                    ListaGenerica.Add(new MoviItems
                    {
                        Id = Convert.ToInt64(item["Id"]),
                        Titulo = Convert.ToString(item["Titulo"]),
                        FechaEmision = Convert.ToDateTime(item["FechaEmision"]),
                        Genero = Convert.ToString(item["Genero"]),
                        Precio = Convert.ToDecimal(item["Precio"]),
                        Imagen =  (byte[]) item["Imagen"]
                    });
                }
                    return ListaGenerica;
            }
            catch (Exception ex)
            {

                if (ListaGenerica.Count() <= 0)
                {
                    MessageBox.Show(ex.Message);
                }
                return ListaGenerica;
            }
  
         
        }



    }
}
