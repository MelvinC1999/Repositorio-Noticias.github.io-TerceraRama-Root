using Repositorio_Noticias.Models;

namespace Repositorio_Noticias.DataAccess
{
    public class NoticiaDA
    {
        private string _cadenaConexion;

        public NoticiaDA(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
        }

        public List<Noticia> ObtenerNoticias()
        {
            // Código para obtener todas las noticias de la base de datos
            return new List<Noticia>();
        }

        public Noticia ObtenerNoticiaPorId(int id)
        {
            // Código para obtener una noticia por su ID
            Noticia noticia = new Noticia();
            return noticia;
        }

        public void CrearNoticia(Noticia noticia)
        {
            // Código para crear una nueva noticia en la base de datos
        }

        public void ActualizarNoticia(Noticia noticia)
        {
            // Código para actualizar una noticia existente en la base de datos
        }

        public void EliminarNoticia(int id)
        {
            // Código para eliminar una noticia por su ID
        }
    }
}
