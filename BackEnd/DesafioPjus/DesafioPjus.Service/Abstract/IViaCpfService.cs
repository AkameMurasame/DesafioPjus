using DesafioPjus.Service.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPjus.Service.Abstract
{
   public interface IViaCpfService
    {
        Task<ViaCepDto> consultaCepAsync(string cep);
    }
}
