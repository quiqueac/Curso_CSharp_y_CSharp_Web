using ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Services
{
    public class PeliculasService
    {
        public Pelicula getPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Escape plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 5, 5)
            };
        }

        public List<Pelicula> getPeliculas()
        {
            //var pelicula1 = new Pelicula()
            //{
            //    Titulo = "Escape plan",
            //    Duracion = 115,
            //    Pais = "USA",
            //    Publicacion = new DateTime(2013, 5, 5)
            //};
            //var pelicula2 = new Pelicula()
            //{
            //    Titulo = "Jumanji",
            //    Duracion = 120,
            //    Pais = "México",
            //    Publicacion = new DateTime(2016, 6, 2)
            //};

            //return new List<Pelicula> { pelicula1, pelicula2 };
            return new List<Pelicula>()
            {
                new Pelicula()
                {
                    Titulo = "Pete's Dragon",
                    Duracion = 115,
                    Pais = "USA",
                    Publicacion = new DateTime(2013, 5, 5),
                    EstaEnCartelera = true,
                    Genero = "Fantasía"
                },
                new Pelicula()
                {
                    Titulo = "Mechanic: Resurrection",
                    Duracion = 115,
                    Pais = "USA",
                    Publicacion = new DateTime(2013, 5, 5),
                    EstaEnCartelera = true,
                    Genero = "Acción"
                },
                new Pelicula()
                {
                    Titulo = "Deadpool",
                    Duracion = 115,
                    Pais = "USA",
                    Publicacion = new DateTime(2013, 5, 5),
                    EstaEnCartelera = false,
                    Genero = "Acción"
                }
            };
        }
    }
}
