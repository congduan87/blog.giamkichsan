using blog.giamkichsan.Api.Models;
using ConsoleApp1.CommandPatterm;
using ConsoleApp1.DecoratorPattern;
using ConsoleApp1.FacadePattern;
using ConsoleApp1.TemplatePattern;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			PatternDecorator();

			Console.ReadLine();
		}

		private static void GetAttributeClass()
		{
			var category = new Categories()
			{
				ID = 1,
				Name = "Sach Van Hoc",
				Description = "Lop 6, Truong THCS",
				OrderNumber = 1,
				ParentID = 0,
			};



			TableAttribute table = (TableAttribute)Attribute.GetCustomAttribute(typeof(Categories), typeof(TableAttribute));
			if (table != null)
			{
				Console.WriteLine("The Name Attribute is: {0}.", table.Name);
			}

			table = (TableAttribute)Attribute.GetCustomAttribute(typeof(ContentDetails), typeof(TableAttribute));
			if (table != null)
			{
				Console.WriteLine("The Name Attribute is: {0}.", table.Name);
			}
		}

		private static void PatternCommand()
		{
			Light light = new Light();
			RemoteControl control = new RemoteControl();

			ICommand on = new TurnOnCommand(light);
			control.setCommand(on);
			control.pressButton();
			light.toString();

			on = new TurnOffCommand(light);
			control.setCommand(on);
			control.pressButton();
			light.toString();
		}

		private static void PatternTemplate()
		{
			Page htmlPage = new HtmlPage();
			Page pdfPage = new PdfPage();

			htmlPage.print();
			pdfPage.print();
		}

		private static void PatternFacade()
		{
			SocialMediaShare social = new SocialMediaShare(new FacebookShare(), new TwitterShare());
			social.Share("thoong bao moi");
		}


		private static void PatternDecorator()
		{
			IComponent component = new Component();
			ADecorator adecorator = new ADecorator(component);
			BDecorator bdecorator = new BDecorator(component);
			ADecorator abdecorator = new ADecorator(bdecorator);

			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(component.Operation());

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine(adecorator.Operation());
			Console.WriteLine(adecorator.AddedBehavior());

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(bdecorator.Operation());

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine(abdecorator.Operation());
		}
	}
}
