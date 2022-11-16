using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemploMVC_vistas.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListaUsuarios()
        {
            List<string> listaUsuarios = new List<string>();
            listaUsuarios.Add("Fernando");
            listaUsuarios.Add("Gustavo");
            listaUsuarios.Add("Carlos");
            listaUsuarios.Add("Alfredo");
            listaUsuarios.Add("Felipe");
            listaUsuarios.Add("Roman");
            listaUsuarios.Add("Ricardo");

            // ViewBag.ListaUsuarios = listaUsuarios;
            // TempData["listaUsuarios"] = listaUsuarios;
            // Session["ListaUsuarios"] = listaUsuarios;
            ViewData["ListaUsuarios"] = listaUsuarios;

            return View(listaUsuarios);
        }

        [HttpPost]
        public ActionResult ListaUsuarios(string selectUsuarios)
        {
            ViewBag.Nombre = selectUsuarios;

            // List<string> listaUsuarios = ViewBag.ListaUsuarios;
            //List<string> listaUsuarios = (List<string>)TempData["ListaUsuarios"];
            //List<string> listaUsuarios = (List<string>)Session["ListaUsuarios"];
            List<string> listaUsuarios = (List<string>)ViewData["ListaUsuarios"];

            return View(listaUsuarios);
        }
    }
}