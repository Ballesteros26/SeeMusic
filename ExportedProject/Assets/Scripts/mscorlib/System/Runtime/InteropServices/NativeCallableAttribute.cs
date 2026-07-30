namespace System.Runtime.InteropServices
{
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class NativeCallableAttribute : Attribute
	{
		public CallingConvention CallingConvention;
	}
}
