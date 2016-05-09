using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDDD.Domain.Entities;
using System.Diagnostics;

namespace ProjetoDDD.Domain.Services.Service
{
    public class ClienteService : IClienteService
    {
        
        public void DefinirClienteVip()
        {
            Debug.WriteLine("Cliente vip OK!");
        }
    }
}
