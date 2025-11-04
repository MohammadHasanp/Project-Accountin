using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLAyer.repository
{
    public interface IGenericRepositorey<TEntyti> where TEntyti:class
    {
        IEnumerable<TEntyti> Get(Expression<Func<TEntyti, bool>> where = null);
        void Insert(TEntyti entyti);
        TEntyti GetById(object Id);
        void Update(TEntyti entyti);
        void Delete(object Id);

    }
}
