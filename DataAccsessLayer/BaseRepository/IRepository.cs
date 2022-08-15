using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.BaseRepository
{
    public interface IRepository<T>where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T model);
        void Update(T model);
        void Delete(T model);
        void SaveChanges();

    }
}
