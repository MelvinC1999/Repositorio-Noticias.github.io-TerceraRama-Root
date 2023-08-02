using Repositorio_Noticias.DataAccess;
using Repositorio_Noticias.Models;

namespace Repositorio_Noticias.LogicaNegocio
{
    public class UsuarioBL
    {
        private UsuarioDA _usuariosAccesoDatos;

        public UsuarioBL(string cadenaConexion)
        {
            _usuariosAccesoDatos = new UsuarioDA(cadenaConexion);
        }

        public List<Usuario> ObtenerUsarios()
        {
            return _usuariosAccesoDatos.ObtenerUsuarios();
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            return _usuariosAccesoDatos.ObtenerUsuarioPorId(id);
        }

        public void CrearUsuario(Usuario usuario)
        {
            // Validaciones y reglas de negocio

            _usuariosAccesoDatos.CrearUsuario(usuario);
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            // Validaciones y reglas de negocio

            _usuariosAccesoDatos.ActualizarUsuario(usuario);
        }

        public void EliminarUsuario(int id)
        {
            _usuariosAccesoDatos.EliminarUsuario(id);
        }
    }
}
