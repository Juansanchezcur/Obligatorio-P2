using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Sistema
    {
        //Listados del sistema y métodos
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Invitacion> _invitaciones = new List<Invitacion>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();

        public List<Usuario> Usuarios
        {
            get { return _usuarios; }
        }
        public List<Invitacion> Invitaciones
        {
            get { return _invitaciones; }
        }
        public List<Publicacion> Publicacionees
        {
            get { return _publicaciones; }
        }

        //Constructor
        public Sistema()
        {

        }


        //PRECARGA
        public void Precargar()
        {
            PrecargarMiembros();
            PrecargarAdministradores();
            PrecargasInvitaciones();
            PrecargasPublicaciones();
        }



        private void PrecargarMiembros()
        {
            Miembro m1 = new Miembro("email1@gmail.com", "Obligatorio1", "Juan", "Sánchez", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m1);
            Miembro m2 = new Miembro("email2@gmail.com", "Obligatorio1", "Carlos", "Sánchez", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m2);
            Miembro m3 = new Miembro("email3@gmail.com", "Obligatorio1", "José", "Pérez", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m3);
            Miembro m4 = new Miembro("email4@gmail.com", "Obligatorio1", "Lionel", "Messi", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m4);
            Miembro m5 = new Miembro("email5@gmail.com", "Obligatorio1", "Cristiano", "Ronaldo", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m5);
            Miembro m6 = new Miembro("email6@gmail.com", "Obligatorio1", "Carlos", "Sánchez", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m6);
            Miembro m7 = new Miembro("email7@gmail.com", "Obligatorio1", "Anibal", "Rodríguez", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m7);
            Miembro m8 = new Miembro("email8@gmail.com", "Obligatorio1", "Sebastían", "Brum", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m8);
            Miembro m9 = new Miembro("email9@gmail.com", "Obligatorio1", "Ana", "Sánchez", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m9);
            Miembro m10 = new Miembro("email10@gmail.com", "Obligatorio1", "Carla", "Sánchez", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m10);
            Miembro m11 = new Miembro("email11@gmail.com", "Obligatorio1", "Lourdes", "Pérez", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m11);
            Miembro m12 = new Miembro("email12@gmail.com", "Obligatorio1", "Thiago", "Messi", new DateTime(1993, 11, 18), false);
            AgregarUsuario(m12);
        }
        private void PrecargarAdministradores()
        {
            Administrador a1 = new Administrador("admin@admin.com", "Obligatorio1");
            AgregarUsuario(a1);
            Administrador a2 = new Administrador("admin2@admin.com", "Obligatorio1");
            AgregarUsuario(a2);

        }

        private void PrecargasInvitaciones()
        {
            //Invitaciones miembro 1
            Invitacion i1 = new Invitacion(BuscarMiembroPorEmail("email1@gmail.com"), BuscarMiembroPorEmail("email2@gmail.com"), EstadoInvitacion.RECHAZADA);
            AgregarInvitacionAmistad(i1);
            Invitacion i2 = new Invitacion(BuscarMiembroPorEmail("email1@gmail.com"), BuscarMiembroPorEmail("email3@gmail.com"), EstadoInvitacion.RECHAZADA);
            AgregarInvitacionAmistad(i2);
            Invitacion i3 = new Invitacion(BuscarMiembroPorEmail("email1@gmail.com"), BuscarMiembroPorEmail("email4@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i3);
            Invitacion i4 = new Invitacion(BuscarMiembroPorEmail("email1@gmail.com"), BuscarMiembroPorEmail("email5@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i4);
            Invitacion i5 = new Invitacion(BuscarMiembroPorEmail("email1@gmail.com"), BuscarMiembroPorEmail("email6@gmail.com"), EstadoInvitacion.RECHAZADA);
            AgregarInvitacionAmistad(i5);
            Invitacion i6 = new Invitacion(BuscarMiembroPorEmail("email1@gmail.com"), BuscarMiembroPorEmail("email7@gmail.com"), EstadoInvitacion.RECHAZADA);
            AgregarInvitacionAmistad(i6);
            Invitacion i7 = new Invitacion(BuscarMiembroPorEmail("email1@gmail.com"), BuscarMiembroPorEmail("email8@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i7);
            Invitacion i8 = new Invitacion(BuscarMiembroPorEmail("email1@gmail.com"), BuscarMiembroPorEmail("email9@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i8);
            Invitacion i9 = new Invitacion(BuscarMiembroPorEmail("email1@gmail.com"), BuscarMiembroPorEmail("email10@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i9);

            //Invitaciones miembro 11
            Invitacion i10 = new Invitacion(BuscarMiembroPorEmail("email11@gmail.com"), BuscarMiembroPorEmail("email2@gmail.com"), EstadoInvitacion.RECHAZADA);
            AgregarInvitacionAmistad(i10);
            Invitacion i11 = new Invitacion(BuscarMiembroPorEmail("email11@gmail.com"), BuscarMiembroPorEmail("email3@gmail.com"), EstadoInvitacion.RECHAZADA);
            AgregarInvitacionAmistad(i11);
            Invitacion i12 = new Invitacion(BuscarMiembroPorEmail("email11@gmail.com"), BuscarMiembroPorEmail("email4@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i12);
            Invitacion i13 = new Invitacion(BuscarMiembroPorEmail("email11@gmail.com"), BuscarMiembroPorEmail("email5@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i13);
            Invitacion i14 = new Invitacion(BuscarMiembroPorEmail("email11@gmail.com"), BuscarMiembroPorEmail("email6@gmail.com"), EstadoInvitacion.RECHAZADA);
            AgregarInvitacionAmistad(i14);
            Invitacion i15 = new Invitacion(BuscarMiembroPorEmail("email11@gmail.com"), BuscarMiembroPorEmail("email7@gmail.com"), EstadoInvitacion.RECHAZADA);
            AgregarInvitacionAmistad(i15);
            Invitacion i16 = new Invitacion(BuscarMiembroPorEmail("email11@gmail.com"), BuscarMiembroPorEmail("email8@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i16);
            Invitacion i17 = new Invitacion(BuscarMiembroPorEmail("email11@gmail.com"), BuscarMiembroPorEmail("email9@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i17);
            Invitacion i18 = new Invitacion(BuscarMiembroPorEmail("email11@gmail.com"), BuscarMiembroPorEmail("email10@gmail.com"), EstadoInvitacion.PENDIENTE_APROBACION);
            AgregarInvitacionAmistad(i18);


            //Cuando es aprobada, agrego también los miembros como amigos

            Miembro m1 = BuscarMiembroPorEmail("email1@gmail.com");
            Miembro m11 = BuscarMiembroPorEmail("email11@gmail.com");
            Invitacion i19 = new Invitacion(m1, m11, EstadoInvitacion.APROBADA);
            AgregarInvitacionAmistad(i19);
            AgregarAmigos(m1, m11);


            Miembro m12 = BuscarMiembroPorEmail("email12@gmail.com");
            Invitacion i20 = new Invitacion(m1, m12, EstadoInvitacion.APROBADA);
            AgregarInvitacionAmistad(i20);
            AgregarAmigos(m1, m12);


            Invitacion i21 = new Invitacion(m11, m12, EstadoInvitacion.APROBADA);
            AgregarInvitacionAmistad(i21);
            AgregarAmigos(m11, m12);




        }
        private void PrecargasPublicaciones()
        {
            //Esta información sirve para probar la parte de que para comentar un post privado, el que comenta debe ser amigo del que creó el post
            Miembro m1 = BuscarMiembroPorEmail("email1@gmail.com");
            Miembro m3 = BuscarMiembroPorEmail("email3@gmail.com");//No es amigo del miembro 1
            Miembro m11 = BuscarMiembroPorEmail("email11@gmail.com");//Amigo del miembro 1

            //Cargamos los Posts

            Post post1 = new Post("Bicicletas", "123456789 123456789 123456789 123456789 123456789 Todos estos caracteres superan los 50.", m1, TipoPrivacidad.Publico, "imagen.png", false, new DateTime(1995, 2, 5));
            AgregarPost(post1);
            Post post2 = new Post("Mundo", "contenido", m1, TipoPrivacidad.Privado, "imagen.png", false, new DateTime(2005, 11, 4));
            AgregarPost(post2);
            Post post3 = new Post("Animales", "contenido", m1, TipoPrivacidad.Publico, "imagen.png", false, new DateTime(2012, 12, 12));
            AgregarPost(post3);
            Post post4 = new Post("Paisajes", "contenido", m1, TipoPrivacidad.Privado, "imagen.png", false, new DateTime(2000, 5, 6));
            AgregarPost(post4);
            Post post5 = new Post("Caminatas", "contenido", m1, TipoPrivacidad.Publico, "imagen.png", false, new DateTime(1990, 12, 8));
            AgregarPost(post5);

            //Comentamos los Posts

            //Post 1
            Comentario comentario1p1 = new Comentario("Comentario 1", "contenido", m1, post1, TipoPrivacidad.Publico);
            AgregarComentario(comentario1p1, post1);
            Comentario comentario2p1 = new Comentario("Comentario 2", "contenido", m1, post1, TipoPrivacidad.Publico);
            AgregarComentario(comentario2p1, post1);
            Comentario comentario3p1 = new Comentario("Comentario 3", "contenido", m11, post1, TipoPrivacidad.Publico);
            AgregarComentario(comentario3p1, post1);
            
            //Post 2
            //Acá se comenta un post privado, usando un comentario privado, de un amigo del miembro que realizó el post
            Comentario comentario1p2 = new Comentario("Comentario 1", "contenido", m11, post2, TipoPrivacidad.Privado);
            AgregarComentario(comentario1p2, post2);
            Comentario comentario2p2 = new Comentario("Comentario 2", "contenido", m11, post2, TipoPrivacidad.Privado);
            AgregarComentario(comentario2p2, post2);
            Comentario comentario3p2 = new Comentario("Comentario 3", "contenido", m11, post2, TipoPrivacidad.Privado);
            AgregarComentario(comentario3p2, post2);

            //Post 3
            Comentario comentario1p3 = new Comentario("Comentario 1", "contenido", m3, post3, TipoPrivacidad.Publico);
            AgregarComentario(comentario1p3, post3);
            Comentario comentario2p3 = new Comentario("Comentario 2", "contenido", m3, post3, TipoPrivacidad.Publico);
            AgregarComentario(comentario2p3, post3);
            Comentario comentario3p3 = new Comentario("Comentario 3", "contenido", m3, post3, TipoPrivacidad.Publico);
            AgregarComentario(comentario3p3, post3);

            //Post 4
            Comentario comentario1p4 = new Comentario("Comentario 1", "contenido", m11, post4, TipoPrivacidad.Privado);
            AgregarComentario(comentario1p4, post4);
            Comentario comentario2p4 = new Comentario("Comentario 2", "contenido", m11, post4, TipoPrivacidad.Privado);
            AgregarComentario(comentario2p4, post4);
            Comentario comentario3p4 = new Comentario("Comentario 3", "contenido", m11, post4, TipoPrivacidad.Privado);
            AgregarComentario(comentario3p4, post4);

            //Post 5
            Comentario comentario1p5 = new Comentario("Comentario 1", "contenido", m3, post5, TipoPrivacidad.Publico);
            AgregarComentario(comentario1p5, post5);
            Comentario comentario2p5 = new Comentario("Comentario 2", "contenido", m3, post5, TipoPrivacidad.Publico);
            AgregarComentario(comentario2p5, post5);
            Comentario comentario3p5 = new Comentario("Comentario 3", "contenido", m3, post5, TipoPrivacidad.Publico);
            AgregarComentario(comentario3p5, post5);

            //REACCIONES A POSTS

            //Post 1
            Reaccion r1p1 = new Reaccion(m1, TipoReaccion.Like);
            AgregarReaccion(r1p1, post1);
            Reaccion r2p1 = new Reaccion(m3, TipoReaccion.Like);
            AgregarReaccion(r2p1, post1);
            Reaccion r3p1 = new Reaccion(m11, TipoReaccion.Dislike);
            AgregarReaccion(r3p1, post1);

            //Post 2
            Reaccion r1p2 = new Reaccion(m1, TipoReaccion.Like);
            AgregarReaccion(r1p2, post2);
            Reaccion r2p2 = new Reaccion(m3, TipoReaccion.Dislike);
            AgregarReaccion(r2p2, post2);
            Reaccion r3p2 = new Reaccion(m11, TipoReaccion.Like);
            AgregarReaccion(r3p2, post2);

            //Post 1
            Reaccion r1p3 = new Reaccion(m1, TipoReaccion.Like);
            AgregarReaccion(r1p3, post3);
            Reaccion r2p3 = new Reaccion(m3, TipoReaccion.Dislike);
            AgregarReaccion(r2p3, post3);
            Reaccion r3p3 = new Reaccion(m11, TipoReaccion.Dislike);
            AgregarReaccion(r3p3, post3);

            //REACCIONES A COMENTARIOS

            //Comentario 1
            Reaccion r1c1 = new Reaccion(m1, TipoReaccion.Like);
            AgregarReaccion(r1c1, comentario1p1);
            Reaccion r2c1 = new Reaccion(m3, TipoReaccion.Like);
            AgregarReaccion(r2c1, comentario1p1);
            Reaccion r3c1 = new Reaccion(m11, TipoReaccion.Dislike);
            AgregarReaccion(r3c1, comentario1p1);

            //Comentario 2
            Reaccion r1c2 = new Reaccion(m1, TipoReaccion.Like);
            AgregarReaccion(r1c2, comentario2p1);
            Reaccion r2c2 = new Reaccion(m3, TipoReaccion.Dislike);
            AgregarReaccion(r2c2, comentario2p1);
            Reaccion r3c2 = new Reaccion(m11, TipoReaccion.Like);
            AgregarReaccion(r3c2, comentario2p1);

            //Comentario 3
            Reaccion r1c3 = new Reaccion(m1, TipoReaccion.Like);
            AgregarReaccion(r1c3, comentario3p1);
            Reaccion r2c3 = new Reaccion(m3, TipoReaccion.Dislike);
            AgregarReaccion(r2c3, comentario3p1);
            Reaccion r3c3 = new Reaccion(m11, TipoReaccion.Dislike);
            AgregarReaccion(r3c3, comentario3p1);


        }

        
        //Agrega un usuario a la lista
        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new Exception("El usuario recibido no puede ser nulo.");
            }
            if (_usuarios.Contains(usuario))
            {
                throw new Exception($"El Usuario con el email {usuario.Email} ya fué registrado anteriormente.");
            }
            usuario.Validar();
            _usuarios.Add(usuario);
        }
        //Agrega una invitación a la lista 
        public void AgregarInvitacionAmistad(Invitacion invitacion)
        {
            if (invitacion == null)
            {
                throw new Exception("La invitación a agregar no puede ser nula.");
            }
            if (_invitaciones.Contains(invitacion))
            {
                throw new Exception($"Esta invitación de amistad ya fué ingresada anteriormente");
            }
            invitacion.Validar();
            _invitaciones.Add(invitacion);

        }

        //Agrega una relación de amistad entre dos miembros y pasa la invitación correspondiente a aprobada
        public void AgregarAmigos(Miembro m1, Miembro m2)
        {
            //Primero busca que existe una invitación entre ambos miembros
            Invitacion i1 = BuscarInvitacion(m1, m2);

            //Valida la invitación y los miembros
            if (i1 == null)
            {
                throw new Exception("No existe invitación entre los miembros buscados, por lo tanto no podemos agregar las amistades.");
            }
            if (m1 == null)
            {
                throw new Exception("El miembro 1 no puede ser nulo)");
            }
            if (m2 == null)
            {
                throw new Exception("El miembro 2 no puede ser nulo)");
            }
            if (m1 == m2)
            {
                throw new Exception("Ambos miembros no pueden ser igualess");
            }
            
            //Cambia el estado de la invitación a aceptada y agrega a cada miembro como amigo en la lista del otro 
            i1.AceptarSolicitud();
            m1.AgregarAmigo(m2);
            m2.AgregarAmigo(m1);
        }

        //Agrega un post a la lista 
        public void AgregarPost(Post post)
        {
            if (post == null)
            {
                throw new Exception("El post a agregar no puede ser nulo.");
            }
            if (_publicaciones.Contains(post))
            {
                throw new Exception($"Este Post ya fué ingresado anteriormente");
            }
            post.Validar();
            _publicaciones.Add(post);

        }
        //Agrega un comentario a la lista 
        public void AgregarComentario(Comentario comentario, Post post)
        {
            if (post == null)
            {
                throw new Exception("El post no puede ser nulo.");
            }
            if (comentario == null)
            {
                throw new Exception("El comentario a agregar no puede ser nulo.");
            }
            if (_publicaciones.Contains(comentario))
            {
                throw new Exception($"Este comentario ya fué ingresado anteriormente");
            }
            //Revisamos que el post no esté censurado
            if (post.Censurado)
            {
                throw new Exception("El Post no puede recibir comentarios porque está censurado");
            }

            //Si el post es privado, solamente los amigos del autor pueden comentarlo
            if (post.Privacidad == TipoPrivacidad.Privado && !post.Autor.Amigos.Contains(comentario.Autor))
            {
                throw new Exception("El post es privado, por lo tanto no puede recibir comentarios de miembros que no son amigos del autor");
            }
            //Si el post es privado, solamente los amigos del autor pueden comentarlo
            if (post.Privacidad != comentario.Privacidad)
            {
                throw new Exception("La privacidad del del Post y el comentario a agregar no pueden ser diferentes");
            }

            comentario.Validar();
            _publicaciones.Add(comentario);
        }

        //Agrega una reacción a la lista 
        public void AgregarReaccion(Reaccion reaccion, Publicacion publicacion)
        {
            if (publicacion == null)
            {
                throw new Exception("La publicación no puede ser nula.");
            }

            if (reaccion == null)
            {
                throw new Exception("La reacción a agregar no puede ser nula.");
            }
            if (publicacion.VerSiTieneReaccion(reaccion))
            {
                throw new Exception($"Esta publicacion ya tiene una reaccion de este miembro");
            }

            publicacion.AgregarReacccion(reaccion);
        }


        //Busca, utilizando un email y devuelve el miembro con ese email asociado
        public Miembro BuscarMiembroPorEmail(string email)
        {
            if (_usuarios.Count == 0)
            {
                throw new Exception("La lista de usuarios está vacía");
            }
            if (!Utilidades.StringValido(email))
            {
                throw new Exception("el Email ingresado no puede ser vacío");
            }
            foreach (Usuario miembro in _usuarios)
            {
                if (miembro.Email == email)
                {
                    if (miembro is Miembro)
                    {
                        return (Miembro)miembro;
                    }
                    else
                    {
                        throw new Exception("El usuario buscado no es un miembro");
                    }
                }

            }
            return null;
        }

        //A partir de dos miembros, busca y devuelve la invitación de amistad asociada
        public Invitacion BuscarInvitacion(Miembro m1, Miembro m2)
        {

            foreach (Invitacion invitacion in _invitaciones)
            {

                if ((invitacion.MiembroSolicitante == m1 &&
                invitacion.MiembroSolicitado == m2) || (
                invitacion.MiembroSolicitado == m1 &&
                 invitacion.MiembroSolicitante == m2))
                {

                    return invitacion;
                }
            }
            return null;
        }

        //Devuelve las publicaciones donde un miembro es el autor
        public List<Publicacion> ListarPublicacionesPorMiembro(Miembro miembro)
        {
            List<Publicacion> aux = new List<Publicacion>();

            foreach (Publicacion publicacion in _publicaciones)
            {
                if (publicacion.Autor == miembro)
                {
                    aux.Add(publicacion);
                }
            }
            return aux;
        }

        //Devuelve los posts donde un miembro ha hecho comentarios
        public List<Post> ListarPostsConComentarios(Miembro miembro)
        {
            List<Post> aux = new List<Post>();
            foreach (Publicacion publicacion in _publicaciones)
            {
                if (publicacion.Autor == miembro && publicacion is Comentario)
                {
                    Comentario comentario = (Comentario)publicacion;
                    Post postDelComentario = comentario.Post;
                    if (!aux.Contains(postDelComentario))
                    {
                        aux.Add(postDelComentario);
                    }

                }
            }
            return aux;
        }

        //Devuelve los posts entre dos fechas
        public List<Post> ListarPostsEntreFechas(DateTime fecha1, DateTime fecha2)
        {
            List<Post> aux = new List<Post>();
            foreach (Publicacion publicacion in _publicaciones)
            {
                if (publicacion is Post && publicacion.Fecha >= fecha1 && publicacion.Fecha <= fecha2)
                {
                    Post post = (Post)publicacion;
                    aux.Add(post);
                }
            }
            aux.Sort(CompararTitulos);
            return aux;
        }

        //Compara los títulos para ordenarlos alfabeticamente
        public static int CompararTitulos(Post post1, Post post2)
        {
            return post1.Titulo.CompareTo(post2.Titulo);
        }

        //Devuelve un listado de los miembros que han hecho más publicaciones
        public List<Miembro> MiembrosConMasPublicaciones()
        {
            int maximo = 0;
            List<Miembro> aux = new List<Miembro>();

            foreach (Usuario usuario in _usuarios)
            {
                if (usuario is Miembro)
                {
                    Miembro miembro = (Miembro)usuario;
                    int cantidadPublicaciones = ContarPublicacionesMiembro(miembro);

                    if (cantidadPublicaciones > maximo)
                    {
                        maximo = cantidadPublicaciones;
                        aux.Clear();
                        aux.Add(miembro);
                    }
                    else if (cantidadPublicaciones == maximo)
                    {
                        aux.Add(miembro);
                    }
                }
            }
            return aux;
        }
        //Cuenta las publicaciones que ha hecho un miembro y devuelve la cantidad
        private int ContarPublicacionesMiembro(Miembro miembro)
        {
            int cantidad = 0;
            foreach (Publicacion publicacion in _publicaciones)
            {
                if (publicacion.Autor == miembro)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }

        //ENUMS

        //Enum Solicitudes de amistad
        public enum EstadoInvitacion { PENDIENTE_APROBACION, APROBADA, RECHAZADA }

        //Enum de las publicaciones
        public enum TipoPrivacidad { Publico, Privado }

        //Enum con los tipos de reacciones posibles
        public enum TipoReaccion { Like, Dislike }
    }

}
