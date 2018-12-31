using System;
using System.Collections.Generic;
using System.Text;
using Temples.DataEntities.Models;

namespace Temples.Services.Interfaces
{
    public interface ITempleService
    {
        Temple GetTempleById(int id);

        void AddTemple(Temple objTemple);
        
        void DeleteTemple(int id);

        IEnumerable<Temple> GetAllTemples();

        IEnumerable<Temple> GetMajorTemples();
    }
}
