﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prototipo.Modelo
{
    internal class Cnx
    {
        private readonly string connectionString = $"Data Source={Environment.MachineName};Initial Catalog=SuperPatitosDB;Integrated Security=True";

        public Cnx()
        {
            try
            {

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message, "Error", MessageBoxButtons.OK);
            }
        }

        public DataRow GetPersonalByEmailPassword(string correo, string contrasena)
        {
            DataRow personalData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetPersonalByEmailPassword", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Contrasena", contrasena);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // El usuario y contraseña son válidos, devuelve la fila de datos del personal
                        personalData = dataTable.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return personalData;
        }

        public DataRow GetPersonalByID(int idPersonal)
        {
            DataRow personalData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetPersonalByID", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idPersonal", idPersonal);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        personalData = dataTable.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return personalData;
        }

        public DataRow GetClienteByIdentificacion(string identificacion)
        {
            DataRow clienteData = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("GetClienteByIdentificacion", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@identificacion", identificacion);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        clienteData = dataTable.Rows[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }

            return clienteData;
        }
    }
}