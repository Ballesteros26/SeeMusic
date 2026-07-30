using System;
using System.Diagnostics.CodeAnalysis;
using Function.Internal;

namespace Function.Types
{
	[Serializable]
	[Preserve]
	public sealed class Tag
	{
		public string username;

		public string name;

		public Tag(string username, string name)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static bool TryParse(string input, [NotNullWhen(true)] out Tag? tag)
		{
			tag = null;
			return false;
		}

		public static implicit operator string(Tag tag)
		{
			return null;
		}
	}
}
