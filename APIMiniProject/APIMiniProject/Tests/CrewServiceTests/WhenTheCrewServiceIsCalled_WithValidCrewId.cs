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
	class WhenTheCrewServiceIsCalled_WithValidCrewId
	{
		private CrewService _crewService;
		[OneTimeSetUp]

		public async Task OneTimeSetupAsync()
		{
			_crewService = new CrewService();
			await _crewService.MakeRequestAsync("5ebf1b7323a9a60006e03a7b");
		}

		[Test]

		public void StatusIs200()
		{
			Assert.That(_crewService.CallManager.StatusCode, Is.EqualTo(200));
		}

		/*
		[Test]
		public void StatusIs200_alt()
		{
			Assert.That(_crewService.CrewResponse)
		}
		*/
	}
}
