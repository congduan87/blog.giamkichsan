using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FacadePattern
{
	public interface IShare
	{
		void SetMessage(string message);
		void Share();
	}
}
