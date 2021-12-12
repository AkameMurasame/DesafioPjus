using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPjus.Domain.Cep
{
    public interface ICepRepository
    {
        Task AddAsync(Cep cep);

        Task<Cep> FindByCep(string cep);
    }
}
