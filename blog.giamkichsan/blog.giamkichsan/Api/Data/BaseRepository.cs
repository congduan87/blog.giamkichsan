using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace blog.giamkichsan.Api.Data
{
	internal class BaseRepository
	{
		private string connectString { get; set; }
		private SqlConnection connection { get; set; }
		public SqlCommand command { get; set; }
		internal readonly string paramPrefix = "@";
		internal BaseRepository()
		{
			this.connectString = ConfigurationManager.ConnectionStrings["BlogsDatabase"].ConnectionString;
		}
		#region private
		private SqlConnection DbConnection
		{
			get
			{
				if (this.connection == null) connection = new SqlConnection(this.connectString);
				if (this.connection.State == ConnectionState.Closed) this.connection.Open();
				return this.connection;
			}
		}
		private void AddParamsInCommand(SqlCommand cmd, Dictionary<string, object> paramsValue = null)
		{
			if (paramsValue != null && paramsValue.Count > 0)
			{
				foreach (var param in paramsValue)
				{
					var sqlParam = new SqlParameter(param.Key, param.Value);
					sqlParam.Value = param;
					if (param.GetType().Name.Equals("Byte[]"))
					{
						sqlParam.SqlDbType = SqlDbType.VarBinary;
					}
					cmd.Parameters.Add(sqlParam);
				}
			}
		}
		private bool ExecuteNonQuery(string commandText, Dictionary<string, object> paramsValue)
		{
			var cmd = new SqlCommand(commandText, DbConnection);
			cmd.CommandType = CommandType.Text;
			AddParamsInCommand(cmd, paramsValue);
			int result = cmd.ExecuteNonQuery();
			cmd.Dispose();
			return result > 0;
		}
		internal IDataReader ExecuteReader(string commandText, Dictionary<string, object> paramsValue = null)
		{
			var cmd = new SqlCommand(commandText, DbConnection);
			cmd.CommandType = CommandType.Text;
			AddParamsInCommand(cmd, paramsValue);
			return cmd.ExecuteReader();
		}
		#endregion
	}
}
