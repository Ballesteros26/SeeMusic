using System.Reflection;
using UnityEngine.Scripting;

namespace Unity.Burst
{
	public static class BurstCompiler
	{
		private class FakeDelegate
		{
			[Preserve]
			public MethodInfo Method { get; }
		}

		internal static bool _IsEnabled;

		public static readonly BurstCompilerOptions Options;

		private static readonly MethodInfo DummyMethodInfo;

		private static void DummyMethod()
		{
		}
	}
}
