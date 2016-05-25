using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVMExample.Interfaces
{
    public interface IRepository<T>
    {
        bool Add(T data); //Create
        T Get(int dataId); //Read
        ICollection<T> GetAll(); //Read
        void Update(T data); //Update
        void Remove(T data); //Delete
    }
}
