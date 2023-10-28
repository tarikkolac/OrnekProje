using System.Threading.Tasks;
using OrnekProje.Models.TokenAuth;
using OrnekProje.Web.Controllers;
using Shouldly;
using Xunit;

namespace OrnekProje.Web.Tests.Controllers
{
    public class HomeController_Tests: OrnekProjeWebTestBase
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