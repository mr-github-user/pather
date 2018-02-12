using Microsoft.Extensions.CommandLineUtils;
using pather.Framework;
using System;
using System.Collections.Generic;

namespace pather
{
	class Program
	{
		static void Main(string[] args)
		{
			var commandLineApplication = new CommandLineApplication();
			var test = new CommandFactory();

			test.ListCommand(commandLineApplication);
			test.AddPathEntryCommand(commandLineApplication);

			commandLineApplication.HelpOption("-? | -h | --help");
			commandLineApplication.Execute(args);
			//if (args.Length != 0)
			//{
			//	var patherInterpreter = new PathCommandInterpreter(args);
			//}
			//else
			//{
			//	Console.WriteLine("Enter Something");
			//}

			//-p path to destination
		}

		private static void Greet(string greeting, List<string> values, bool useUppercase)
		{
			Console.WriteLine(greeting);
			foreach(var value in values)
			{
				Console.Write(useUppercase ? value.ToUpper() : value);
			}
		}

	//	CommandArgument names = null;
	//	var command = x.Command("name",
	//		(target) =>
	//			names = target.Argument(
	//				"fullname",
	//				"Enter the full name of who you want to greet",
	//				multipleValues: true));

	//	CommandOption greeting = command.Option(
	//		"-$|-g |--greeting <greeting>",
	//		@"The greeting to display. the greeting supports
	//				a format string where {fullname} will be 
	//				substituted with the fullname.",
	//		CommandOptionType.SingleValue);

	//	CommandOption uppercase = command.Option(
	//		"-u | --uppercase", "Display the greetnig in uppercase",
	//		CommandOptionType.NoValue);

	//	x.HelpOption("-? | -h | --help");

	//		command.OnExecute(() =>
	//		{
	//			if (greeting.HasValue())
	//			{
	//				Greet(greeting.Value(), names.Values, uppercase.HasValue());
	//}

	//			return 0;
	//		});
	}
}
