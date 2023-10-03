using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Post : Publicacion

    {
        public string Imagen { get; set; }
        public bool Censurado { get; set; }

        public Post(string titulo, string contenido, Miembro autor, Sistema.TipoPrivacidad privacidad, string imagen, bool censurado) : base(titulo, contenido, autor, privacidad)
        {
            Imagen = imagen;
            Censurado = censurado;
            Validar();
        }
        //Este segundo constructor lo usamos solamente para la precarga (para tener diferentes fechas de publicacion de los posts, ya que por letra usamos siempre el primero, tomando en cuenta que dice que la fecha al cargar un post es siempre la fecha actual
        public Post(string titulo, string contenido, Miembro autor, Sistema.TipoPrivacidad privacidad, string imagen, bool censurado, DateTime fecha) : base(titulo, contenido, autor, privacidad, fecha)
        {
            Imagen = imagen;
            Censurado = censurado;
            Validar();
        }

        //VALIDACIONES
        public void Validar()
        {
            ValidarImagen();
        }

        //Validaciones de el string de imagen
        private void ValidarImagen()
        {
            ValidarImagenString();
            ValidarImagenTerminacion();
        }


        private void ValidarImagenString()
        {
            if (!Utilidades.StringValido(Imagen))
            {
                throw new Exception("La imágen no puede ser un string vacío");
            }
        }

        private void ValidarImagenTerminacion()
        {
            if (!(Imagen.ToLower()).EndsWith(".png") || (Imagen.ToLower()).EndsWith(".jpg"))
            {
                throw new Exception("La imágen debe terminar en .png o .jpg");
            }
        }



        public override string ToString()
        {
            if (Censurado)
            {
                return $"No se puede mostrar el contenido del Post de ID:{Id} porque fué censurado";
            }
            else
            {
                string respuesta = base.ToString();
                respuesta += $"Imagen:{Imagen} \n";
                return respuesta;
            }
        }
    }

}