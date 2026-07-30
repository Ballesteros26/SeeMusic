using System;
using System.Collections.Generic;

namespace Parse.Core.Internal
{
	public class ParseIncrementOperation : IParseFieldOperation
	{
		private static readonly IDictionary<Tuple<Type, Type>, Func<object, object, object>> adders;

		private object amount;

		public object Amount => null;

		static ParseIncrementOperation()
		{
		}

		public ParseIncrementOperation(object amount)
		{
		}

		public object Encode()
		{
			return null;
		}

		private static object Add(object obj1, object obj2)
		{
			return null;
		}

		public IParseFieldOperation MergeWithPrevious(IParseFieldOperation previous)
		{
			return null;
		}

		public object Apply(object oldValue, string key)
		{
			return null;
		}
	}
}
