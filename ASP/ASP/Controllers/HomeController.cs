using ASP.Models;
using ASP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public bool Empleado { get; set; }
        public DateTime Nacimiento { get; set; }
    }

    public class HomeController : Controller
    {
        private PeliculasService _peliculasService;

        public HomeController()
        {
            _peliculasService = new PeliculasService();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var persona = new Persona()
            {
                Nombre = "Claudia",
                Edad = 35,
                Empleado = true,
                Nacimiento = new DateTime(2015, 1, 2)
            };
            var personas = new List<Persona>()
            {
                new Persona()
                {
                    Nombre = "Marcela",
                    Edad = 18
                },
                new Persona()
                {
                    Nombre = "Henry",
                    Edad = 40
                },
                new Persona()
                {
                    Nombre = "Daniela",
                    Edad = 27
                }
            };

            ViewBag.MiListados = personas;
            ViewBag.Propiedad = persona;
            ViewBag.MiListado = ObtenerListado();
            ViewBag.MiListadoEnum = ToListSelectListItem<ResultadoOperacion>();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Persona persona)
        {
            ViewBag.Message = "Exitoso";
            return View(persona);
        }

        private List<SelectListItem> ToListSelectListItem<T>()
        {
            var t = typeof(T);

            if (!t.IsEnum)
            {
                throw new ApplicationException("Tipo debe ser Enum");
            }

            var members = t.GetFields(BindingFlags.Public | BindingFlags.Static);

            var result = new List<SelectListItem>();

            foreach (var member in members)
            {
                var attributeDescription = member.GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);
                var descripcion = member.Name;

                if (attributeDescription.Any())
                {
                    descripcion = ((System.ComponentModel.DescriptionAttribute)attributeDescription[0]).Description;
                }

                var valor = ((int)Enum.Parse(t, member.Name));
                result.Add(new SelectListItem()
                {
                    Text = descripcion,
                    Value = valor.ToString()
                });
            }
            return result;
        }

        public List<SelectListItem> ObtenerListado()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "Sí",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "No",
                    Value = "2",
                },
                new SelectListItem()
                {
                    Text = "Quizás",
                    Value = "3"
                }
            };
        }

        //public ContentResult Index()
        //{
        //    return Content("<b>Felipe</b>");
        //}

        //public JsonResult Index()
        //{
        //    var persona1 = new Persona() { Nombre = "Felipe", Edad = 99 };
        //    var persona2 = new Persona() { Nombre = "Claudia", Edad = 90 };

        //    return Json(new List<Persona>() { persona1, persona2 }, JsonRequestBehavior.AllowGet);
        //}

        //public RedirectResult Index()
        //{
        //    return Redirect("https://google.com.mx");
        //}

        //public RedirectToRouteResult Index()
        //{
        //    return RedirectToAction("Register", "Account");
        //}

        //public ActionResult Index()
        //{
        //    return RedirectToRoute("Ejemplo");
        //}

        //public HttpStatusCodeResult Index()
        //{
        //    //return new HttpStatusCodeResult(301);
        //    return new HttpStatusCodeResult(404, "Recurso no encontrado");
        //}

        //public FileResult Index()
        //{
        //    var ruta = Server.MapPath("HTML5.pdf");
        //    return File(ruta, "application/pdf", "Ejemplo.pdf");
        //}

        public ActionResult About(string edad)
        {
            ViewBag.Message = "Your application description page." + edad;

            var peliculasService = new PeliculasService();
            var model = peliculasService.getPeliculas();

            return View(model);
        }

        [ChildActionOnly]
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. ";
            ViewBag.UnInt = 45;
            ViewBag.UnaFecha = new DateTime(1800, 4, 7);
            ViewData["MiMensaje"] = "esto con View Data";

            var model = _peliculasService.getPeliculas();

            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(string nombre)
        {
            ViewBag.Message = "Your contact page. " + nombre;

            return View();
        }

        public ActionResult MiAction()
        {
            return View();
        }
    }
}