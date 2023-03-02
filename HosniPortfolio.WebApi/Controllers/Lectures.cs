using System.Linq;
using HosniPortfolio.WebApi.Models;
using HosniPortfolio.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HosniPortfolio.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class Lectures : ControllerBase
	{
		private readonly IEntityService<Lecture> entityService;

		public Lectures(IEntityService<Lecture> entityService)
		{
			this.entityService = entityService;
		}

		[HttpGet]
		public IQueryable<Lecture> getAll() => entityService.RetrieveAll();
	}
}
