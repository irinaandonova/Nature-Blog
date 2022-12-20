﻿using NatureBlog.Domain.Models;

namespace NatureBlog.Application.Repositories
{
    public interface IRegionRepository
    {
        public Task Add(Region region);

        public Task<List<Region>> GetAll();

        public Task<bool> Delete(int regionId);

    }
}
