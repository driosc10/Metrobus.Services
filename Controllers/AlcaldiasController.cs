using Metrobus.Services.Contexts;
using Metrobus.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrobus.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlcaldiasController : ControllerBase
    {
        private readonly AppDbContext context;

        public AlcaldiasController(AppDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Obtiene toda la información de las Alcadias
        /// </summary>
        /// <returns>Lista de Alcaldias</returns>
        [HttpGet]
        public IEnumerable<Alcaldias> Get()
        {
            return context.Alcaldias.ToList();
        }

        /// <summary>
        /// Inserta la información de una Alcaldia
        /// </summary>
        /// <param name="alcaldia"></param>
        /// <returns>ActionResult</returns>
        [HttpPost]
        public ActionResult Insert([FromBody] Alcaldias alcaldia)
        {
            try
            {
                context.Alcaldias.Add(alcaldia);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
