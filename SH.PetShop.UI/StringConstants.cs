using System;

namespace SH.PetShop.UI
{
    public class StringContants
    {
        public const string WelcomeText = "__________Welcome to PetshopMenu__________";
        public const string IntInvalid = "The input was not or Number or something else when wrong tryagain";
        public const string AddPetMes = "Hello to add a pet Please enter the following infomation.";
        public const string AddPetName = "Please Enter the name of the Pet";
        public const string AddPetTypeToPet = "Choose what PetType from the List";
        public void WelcomeMes()
        {
            
            Console.WriteLine($"{WelcomeText}");
            Console.WriteLine("                             .-.");
            Console.WriteLine("(___________________________()6 `-,");
            Console.WriteLine("(   ______________________   /''\"`");
            Console.WriteLine("//\\\\                      //\\\\");
            Console.WriteLine("\"\" \"\"                     \"\" \"\"");
            Console.WriteLine();
        }
        
        
    }
    
    
    
   
    
}