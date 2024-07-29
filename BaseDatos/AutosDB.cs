using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDatos
{
    public class AutosDB : DB
    {
        public AutosDB(string server, string db, string user, string password) : base(server, db, user, password)
        {
          
        }
        
        public List<Autos> ObtenerTodos()
        {
            Connect();
            List<Autos> autos = new List<Autos>();
            string query = "SELECT * FROM Autos";
            SqlCommand comando = new SqlCommand(query, _connection);
            SqlDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                int idAuto = leer.GetInt32(0);
                int modeloId = leer.GetInt32(1);
                decimal precio = leer.GetDecimal(2);
                int anio = leer.GetInt32(3);
                autos.Add(new Autos(idAuto, modeloId, precio,anio));
            }
            CloseConnection();
            return autos;
        }

        public void Agregar(Autos autos)
        {
            Connect();
            string query = "INSERT INTO Autos(ModeloID,Precio,Anio) " +
                           "VALUES(@modeloId,@precio,@anio)";

            SqlCommand comando = new SqlCommand(query, _connection);

            comando.Parameters.AddWithValue("@modeloId", autos.idModelo);
            comando.Parameters.AddWithValue("@precio", autos.precio);
            comando.Parameters.AddWithValue("@anio", autos.anio);

            comando.ExecuteNonQuery();

            CloseConnection();
        }

    }
}
