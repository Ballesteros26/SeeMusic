using System.Collections.Generic;
using UnityEngine;

namespace ForieroEngine
{
	public static class Instances
	{
		public static Dictionary<string, object> instances;

		public static T Instance<T>(string name, string assetPath = "") where T : ScriptableObject
		{
			return null;
		}
	}
}
