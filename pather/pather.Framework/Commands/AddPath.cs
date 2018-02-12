using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pather.Framework.Commands
{
	public class AddPathCommand : IPathCommand
	{
		private PatherService _service;
		private string Name;
		private string Path;

		public AddPathCommand(PatherService service)
		{
			_service = service;
		}

		public void Execute(IEnumerable<string> paramList)
		{
			if(paramList.Count() != 3)
			{
				throw new ArgumentException();
			}

			var parameters = paramList.Skip(1).ToList();

			var pathValue = new PathValue
			{
				Name = parameters[0],
				Path = parameters[1]
			};

			try
			{
				_service.AddPathValue(pathValue);
				var pathLedgerService = new PathLedgerService();
				pathLedgerService.AddEntry(pathValue);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			



		}
	}
}
