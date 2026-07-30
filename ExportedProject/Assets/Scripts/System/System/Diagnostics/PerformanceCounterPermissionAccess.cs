namespace System.Diagnostics
{
	/// <summary>Defines access levels used by <see cref="T:System.Diagnostics.PerformanceCounter" /> permission classes.</summary>
	/// <filterpriority>2</filterpriority>
	[Flags]
	public enum PerformanceCounterPermissionAccess
	{
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can read, write, and create categories.</summary>
		Administer = 7,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can read categories.</summary>
		[Obsolete("This member has been deprecated.  Use System.Diagnostics.PerformanceCounter.PerformanceCounterPermissionAccess.Read instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		Browse = 1,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can read and write categories.</summary>
		[Obsolete("This member has been deprecated.  Use System.Diagnostics.PerformanceCounter.PerformanceCounterPermissionAccess.Write instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		Instrument = 3,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> has no permissions.</summary>
		None = 0,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can read categories.</summary>
		Read = 1,
		/// <summary>The <see cref="T:System.Diagnostics.PerformanceCounter" /> can write categories.</summary>
		Write = 2
	}
}
