﻿using Nop.Core.Domain.Catalog;
using Nop.Services.Caching;

namespace Nop.Services.Catalog.Caching
{
    /// <summary>
    /// Represents a manufacturer template cache event consumer
    /// </summary>
    public partial class ManufacturerTemplateCacheEventConsumer : CacheEventConsumer<ManufacturerTemplate>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(ManufacturerTemplate entity)
        {
            Remove(NopCatalogDefaults.ManufacturerTemplatesAllCacheKey);
        }
    }
}
