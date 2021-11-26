﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using NLog;

namespace TrabajoPractico3.Models.Entidades
{
    public class RepositorioUsuarioSQLite : IRepositorioUsuario
    {
        private readonly Logger logger;
        private readonly string connectionString;

        public RepositorioUsuarioSQLite(string connectionString, Logger logger)
        {
            this.logger = logger;
            this.connectionString = connectionString;
        }


        public int GetUsuarioID(string usuario, string contrasenia)
        {
            int id = 0;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string sqlQuery = "SELECT usuarioId FROM Usuarios WHERE usuario = @usuario AND contraseña = @contrasenia;";

                    using (SQLiteCommand command = new SQLiteCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", usuario);
                        command.Parameters.AddWithValue("@usuarioPassword", contrasenia);
                        connection.Open();

                        using (SQLiteDataReader dataReader = command.ExecuteReader())
                        {
                            dataReader.Read();
                            id = Convert.ToInt32(dataReader["usuarioId"]);
                            connection.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

            return id;
        }
        public void SaveUsuario(Usuario usuario)
        {
            string consulta = @"INSERT INTO Usuarios (usuario, email, contraseña, activo)
                                VALUES (@usuario, @email, @contrasenia, 1);";
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(consulta, conexion))
                    {
                        conexion.Open();
                        command.Parameters.AddWithValue("@usuario", usuario.NombreDeUsuario);
                        command.Parameters.AddWithValue("@email", usuario.Email);
                        command.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
                        command.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
        public void UpdateUsuario(Usuario usuario)
        {
            string consulta = @"UPDATE Usuarios SET usuario = @usuario, email = @email, contraseña = @contrasenia, activo = 1
                                WHERE usuarioId = @id;";
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(consulta, conexion))
                    {
                        conexion.Open();
                        command.Parameters.AddWithValue("@usuario", usuario.NombreDeUsuario);
                        command.Parameters.AddWithValue("@email", usuario.Email);
                        command.Parameters.AddWithValue("@contrasenia", usuario.Contrasenia);
                        command.Parameters.AddWithValue("@id", usuario.Id);
                        command.ExecuteNonQuery();
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
        public void Delete(int id)
        {
            string SqlQuery = "UPDATE Usuarios SET activo = 0 WHERE usuarioId = @id";
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion))
                    {

                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
    }
}