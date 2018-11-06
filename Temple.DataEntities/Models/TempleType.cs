using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Temples.DataEntities.Models
{
    /// <summary>
    /// Entity for the Temple Type 
    /// Example : 
    /// </summary>
    public class TempleType
    {
        [Key]
        public long ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

    }
}
