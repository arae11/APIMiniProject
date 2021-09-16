using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMiniProject.Data;
using APIMiniProject.HTTPManager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using APIMiniProject.Services;
namespace APIMiniProject.Tests.CrewServiceTests
{
	class WhenTheCrewServiceIsCalled_WithInvalidCrewId
	{
		private CrewService _crewService;
		[OneTimeSetUp]

		public async Task OneTimeSetupAsync()
		{
			_crewService = new CrewService();
			await _crewService.MakeRequestAsync("Arthur_Best_Boy");
		}

		[Test]

		public void StatusIs404()
		{
			Assert.That(_crewService.CallManager.StatusCode, Is.EqualTo(404));
		}
	}
}
