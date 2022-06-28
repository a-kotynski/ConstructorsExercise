using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2484618#content

namespace ConstructorsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //var customer = new Customer(1, "John"); // same thing as below
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "John";

            var order = new Order();
            //customer.Orders = new List<Order>(); // in Main() method we should not be
                                                 // responsible for initializing an Order's list
                                                 // because we need to remember to initialize it all over again
                                                 // every single time we use a Customer object
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}