using System;

namespace pather
{
	class Program
	{
		static void Main(string[] args)
		{
			var x = System.Environment.GetEnvironmentVariable("Path");
			x = x + @"";
			Environment.SetEnvironmentVariable("Path", x, EnvironmentVariableTarget.Machine);
			Console.WriteLine("Hello World!");

			//-p path to destination
		}
	}
}
