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

        // GET: api/Motoristas
        [HttpGet]
        public IEnumerable<Motorista> Get()
        {
            return motoristaRepository.GetAllDrivers();
        }

        //// GET: api/Motoristas/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Motoristas
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Motoristas/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Motoristas/5
        //public void Delete(int id)
        //{
        //}
    }
}
