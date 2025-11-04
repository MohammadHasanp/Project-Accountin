using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModel.Customers;

namespace Accounting.DataLAyer.repository
{
   public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        List<Customer> GetCustomersByFilter(string Parametr);
        List<GetcustomerList> GetNameCustomerByFilter(string Filter = "");
        Customer GetCustomerById(int CustomerID);
        bool InsertCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int customerID);
        bool Update(Customer customer);
        int GetCustomerIDByName(string Name);
        string GetNamecustomrerById(int CustomerID);
        
    }
}
