using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Repositories
{
    public interface IRepository<Type>
    {
        void Create(Type element);
        void Delete(Type element);
        void Update(Type element);
        List<Type> GetAllElements();
    }
}
