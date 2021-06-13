using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAssignment
{
    class CustomerCollection
    {
        static List<Customer> customerList = new List<Customer>();

        static List<Customer> GetList()
        {
            return customerList;
        }
        static Customer GetCustomerByName(string pname)
        {
            for (int i = 0; i < customerList.Count; i++)
            {
                if(customerList[i].CustomerName == pname)
                {
                    return customerList[i];
                }
            }
            return null;
        }
        static Customer GetCustomerByCitynCountry(string pcity, string pcountry)
        {
            for (int i = 0; i < customerList.Count; i++)
            {
                if(customerList[i].City == pcity && customerList[i].Country == pcountry)
                {
                    return customerList[i];
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            customerList.Add(new Customer("Ross", "New York", "USA"));
            customerList.Add(new Customer("Django", "Chickasaw County", "Arizona"));
            customerList.Add(new Customer("Chandler", "New York", "USA"));
            customerList.Add(new Customer("John", "Melbourne", "Australia"));
            customerList.Add(new Customer("Rachel", "New York", "USA"));
            customerList.Add(new Customer("Rahul", "Mumbai", "India"));
            customerList.Add(new Customer("Monica", "New York", "USA"));
            customerList.Add(new Customer("Brooks", "Zurich", "Switzerland"));
            customerList.Add(new Customer("Joey", "New York", "USA"));

            Console.WriteLine(GetCustomerByName("Joey"));
            Console.WriteLine(GetCustomerByCitynCountry("Mumbai", "India"));
        }
    }
}
