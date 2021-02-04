using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Metrobus.Services.Models
{
    /// <summary>
    /// Represent a entitty model of Metrobuses
    /// </summary>
    //[Table("Metrobuses")]
    public class Metrobuses
    {
        /// <summary>
        /// Identificador único del Metrobus
        /// </summary>
        [Key]
        public int MetrobusID { get; set; }
        /// <summary>
        /// Identificador del vehículo
        /// </summary>
        public int Vehicle_ID { get; set; }
        /// <summary>
        /// Latitud del Metrobus
        /// </summary>
        public string Latitud { get; set; }
        /// <summary>
        /// Longitud del Metrobus
        /// </summary>
        public string Longitud { get; set; }
        /// <summary>
        /// Fecha de actualización de las coordenadas del Metrobus
        /// </summary>
        public DateTime Date_Update { get; set; }
    }
}
