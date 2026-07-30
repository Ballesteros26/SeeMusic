using System;

namespace Parse.Common.Internal
{
	[AttributeUsage(AttributeTargets.All)]
	internal class PreserveAttribute : Attribute
	{
		public bool AllMembers;

		public bool Conditional;
	}
}
