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
    public class RastreioController : ControllerBase
    {
        private IRastreioService _rastreioService;

        public RastreioController(IRastreioService rastreioService)
        {
            _rastreioService = rastreioService;
        }
        [HttpGet]
        public List<Rastreio> GetAll()
        {
            return _rastreioService.GetAll().ToList();
        }
        [HttpPost]
        public void Add(Rastreio rastreio)
        {
            _rastreioService.Add(rastreio);
        }
        [HttpDelete]
        public void Delete(int id)
        {
            var rastreio = _rastreioService.Get(id);
            _rastreioService.Remove(rastreio);                
        }
        [HttpPut]
        public void Update(Rastreio rastreio)
        {
            _rastreioService.Update(rastreio);
        }
        


    }
}
