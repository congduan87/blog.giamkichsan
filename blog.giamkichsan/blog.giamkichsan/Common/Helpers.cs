using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace blog.giamkichsan.Common
{
	public class Helpers
	{
		public static string GetTableName(Type type)
		{
			const string preTable = "Blogs_";
			TableAttribute table = (TableAttribute)Attribute.GetCustomAttribute(type, typeof(TableAttribute));
			if (table != null)
				return table.Name;
			else
				return preTable + type.Name;
		}
	}
}
