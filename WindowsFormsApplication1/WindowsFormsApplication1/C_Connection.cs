﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class C_Connection
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private string[,] dmL;
        private string[,] tables;
        public SqlConnection Con
        {
            get
            {
                return connection;
            }

            set
            {
                connection = value;
            }
        }

        public SqlDataAdapter Adapter
        {
            get
            {
                return adapter;
            }

            set
            {
                adapter = value;
            }
        }

        /// <summary>
        /// [0,0] INSERT INTO
        /// [0,1] VALUES
        /// </summary>
        public string[,] DML
        {
            get
            {
                return this.dmL;
            }

            set
            {
                this.dmL = value;
            }
        }

        /// <summary>
        /// [0,0] Personas.Psicologo
        /// [0,1] Psicolo Values
        /// </summary>
        public string[,] Tables
        {
            get
            {
                return tables;
            }

            set
            {
                tables = value;
            }
        }


        /// <summary>
        /// Clase para la conexion y ejecucion de Consultas en SQL
        /// </summary>
        /// <param name="c_string">Cadena de Conexion :p</param>
        public C_Connection(string c_string)
        {
            this.connection = new SqlConnection(c_string);
            this.adapter = new SqlDataAdapter();
            this.dmL = new string[,]
            {
                { "INSERT INTO "}//Row = 0 Col = 0
                ,
                { "VALUES" } //Row = 1 Col = 0
            };

            this.tables = new string[,]
            {
                { "Persona.Psicologo" }//Row = 0 Col = 0
                ,
                {"(nombre, paterno, materno, direccion, colonia, telefono, diasLaborales, sexo, limitePacientes, fechaNacimiento)" }
            };
        }

        public bool execute_Query(string query)
        {
            try
            {
                this.connection.Open();
                adapter.InsertCommand = new SqlCommand(query, this.connection);
                adapter.InsertCommand.ExecuteNonQuery();
                this.connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                this.connection.Close();                
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }

            return false;
        }

    }
}

