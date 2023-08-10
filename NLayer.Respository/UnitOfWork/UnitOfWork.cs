using System;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.UnitOfWorks;

namespace NLayer.Respository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

