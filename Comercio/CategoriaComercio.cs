﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Comercio
{
    public class CategoriaComercio
    {
        public List<Categoria> Listar()
        {
            List<Categoria> catlst = new List<Categoria>();

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;


            connection.ConnectionString = "data source = localhost\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";

            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "SELECT * FROM CATEGORIAS;";
            command.Connection = connection;

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Categoria aux = new Categoria();
                aux.Id = (int)reader["Id"];
                aux.Nombre = (string)reader["Descripcion"];

                catlst.Add(aux);
            }

            connection.Close();
            return catlst;



        }
    }
}
