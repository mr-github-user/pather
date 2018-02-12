using pather.Framework.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace pather.Framework
{
	public class PathCommandInterpreter
	{
		private PatherService _pathService;
		private List<string> _commands = new List<string>();

		public PathCommandInterpreter(string[] command)
		{
			_pathService = new PatherService();
			_commands.AddRange(command);

			ParseCommand();
		}

		private void ExecuteCommand(IPathCommand command)
		{
			command.Execute(_commands);
		}

		private void ParseCommand()
		{
			var tag = _commands[0];
			switch(tag)
			{
				case "-l":
				var command = new ListCommand(_pathService);
					command.Execute(_commands);
					break;
				case "-a":
					var c = new AddPathCommand(_pathService);
					c.Execute(_commands);
					break;
				default:
					Console.WriteLine("Invalid Command");
					break;
			}

			


		}
	}
}
