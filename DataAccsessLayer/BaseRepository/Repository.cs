using DataAccsessLayer.BaseRepository.UserRepo;
using DataAccsessLayer.Context;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.BaseRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly MasterContext context;
        private readonly DbSet<T> db;

        public Repository(MasterContext _context)
        {
            context = _context;
            db= context.Set<T>();
        }
        public void Add(T model)
        {
            context.Add(model);
        }

        public void Delete(T model)
        {
            context.Remove(model);
        }

        public IQueryable<T> GetAll()
        {
            return db;
        }

        public T GetById(int id)
        {
            return db.Find(id);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(T model)
        {
            db.Update(model);
        }
        public Users GetUserPassword(string email)
        {
            return context.Users
                .Include(x => x.Password)
                .FirstOrDefault(x => x.Email == email);
        }
    }
}
