using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfCodeFirst.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public string Autor { get; set; }
        public DateTime Publicacion { get; set; }
    }
}