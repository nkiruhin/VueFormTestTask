﻿using VueForm.SharedKernel.Interfaces;
using VueForm.SharedKernel;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueForm.Infrastructure.Data
{
    public class EfRepository : IRepository
    {
        private readonly AppDbContext _dbContext;

        public EfRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> GetQuery<T>() where T : BaseEntity
        {
            return _dbContext.Set<T>().AsNoTracking();
        }
        public T GetById<T>(int id) where T : BaseEntity
        {
            return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public Task<T> GetByIdAsync<T>(int id) where T : BaseEntity
        {
            return _dbContext.Set<T>().SingleOrDefaultAsync(e => e.Id == id);
        }

        public Task<List<T>> ListAsync<T>() where T : BaseEntity
        {
            return _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync<T>(T entity) where T : BaseEntity
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync<T>(T entity) where T : BaseEntity
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync<T>(T entity) where T : BaseEntity
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task AddRangeAsync<T>(List<T> entitys) where T : BaseEntity
        {
            await _dbContext.Set<T>().AddRangeAsync(entitys);
            await _dbContext.SaveChangesAsync();
        }

    }
}
