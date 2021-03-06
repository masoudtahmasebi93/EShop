﻿using EShop.Common.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShop.Common.Services
{
    public interface IEntityService<T> : IBaseService where T : BaseModel
    {
        Task AddAsync(T model);
        Task UpdateAsync(Guid id, T model);
        Task RemoveAsync(Guid id);
        Task<List<T>> GetAsync();
        Task<T> GetAsync(Guid id);
        List<T> Get(Func<T, bool> predicate = null);
        bool Any(Guid id);
        Task<T> GetAsync(string name);
        Task UpdateSingleFieldAsync(Guid id, dynamic model);
    }
}