using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.IoC;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private IContatoService _contatoService;

        public ContatoController(IContatoService contatoService)
        {
            _contatoService = contatoService;
        }
        [HttpGet]
        public List<Contato> GetAll()
        {
            return _contatoService.GetAll().ToList();
        }
        [HttpPost]
        public Validate Add(Contato contato)
        {
            return _contatoService.Add(contato);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            var contato = _contatoService.Get(id);
            _contatoService.Remove(contato);
        }
        [HttpPut]
        public void Update(Contato contato)
        {
            _contatoService.Update(contato);
        }
    }

}
