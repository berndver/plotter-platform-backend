using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ResourceRepository : IRepository<Resource>
{
    private readonly PlotterPlatformContext _context;

    public ResourceRepository(PlotterPlatformContext context)
    {
        _context = context;
    }

    public async Task<Resource?> ReadAsync(Guid id)
    {
        return await _context.Resources.FindAsync(id);
    }

    public async Task<IEnumerable<Resource>> ReadListAsync()
    {
        return await _context.Resources.ToListAsync();
    }

    public async Task<Resource> CreateAsync(Resource entity)
    {
        await _context.Resources.AddAsync(entity);
        return entity;
    }

    public Task UpdateAsync(Resource entity)
    {
        _context.Resources.Update(entity);
        return Task.CompletedTask;
    }
}