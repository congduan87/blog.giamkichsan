using blog.giamkichsan.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog.giamkichsan.Api.AbstractData
{
	public abstract class BaseCategoriesRepository
	{
		public abstract List<Categories> Search(string name);
		public abstract List<Categories> GetAll(string name, int pageIndex = 0, int pageSize = 10);
		public abstract Boolean Insert(Categories item);
		public abstract Boolean Update(Categories item);
		public abstract Boolean Delete(int id);
	}
}
