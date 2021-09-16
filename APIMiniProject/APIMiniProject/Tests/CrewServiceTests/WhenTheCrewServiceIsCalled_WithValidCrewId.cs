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

		
		[Test]
		public void ReturnsTypeOfCrewResponse()
		{
			Assert.That(_crewService.CrewResponseDTO.Response, Is.TypeOf<CrewResponse>());

		}

		[Test]
		public void HasCorrectNameDTO()
		{
			Assert.That(_crewService.CrewResponseDTO.Response.name, Is.EqualTo("Douglas Hurley"));
		}

		[Test]
		public void HasCorrectNameJSON()
		{
			Assert.That(_crewService.JsonResponse["name"].ToString(), Is.EqualTo("Douglas Hurley"));
		}

		[Test]
		public void HasCorrectAgencyDTO()
		{
			Assert.That(_crewService.CrewResponseDTO.Response.agency, Is.EqualTo("NASA"));

		}


		[Test]
		public void HasCorrectAgencyJSON()
		{
			Assert.That(_crewService.JsonResponse["agency"].ToString(), Is.EqualTo("NASA"));
		}

		[Test]
		public void HasCorrectPilotStatusDTO()
		{
			Assert.That(_crewService.CrewResponseDTO.Response.status, Is.EqualTo("active"));
		}

		[Test]
		public void HasCorrectPilotStatusJSON()
		{
			Assert.That(_crewService.JsonResponse["status"].ToString(), Is.EqualTo("active"));
		}

		[Test]

		public void HasCorectLaunchCountDTO()
		{
			Assert.That(_crewService.CrewResponseDTO.Response.launches.Count(),Is.EqualTo(1));

		}

		[Test]

		public void HasCorectLaunchCountJSON()
		{
			Assert.That(_crewService.JsonResponse["launches"].Count(), Is.EqualTo(1));

		}

	}
}
