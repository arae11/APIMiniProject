using NUnit.Framework;
using APIMiniProject.Services;
using System.Threading.Tasks;
using APIMiniProject.Data;

namespace APIMiniProject.Tests.StarlinkTests
{
    public class WhenStarlinkSingleSateliteService
    {
        private StarlinkSingleSateliteService _starlinkSingleSateliteServices;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _starlinkSingleSateliteServices = new StarlinkSingleSateliteService();
            await _starlinkSingleSateliteServices.MakeRequest("5eed770f096e59000698560e");
        }

        [Test]
        public void StatusIs200()
        {
            var result = _starlinkSingleSateliteServices.CallManager.StatusCode;
            Assert.That(result, Is.EqualTo(200));

        }


        [Test]
        public void CorrectObjectNameIsReturned()
        {
            string result = _starlinkSingleSateliteServices.SingleStarlinkDTO.Response.version;
            Assert.That(result, Is.EqualTo("v0.9"));
        }

    }
}
