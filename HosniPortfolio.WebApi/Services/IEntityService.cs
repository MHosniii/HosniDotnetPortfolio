using System.Linq;

namespace HosniPortfolio.WebApi.Services
{
	public interface IEntityService<T> where T : class
	{
		IQueryable<T> RetrieveAll();
	}
}
