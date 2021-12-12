using AutoMapper;
using DesafioPjus.Domain.Cep;
using DesafioPjus.Service.Abstract;
using DesafioPjus.Service.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPjus.Service.Concrete
{
    public class ViaCpfService : IViaCpfService
    {
        private readonly HttpClient _httpClient;
        private readonly ICepRepository _cepRepository;
        private readonly IMapper _mapper;

        public ViaCpfService(HttpClient httpClient, ICepRepository cepRepository, IMapper mapper)
        {
            _httpClient = httpClient;
            _cepRepository = cepRepository;
            _mapper = mapper;
        }

        public async Task<ViaCepDto> consultaCepAsync(string cep)
        {
            var viaCepDto = await consultaViaCepAsync(cep);

            var cepEntity = _mapper.Map<Cep>(viaCepDto);

            var dbCep = await _cepRepository.FindByCep(viaCepDto.cep);

            if (dbCep == null)
            {
                await _cepRepository.AddAsync(cepEntity);
            }

            return viaCepDto;
        }

        private async Task<ViaCepDto> consultaViaCepAsync(string cep)
        {
            var responseString = await _httpClient.GetStringAsync(@$"https://viacep.com.br/ws/{cep}/json/");
            var viaCepDto = JsonConvert.DeserializeObject<ViaCepDto>(responseString);
            return viaCepDto;
        }
    }
}
