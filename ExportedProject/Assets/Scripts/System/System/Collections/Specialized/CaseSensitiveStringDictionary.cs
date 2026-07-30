namespace System.Collections.Specialized
{
	internal class CaseSensitiveStringDictionary : StringDictionary
	{
		public override string this[string key]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Add(string key, string value)
		{
		}

		public override bool ContainsKey(string key)
		{
			return false;
		}

		public override void Remove(string key)
		{
		}
	}
}
