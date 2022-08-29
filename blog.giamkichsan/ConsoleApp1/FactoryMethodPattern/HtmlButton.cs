using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.FactoryMethodPattern
{
	public class HtmlButton : Button
	{
		public void render()
		{
			Console.WriteLine("<button>Test button</button>");
			onclick();
		}

		private void onclick()
		{
			Console.WriteLine("Click! button says - 'Hello world'");
		}
	}
}
