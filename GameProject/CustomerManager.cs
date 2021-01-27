using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CustomerManager
    {
        public void Save(Customer customer)
        {

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "isimli oyuncu sisteme kayıt edildi.");
        }

        public void Update(Customer customer)
        {

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + " isimli oyuncunun bilgileri güncellendi.");
        }

        public void Delete(Customer customer)
        {

            Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + "isimli oyuncu sistemden silindi.");
        }
    }   
}
