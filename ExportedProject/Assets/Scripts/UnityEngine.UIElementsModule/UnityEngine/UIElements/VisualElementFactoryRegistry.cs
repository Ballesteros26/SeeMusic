using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal class VisualElementFactoryRegistry
	{
		private static Dictionary<string, List<IUxmlFactory>> s_Factories;

		internal static Dictionary<string, List<IUxmlFactory>> factories => null;

		protected static void RegisterFactory(IUxmlFactory factory)
		{
		}

		internal static bool TryGetValue(string fullTypeName, out List<IUxmlFactory> factoryList)
		{
			factoryList = null;
			return false;
		}

		private static void RegisterEngineFactories()
		{
		}

		internal static void RegisterUserFactories()
		{
		}
	}
}
