using MarcoTeste.WebAPI.Models;
using MarcoTeste.WebAPI.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace MarcoTeste.WebAPI.Controllers
{
    [RoutePrefix("motoristas")]
    public class MotoristasController : ApiController
    {
        private MotoristaRepository motoristaRepository;

        public MotoristasController()
        {
            this.motoristaRepository = new MotoristaRepository();
        }

        [HttpGet]
        public IEnumerable<Motorista> Get()
        {
            return motoristaRepository.GetAllDrivers();
        }
    }
}
