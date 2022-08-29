using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DecoratorPattern
{
	public class Component : IComponent
	{
		public string Operation()
		{
			return "Hello world! This is operation object";
		}
	}
}
