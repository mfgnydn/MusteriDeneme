using System;

namespace MusteriDeneme
{
    class Program
    {
        static void Main(string[] args)
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
            customer2.Adress = "LAS VEGAS";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "BILL";
            customer3.LastName = "GATES";
            customer3.Adress = "INDIANA";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            foreach (var customer in customers)
            {
                Console.WriteLine("Id = " + customer.Id);
                Console.WriteLine("Name = " + customer.Name);
                Console.WriteLine("LastName = " + customer.LastName);
                Console.WriteLine("Adress = " + customer.Adress);
                Console.WriteLine("----------------------");

            }
            Console.WriteLine("_______________________MÜŞTERİ EKLEME_________________________");

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();

            Console.WriteLine("_______________________MÜŞTERİ SİLME____________________________");

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Delete();

            Console.WriteLine("_______________________MÜŞTERİ LİSTESİ____________________________");

            CustomerManager customerManager3 = new CustomerManager();
            customerManager1.Liste();




        }
    }
}
