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
    public class Categoria
    {
        public List<CategoriaDTO> Listar_Categoria()
        {
            List<CategoriaDTO> lista = new List<CategoriaDTO>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select * from Categoria";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(
                                new CategoriaDTO()
                                {
                                    Nombre = reader["Nombre"].ToString(),
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
