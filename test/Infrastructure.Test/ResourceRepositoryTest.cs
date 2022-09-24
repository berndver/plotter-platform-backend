using System;
using System.Threading.Tasks;
using Domain;
using Infrastructure.Repositories;
using Xunit;

namespace Infrastructure.Test;

public class ResourceRepositoryTest
{
    private readonly IRepository<Resource> _repository;

    public ResourceRepositoryTest()
    {
        _repository = new ResourceRepository(new PlotterPlatformContext());
    }

    [Fact]
    public async Task ReadListAsyncTest()
    {
        await _repository.ReadListAsync();
    }
}