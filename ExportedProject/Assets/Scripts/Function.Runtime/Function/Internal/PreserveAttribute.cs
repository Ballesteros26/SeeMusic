using System;

namespace Function.Internal
{
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	internal sealed class PreserveAttribute : Attribute
	{
	}
}
