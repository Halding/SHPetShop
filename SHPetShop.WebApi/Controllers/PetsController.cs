using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SH.PetShop.Core.IServices;
using SH.PetShop.Core.Models;

namespace SHPetShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private readonly IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }
        
        [HttpPost]
        public Pet Create(string name,PetType type,string color,DateTime birthday,DateTime soldDate,double price)
        {
            return _petService.CreatePet(name, type, color, birthday, soldDate, price);
        }
        
        [HttpGet]
        public ActionResult<List<Pet>> GetPetList()
        {
            return _petService.GetAllPets();
        }

        [HttpDelete]
        public ActionResult<Pet> DeletePet(int id)
        {
            return _petService.DeletePet(id);
        }
        

    }
}