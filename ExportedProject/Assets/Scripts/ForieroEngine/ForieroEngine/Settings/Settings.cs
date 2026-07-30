using UnityEngine;

namespace ForieroEngine.Settings
{
	public abstract class Settings<T> : ScriptableObject where T : Settings<T>, ISettingsProvider
	{
		private static T _instance;

		public static T instance => null;

		public static T Instance()
		{
			return null;
		}
	}
}
