using System;
using System.Collections.Generic;
using System.Text;

namespace pather.Framework.Commands
{
	public class ListCommand : IPathCommand
	{
		private PatherService _service;

		public ListCommand(PatherService service)
		{
			_service = service;
		}

		public void Execute(IEnumerable<string> paramList)
		{
			var paths = _service.GetPath();
			foreach (var path in paths)
			{
				Console.WriteLine(path);
			}
		}
	}
}
