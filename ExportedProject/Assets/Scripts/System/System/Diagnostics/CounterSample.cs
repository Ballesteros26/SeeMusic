namespace System.Diagnostics
{
	/// <summary>Defines a structure that holds the raw data for a performance counter.</summary>
	/// <filterpriority>2</filterpriority>
	public struct CounterSample
	{
		/// <summary>Defines an empty, uninitialized performance counter sample of type NumberOfItems32.</summary>
		/// <filterpriority>1</filterpriority>
		public static CounterSample Empty;

		/// <summary>Gets an optional, base raw value for the counter.</summary>
		/// <returns>The base raw value, which is used only if the sample is based on multiple counters.</returns>
		/// <filterpriority>2</filterpriority>
		public long BaseValue => 0L;

		/// <summary>Gets the raw counter frequency.</summary>
		/// <returns>The frequency with which the counter is read.</returns>
		/// <filterpriority>2</filterpriority>
		public long CounterFrequency => 0L;

		/// <summary>Gets the counter's time stamp.</summary>
		/// <returns>The time at which the sample was taken.</returns>
		/// <filterpriority>2</filterpriority>
		public long CounterTimeStamp => 0L;

		/// <summary>Gets the performance counter type.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.PerformanceCounterType" /> object that indicates the type of the counter for which this sample is a snapshot.</returns>
		/// <filterpriority>2</filterpriority>
		public PerformanceCounterType CounterType => default(PerformanceCounterType);

		/// <summary>Gets the raw value of the counter.</summary>
		/// <returns>The numeric value that is associated with the performance counter sample.</returns>
		/// <filterpriority>2</filterpriority>
		public long RawValue => 0L;

		/// <summary>Gets the raw system frequency.</summary>
		/// <returns>The frequency with which the system reads from the counter.</returns>
		/// <filterpriority>2</filterpriority>
		public long SystemFrequency => 0L;

		/// <summary>Gets the raw time stamp.</summary>
		/// <returns>The system time stamp.</returns>
		/// <filterpriority>2</filterpriority>
		public long TimeStamp => 0L;

		/// <summary>Gets the raw, high-fidelity time stamp.</summary>
		/// <returns>The system time stamp, represented within 0.1 millisecond.</returns>
		/// <filterpriority>2</filterpriority>
		public long TimeStamp100nSec => 0L;

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.CounterSample" /> structure and sets the <see cref="P:System.Diagnostics.CounterSample.CounterTimeStamp" /> property to 0 (zero).</summary>
		/// <param name="rawValue">The numeric value associated with the performance counter sample. </param>
		/// <param name="baseValue">An optional, base raw value for the counter, to use only if the sample is based on multiple counters. </param>
		/// <param name="counterFrequency">The frequency with which the counter is read. </param>
		/// <param name="systemFrequency">The frequency with which the system reads from the counter. </param>
		/// <param name="timeStamp">The raw time stamp. </param>
		/// <param name="timeStamp100nSec">The raw, high-fidelity time stamp. </param>
		/// <param name="counterType">A <see cref="T:System.Diagnostics.PerformanceCounterType" /> object that indicates the type of the counter for which this sample is a snapshot. </param>
		public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.CounterSample" /> structure and sets the <see cref="P:System.Diagnostics.CounterSample.CounterTimeStamp" /> property to the value that is passed in.</summary>
		/// <param name="rawValue">The numeric value associated with the performance counter sample. </param>
		/// <param name="baseValue">An optional, base raw value for the counter, to use only if the sample is based on multiple counters. </param>
		/// <param name="counterFrequency">The frequency with which the counter is read. </param>
		/// <param name="systemFrequency">The frequency with which the system reads from the counter. </param>
		/// <param name="timeStamp">The raw time stamp. </param>
		/// <param name="timeStamp100nSec">The raw, high-fidelity time stamp. </param>
		/// <param name="counterType">A <see cref="T:System.Diagnostics.PerformanceCounterType" /> object that indicates the type of the counter for which this sample is a snapshot. </param>
		/// <param name="counterTimeStamp">The time at which the sample was taken. </param>
		public CounterSample(long rawValue, long baseValue, long counterFrequency, long systemFrequency, long timeStamp, long timeStamp100nSec, PerformanceCounterType counterType, long counterTimeStamp)
		{
		}

		/// <summary>Calculates the performance data of the counter, using a single sample point. This method is generally used for uncalculated performance counter types.</summary>
		/// <returns>The calculated performance value.</returns>
		/// <param name="counterSample">The <see cref="T:System.Diagnostics.CounterSample" /> structure to use as a base point for calculating performance data. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static float Calculate(CounterSample counterSample)
		{
			return 0f;
		}

		/// <summary>Calculates the performance data of the counter, using two sample points. This method is generally used for calculated performance counter types, such as averages.</summary>
		/// <returns>The calculated performance value.</returns>
		/// <param name="counterSample">The <see cref="T:System.Diagnostics.CounterSample" /> structure to use as a base point for calculating performance data. </param>
		/// <param name="nextCounterSample">The <see cref="T:System.Diagnostics.CounterSample" /> structure to use as an ending point for calculating performance data. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static float Calculate(CounterSample counterSample, CounterSample nextCounterSample)
		{
			return 0f;
		}

		/// <summary>Indicates whether the specified <see cref="T:System.Diagnostics.CounterSample" /> structure is equal to the current <see cref="T:System.Diagnostics.CounterSample" /> structure.</summary>
		/// <returns>true if <paramref name="sample" /> is equal to the current instance; otherwise, false. </returns>
		/// <param name="sample">The <see cref="T:System.Diagnostics.CounterSample" /> structure to be compared with this instance.</param>
		public bool Equals(CounterSample sample)
		{
			return false;
		}

		/// <summary>Returns a value that indicates whether two <see cref="T:System.Diagnostics.CounterSample" /> structures are equal.</summary>
		/// <returns>true if <paramref name="a" /> and <paramref name="b" /> are equal; otherwise, false.</returns>
		/// <param name="a">A <see cref="T:System.Diagnostics.CounterSample" /> structure.</param>
		/// <param name="b">Another <see cref="T:System.Diagnostics.CounterSample" /> structure to be compared to the structure specified by the <paramref name="a" /> parameter.</param>
		public static bool operator ==(CounterSample a, CounterSample b)
		{
			return false;
		}

		/// <summary>Returns a value that indicates whether two <see cref="T:System.Diagnostics.CounterSample" /> structures are not equal.</summary>
		/// <returns>true if <paramref name="a" /> and <paramref name="b" /> are not equal; otherwise, false</returns>
		/// <param name="a">A <see cref="T:System.Diagnostics.CounterSample" /> structure.</param>
		/// <param name="b">Another <see cref="T:System.Diagnostics.CounterSample" /> structure to be compared to the structure specified by the <paramref name="a" /> parameter.</param>
		public static bool operator !=(CounterSample a, CounterSample b)
		{
			return false;
		}
	}
}
