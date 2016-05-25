using System;
using System.Collections.Generic;
using System.Linq;
using SimpleMVVMExample.Interfaces;

namespace SimpleMVVMExample.Data
{
    //public class Repository<T> : IRepository<T> where T : class
    //{
    //    private static Repository<T> _instance;

    //    private Repository()
    //    {
    //    }

    //    public static Repository<T> GetInstance()
    //    {
    //        if (_instance == null)
    //            _instance = new Repository<T>();

    //        return _instance;
    //    }

    //    public bool Add(T data)
    //    {
    //        using (var db = new TransactionContext())
    //        {
    //            Console.WriteLine("Added data");
    //            db.Set<T>().Add(data);
    //            db.SaveChanges();
    //            return true;
    //        }
    //    }

    //    public T Get(int dataId)
    //    {
    //        using (var db = new TransactionContext())
    //        {
    //            Console.WriteLine("Get data");
    //            return (T)Convert.ChangeType(db.Set<T>().FindAsync(dataId), typeof(T));
    //        }
    //    }

    //    public ICollection<T> GetList()
    //    {
    //        using (var db = new TransactionContext())
    //        {
    //            Console.WriteLine("Get data list");
    //            return db.Set<T>().ToList();
    //        }
    //    }

    //    public void Remove(T data)
    //    {
    //        using (var db = new TransactionContext())
    //        {
    //            Console.WriteLine("Remove data");
    //            db.Set<T>().Remove(data);
    //            db.SaveChanges();
    //        }
    //    }

    //    public void Update(T data)
    //    {
    //        using (var db = new TransactionContext())
    //        {
    //            Console.WriteLine("Update data");
    //            db.Entry(data).State = System.Data.Entity.EntityState.Modified;
    //            db.SaveChanges();
    //        }
    //    }
    //}
}
