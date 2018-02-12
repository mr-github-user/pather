using System;
using System.Collections.Generic;
using System.Text;

namespace pather.Framework
{
	interface IPathCommand
	{
		void Execute(IEnumerable<string> paramList);
	}
}
