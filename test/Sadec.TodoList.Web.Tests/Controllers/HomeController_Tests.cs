using System.Threading.Tasks;
using Sadec.TodoList.Models.TokenAuth;
using Sadec.TodoList.Web.Controllers;
using Shouldly;
using Xunit;

namespace Sadec.TodoList.Web.Tests.Controllers
{
    public class HomeController_Tests: TodoListWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}