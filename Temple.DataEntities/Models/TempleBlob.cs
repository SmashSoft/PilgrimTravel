using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Temples.DataEntities.Models
{
    /// <summary>
    /// Temple blob entity
    /// </summary>
    public class TempleBlob: EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]        
        public string History { get; set; }
        [Required]
        public string Importance { get; set; }

        //FK
        public int TempleID { get; set; }
        public Temple PrimaryTemple { get; set; }

    }
}
