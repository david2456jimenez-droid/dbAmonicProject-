using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MisClases
{
    public class UserDAO: Conexion

    {
        public List<Users> ObtenerUsers()
        {
            List<Users> ListaUsers = new List<Users>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = "select UserID, Email, Password, FirstName, LastName, BirthDate, Active, offices.Title as TitleOffices, Roles.Title as TitleRoles from Users join Offices on Offices.OfficesID = Users.OfficeID join Roles on Roles.RolesID = Users.RoleID;";
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.CommandType = CommandType.Text;

                    SqlDataReader reader = comando.ExecuteReader();

                    
                        while (reader.Read())
                        {
                            Users user = new Users
                            {
                               
                                FirstName = reader["FirstName"].ToString(),
                                LastName = reader["LastName"].ToString(),
   
                                TitleRoles= reader["TitleRoles"].ToString(),
                                Email = reader["Email"].ToString(),
                                TitleOffices = reader["TitleOffices"].ToString(),
                                UserID = Convert.ToInt32(reader["UserID"]),
                                Password = Convert.ToInt32(reader["Password"]),
                                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
                                Active = Convert.ToBoolean(reader["Active"])



                            };
                            ListaUsers.Add(user);


                        
                        }

                }


            }return ListaUsers;
        }

        public bool Login(string Email, string Password)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string consul = "Select count(*) from Users where Email=@email and Password=@password";

                using (SqlCommand comando = new SqlCommand(consul, conexion))
                {
                    comando.Parameters.AddWithValue("@email", Email);
                    comando.Parameters.AddWithValue("@password", Password);

                    int cantidad = (int)comando.ExecuteScalar();

                    return cantidad > 0;

                }

            }
        }
    }
}
