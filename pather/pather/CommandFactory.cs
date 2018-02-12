using Microsoft.Extensions.CommandLineUtils;
using pather.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pather
{
	public class CommandFactory
	{
		public void ListCommand(CommandLineApplication app)
		{
			app.Command("list", (cmd) =>
			{
				cmd.Description = "List path Environment Variables";

				cmd.OnExecute(() =>
				{
					var patherService = new PatherService();
					var paths = patherService.GetPath();
					foreach (var path in paths)
					{
						Console.WriteLine(path);
					}

					return 0;
				});
			});
		}

		public void AddPathEntryCommand(CommandLineApplication app)
		{
			app.Command("add", (cmd) =>
			{
				cmd.HelpOption("-?|-h|--help");

				var name = cmd.Argument(
					"name",
					"The name of the Path Entry",
					false
						);

				var path = cmd.Argument(
					"path",
					"the path to the directory",
					false
						);

				cmd.Description = "Add a new entry to the System Environment Variable Path";
				cmd.OnExecute(() =>
				{
					if (name.Value == null || path.Value == null)
					{
						Console.WriteLine("a name and path must be supplied!");
						cmd.ShowHelp();
						return 1;
					}

					var patherService = new PatherService();
					var pathValue = new PathValue
					{
						Name = name.Value,
						Path = path.Value
					};

					patherService.AddPathValue(pathValue);
					Console.WriteLine($"Saving Name: {name.Value} path:{path.Value}");
					return 0;
				});
			});

		}
		public void RemovePathEntry(CommandLineApplication app)
		{
			app.Command("remove", (cmd) =>
			{
				cmd.HelpOption("-?|-h|--help");

				var name = cmd.Argument(
					"name",
					"The name of the Path Entry",
					false
						);

				var path = cmd.Argument(
					"path",
					"the path to the directory",
					false
						);

				cmd.Description = "Add a new entry to the System Environment Variable Path";
				cmd.OnExecute(() =>
				{
					if (name.Value == null || path.Value == null)
					{
						Console.WriteLine("a name and path must be supplied!");
						cmd.ShowHelp();
						return 1;
					}

					Console.WriteLine($"Saving Name: {name.Value} path:{path.Value}");
					return 0;
				});
			});

		}
	}
}
