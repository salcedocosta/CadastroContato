using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.IoC;
using Service.IoC;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private IContatoService _contatoService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IContatoService contatoService)
        {
            _logger = logger;
            _contatoService = contatoService;
        }

        [HttpGet]
        public IEnumerable<Contato> Get()
        {
            _contatoService.Add(new Domain.Contato()
            {
                Nome = "Salcedo",
                DataNascimento = Convert.ToDateTime("11/07/1981"),
                Idade = new Random().Next(0,100),
                Sexo = "M"

            });
            return _contatoService.GetAll();
        }

        [HttpPost]
        public void Post(Contato contato)
        {
            //_contatoService.Add(contato);
            _contatoService.Add(new Domain.Contato()
            {
                Nome = "Salcedo",
                DataNascimento = Convert.ToDateTime("11/07/1981"),
                Idade = 38,
                Sexo = "M"

            });
        }
    }
}
