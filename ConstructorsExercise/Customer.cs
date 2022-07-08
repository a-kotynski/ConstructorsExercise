//https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/learn/lecture/2484618#content

namespace ConstructorsExercise
{
    public class Customer
    {
        public int Id; // field declaration
        public string Name; // same // default value for strings and any other reference
                            // types is null

        public List<Order> Orders; //requires initialization in a constructor

        public Customer()
        {
            Orders = new List<Order>(); // if you use the constructors below, the list will
                                        // become null - we solve it with adding : this()
        }
        public Customer(int id) : this() // this() is a constructor without parameters
        {
            this.Id = id;
        }
        public Customer(int id, string name) : this(id)
        {
            //this.Id = id;
            this.Name = name;
        }
        // this() is used for specifying any other constructors we're passing control to
    }
}