using Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            IEnumerable<mvcUsuario> empList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Usuario").Result;
            empList = response.Content.ReadAsAsync<IEnumerable<mvcUsuario>>().Result;
            return View(empList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new mvcUsuario());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Usuario/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcUsuario>().Result);
            }

        }
        //Nuevo y actualizacion
        [HttpPost]
        public ActionResult AddOrEdit(mvcUsuario emp)
        {
            if (emp.UsuarioId == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Usuario", emp).Result;
                TempData["SuccessMessage"] = "Nuevo registro almacenado ";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Usuario/" + emp.UsuarioId,
                    emp).Result;
                TempData["SuccessMessage"] = "Actualizado exitosamente...!";
            }
            return RedirectToAction("Index");
        }
        //Delete
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Usuario/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }

    }
}