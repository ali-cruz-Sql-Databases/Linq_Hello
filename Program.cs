using System;
using System.Collections.Generic;


/* IEnumerable       
 *  - Current element
 *  - Move Next element
 *  - NOT possible to manipulate (can't back, jump, reset, access with an index)
 *  - Loops over generic and non-generic list
 *  - Loops over linq query
 *  - Just has one method GetEnumerator
 *  
 *  Miembros: Enumerable / IEnumerator
 *      - MoveNext() : Set enumerator to the next element of the collection
 *      - Reset : Sets enumerator to its initial position (is before the first element)
 *      - Current (Property)
 * 
 */


// IEnumerable in action

namespace HelloLinq
{
    public class main
    {
        Customer[] customers = new Customer[]
        {
            new Customer { Name = "Ali", City = "MX", Mobile = 2222996577, Amount = 5495.50 },
            new Customer { Name = "Sara", City = "MX", Mobile = 2222665598, Amount = 152.63 },
            new Customer { Name = "TD", City = "PUE", Mobile = 222233365, Amount = 15623.33 }
        };

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customers;
        }

        foreach (var cust in GetAllCustomer()) 
        {   
            Console.WriteLine("Hola");
        }
}



    public class Customer
    {
        private string _Name;
        private string _City;
        private long _Mobile;
        private double _Amount;

        public string Name { get; set; }

        public string City { get; set; }

        public long Mobile { get; set; }

        public double Amount { get; set; }
    }



    ////GenerateNumbers(10)

    //IEnumerable<int> GenerateNumbers(int maxValue)
    //{
    //    var result = new List<int>();

    //    for (var i = 0; i <= maxValue; i++)
    //    {
    //        result.Add(i);
    //    }

    //    return result;

    //}

}

