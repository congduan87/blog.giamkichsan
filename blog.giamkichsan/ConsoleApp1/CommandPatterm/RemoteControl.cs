using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandPatterm
{
	public class RemoteControl
	{
		private ICommand command;
		public void setCommand(ICommand command)
		{
			this.command = command;
		}
		public void pressButton()
		{
			this.command.execute();
		}
	}
}
