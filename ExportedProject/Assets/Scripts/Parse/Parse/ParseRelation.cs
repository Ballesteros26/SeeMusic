namespace Parse
{
	public sealed class ParseRelation<T> : ParseRelationBase where T : ParseObject
	{
		public ParseQuery<T> Query => null;

		internal ParseRelation(ParseObject parent, string key)
			: base(null, null)
		{
		}

		internal ParseRelation(ParseObject parent, string key, string targetClassName)
			: base(null, null)
		{
		}

		public void Add(T obj)
		{
		}

		public void Remove(T obj)
		{
		}
	}
}
