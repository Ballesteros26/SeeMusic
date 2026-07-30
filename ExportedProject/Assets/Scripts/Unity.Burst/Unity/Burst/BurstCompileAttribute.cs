using System;

namespace Unity.Burst
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
	public class BurstCompileAttribute : Attribute
	{
	}
}
