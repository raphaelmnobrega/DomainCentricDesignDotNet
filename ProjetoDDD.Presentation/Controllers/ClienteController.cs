using projetoDDD.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoDDD.Domain.Services.Service;
using projetoDDD.Application.Interfaces;

namespace ProjetoDDD.Presentation.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        private IAppClienteService appClienteService;

        public ClienteController(IAppClienteService iAppCliente)
        {
            this.appClienteService = iAppCliente;
        }

        public ActionResult Index()
        {
            appClienteService.DefinirClienteVip();
            return View();
        }
    }
}