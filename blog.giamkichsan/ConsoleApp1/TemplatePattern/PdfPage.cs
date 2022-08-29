using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.TemplatePattern
{
	public class PdfPage : Page
	{
		protected override void printBody()
		{
			Console.WriteLine("Pdf Body");
		}

		protected override void printFooter()
		{
			Console.WriteLine("Pdf Footer");
		}

		protected override void printHeader()
		{
			Console.WriteLine("Pdf Header");
		}
	}
}
