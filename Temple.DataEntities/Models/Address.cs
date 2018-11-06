using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Temples.DataEntities.Models
{
    public class Address: EntityBase
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Address1 { get; set; }

        [MaxLength(100)]
        public string Address2 { get; set; }


        [MaxLength(100)]
        public string Address3 { get; set; }

        [MaxLength(100)]
        public string Taluk { get; set; }
        
        public string District { get; set; } //TO DO: this needs to be moved to seperate class

        public string State { get; set; }

        [MinLength(5)]
        [MaxLength(6)]
        public int ZipCode { get; set; }

    }

}
