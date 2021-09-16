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
    class WhenCapsuleServiceIsCalled_WithValidCapsuleId
    {
        private CapsuleService _capsuleService;

        [OneTimeSetUp]
        public async Task OneTimeSetUpAsync()
        {
            _capsuleService = new CapsuleService();
            await _capsuleService.MakeRequestAsync("5e9e2c5bf35918ed873b2664");
        }

        [Test]
        public void StatusIs200()
        {
            Assert.That(_capsuleService.CallManager.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void ReturnsTypeOfCapsuleResponse()
        {
            Assert.That(_capsuleService.CapsuleResponseDTO.Response, Is.TypeOf<CapsuleResponse>());
        }

        [Test]
        public void HasCorrectCapsuleSerialDTO()
        {
            Assert.That(_capsuleService.CapsuleResponseDTO.Response.serial, Is.EqualTo("C101"));
        }

        [Test]
        public void HasCorrectCapsuleSerialJSON()
        {
            Assert.That(_capsuleService.JsonResponse["serial"].ToString(), Is.EqualTo("C101"));
        }

        [Test]
        public void HasCorrectCapsuleStatusDTO()
        {
            Assert.That(_capsuleService.CapsuleResponseDTO.Response.status, Is.EqualTo("retired"));
        }

        [Test]
        public void HasCorrectCapsuleStatusJSON()
        {
            Assert.That(_capsuleService.JsonResponse["status"].ToString(), Is.EqualTo("retired"));
        }

        [Test]
        public void HasCorrectCapsuleTypeDTO()
        {
            Assert.That(_capsuleService.CapsuleResponseDTO.Response.type, Is.EqualTo("Dragon 1.0"));
        }

        [Test]
        public void HasCorrectCapsuleTypeJSON()
        {
            Assert.That(_capsuleService.JsonResponse["type"].ToString(), Is.EqualTo("Dragon 1.0"));
        }
    }
}
