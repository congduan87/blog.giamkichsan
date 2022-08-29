using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DecoratorPattern
{
	public class ADecorator : IComponent
	{
		private readonly IComponent _Icomponent;
		public ADecorator(IComponent icompnent)
		{
			this._Icomponent = icompnent;
		}
		public string Operation()
		{
			return this._Icomponent.Operation();
		}
		public string AddedBehavior()
		{
			return "This is the ADecorator object";
		}
	}
}
