using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace clase20
{
    public class Persona
    {
        private static SqlConnection _cn;
        private static SqlCommand _cmd;

        private int _id;

        public int Id
        {
            get { return _id; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        public Persona(string nombre, int edad)
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public Persona(int edad)
        {
            this.Edad = edad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Id: " + this.Id);
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Edad: " + this.Edad);

            return sb.ToString();
        }

        public static List<Persona> TraerPersonas()
        {
            try
            {
                List<Persona> lista = new List<Persona>();
                _cn = new SqlConnection(Properties.Settings.Default.MiConexion);
                _cmd = new SqlCommand();

                _cmd.CommandType = System.Data.CommandType.Text;
                _cmd.CommandText = "SELECT id, nombre, edad FROM Personas";
                _cmd.Connection = _cn;
                _cn.Open();

                //Para instrucciones que retornan resultados(select) se ejecuta como ExecuteReader
                //El dataReader es de solo lectura y de solo avance
                SqlDataReader dr = _cmd.ExecuteReader();

                while (dr.Read())
                {
                    Persona personaAux = new Persona(dr["nombre"].ToString(), int.Parse(dr["edad"].ToString()));
                    lista.Add(personaAux);
                }

                _cn.Close();

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool Agregar()
        {
            try
            {
                _cn = new SqlConnection(Properties.Settings.Default.MiConexion);
                _cmd = new SqlCommand();

                _cmd.CommandType = System.Data.CommandType.Text;
                _cmd.CommandText = "INSERT INTO Personas(nombre, edad) VALUES ('" + this.Nombre + "', " + this.Edad + ")";
                _cmd.Connection = _cn;
                _cn.Open();

                //Para las instrucciones que no retornan valores(insert, update, delete) se ejecuta como NonQuery
                //El dataReader es de solo lectura y de solo avance
                _cmd.ExecuteNonQuery();
                _cn.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Eliminar()
        {
            try
            {
                _cn = new SqlConnection(Properties.Settings.Default.MiConexion);
                _cmd = new SqlCommand();

                _cmd.CommandType = System.Data.CommandType.Text;
                _cmd.CommandText = "DELETE FROM Personas WHERE nombre = '" + this.Nombre + "'";
                _cmd.Connection = _cn;
                _cn.Open();

                //Para las instrucciones que no retornan valores(insert, update, delete) se ejecuta como NonQuery
                //El dataReader es de solo lectura y de solo avance
                _cmd.ExecuteNonQuery();
                _cn.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
