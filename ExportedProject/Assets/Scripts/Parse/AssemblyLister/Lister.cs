using System.Collections.Generic;
using System.Reflection;

namespace AssemblyLister
{
	public static class Lister
	{
		public static IEnumerable<Assembly> AllAssemblies => null;

		private static IEnumerable<Assembly> DeepWalkReferences(this Assembly assembly, HashSet<string> seen = null)
		{
			return null;
		}
	}
}
