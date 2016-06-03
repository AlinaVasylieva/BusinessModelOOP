using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPUnitTests
{
    public class CustomerRepository
    {
        //Making cohesgn with address repository class
        public AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        /// <summary>
        /// Retrieve one customer
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            //Create an instance of Customer class
            Customer customer = new Customer(customerId);
            //Setting the Address List for this customer
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            //Code that retrieves the defined customer

            //Temporary hard coded values return 
            // a populated customer

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobitton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        /// <summary>
        /// Retrieves all customers
        /// </summary>
        //public List<Customer> Retrieve()
        //{
        //    return new List<Customer>();
        //}

        /// <summary>
        /// Saves the current customer
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            //Code that saves the defined customer
            return true;
        }

    }
}
