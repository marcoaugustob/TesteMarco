using MarcoTeste.WebAPI.Dtos;
using MarcoTeste.WebAPI.Models;
using MarcoTeste.WebAPI.Services;
using System;
using System.Web.Http;

namespace MarcoTeste.WebAPI.Controllers
{
    [System.Web.Http.RoutePrefix("api/Veiculo")]
    public class VeiculosController : ApiController
    {
        private VeiculoRepository veiculoRepository;

        public VeiculosController()
        {
            this.veiculoRepository = new VeiculoRepository();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(VeiculoDTO veiculoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (veiculoDto == null)
            {
                return BadRequest();
            }

            try
            {

                var veiculo = new Veiculo
                {
                    Id = veiculoRepository.CountVeiculos(),
                    Placa = veiculoDto.Placa,
                    Frota = veiculoDto.Frota,
                    Propriedade = veiculoDto.Propriedade,
                    TipoVeiculo = veiculoDto.TipoVeiculo,
                    TipoCarroceria = veiculoDto.TipoCarroceria,
                    Fabricante = veiculoDto.Fabricante,
                    Modelo = veiculoDto.Modelo,
                    AnoFabricacao = veiculoDto.AnoFabricacao,
                    AnoModelo = veiculoDto.AnoModelo,
                    Pais = veiculoDto.Pais,
                    CidadeUF = veiculoDto.CidadeUF,
                    Tara = veiculoDto.Tara != null && veiculoDto.Tara != 0 ? veiculoDto.Tara : 0,
                    CapacidadeCarga = veiculoDto.CapacidadeCarga != null && veiculoDto.CapacidadeCarga != 0 ? veiculoDto.CapacidadeCarga : 0,
                    Cubagem = veiculoDto.Cubagem != null && veiculoDto.Cubagem != 0 ? veiculoDto.Cubagem : 0,
                    MotoristaId = veiculoDto.MotoristaId != null && veiculoDto.MotoristaId != 0 ? veiculoDto.MotoristaId : 0,
                    Proprietario = veiculoDto.Proprietario
                };

                veiculoRepository.SaveVeiculo(veiculo);
                return Ok();
            }
            catch (Exception ex)
            {
               return BadRequest();
            }




        }
    }
}