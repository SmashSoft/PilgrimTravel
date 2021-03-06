﻿using System;
using System.Collections.Generic;
using System.Text;
using Temples.DataEntities.Models;

namespace Temples.ViewMapper.ModelEntities
{
    public class TempleViewModel
    {        
        public int ID { get; set; }
     
        public string Name { get; set; }

        public string Note { get; set; }

        public int AddressID { get; set; }

        public Address PrimaryAddress { get; set; }

        public int StyleID { get; set; }

        public Style PrimaryStyle { get; set; }

    }
}
