using System.Collections.Generic;
using SH.PetShop.Core.Models;

namespace SH.PetShop.Domain.IRepositories
{
    public interface IPetTypeRepositorie
    {

        List<PetType> FindAllPetTypes();


        PetType FindPetTypeById(int id);
    }
}