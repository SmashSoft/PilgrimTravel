using System;
using System.Collections.Generic;
using System.Text;
using Temples.DataEntities.Models;
using Temples.Repository.Interface;
using Temples.Services.Interfaces;

namespace Temples.Services
{
    public class TempleService : ITempleService
    {
        private readonly ITempleRepository _templeRepo;

        public TempleService(ITempleRepository templeRepository)
        {
            _templeRepo = templeRepository;
        }

        public void AddTemple(Temple objTemple)
        {
            _templeRepo.Add(objTemple);            
        }

        public void DeleteTemple(int id)
        {
            Temple objTemple = GetTempleById(id);
            _templeRepo.Remove(objTemple);
        }

        public IEnumerable<Temple> GetAllTemples()
        {
            return _templeRepo.GetAll();
        }

        public IEnumerable<Temple> GetMajorTemples()
        {
           return _templeRepo.GetMajorTemples();
        }

        public Temple GetTempleById(int id)
        {
            return _templeRepo.Get(id);
        }
        
    }
}
