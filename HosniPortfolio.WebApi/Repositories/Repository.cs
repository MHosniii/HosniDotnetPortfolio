using System.Linq;
using HosniPortfolio.WebApi.Data;
using Microsoft.EntityFrameworkCore;

namespace HosniPortfolio.WebApi.Repositories
{
	public class Repository<T>: IRepository<T> where T : class
	{
		private readonly AppDbContext appDbContext;
		private DbSet<T> entity;
		public Repository(AppDbContext appDbContext)
		{
			this.appDbContext = appDbContext;
			entity = appDbContext.Set<T>();
		}

		public IQueryable<T> SelectAll() => entity;
	}
}
