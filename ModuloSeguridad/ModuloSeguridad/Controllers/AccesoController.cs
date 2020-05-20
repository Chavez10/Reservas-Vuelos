using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModuloSeguridad.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string user, string pass)
        {
            try {
                using (Models.BDSEGURIDADEntities db = new Models.BDSEGURIDADEntities())
                {
                    var usuarios = (from datos in db.USUARIOS
                                   where datos.NIC_USER == user.Trim()
                                   && datos.PAS_USER == pass.Trim()
                                   select datos).FirstOrDefault();
                    if(usuarios == null)
                    {
                        ViewBag.Error = "Usuario o contraseña incorrectos";
                        return View();
                    }else
                    {
                        Session["user"] = usuarios;

                    }
                }
                return RedirectToAction("Index", "Home");
            }
            catch {
                return View();
            }
            
        }
    }
}