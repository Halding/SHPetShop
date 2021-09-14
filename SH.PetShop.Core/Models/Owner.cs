using System.Collections.Generic;

namespace SH.PetShop.Core.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }

        public string Name { get; set; }

        public List<int> PetId { get; set; }

    }
}