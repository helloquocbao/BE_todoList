using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using Sadec.TodoList.Authorization.Users;
using Sadec.TodoList.Editions;

namespace Sadec.TodoList.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
