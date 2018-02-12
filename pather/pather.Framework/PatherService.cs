using System;
using System.Collections.Generic;

namespace pather.Framework
{
	public class PatherService
	{
		private string path => System.Environment.GetEnvironmentVariable("Path");
		public IEnumerable<string> GetPath()
		{
			return path.Split(';');
		}

		public void AddPathValue(PathValue pathValue)
		{
			var working = path;

			if(working.Contains(pathValue.Path))
			{

			}
			else
			{
				working = working + $";{pathValue.Path}";
			}

			Environment.SetEnvironmentVariable("Path", working, EnvironmentVariableTarget.Machine);
		}

		public bool RemovePathValue(string Name)
		{
			return false;
		}
	}
}
