using System.Collections.Generic;
using SH.PetShop.Core.Models;

namespace SH.PetShop.Core.IServices
{
    public interface IPetTypeService
    {
         List<PetType> GetAllPetTypes();

         PetType  GetPetTypeById(int id);
    }
}