using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace System.Diagnostics
{
	/// <summary>Represents a Windows NT performance counter component.</summary>
	/// <filterpriority>1</filterpriority>
	[InstallerType("System.Diagnostics.PerformanceCounterInstaller,System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	public sealed class PerformanceCounter : Component, ISupportInitialize
	{
		/// <summary>Specifies the size, in bytes, of the global memory shared by performance counters. The default size is 524,288 bytes.</summary>
		/// <filterpriority>1</filterpriority>
		[Obsolete("This field has been deprecated and is not used.  Use machine.config or an application configuration file to set the size of the PerformanceCounter file mapping.")]
		public static int DefaultFileMappingSize;

		/// <summary>Gets or sets the name of the performance counter category for this performance counter.</summary>
		/// <returns>The name of the performance counter category (performance object) with which this performance counter is associated.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Diagnostics.PerformanceCounter.CategoryName" /> is null. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <filterpriority>1</filterpriority>
		public string CategoryName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the description for this performance counter.</summary>
		/// <returns>A description of the item or quantity that this performance counter measures.</returns>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="T:System.Diagnostics.PerformanceCounter" /> instance is not associated with a performance counter. -or-The <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> property is set to <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />  when using global shared memory.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public string CounterHelp => null;

		/// <summary>Gets or sets the name of the performance counter that is associated with this <see cref="T:System.Diagnostics.PerformanceCounter" /> instance.</summary>
		/// <returns>The name of the counter, which generally describes the quantity being counted. This name is displayed in the list of counters of the Performance Counter Manager MMC snap in's Add Counters dialog box.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <see cref="P:System.Diagnostics.PerformanceCounter.CounterName" /> is null. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <filterpriority>1</filterpriority>
		public string CounterName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the counter type of the associated performance counter.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.PerformanceCounterType" /> that describes both how the counter interacts with a monitoring application and the nature of the values it contains (for example, calculated or uncalculated).</returns>
		/// <exception cref="T:System.InvalidOperationException">The instance is not correctly associated with a performance counter. -or-The <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> property is set to <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />  when using global shared memory.</exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public PerformanceCounterType CounterType => default(PerformanceCounterType);

		/// <summary>Gets or sets the lifetime of a process.</summary>
		/// <returns>One of the <see cref="T:System.Diagnostics.PerformanceCounterInstanceLifetime" /> values. The default is <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Global" />.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The value set is not a member of the <see cref="T:System.Diagnostics.PerformanceCounterInstanceLifetime" /> enumeration. </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> is set after the <see cref="T:System.Diagnostics.PerformanceCounter" /> has been initialized.</exception>
		public PerformanceCounterInstanceLifetime InstanceLifetime
		{
			get
			{
				return default(PerformanceCounterInstanceLifetime);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets an instance name for this performance counter.</summary>
		/// <returns>The name of the performance counter category instance, or an empty string (""), if the counter is a single-instance counter.</returns>
		/// <filterpriority>1</filterpriority>
		public string InstanceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the computer name for this performance counter </summary>
		/// <returns>The server on which the performance counter and its associated category reside.</returns>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Diagnostics.PerformanceCounter.MachineName" /> format is invalid. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <filterpriority>1</filterpriority>
		public string MachineName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the raw, or uncalculated, value of this counter.</summary>
		/// <returns>The raw value of the counter.</returns>
		/// <exception cref="T:System.InvalidOperationException">You are trying to set the counter's raw value, but the counter is read-only.-or- The instance is not correctly associated with a performance counter. -or-The <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> property is set to <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />  when using global shared memory.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public long RawValue
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value indicating whether this <see cref="T:System.Diagnostics.PerformanceCounter" /> instance is in read-only mode.</summary>
		/// <returns>true, if the <see cref="T:System.Diagnostics.PerformanceCounter" /> instance is in read-only mode (even if the counter itself is a custom .NET Framework counter); false if it is in read/write mode. The default is the value set by the constructor.</returns>
		/// <filterpriority>1</filterpriority>
		public bool ReadOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new, read-only instance of the <see cref="T:System.Diagnostics.PerformanceCounter" /> class, without associating the instance with any system or custom performance counter.</summary>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		public PerformanceCounter()
		{
		}

		/// <summary>Initializes a new, read-only instance of the <see cref="T:System.Diagnostics.PerformanceCounter" /> class and associates it with the specified system or custom performance counter on the local computer. This constructor requires that the category have a single instance.</summary>
		/// <param name="categoryName">The name of the performance counter category (performance object) with which this performance counter is associated. </param>
		/// <param name="counterName">The name of the performance counter. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="categoryName" /> is an empty string ("").-or- <paramref name="counterName" /> is an empty string ("").-or- The category specified does not exist. -or-The category specified is marked as multi-instance and requires the performance counter to be created with an instance name.-or-<paramref name="categoryName" /> and <paramref name="counterName" /> have been localized into different languages.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="categoryName" /> or <paramref name="counterName" /> is null. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		public PerformanceCounter(string categoryName, string counterName)
		{
		}

		/// <summary>Initializes a new, read-only or read/write instance of the <see cref="T:System.Diagnostics.PerformanceCounter" /> class and associates it with the specified system or custom performance counter on the local computer. This constructor requires that the category contain a single instance.</summary>
		/// <param name="categoryName">The name of the performance counter category (performance object) with which this performance counter is associated. </param>
		/// <param name="counterName">The name of the performance counter. </param>
		/// <param name="readOnly">true to access the counter in read-only mode (although the counter itself could be read/write); false to access the counter in read/write mode. </param>
		/// <exception cref="T:System.InvalidOperationException">The <paramref name="categoryName" /> is an empty string ("").-or- The <paramref name="counterName" /> is an empty string ("").-or- The category specified does not exist. (if <paramref name="readOnly" /> is true). -or- The category specified is not a .NET Framework custom category (if <paramref name="readOnly" /> is false). -or-The category specified is marked as multi-instance and requires the performance counter to be created with an instance name.-or-<paramref name="categoryName" /> and <paramref name="counterName" /> have been localized into different languages.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="categoryName" /> or <paramref name="counterName" /> is null. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		public PerformanceCounter(string categoryName, string counterName, bool readOnly)
		{
		}

		/// <summary>Initializes a new, read-only instance of the <see cref="T:System.Diagnostics.PerformanceCounter" /> class and associates it with the specified system or custom performance counter and category instance on the local computer.</summary>
		/// <param name="categoryName">The name of the performance counter category (performance object) with which this performance counter is associated. </param>
		/// <param name="counterName">The name of the performance counter. </param>
		/// <param name="instanceName">The name of the performance counter category instance, or an empty string (""), if the category contains a single instance. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="categoryName" /> is an empty string ("").-or- <paramref name="counterName" /> is an empty string ("").-or- The category specified is not valid. -or-The category specified is marked as multi-instance and requires the performance counter to be created with an instance name.-or-<paramref name="instanceName" /> is longer than 127 characters.-or-<paramref name="categoryName" /> and <paramref name="counterName" /> have been localized into different languages.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="categoryName" /> or <paramref name="counterName" /> is null. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		public PerformanceCounter(string categoryName, string counterName, string instanceName)
		{
		}

		/// <summary>Initializes a new, read-only or read/write instance of the <see cref="T:System.Diagnostics.PerformanceCounter" /> class and associates it with the specified system or custom performance counter and category instance on the local computer.</summary>
		/// <param name="categoryName">The name of the performance counter category (performance object) with which this performance counter is associated. </param>
		/// <param name="counterName">The name of the performance counter. </param>
		/// <param name="instanceName">The name of the performance counter category instance, or an empty string (""), if the category contains a single instance. </param>
		/// <param name="readOnly">true to access a counter in read-only mode; false to access a counter in read/write mode. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="categoryName" /> is an empty string ("").-or- <paramref name="counterName" /> is an empty string ("").-or- The read/write permission setting requested is invalid for this counter.-or- The category specified does not exist (if <paramref name="readOnly" /> is true). -or- The category specified is not a .NET Framework custom category (if <paramref name="readOnly" /> is false). -or-The category specified is marked as multi-instance and requires the performance counter to be created with an instance name.-or-<paramref name="instanceName" /> is longer than 127 characters.-or-<paramref name="categoryName" /> and <paramref name="counterName" /> have been localized into different languages.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="categoryName" /> or <paramref name="counterName" /> is null. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		public PerformanceCounter(string categoryName, string counterName, string instanceName, bool readOnly)
		{
		}

		/// <summary>Initializes a new, read-only instance of the <see cref="T:System.Diagnostics.PerformanceCounter" /> class and associates it with the specified system or custom performance counter and category instance, on the specified computer.</summary>
		/// <param name="categoryName">The name of the performance counter category (performance object) with which this performance counter is associated. </param>
		/// <param name="counterName">The name of the performance counter. </param>
		/// <param name="instanceName">The name of the performance counter category instance, or an empty string (""), if the category contains a single instance. </param>
		/// <param name="machineName">The computer on which the performance counter and its associated category exist. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="categoryName" /> is an empty string ("").-or- <paramref name="counterName" /> is an empty string ("").-or- The read/write permission setting requested is invalid for this counter.-or- The counter does not exist on the specified computer. -or-The category specified is marked as multi-instance and requires the performance counter to be created with an instance name.-or-<paramref name="instanceName" /> is longer than 127 characters.-or-<paramref name="categoryName" /> and <paramref name="counterName" /> have been localized into different languages.</exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="machineName" /> parameter is not valid. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="categoryName" /> or <paramref name="counterName" /> is null. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		public PerformanceCounter(string categoryName, string counterName, string instanceName, string machineName)
		{
		}

		/// <summary>Begins the initialization of a <see cref="T:System.Diagnostics.PerformanceCounter" /> instance used on a form or by another component. The initialization occurs at runtime.</summary>
		/// <filterpriority>2</filterpriority>
		public void BeginInit()
		{
		}

		/// <summary>Closes the performance counter and frees all the resources allocated by this performance counter instance.</summary>
		/// <filterpriority>2</filterpriority>
		public void Close()
		{
		}

		/// <summary>Frees the performance counter library shared state allocated by the counters.</summary>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1">
		///     <Machine name=".">
		///       <Category name="*" access="Browse" />
		///     </Machine>
		///   </IPermission>
		/// </PermissionSet>
		public static void CloseSharedResources()
		{
		}

		/// <summary>Decrements the associated performance counter by one through an efficient atomic operation.</summary>
		/// <returns>The decremented counter value.</returns>
		/// <exception cref="T:System.InvalidOperationException">The counter is read-only, so the application cannot decrement it.-or- The instance is not correctly associated with a performance counter. -or-The <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> property is set to <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />  when using global shared memory.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public long Decrement()
		{
			return 0L;
		}

		/// <summary>Ends the initialization of a <see cref="T:System.Diagnostics.PerformanceCounter" /> instance that is used on a form or by another component. The initialization occurs at runtime.</summary>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void EndInit()
		{
		}

		/// <summary>Increments the associated performance counter by one through an efficient atomic operation.</summary>
		/// <returns>The incremented counter value.</returns>
		/// <exception cref="T:System.InvalidOperationException">The counter is read-only, so the application cannot increment it.-or- The instance is not correctly associated with a performance counter. -or-The <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> property is set to <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />  when using global shared memory.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public long Increment()
		{
			return 0L;
		}

		/// <summary>Increments or decrements the value of the associated performance counter by a specified amount through an efficient atomic operation.</summary>
		/// <returns>The new counter value.</returns>
		/// <param name="value">The value to increment by. (A negative value decrements the counter.) </param>
		/// <exception cref="T:System.InvalidOperationException">The counter is read-only, so the application cannot increment it.-or- The instance is not correctly associated with a performance counter. -or-The <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> property is set to <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />  when using global shared memory.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public long IncrementBy(long value)
		{
			return 0L;
		}

		/// <summary>Obtains a counter sample, and returns the raw, or uncalculated, value for it.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.CounterSample" /> that represents the next raw value that the system obtains for this counter.</returns>
		/// <exception cref="T:System.InvalidOperationException">The instance is not correctly associated with a performance counter. -or-The <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> property is set to <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />  when using global shared memory.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public CounterSample NextSample()
		{
			return default(CounterSample);
		}

		/// <summary>Obtains a counter sample and returns the calculated value for it.</summary>
		/// <returns>The next calculated value that the system obtains for this counter.</returns>
		/// <exception cref="T:System.InvalidOperationException">The instance is not correctly associated with a performance counter. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <exception cref="T:System.UnauthorizedAccessException">Code that is executing without administrative privileges attempted to read a performance counter.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public float NextValue()
		{
			return 0f;
		}

		/// <summary>Deletes the category instance specified by the <see cref="T:System.Diagnostics.PerformanceCounter" /> object <see cref="P:System.Diagnostics.PerformanceCounter.InstanceName" /> property.</summary>
		/// <exception cref="T:System.InvalidOperationException">This counter is read-only, so any instance that is associated with the category cannot be removed.-or- The instance is not correctly associated with a performance counter. -or-The <see cref="P:System.Diagnostics.PerformanceCounter.InstanceLifetime" /> property is set to <see cref="F:System.Diagnostics.PerformanceCounterInstanceLifetime.Process" />  when using global shared memory.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">An error occurred when accessing a system API. </exception>
		/// <exception cref="T:System.PlatformNotSupportedException">The platform is Windows 98 or Windows Millennium Edition (Me), which does not support performance counters. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		///   <IPermission class="System.Diagnostics.PerformanceCounterPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		public void RemoveInstance()
		{
		}
	}
}
