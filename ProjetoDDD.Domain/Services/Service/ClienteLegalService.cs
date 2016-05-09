using ProjetoDDD.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Services.Service
{
    public class ClienteLegalService : IClienteService
    {
        public void DefinirClienteVip()
        {
            Debug.WriteLine("Cliente vip legal");
        }
    }
}
