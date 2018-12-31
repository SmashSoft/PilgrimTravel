using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Temples.DataEntities.Models
{
    /// <summary>
    /// Entity for the Temple Diery information
    /// </summary>
    public class Diety
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        [Display(Name ="Diety Name")]
        public string DietyName { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Description { get; set; }

        [Required]
        [MaxLength(5000)]
        public string Features { get; set; }

        [Required]
        public bool IsPrimary { get; set; }


        //TO DO: FK properties
        public int TempleID { get; set; }
        public Temple PrimaryTemple { get; set; }
    }
}
