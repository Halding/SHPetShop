using System;
using System.Runtime.CompilerServices;
using SH.PetShop.Core.IServices;

namespace SH.PetShop.UI
{
    public class Menu
    {
        private readonly IPetService _service;
        private Util _ = new Util();

        public string[] menuItems =
        {
          "List All Pets",
          "Add New Pet",
          "Delete a Pet",
          "Search for Pet",
          "Edit Pet",
          "Exit"
            
        };

        public Menu(IPetService service)
        {
            _service = service;
        }

        public void ShowMenu()
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                _.CWL($"Press ({i + 1}) {menuItems[i]}");
            }

            Console.ReadLine();
        }
        
        
        
    }
}