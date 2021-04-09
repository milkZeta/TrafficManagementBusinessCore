using System.Threading.Tasks;
using TrafficManagementBusinessCore.Models.TokenAuth;
using TrafficManagementBusinessCore.Web.Controllers;
using Shouldly;
using Xunit;

namespace TrafficManagementBusinessCore.Web.Tests.Controllers
{
    public class HomeController_Tests: TrafficManagementBusinessCoreWebTestBase
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