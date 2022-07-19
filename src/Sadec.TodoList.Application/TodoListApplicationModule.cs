using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Sadec.TodoList.Authorization;

namespace Sadec.TodoList
{
    [DependsOn(
        typeof(TodoListCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TodoListApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TodoListAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TodoListApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);
            
        }
    }
}
