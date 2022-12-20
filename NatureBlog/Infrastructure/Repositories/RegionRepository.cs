﻿using Microsoft.EntityFrameworkCore;
using NatureBlog.Application.Repositories;
using NatureBlog.Domain.Models;

namespace NatureBlog.Infrastructure.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly AppDBContext _dbContext;

        public RegionRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Region region)
        {
             await _dbContext.Regions.AddAsync(region);
            _dbContext.SaveChanges();   
        }

        public async Task<List<Region>> GetAll()
        {
            List<Region> result = await _dbContext.Regions.ToListAsync();
            return result;
        }
    }
}
