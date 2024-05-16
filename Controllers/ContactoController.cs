using Microsoft.AspNetCore.Mvc;

using CRUDCORE.Datos;
using CRUDCORE.Models;

namespace CRUDCORE.Controllers
{
    public class ContactoController : Controller
    {

        ContactoDatos _ContactoDatos = new ContactoDatos();

        public IActionResult Index()
        {
            //LA VISTA MOSTRARÁ UNA LISTA DE CONTACTOS
            var oLista = _ContactoDatos.Index();

            return View(oLista);
        }

        public IActionResult Create()
        {
            //METODO SOLO DEVUELVE LA VISTA
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactoModel oContacto)
        {
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN BD
            if (!ModelState.IsValid)
                return View();


            var respuesta = _ContactoDatos.Create(oContacto);

            if (respuesta)
                return RedirectToAction("Index");
            else 
                return View();
        }

        public IActionResult Edit(int IdContacto)
        {
            //METODO SOLO DEVUELVE LA VISTA
            var ocontacto = _ContactoDatos.Obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Edit(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
                return View();


            var respuesta = _ContactoDatos.Edit(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }


        public IActionResult Eliminar(int IdContacto)
        {
            //METODO SOLO DEVUELVE LA VISTA
            var ocontacto = _ContactoDatos.Obtener(IdContacto);
            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {
  
            var respuesta = _ContactoDatos.Eliminar(oContacto.IdContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

    }
}