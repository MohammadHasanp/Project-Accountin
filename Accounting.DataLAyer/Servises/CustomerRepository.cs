using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLAyer.repository;
using System.Data.Entity;
using Accounting.ViewModel.Customers;
using Accounting.DataLAyer;

namespace Accounting.DataLAyer.Servises
{
    public class CustomerRepository :ICustomerRepository
    {
        private Accoounting_DBEntities db;
        public CustomerRepository(Accoounting_DBEntities Context)
        {
            db = Context;
        }
        public bool DeleteCustomer(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerID)
        {
            try
            {
                var customer = GetCustomerById(customerID);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customer> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customer GetCustomerById(int CustomerID)
        {
            return db.Customers.Find(CustomerID);
        }

        public int GetCustomerIDByName(string Name)
        {
            return db.Customers.First(c => c.FullName == Name).CustomerID;
        }

        public List<Customer> GetCustomersByFilter(string Parametr)
        {
            return db.Customers.Where(c => c.FullName.Contains(Parametr) || c.Email.Contains(Parametr) || c.Mobil.Contains(Parametr)).ToList();

        }

        public List<GetcustomerList> GetNameCustomerByFilter(string Filter = "")
        {
            if (Filter == "")
            {
                return db.Customers.Select(c => new GetcustomerList()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName,

                }).ToList();

            }
            return db.Customers.Where(c => c.FullName.Contains(Filter)).Select(c => new GetcustomerList
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName,
            }).ToList();


        }

        public string GetNamecustomrerById(int CustomerID)
        {

            return db.Customers.Find(CustomerID).FullName;
        }

        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Customer customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
