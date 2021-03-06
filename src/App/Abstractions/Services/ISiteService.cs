﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Bit.App.Models;
using Bit.App.Models.Api;

namespace Bit.App.Abstractions
{
    public interface ISiteService
    {
        Task<Site> GetByIdAsync(string id);
        Task<IEnumerable<Site>> GetAllAsync();
        Task<IEnumerable<Site>> GetAllAsync(bool favorites);
        Task<ApiResult<SiteResponse>> SaveAsync(Site site);
        Task<ApiResult> DeleteAsync(string id);
    }
}
