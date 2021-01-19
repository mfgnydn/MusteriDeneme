using System;
using System.Collections.Generic;
using System.Text;

namespace MusteriDeneme
{
    class CustomerManager
    {
        public void Add()
        {
            Console.Write("Id = " );
            Convert.ToInt32(Console.ReadLine());
            Console.Write("Name = " );
            Console.ReadLine();
            Console.Write("LastName = " );
            Console.ReadLine();
            Console.Write("Adress = " );
            Console.ReadLine();
        }
        public void Delete()
        {
            Console.Write("Id = ");
            Convert.ToInt32(Console.ReadLine());
            Console.Write("Name = ");
            Console.ReadLine();
            Console.Write("LastName = ");
            Console.ReadLine();
            Console.Write("Adress = ");
            Console.ReadLine();
        }
        public void Liste()
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "ELON";
            customer1.LastName = "MUSK";
            customer1.Adress = "NEWYORK";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "JEFF";
            customer2.LastName = "BEZOS";
            customer2.Adress = "LASVEGAS";

            Customer customer3 = new Customer();
            customer3.Id = 4;
            customer3.Name = "FURKAN";
            customer3.LastName = "GÜNAYDIN";
            customer3.Adress = "GİRESUN";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (var customer in customers)
            {
                Console.WriteLine("Id = " + customer.Id);
                Console.WriteLine("Name = " + customer.Name);
                Console.WriteLine("LastName = " + customer.LastName);
                Console.WriteLine("Adress = " + customer.Adress);
                Console.WriteLine("----------------------");
            }

               
        }



    }
}
