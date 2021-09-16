using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMiniProject.Services;
using APIMiniProject.Data;
using NUnit.Framework;

namespace APIMiniProject.Tests.CapsuleServiceTests
{
    class WhenGetLaunchesIsCalled_WithoutARequest
    {
        private CapsuleService _capsuleService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _capsuleService = new CapsuleService();
        }

        [Test]
        public void ThrowsInvalidOperationException_WithMessage()
        {
            Assert.That(() => _capsuleService.GetLaunches(), Throws.TypeOf<InvalidOperationException>().With.Message.Contains("Please make a valid request first"));
        }

       
    }
}
