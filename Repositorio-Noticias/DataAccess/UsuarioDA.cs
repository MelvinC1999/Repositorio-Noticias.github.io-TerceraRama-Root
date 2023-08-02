using Repositorio_Noticias.Models;
using System.Data.SqlClient;

namespace Repositorio_Noticias.DataAccess
{
    public class UsuarioDA
    {
        private string _cadenaConexion;
        public UsuarioDA(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }
        public List<Usuario> ObtenerUsuarios()
        {
            var usuarios = new List<Usuario>();

            using (var connection = new SqlConnection(_cadenaConexion))
            {
                connection.Open();

                using (var command = new SqlCommand("SELECT * FROM Usuarios", connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var usuario = new Usuario
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                // Asigna el resto de las propiedades del usuario aquí
                            };

                            usuarios.Add(usuario);
                        }
                    }
                }
                connection.Close();
            }
            return usuarios;
        }
        ///
        public Usuario ObtenerUsuarioPorId(int id)
        {
            Usuario usuario = null;

            var connection = new SqlConnection(_cadenaConexion);
            connection.Open();

            var command = new SqlCommand("SELECT * FROM Usuarios WHERE Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", id);

            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                usuario = new Usuario
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                    // Asigna el resto de las propiedades del usuario aquí
                };
            }

            reader.Close();
            connection.Close();

            return usuario;
        }
        ///CrearUusario(usuario)
        ///
        public void CrearUsuario(Usuario usuario)
        {
            using (var connection = new SqlConnection(_cadenaConexion))
            {
                connection.Open();

                using (var command = new SqlCommand("INSERT INTO Usuarios (Nombre) VALUES (@Nombre)", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        ///
        ///ActualizarUsuario(usuario)
        ///
        public void ActualizarUsuario(Usuario usuario)
        {
            using (var connection = new SqlConnection(_cadenaConexion))
            {
                connection.Open();

                using (var command = new SqlCommand("UPDATE Usuarios SET Nombre = @Nombre WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("@Id", usuario.Id);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        ///
        ///EliminarUsuario(id)
        ///
        public void EliminarUsuario(int id)
        {
            using (var connection = new SqlConnection(_cadenaConexion))
            {
                connection.Open();

                using (var command = new SqlCommand("DELETE FROM Usuarios WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        ///
        ///
    }
}
