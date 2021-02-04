using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Metrobus.Services.Models
{
    /// <summary>
    /// Represent a entitty model of Alcaldias
    /// </summary>
    //[Table("Alcaldias")]
    public class Alcaldias
    {
        /// <summary>
        /// Identificador único de la Alcaldia
        /// </summary>
        [Key]
        public int AlcaldiaID { get; set; }
        /// <summary>
        /// Nombre de la Alcaldia
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Latitud de la Alcaldia
        /// </summary>
        public string Latitud { get; set; }
        /// <summary>
        /// Longitud de la Alcaldia
        /// </summary>
        public string Longitud { get; set; }
    }
}
