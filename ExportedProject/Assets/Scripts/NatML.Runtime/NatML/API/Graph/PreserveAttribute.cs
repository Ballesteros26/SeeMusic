using System;

namespace NatML.API.Graph
{
	[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
	public sealed class PreserveAttribute : Attribute
	{
	}
}
