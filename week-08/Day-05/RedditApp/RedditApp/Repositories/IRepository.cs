using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Repositories
{
    public interface IRepository<T, Tkey>
    {
        IEnumerable<T> GetAllElement();
        T GetT(Tkey tkey);
        void Create(T element);
        void Update(T element);
        void Delete(T element);
        void Save();
    }
}
