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
    class WhenRocketServiceIsCalled_WithInvalidRocketId
    {
        private RocketService _rocketService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _rocketService = new RocketService();
            await _rocketService.MakeRequestAsync("abc");
        }

        [Test]
        public void StatusIs404()
        {
            Assert.That(_rocketService.CallManager.StatusCode, Is.EqualTo(404));
        }
    }
}
