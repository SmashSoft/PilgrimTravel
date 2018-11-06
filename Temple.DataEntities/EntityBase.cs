using System;
using System.Collections.Generic;
using System.Text;

namespace Temples.DataEntities
{
    public class EntityBase
    {
        public DateTime? Created { get; set; }

        public DateTime? Updated { get; set; }

        public bool Deleted { get; set; }

        public EntityBase()
        {

            Deleted = false;

        }
    }
}
