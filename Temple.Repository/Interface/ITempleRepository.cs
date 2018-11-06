using System;
using System.Collections.Generic;
using System.Text;
using Temples.DataEntities.Models;

namespace Temples.Repository.Interface
{
    /// <summary>
    /// Any additional reporitoy method will go here
    /// </summary>
    public interface ITempleRepository:IGenericRepository<Temple>
    {
        IEnumerable<Temple> Temples { get;  }

        IEnumerable<Temple> GetMajorTemples();
    }
}
