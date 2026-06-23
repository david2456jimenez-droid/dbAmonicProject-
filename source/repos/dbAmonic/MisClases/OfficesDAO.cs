using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MisClases
{
    public class OfficesDAO: Conexion
    {
       

        public List<Offices> ObtenerOffices()
        {
            List<Offices> ListaOffices = new List<Offices>();

            using (SqlConnection conexion= ObtenerConexion())
            {
                conexion.Open();
                string consulta = "select OfficesID, Title, Phone, Contact, Name from Offices\r\njoin Countries\r\nON \r\nCountries.CountryID = Offices.CountryID;";

                using (SqlCommand comando= new SqlCommand(consulta, conexion))
                {
                    comando.CommandType= CommandType.Text;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            Offices of = new Offices
                            {
                                OfficeID = Convert.ToInt32(reader["OfficesID"]),
                                Title = reader["Title"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Contact= reader["Contact"].ToString(),
                                CountryName= reader["Name"].ToString()

                            };
                            ListaOffices.Add(of);
                        }

                    }
                }
                
            } return ListaOffices;
        }
    }
}
