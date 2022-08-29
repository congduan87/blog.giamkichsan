using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tracuu.giamkichsan.Data;

namespace tracuu.giamkichsan.Common
{
	public class CntGlobal
	{
		private const string _TYPEPROJECT = "TraCuu";
		private static TraCuuDbContext _traCuuDbContext;
		public static TraCuuDbContext traCuuDbContext
		{
			get
			{
				if(_traCuuDbContext == null)
				{
					_traCuuDbContext = new TraCuuDbContext();
				}
				return _traCuuDbContext;
			}
		}
	}
}
