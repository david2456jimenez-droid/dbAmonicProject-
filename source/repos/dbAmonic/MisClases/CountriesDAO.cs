using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MisClases
{
    
    public class CountriesDAO : Conexion
    {
        public List<Countries> MostrarCountries()

        {
            List<Countries> ListaCountries = new List<Countries>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string cons = "Select * from countries";
                using (SqlCommand comando = new SqlCommand(cons, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Countries countries = new Countries
                            {
                                CountryID=Convert.ToInt32(reader["CountryID"]),
                                CountryName=reader["Name"].ToString(),
                            };

                            ListaCountries.Add(countries);
                        }
                    }
                }
            }
            return ListaCountries;

          
        }  


    }
}

