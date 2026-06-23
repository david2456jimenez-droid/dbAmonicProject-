using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MisClases
{
    public class RolesDAO: Conexion
    {
        public List<Roles> ObtenerRoles()
        {
            List<Roles> ListaRoles = new List<Roles>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = "select Title from Roles;";


                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Roles roles = new Roles
                            {
                                Title = reader["Title"].ToString()
                            };
                            ListaRoles.Add(roles);
                        }
                    }
                }
            }return ListaRoles;
        }   
    }
}
