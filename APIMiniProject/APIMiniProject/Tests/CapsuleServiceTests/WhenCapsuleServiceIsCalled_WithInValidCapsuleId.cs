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
    class WhenCapsuleServiceIsCalled_WithInValidCapsuleId
    {
        private CapsuleService _capsuleService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _capsuleService = new CapsuleService();
            await _capsuleService.MakeRequestAsync("5e");
        }

        [Test]
        public void StatusIs404()
        {
            Assert.That(_capsuleService.CallManager.StatusCode, Is.EqualTo(404));
        }

    }
}
