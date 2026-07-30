namespace System.Runtime.InteropServices
{
	/// <summary>Indicates that the HRESULT or retval signature transformation that takes place during COM interop calls should be suppressed.</summary>
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Method, Inherited = false)]
	public sealed class PreserveSigAttribute : Attribute
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.InteropServices.PreserveSigAttribute" /> class.</summary>
		public PreserveSigAttribute()
		{
		}
	}
}
