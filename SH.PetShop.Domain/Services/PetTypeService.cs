using System.Collections.Generic;
using SH.PetShop.Core.IServices;
using SH.PetShop.Core.Models;
using SH.PetShop.Domain.IRepositories;

namespace SH.PetShop.Domain.Services
{
    public class PetTypeService : IPetTypeService
    {
        private IPetTypeRepositorie _repo;

        public PetTypeService(IPetTypeRepositorie repo)
        {
            _repo = repo;
        }
        
        public List<PetType> GetAllPetTypes()
        {
            throw new System.NotImplementedException();
        }

        public PetType GetPetTypeById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}