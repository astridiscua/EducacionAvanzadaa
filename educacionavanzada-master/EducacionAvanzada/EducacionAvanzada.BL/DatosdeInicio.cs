using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducacionAvanzada.BL
{
    
        public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
        {
            protected override void Seed(Contexto contexto)
            {
                var nuevoUsuario = new Usuario();
                nuevoUsuario.Nombre = "admin";
                nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario1 = new Usuario();
            nuevoUsuario.Nombre = "astrid";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario2 = new Usuario();
            nuevoUsuario.Nombre = "jaime";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario3 = new Usuario();
            nuevoUsuario.Nombre = "carolina";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            var nuevoUsuario4 = new Usuario();
            nuevoUsuario.Nombre = "anner";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");
            contexto.Usuarios.Add(nuevoUsuario);

                base.Seed(contexto);
            }
}
}

