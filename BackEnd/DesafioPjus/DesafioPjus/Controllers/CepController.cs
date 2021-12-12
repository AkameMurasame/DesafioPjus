using DesafioPjus.Service.Abstract;
using DesafioPjus.Service.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPjus.Controllers
{
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCpfService _cpfService;

        public CepController(IViaCpfService cpfService)
        {
            _cpfService = cpfService;
        }

        [HttpGet("consulta/{cep}")]
        [ProducesResponseType(typeof(ViaCepDto), StatusCodes.Status200OK)]
        public async Task<ViaCepDto> pesquisarCep(string cep)
        {
            var viaCep = await _cpfService.consultaCepAsync(cep);

            return viaCep;
        }
    }
}
