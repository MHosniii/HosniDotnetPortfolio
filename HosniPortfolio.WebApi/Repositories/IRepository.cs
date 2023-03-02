using System.Linq;

namespace HosniPortfolio.WebApi.Repositories
{
	public interface IRepository<T> where T : class
	{
		IQueryable<T> SelectAll();
	}
}
