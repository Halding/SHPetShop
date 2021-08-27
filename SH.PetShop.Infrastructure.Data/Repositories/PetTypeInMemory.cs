using System.Collections.Generic;
using SH.PetShop.Core.Models;
using SH.PetShop.Domain.IRepositories;

namespace SH.PetShop.Infrastructure.Data.Repositories
{
    public class PetTypeInMemory : IPetTypeRepositorie
    {
        private static List<PetType> PetTypeList = new List<PetType>();

        public PetTypeInMemory()
        {
            PetType cat = new PetType {Id = 1, Name = "Cat"};
            PetType dog = new PetType {Id = 2, Name = "Dog"};
            PetType pig = new PetType {Id = 3, Name = "Pig"};
            
            PetTypeList.AddRange(new List<PetType>{cat,dog,pig});
            
        }

        public List<PetType> FindAllPetTypes()
        {
            return PetTypeList;
        }

        public PetType FindPetTypeById(int id)
        {
            foreach (var petType in PetTypeList)
            {
                if (petType.Id == id)
                {
                    return petType;
                }
            }

            return null;
        }
    }
}