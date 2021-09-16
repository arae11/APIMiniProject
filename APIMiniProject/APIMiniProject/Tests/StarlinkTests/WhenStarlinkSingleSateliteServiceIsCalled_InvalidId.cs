using NUnit.Framework;
using APIMiniProject.Services;
using System.Threading.Tasks;
using APIMiniProject.Data;

namespace APIMiniProject.Tests.StarlinkTests
{
    public class WhenStarlinkSingleSateliteServiceIsCalled_InvalidId
    {
        private StarlinkSingleSateliteService _starlinkSingleSateliteService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _starlinkSingleSateliteService = new StarlinkSingleSateliteService();
            await _starlinkSingleSateliteService.MakeRequestAsync("xxxxxx");
        }

        [Test]
        public void StatusIs404()
        {
            Assert.That(_starlinkSingleSateliteService.CallManager.StatusCode, Is.EqualTo(404));
        }

        [Test]
        public void NotFoundMessage()
        {
            Assert.That(_starlinkSingleSateliteService.StarlinkResponse, Is.EqualTo("Not Found"));
        }
    }
}
