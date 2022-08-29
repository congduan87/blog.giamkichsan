using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CommandPatterm
{
	public class Light
	{
		private bool Stattus { get; set; }

		public void TurnOn()
		{
			this.Stattus = true;
		}
		public void TurnOff()
		{
			this.Stattus = false;
		}

		public void toString()
		{
			Console.WriteLine("Status: {0}", this.Stattus);
		}

	}
}
