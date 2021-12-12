using DesafioPjus.Domain.Cep;
using DesafioPjus.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPjus.Infrastructure.Domain.Cep
{
    public class CepRepository : ICepRepository
    {

        private readonly DesafioPjusDbContext _context;

        public CepRepository(DesafioPjusDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddAsync(DesafioPjus.Domain.Cep.Cep cep)
        {
            await _context.Cep.AddAsync(cep);
            await _context.SaveChangesAsync();
        }

        public async Task<DesafioPjus.Domain.Cep.Cep> FindByCep(string cep)
        {
            return await _context
               .Cep.Where(e => e.cep == cep).FirstOrDefaultAsync();
        }
    }
}
