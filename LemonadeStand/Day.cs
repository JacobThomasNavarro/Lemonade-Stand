using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        // member variables (HAS A)
        public Weather weather;
        public List<Customer> customers;

        // constructor
        public Day()
        {
            customers = new List<Customer>() { };
        }

        // member methods (CAN DO)
        public void AddCustomers()
        {
            for (int i = 0; i < 100; i++)
            {
                customers.Add(new Customer());
            }
        }
    }
}
