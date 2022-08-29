using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DecoratorPattern
{
	public class BDecorator : IComponent
	{
		private readonly IComponent _IComponent;
		public BDecorator(IComponent icomponent)
		{
			this._IComponent = icomponent;
		}

		public string Operation()
		{
			return $"{this._IComponent.Operation()}. But I was 'overrride'";
		}
	}
}
