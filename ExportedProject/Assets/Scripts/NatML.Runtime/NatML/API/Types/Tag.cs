using System;
using System.Diagnostics.CodeAnalysis;
using NatML.API.Graph;

namespace NatML.API.Types
{
	[Serializable]
	[Preserve]
	public sealed class Tag
	{
		public string username;

		public string name;

		public string? variant;

		public Tag(string username, string name, string? variant = null)
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
