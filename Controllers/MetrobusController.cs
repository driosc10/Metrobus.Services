using Metrobus.Services.Contexts;
using Metrobus.Services.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrobus.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetrobusController : ControllerBase
    {
        private readonly AppDbContext context;

        public MetrobusController(AppDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Obtiene toda la información de los Metrobuses
        /// </summary>
        /// <returns>Lista de Metrobuses</returns>
        [HttpGet]
        public IEnumerable<Metrobuses> Get()
        {
            return context.Metrobuses.ToList();
        }

        /// <summary>
        /// Obtiene la información del Metrobus por su identificador
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Metrobus</returns>
        [HttpGet("id")]
        public IEnumerable<Metrobuses> Get(int id)
        {
            var metrobus = context.Metrobuses.Where(m => m.Vehicle_ID == id).ToList();
            return metrobus;
        }

        /// <summary>
        /// Inserta la información de un Metrobus
        /// </summary>
        /// <param name="metrobus"></param>
        /// <returns>ActionResult</returns>
        [HttpPost]
        public ActionResult Insert([FromBody] Metrobuses metrobus)
        {
            try
            {
                context.Metrobuses.Add(metrobus);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Actualiza la información de un Metrobus
        /// </summary>
        /// <param name="metrobus"></param>
        /// <returns>ActionResult</returns>
        [HttpPut("{id}")]
        public ActionResult Update([FromBody] Metrobuses metrobus)
        {
            try
            {
                context.Entry(metrobus).State = EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
