using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLAyer;
using Accounting.DataLAyer.repository;
using Accounting.DataLAyer.Servises;


namespace Accounting.DataLAyer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accoounting_DBEntities db = new Accoounting_DBEntities();
       

        private ICustomerRepository _customerRepository;
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
      
        }



        private IGenericRepositorey<Accounting> _genericRepositorey;
        public IGenericRepositorey<Accounting> GenericRepositorey
        {
            get
            {
                if (_genericRepositorey == null)
                {
                    _genericRepositorey = new GenericRepositorey<Accounting>(db);
                }
                return _genericRepositorey;
            }
        }


        private IGenericRepositorey<Login_Db> _LoginRepository;
        public IGenericRepositorey<Login_Db> LogonRepository
        {
            get
            {
                if (_LoginRepository == null)
                {
                    _LoginRepository = new GenericRepositorey<Login_Db>(db);
                }
                return _LoginRepository;
            }
        }





        public void Save()
        {
            db.SaveChanges();
        }
    
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
