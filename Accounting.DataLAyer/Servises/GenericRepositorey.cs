using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using Accounting.DataLAyer.repository;
using Accounting.DataLAyer;

namespace Accounting.DataLAyer
{
    public class GenericRepositorey<TEntyti>: IGenericRepositorey<TEntyti> where TEntyti :class
    {
        private Accoounting_DBEntities _Db;
        private DbSet<TEntyti> _DbSet;

        public GenericRepositorey(Accoounting_DBEntities db)
        {
            _Db = db;
            _DbSet = _Db.Set<TEntyti>();
        }

        public virtual IEnumerable<TEntyti> Get(Expression<Func<TEntyti, bool>> where = null)  
        {
            IQueryable<TEntyti> Query = _DbSet;
            if (where != null)
            {
                Query = Query.Where(where);
            }
            return Query;//ToList()
        }

        public virtual void Insert(TEntyti entyti)
        {
            _DbSet.Add(entyti);
        }

        public virtual TEntyti GetById(object ID)
        {
            return _DbSet.Find(ID);
        }

        public virtual void Update(TEntyti entity)
        {
   
            _Db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntyti entity)
        {

            _DbSet.Attach(entity);
            _Db.Entry(entity).State = EntityState.Deleted;
        }
        public virtual void Delete(object Id)
        {
            var entity = GetById(Id);
            Delete(entity);
            

        }
    }

}