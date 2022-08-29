using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FactoryMethodPattern
{
	public abstract class Dialog
	{
		public void renderWindow()
		{

		}
		public abstract Button CreateButton();
	}
}
