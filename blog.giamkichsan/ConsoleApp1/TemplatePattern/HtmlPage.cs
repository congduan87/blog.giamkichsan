using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TemplatePattern
{
	public class HtmlPage : Page
	{
		protected override void printBody()
		{
			Console.WriteLine("Html Body");
		}

		protected override void printFooter()
		{
			Console.WriteLine("Html Footer");
		}

		protected override void printHeader()
		{
			Console.WriteLine("Html Header");
		}
	}
}
