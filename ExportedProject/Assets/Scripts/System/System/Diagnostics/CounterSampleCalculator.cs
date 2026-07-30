namespace System.Diagnostics
{
	/// <summary>Provides a set of utility functions for interpreting performance counter data.</summary>
	/// <filterpriority>2</filterpriority>
	public static class CounterSampleCalculator
	{
		/// <summary>Computes the calculated value of a single raw counter sample.</summary>
		/// <returns>A floating-point representation of the performance counter's calculated value.</returns>
		/// <param name="newSample">A <see cref="T:System.Diagnostics.CounterSample" /> that indicates the most recent sample the system has taken. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static float ComputeCounterValue(CounterSample newSample)
		{
			return 0f;
		}

		/// <summary>Computes the calculated value of two raw counter samples.</summary>
		/// <returns>A floating-point representation of the performance counter's calculated value.</returns>
		/// <param name="oldSample">A <see cref="T:System.Diagnostics.CounterSample" /> that indicates a previous sample the system has taken. </param>
		/// <param name="newSample">A <see cref="T:System.Diagnostics.CounterSample" /> that indicates the most recent sample the system has taken. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="oldSample" /> uses a counter type that is different from <paramref name="newSample" />. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">
		///   <paramref name="newSample" /> counter type has a Performance Data Helper (PDH) error. For more information, see "Checking PDH Interface Return Values" in the Win32 and COM Development section of this documentation.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static float ComputeCounterValue(CounterSample oldSample, CounterSample newSample)
		{
			return 0f;
		}
	}
}
