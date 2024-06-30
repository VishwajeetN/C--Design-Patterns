using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static Design_Patterns.Structural_Design_Patterns.Adapter_Design_Pattern.Adapter_Pattern;

namespace Design_Patterns.Structural_Design_Patterns.Adapter_Design_Pattern
{
    public class Adapter_Pattern2
    {
        // Data Property 
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string Contact { get; set; }

        }
        public class CustomerManager
        {
            // Assumet this list is getting from Data Base
            private List<Customer> customerList = new List<Customer>();

            public CustomerManager()
            {
                customerList.Add(new Customer
                {
                    Id = 1,
                    Name = "Mohan",
                    Address = "Delhi",
                    Contact = "9876543212"
                }
                );
            }
            public string GetData()
            {
                return JsonConvert.SerializeObject(customerList);

            }
        }
        public class CustomerDTO
        {
            public int CustomerId { get; set; }
            public string FullName { get; set; }
            public string AddressDetails { get; set; }
            public string Mobile { get; set; }
        }

        //Interface Adapter
        public interface ICustomer
        {
            IEnumerable<CustomerDTO> GetCustomers();
        }

        // By using Class Adapter Pattern
        //public class CustomerAdapter : CustomerManager, ICustomer
        //{
        //    public IEnumerable<CustomerDTO> GetCustomers()
        //    {
        //        var data = GetData();
        //        IEnumerable<Customer> customers = JsonConvert.DeserializeObject<IEnumerable<Customer>>(data);
        //        return customers.Select(x => new CustomerDTO
        //        {
        //            CustomerId = x.Id,
        //            FullName = x.Name,
        //            AddressDetails = x.Address,
        //            Mobile = x.Contact
        //        });
        //    }
        //}

        // By using Object Adapter Pattern
        public class CustomerAdapter : ICustomer
        {
            CustomerManager customerManager = new CustomerManager();
            public IEnumerable<CustomerDTO> GetCustomers()
            {
                var data = customerManager.GetData();
                IEnumerable<Customer> customers = JsonConvert.DeserializeObject<IEnumerable<Customer>>(data);
                return customers.Select(x => new CustomerDTO
                {
                    CustomerId = x.Id,
                    FullName = x.Name,
                    AddressDetails = x.Address,
                    Mobile = x.Contact
                });
            }
        }
    }
}
