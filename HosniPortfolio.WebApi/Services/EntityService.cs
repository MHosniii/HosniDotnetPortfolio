using System.Linq;
using HosniPortfolio.WebApi.Repositories;

namespace HosniPortfolio.WebApi.Services
{
	public class EntityService<T> : IEntityService<T> where T : class
	{
		private readonly IRepository<T> repository;

		public EntityService(IRepository<T> repository)
		{
			this.repository = repository;
		}
		public IQueryable<T> RetrieveAll()=>repository.SelectAll();
	}
}
