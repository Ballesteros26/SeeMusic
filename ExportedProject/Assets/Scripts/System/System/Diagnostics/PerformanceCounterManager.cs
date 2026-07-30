using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Prepares performance data for the performance.dll the system loads when working with performance counters.</summary>
	/// <filterpriority>2</filterpriority>
	[Guid("82840BE1-D273-11D2-B94A-00600893B17A")]
	[Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	[ComVisible(true)]
	public sealed class PerformanceCounterManager : ICollectData
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.PerformanceCounterManager" /> class.</summary>
		[Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		public PerformanceCounterManager()
		{
		}

		/// <summary>Called by the perf dll's close performance data </summary>
		[Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		void ICollectData.CloseData()
		{
		}

		/// <summary>Performance data collection routine. Called by the PerfCount perf dll.</summary>
		/// <param name="callIdx">The call index. </param>
		/// <param name="valueNamePtr">A pointer to a Unicode string list with the requested Object identifiers.</param>
		/// <param name="dataPtr">A pointer to the data buffer.</param>
		/// <param name="totalBytes">A pointer to a number of bytes.</param>
		/// <param name="res">When this method returns, contains a <see cref="T:System.IntPtr" /> with a value of -1.</param>
		[Obsolete("This class has been deprecated.  Use the PerformanceCounters through the System.Diagnostics.PerformanceCounter class instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		void ICollectData.CollectData(int callIdx, IntPtr valueNamePtr, IntPtr dataPtr, int totalBytes, out IntPtr res)
		{
			res = default(IntPtr);
		}
	}
}
