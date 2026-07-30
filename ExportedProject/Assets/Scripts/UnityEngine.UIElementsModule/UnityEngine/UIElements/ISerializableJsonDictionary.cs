namespace UnityEngine.UIElements
{
	internal interface ISerializableJsonDictionary
	{
		void Set<T>(string key, T value) where T : class;

		void Overwrite(object obj, string key);

		bool ContainsKey(string key);
	}
}
