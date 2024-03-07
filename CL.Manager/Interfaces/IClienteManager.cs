﻿using CL.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.Interfaces
{
    public interface IClienteManager
    {
        Task<Cliente> GetClienteAsync(int id);

        Task<IEnumerable<Cliente>> GetClienteAsync();        
    }
}