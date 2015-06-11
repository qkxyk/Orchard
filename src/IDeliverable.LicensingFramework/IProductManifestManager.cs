using System;
using System.Collections.Generic;
using Orchard;

namespace IDeliverable.Licensing
{
    public interface IProductManifestManager : IDependency
    {
        IEnumerable<ProductManifest> GetProductManifests();
        ProductManifest FindByProductId(int productId);
        ProductManifest FindByExtensionName(string extensionName);
        ProductManifest Find(Func<ProductManifest, bool> predicate);
    }
}