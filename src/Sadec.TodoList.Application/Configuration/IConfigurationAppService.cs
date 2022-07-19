using System.Threading.Tasks;
using Sadec.TodoList.Configuration.Dto;

namespace Sadec.TodoList.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
