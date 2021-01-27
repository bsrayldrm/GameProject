using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SaleManager
    {
        public void Sale(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName+" "  + game.GameName + " " + "oyununu sayın aldı.");
        } 

       
    }
}
