using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TemplatePattern
{
	public abstract class Page
	{
		public void print()
		{
			Console.WriteLine("------------------------------------");
			printHeader();
			printBody();
			printFooter();
			Console.WriteLine("------------------------------------");
		}

		protected abstract void printHeader();
		protected abstract void printBody();
		protected abstract void printFooter();

	}
}
