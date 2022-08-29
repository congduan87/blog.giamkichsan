using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandPatterm
{
	public class TurnOffCommand : ICommand
	{
		private Light light;
		public TurnOffCommand(Light light)
		{
			this.light = light;
		}
		public void execute()
		{
			this.light.TurnOff();
		}
	}
}
