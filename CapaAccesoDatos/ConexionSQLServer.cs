using System;
using CapaNegocio;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ConexionSQLServer : ICentralRiesgo
    {
        public SqlConnection conexion;

        public ConexionSQLServer()
        {

            this.conexion = new SqlConnection(@"Data Source=DESKTOP-UG9NHAN\SQLEXPRESS;Persist Security Info=True;User ID=sa;Password=sa;TrustServerCertificate=True;Initial Catalog=DbParcialArq");
        }

        public int ConsultarPuntaje(string tipoDoc, string nroDoc)
        {
            int puntaje = 0;


            string select = string.Format("SELECT Puntaje FROM CentralRiesgo WHERE TipoDoc = '{0}' AND NroDoc = '{1}'", tipoDoc, nroDoc);

            conexion.Open();

            SqlCommand comando = new SqlCommand(select, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            // Si encuentra un registro, leemos el puntaje
            if (reader.Read())
            {
                puntaje = reader.GetInt32(0); // Columna 0 es Puntaje
            }

            conexion.Close();

            return puntaje;
        }
    }
}
