using NUnit.Framework;
using APIMiniProject.Services;
using System.Threading.Tasks;
using APIMiniProject.Data;

namespace APIMiniProject.Tests.StarlinkTests
{
    public class WhenStarlinkSingleSateliteServiceIsCalled_WithValidId
    {
        private StarlinkSingleSateliteService _starlinkSingleSateliteServices;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _starlinkSingleSateliteServices = new StarlinkSingleSateliteService();
            await _starlinkSingleSateliteServices.MakeRequestAsync("5eed770f096e59000698560e");
        }

        [Test]
        public void StatusIs200()
        {
            var result = _starlinkSingleSateliteServices.CallManager.StatusCode;
            Assert.That(result, Is.EqualTo(200));

        }


        [Test]
        public void HasCorrectStarlinkVersionDTO()
        {
            string result = _starlinkSingleSateliteServices.SingleStarlinkDTO.Response.version;
            Assert.That(result, Is.EqualTo("v0.9"));
        }

        [Test]
        public void HasCorrectVersionJSON()
        {
            string result = _starlinkSingleSateliteServices.Json_Response["version"].ToString();
            Assert.That(result, Is.EqualTo("v0.9"));
        }

        [Test]
        public void ReturnsTypeOfStarlinkResponse()
        {
            Assert.That(_starlinkSingleSateliteServices.SingleStarlinkDTO.Response, Is.TypeOf<StarlinkSingleResponse>());
        }

        [Test]
        public void HasCorrectStarlinkIdDTO()
        {
            Assert.That(_starlinkSingleSateliteServices.SingleStarlinkDTO.Response.id, Is.EqualTo("5eed770f096e59000698560e"));
        }

        [Test]
        public void HasCorrectStarlinkIdJSON()
        {
            Assert.That(_starlinkSingleSateliteServices.Json_Response["id"].ToString(), Is.EqualTo("5eed770f096e59000698560e"));
        }

        [Test]
        public void HasCorrectStarlinkClassificationTypeDTO()
        {
            Assert.That(_starlinkSingleSateliteServices.SingleStarlinkDTO.Response.spaceTrack.CLASSIFICATION_TYPE, Is.EqualTo("U"));
        }

        [Test]
        public void HasCorrectStarlinkClassificationTypeJSON()
        {
            Assert.That(_starlinkSingleSateliteServices.Json_Response["spaceTrack"]["CLASSIFICATION_TYPE"].ToString(), Is.EqualTo("U"));
        }

    }
}
