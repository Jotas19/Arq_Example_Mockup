using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Ecommerce3.Dominioo;
namespace Ecommerce.Datos
{
    public class Producto
    {
        public List <ProductoDTO> Listar()
        {
            List<ProductoDTO> lista = new List<ProductoDTO>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select * from Producto";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            lista.Add(
                                new ProductoDTO()
                                {
                                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                    Nombre = reader ["Nombre"].ToString(),
                                    Precio = Convert.ToDecimal(reader["Precio"]),
                                    Stock = (short?)Convert.ToInt32(reader["Stock"]),
                                    Descripcion = reader ["Descripcion"].ToString(),
                                    Referencia = reader ["Referencia"].ToString(),
                                }
                            );
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return lista;

        }

        public List<ImagenProductoDTO> Listar_Imagen()
        {
            List<ImagenProductoDTO> lista = new List<ImagenProductoDTO>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select * from ImagenProducto";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(
                                new ImagenProductoDTO()
                                {
                                    IdImagenProducto = Convert.ToInt32(reader["IdImagenProducto"]),
                                    IdProducto = Convert.ToInt32(reader["IdProducto"]),
                                    Url = reader["Url"].ToString(),

                                }
                            );
                        }
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }

            return lista;

        }
    }
}
