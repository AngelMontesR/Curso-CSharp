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

        public Autos ObtenerAuto(int id)
        {
            Connect();
            Autos autos = null;

            string query = "SELECT * FROM Autos WHERE AutoID = @autoID";
            SqlCommand comando = new SqlCommand(query, _connection);
            comando.Parameters.AddWithValue("@autoID", id);
            SqlDataReader leer = comando.ExecuteReader();

            while(leer.Read())
            {
                int idAuto = leer.GetInt32(0);
                int modeloId = leer.GetInt32(1);
                decimal precio = leer.GetDecimal(2);
                int anio = leer.GetInt32(3);
                autos = new Autos(modeloId,precio,anio);
            }

            CloseConnection();

            return autos;
        }

        public void Editar(Autos autos)
        {
            Connect();
            string query = "UPDATE Autos SET Precio = @precio , Anio = @anio WHERE AutoID = @autoID";
            SqlCommand comando = new SqlCommand(query, _connection);
            comando.Parameters.AddWithValue("@autoID", autos.idAuto);
            comando.Parameters.AddWithValue("@precio", autos.precio);
            comando.Parameters.AddWithValue("@anio", autos.anio);
            comando.ExecuteNonQuery();
            CloseConnection();
        }


        public void Eliminar(int id)
        {
            Autos auto = ObtenerAuto(id);

            Connect();
            if(auto != null)
            {
                string query = "DELETE Autos WHERE AutoID = @autoID";
                SqlCommand comando = new SqlCommand(query, _connection);
                comando.Parameters.AddWithValue("@autoID", id);
                comando.ExecuteNonQuery();
            }
            else
            {
                Console.WriteLine("No existe el Auto");
            }
            CloseConnection();
        }

    }
}
