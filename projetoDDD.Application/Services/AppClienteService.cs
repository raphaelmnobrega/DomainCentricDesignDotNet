using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using projetoDDD.Application.Interfaces;

namespace projetoDDD.Application.Services
{
    public class AppClienteService : IAppClienteService
    {
        private IClienteService service;

        public AppClienteService(IClienteService service)
        {
            this.service = service;
        }

        public void DefinirClienteVip()
        {
            this.service.DefinirClienteVip();
        }
    }
}
