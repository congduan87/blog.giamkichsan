using blog.giamkichsan.Api.AbstractData;
using blog.giamkichsan.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blog.giamkichsan.Common;

namespace blog.giamkichsan.Api.Data
{
	public class CategoriesRepository : BaseCategoriesRepository
	{
		private BaseRepository baseRepository{get;set;}
		public override bool Delete(int id)
		{
			throw new NotImplementedException();
		}

		public override List<Categories> GetAll(string name, int pageIndex = 0, int pageSize = 10)
		{
			List<Categories> ress = new List<Categories>();
			string tableName = Helpers.GetTableName(typeof(Categories));
			Dictionary<string, object> parameters = new Dictionary<string, object>();
			System.Linq.Expressions.Expression<Func<Categories, bool>> deleg = i => i.Name.Equals(name) && "".Equals(pageIndex) && "".Equals(pageSize);
			string clause = deleg.GetKeyValue(parameters, baseRepository.paramPrefix);

			string commandText = "SELECT * FROM " + tableName + " WHERE " + clause + " \n " + string.Format("ORDER BY {0} OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY;", "ID", pageSize, pageSize * pageIndex);

			var reader = baseRepository.ExecuteReader(commandText, parameters);
			while (reader != null && reader.Read())
			{
				Categories res = new Categories();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					if (reader[i] != null)
					{
						typeof(Categories).GetProperty(reader.GetName(i)).SetValue(res, reader[i], null);
					}
				}
				ress.Add(res);
			}
			reader.Close();
			return ress;
		}

		public override bool Insert(Categories item)
		{
			throw new NotImplementedException();
		}

		public override List<Categories> Search(string name)
		{
			throw new NotImplementedException();
		}

		public override bool Update(Categories item)
		{
			throw new NotImplementedException();
		}
	}
}
