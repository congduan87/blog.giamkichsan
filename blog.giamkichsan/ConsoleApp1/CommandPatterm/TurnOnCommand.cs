using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandPatterm
{
	public class TurnOnCommand : ICommand
	{
		private Light light;
		public TurnOnCommand(Light light)
		{
			this.light = light;
		}
		public void execute()
		{
			this.light.TurnOn();
		}
	}
}
