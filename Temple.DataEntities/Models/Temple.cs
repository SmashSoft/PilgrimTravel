using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Temples.DataEntities.Models;

namespace Temples.DataEntities.Models
{
    public class Temple: EntityBase
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }        
        public string Note { get; set; }
        
        public int AddressID { get; set; }
        public Address PrimaryAddress { get; set; } 
        public int StyleID { get; set; }
        public Style PrimaryStyle { get; set; }
    }
}
