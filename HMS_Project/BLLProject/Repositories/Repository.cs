﻿using BLLProject.Interfaces;
using DALProject.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLProject.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly HMSdbcontext context;

        public Repository(HMSdbcontext context)
        {
            this.context = context;
        }
        public int Add(T entity)
        {
            context.Set<T>().Add(entity);
            return context.SaveChanges();
        }

        public int Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChanges();
        }
        public int Update(T entity)
        {
            context.Set<T>().Update(entity);
            return context.SaveChanges();
        }

        public T Get(int Id) => context.Set<T>().Find(Id);

        public IEnumerable<T> GetALL() => context.Set<T>().AsNoTracking().ToList();

    }
}
