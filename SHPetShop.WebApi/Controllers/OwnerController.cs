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
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        [HttpPost]
        public Owner Create(string name, List<int> petId)
        {
            return _ownerService.CreateOwner(name, petId);
        }
    }
}