using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FacadePattern
{
	public class TwitterShare : IShare
	{
		private string Message { get; set; }
		public void SetMessage(string message)
		{
			this.Message = message;
		}

		public void Share()
		{
			//Complecated....
			Console.WriteLine("TwitterShare shared " + this.Message);
		}
	}
}
