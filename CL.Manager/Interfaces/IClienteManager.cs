﻿using CL.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CL.Manager.Interfaces
{
    public interface IClienteManager
    {
        Task DeleteClienteAsync(int id);

        Task<Cliente> GetClienteAsync(int id);

        Task<IEnumerable<Cliente>> GetClienteAsync();

        Task<Cliente> InsertClienteAsync(Cliente cliente);
        Task<Cliente> UpdateClienteAsync(Cliente cliente);
    }
}
