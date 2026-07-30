using System.Collections.Generic;

namespace Parse.Core.Internal
{
	public class ParseObjectIdComparer : IEqualityComparer<object>
	{
		bool IEqualityComparer<object>.Equals(object p1, object p2)
		{
			return false;
		}

		public int GetHashCode(object p)
		{
			return 0;
		}
	}
}
