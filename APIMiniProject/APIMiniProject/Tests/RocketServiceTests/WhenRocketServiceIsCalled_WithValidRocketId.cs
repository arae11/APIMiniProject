using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMiniProject.Services;
using APIMiniProject.Data;
using NUnit.Framework;
using APIMiniProject.HTTPManager;

namespace APIMiniProject.Tests.RocketServiceTests
{
    class WhenRocketServiceIsCalled_WithValidRocketId
    {
        private RocketService _rocketService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _rocketService = new RocketService();
            await _rocketService.MakeRequestAsync("5e9d0d95eda69955f709d1eb");
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_rocketService.CallManager.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void ReturnsTypeOfRocketResponse()
        {
            Assert.That(_rocketService.RocketResponseDTO.Response, Is.TypeOf<RocketResponse>());
        }

        [Test]
        public void HasCorrectEngineTypeDTO()
        {
            Assert.That(_rocketService.RocketResponseDTO.Response.engines.type, Is.EqualTo("merlin"));
        }

        [Test]
        public void HasCorrectEngineTypeJSON()
        {
            Assert.That(_rocketService.JsonResponse["engines"]["type"].ToString(), Is.EqualTo("merlin"));
        }

        [Test]
        public void HasCorrectRocketTypeDTO()
        {
            Assert.That(_rocketService.RocketResponseDTO.Response.type, Is.EqualTo("rocket"));
        }

        [Test]
        public void HasCorrectRocketTypeJSON()
        {
            Assert.That(_rocketService.JsonResponse["type"].ToString(), Is.EqualTo("rocket"));
        }

        [Test]
        public void HasCorrectRocketNameDTO()
        {
            Assert.That(_rocketService.RocketResponseDTO.Response.name, Is.EqualTo("Falcon 1"));
        }

        [Test]
        public void HasCorrectRocketNameJSON()
        {
            Assert.That(_rocketService.JsonResponse["name"].ToString(), Is.EqualTo("Falcon 1"));
        }

        [Test]
        public void HasCorrectCostPerLaunchDTO()
        {
            Assert.That(_rocketService.RocketResponseDTO.Response.cost_per_launch, Is.EqualTo(6700000));
        }

        [Test]
        public void HasCorrectCostPerLaunchJSON()
        {
            Assert.That(_rocketService.JsonResponse["cost_per_launch"].ToString(), Is.EqualTo("6700000"));
        }

        [Test]
        public void HasCorrectDescriptionDTO()
        {
            Assert.That(_rocketService.RocketResponseDTO.Response.description, Is.EqualTo(
                "The Falcon 1 was an expendable launch system privately developed and manufactured by SpaceX during 2006-2009. " +
                "On 28 September 2008, Falcon 1 became the first privately-developed liquid-fuel launch vehicle to go into orbit around the Earth."));
        }

        [Test]
        public void HasCorrectDescriptionJSON()
        {
            Assert.That(_rocketService.JsonResponse["description"].ToString(), Is.EqualTo(
                "The Falcon 1 was an expendable launch system privately developed and manufactured by SpaceX during 2006-2009. " +
                "On 28 September 2008, Falcon 1 became the first privately-developed liquid-fuel launch vehicle to go into orbit around the Earth."));
        }
    }
}
