using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Diagnostics
{
	/// <summary>Provides interaction with Windows event logs. </summary>
	/// <filterpriority>1</filterpriority>
	[MonitoringDescription("EventLogDesc")]
	[InstallerType("System.Diagnostics.EventLogInstaller, System.Configuration.Install, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DefaultEvent("EntryWritten")]
	public class EventLog : Component, ISupportInitialize
	{
		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Diagnostics.EventLog" /> receives <see cref="E:System.Diagnostics.EventLog.EntryWritten" /> event notifications.</summary>
		/// <returns>true if the <see cref="T:System.Diagnostics.EventLog" /> receives notification when an entry is written to the log; otherwise, false.</returns>
		/// <exception cref="T:System.InvalidOperationException">The event log is on a remote computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public bool EnableRaisingEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets the contents of the event log.</summary>
		/// <returns>An <see cref="T:System.Diagnostics.EventLogEntryCollection" /> holding the entries in the event log. Each entry is associated with an instance of the <see cref="T:System.Diagnostics.EventLogEntry" /> class.</returns>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public EventLogEntryCollection Entries => null;

		/// <summary>Gets or sets the name of the log to read from or write to.</summary>
		/// <returns>The name of the log. This can be Application, System, Security, or a custom log name. The default is an empty string ("").</returns>
		/// <filterpriority>1</filterpriority>
		public string Log
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the event log's friendly name.</summary>
		/// <returns>A name that represents the event log in the system's event viewer.</returns>
		/// <exception cref="T:System.InvalidOperationException">The specified <see cref="P:System.Diagnostics.EventLog.Log" /> does not exist in the registry for this computer.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public string LogDisplayName => null;

		/// <summary>Gets or sets the name of the computer on which to read or write events.</summary>
		/// <returns>The name of the server on which the event log resides. The default is the local computer (".").</returns>
		/// <exception cref="T:System.ArgumentException">The computer name is invalid. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
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

		/// <summary>Gets or sets the maximum event log size in kilobytes.</summary>
		/// <returns>The maximum event log size in kilobytes. The default is 512, indicating a maximum file size of 512 kilobytes.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The specified value is less than 64, or greater than 4194240, or not an even multiple of 64. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.EventLog.Log" /> value is not a valid log name.- or -The registry key for the event log could not be opened on the target computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public long MaximumKilobytes
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		/// <summary>Gets the number of days to retain entries in the event log.</summary>
		/// <returns>The number of days that entries in the event log are retained. The default value is 7.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public int MinimumRetentionDays => 0;

		/// <summary>Gets the configured behavior for storing new entries when the event log reaches its maximum log file size.</summary>
		/// <returns>The <see cref="T:System.Diagnostics.OverflowAction" /> value that specifies the configured behavior for storing new entries when the event log reaches its maximum log size. The default is <see cref="F:System.Diagnostics.OverflowAction.OverwriteOlder" />.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public OverflowAction OverflowAction => default(OverflowAction);

		/// <summary>Gets or sets the source name to register and use when writing to the event log.</summary>
		/// <returns>The name registered with the event log as a source of entries. The default is an empty string ("").</returns>
		/// <exception cref="T:System.ArgumentException">The source name results in a registry key path longer than 254 characters.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public string Source
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the object used to marshal the event handler calls issued as a result of an <see cref="T:System.Diagnostics.EventLog" /> entry written event.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> used to marshal event-handler calls issued as a result of an <see cref="E:System.Diagnostics.EventLog.EntryWritten" /> event on the event log.</returns>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public ISynchronizeInvoke SynchronizingObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Occurs when an entry is written to an event log on the local computer.</summary>
		/// <filterpriority>2</filterpriority>
		public event EntryWrittenEventHandler EntryWritten
		{
			add
			{
			}
			remove
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLog" /> class. Does not associate the instance with any log.</summary>
		public EventLog()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLog" /> class. Associates the instance with a log on the local computer.</summary>
		/// <param name="logName">The name of the log on the local computer. </param>
		/// <exception cref="T:System.ArgumentNullException">The log name is null. </exception>
		/// <exception cref="T:System.ArgumentException">The log name is invalid. </exception>
		public EventLog(string logName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLog" /> class. Associates the instance with a log on the specified computer.</summary>
		/// <param name="logName">The name of the log on the specified computer. </param>
		/// <param name="machineName">The computer on which the log exists. </param>
		/// <exception cref="T:System.ArgumentNullException">The log name is null. </exception>
		/// <exception cref="T:System.ArgumentException">The log name is invalid.-or- The computer name is invalid. </exception>
		public EventLog(string logName, string machineName)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLog" /> class. Associates the instance with a log on the specified computer and creates or assigns the specified source to the <see cref="T:System.Diagnostics.EventLog" />.</summary>
		/// <param name="logName">The name of the log on the specified computer </param>
		/// <param name="machineName">The computer on which the log exists. </param>
		/// <param name="source">The source of event log entries. </param>
		/// <exception cref="T:System.ArgumentNullException">The log name is null. </exception>
		/// <exception cref="T:System.ArgumentException">The log name is invalid.-or- The computer name is invalid. </exception>
		public EventLog(string logName, string machineName, string source)
		{
		}

		/// <summary>Begins the initialization of an <see cref="T:System.Diagnostics.EventLog" /> used on a form or used by another component. The initialization occurs at runtime.</summary>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="T:System.Diagnostics.EventLog" /> is already initialized.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void BeginInit()
		{
		}

		/// <summary>Removes all entries from the event log.</summary>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The event log was not cleared successfully.-or- The log cannot be opened. A Windows error code is not available. </exception>
		/// <exception cref="T:System.ArgumentException">A value is not specified for the <see cref="P:System.Diagnostics.EventLog.Log" /> property. Make sure the log name is not an empty string. </exception>
		/// <exception cref="T:System.InvalidOperationException">The log does not exist. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void Clear()
		{
		}

		/// <summary>Closes the event log and releases read and write handles.</summary>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The event log's read handle or write handle was not released successfully. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void Close()
		{
		}

		/// <summary>Establishes a valid event source for writing localized event messages, using the specified configuration properties for the event source and the corresponding event log.</summary>
		/// <param name="sourceData">The configuration properties for the event source and its target event log. </param>
		/// <exception cref="T:System.ArgumentException">The computer name specified in <paramref name="sourceData" /> is not valid.- or - The source name specified in <paramref name="sourceData" /> is null.- or - The log name specified in <paramref name="sourceData" /> is not valid. Event log names must consist of printable characters and cannot include the characters '*', '?', or '\'.- or - The log name specified in <paramref name="sourceData" /> is not valid for user log creation. The Event log names AppEvent, SysEvent, and SecEvent are reserved for system use.- or - The log name matches an existing event source name.- or - The source name specified in <paramref name="sourceData" /> results in a registry key path longer than 254 characters.- or - The first 8 characters of the log name specified in <paramref name="sourceData" /> are not unique.- or - The source name specified in <paramref name="sourceData" /> is already registered.- or - The source name specified in <paramref name="sourceData" /> matches an existing event log name.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened. </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="sourceData" /> is null. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void CreateEventSource(EventSourceCreationData sourceData)
		{
		}

		/// <summary>Establishes the specified source name as a valid event source for writing entries to a log on the local computer. This method can also create a new custom log on the local computer.</summary>
		/// <param name="source">The source name by which the application is registered on the local computer. </param>
		/// <param name="logName">The name of the log the source's entries are written to. Possible values include Application, System, or a custom event log. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="source" /> is an empty string ("") or null.- or - <paramref name="logName" /> is not a valid event log name. Event log names must consist of printable characters, and cannot include the characters '*', '?', or '\'.- or - <paramref name="logName" /> is not valid for user log creation. The event log names AppEvent, SysEvent, and SecEvent are reserved for system use.- or - The log name matches an existing event source name.- or - The source name results in a registry key path longer than 254 characters.- or - The first 8 characters of <paramref name="logName" /> match the first 8 characters of an existing event log name.- or - The source cannot be registered because it already exists on the local computer.- or - The source name matches an existing event log name. </exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened on the local computer. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void CreateEventSource(string source, string logName)
		{
		}

		/// <summary>Establishes the specified source name as a valid event source for writing entries to a log on the specified computer. This method can also be used to create a new custom log on the specified computer.</summary>
		/// <param name="source">The source by which the application is registered on the specified computer. </param>
		/// <param name="logName">The name of the log the source's entries are written to. Possible values include Application, System, or a custom event log. If you do not specify a value, <paramref name="logName" /> defaults to Application. </param>
		/// <param name="machineName">The name of the computer to register this event source with, or "." for the local computer. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="machineName" /> is not a valid computer name.- or - <paramref name="source" /> is an empty string ("") or null.- or - <paramref name="logName" /> is not a valid event log name. Event log names must consist of printable characters, and cannot include the characters '*', '?', or '\'.- or - <paramref name="logName" /> is not valid for user log creation. The event log names AppEvent, SysEvent, and SecEvent are reserved for system use.- or - The log name matches an existing event source name.- or - The source name results in a registry key path longer than 254 characters.- or - The first 8 characters of <paramref name="logName" /> match the first 8 characters of an existing event log name on the specified computer.- or - The source cannot be registered because it already exists on the specified computer.- or - The source name matches an existing event source name. </exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened on the specified computer. </exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[Obsolete("This method has been deprecated.  Please use System.Diagnostics.EventLog.CreateEventSource(EventSourceCreationData sourceData) instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		public static void CreateEventSource(string source, string logName, string machineName)
		{
		}

		/// <summary>Removes an event log from the local computer.</summary>
		/// <param name="logName">The name of the log to delete. Possible values include: Application, Security, System, and any custom event logs on the computer. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="logName" /> is an empty string ("") or null. </exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened on the local computer.- or - The log does not exist on the local computer. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The event log was not cleared successfully.-or- The log cannot be opened. A Windows error code is not available. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void Delete(string logName)
		{
		}

		/// <summary>Removes an event log from the specified computer.</summary>
		/// <param name="logName">The name of the log to delete. Possible values include: Application, Security, System, and any custom event logs on the specified computer. </param>
		/// <param name="machineName">The name of the computer to delete the log from, or "." for the local computer. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="logName" /> is an empty string ("") or null. - or - <paramref name="machineName" /> is not a valid computer name. </exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened on the specified computer.- or - The log does not exist on the specified computer. </exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The event log was not cleared successfully.-or- The log cannot be opened. A Windows error code is not available. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void Delete(string logName, string machineName)
		{
		}

		/// <summary>Removes the event source registration from the event log of the local computer.</summary>
		/// <param name="source">The name by which the application is registered in the event log system. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="source" /> parameter does not exist in the registry of the local computer.- or - You do not have write access on the registry key for the event log.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void DeleteEventSource(string source)
		{
		}

		/// <summary>Removes the application's event source registration from the specified computer.</summary>
		/// <param name="source">The name by which the application is registered in the event log system. </param>
		/// <param name="machineName">The name of the computer to remove the registration from, or "." for the local computer. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="machineName" /> parameter is invalid. - or - The <paramref name="source" /> parameter does not exist in the registry of the specified computer.- or - You do not have write access on the registry key for the event log.</exception>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="source" /> cannot be deleted because in the registry, the parent registry key for <paramref name="source" /> does not contain a subkey with the same name.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void DeleteEventSource(string source, string machineName)
		{
		}

		/// <summary>Ends the initialization of an <see cref="T:System.Diagnostics.EventLog" /> used on a form or by another component. The initialization occurs at runtime.</summary>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void EndInit()
		{
		}

		/// <summary>Determines whether the log exists on the local computer.</summary>
		/// <returns>true if the log exists on the local computer; otherwise, false.</returns>
		/// <param name="logName">The name of the log to search for. Possible values include: Application, Security, System, other application-specific logs (such as those associated with Active Directory), or any custom log on the computer. </param>
		/// <exception cref="T:System.ArgumentException">The logName is null or the value is empty. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static bool Exists(string logName)
		{
			return false;
		}

		/// <summary>Determines whether the log exists on the specified computer.</summary>
		/// <returns>true if the log exists on the specified computer; otherwise, false.</returns>
		/// <param name="logName">The log for which to search. Possible values include: Application, Security, System, other application-specific logs (such as those associated with Active Directory), or any custom log on the computer. </param>
		/// <param name="machineName">The name of the computer on which to search for the log, or "." for the local computer. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="machineName" /> parameter is an invalid format. Make sure you have used proper syntax for the computer on which you are searching.-or- The <paramref name="logName" /> is null or the value is empty. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static bool Exists(string logName, string machineName)
		{
			return false;
		}

		/// <summary>Searches for all event logs on the local computer and creates an array of <see cref="T:System.Diagnostics.EventLog" /> objects that contain the list.</summary>
		/// <returns>An array of type <see cref="T:System.Diagnostics.EventLog" /> that represents the logs on the local computer.</returns>
		/// <exception cref="T:System.SystemException">You do not have read access to the registry.-or- There is no event log service on the computer. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static EventLog[] GetEventLogs()
		{
			return null;
		}

		/// <summary>Searches for all event logs on the given computer and creates an array of <see cref="T:System.Diagnostics.EventLog" /> objects that contain the list.</summary>
		/// <returns>An array of type <see cref="T:System.Diagnostics.EventLog" /> that represents the logs on the given computer.</returns>
		/// <param name="machineName">The computer on which to search for event logs. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="machineName" /> parameter is an invalid computer name. </exception>
		/// <exception cref="T:System.InvalidOperationException">You do not have read access to the registry.-or- There is no event log service on the computer. </exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static EventLog[] GetEventLogs(string machineName)
		{
			return null;
		}

		/// <summary>Gets the name of the log to which the specified source is registered.</summary>
		/// <returns>The name of the log associated with the specified source in the registry.</returns>
		/// <param name="source">The name of the event source. </param>
		/// <param name="machineName">The name of the computer on which to look, or "." for the local computer. </param>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static string LogNameFromSourceName(string source, string machineName)
		{
			return null;
		}

		/// <summary>Changes the configured behavior for writing new entries when the event log reaches its maximum file size.</summary>
		/// <param name="action">The overflow behavior for writing new entries to the event log. </param>
		/// <param name="retentionDays">The minimum number of days each event log entry is retained. This parameter is used only if <paramref name="action" /> is set to <see cref="F:System.Diagnostics.OverflowAction.OverwriteOlder" />. </param>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="action" /> is not a valid <see cref="P:System.Diagnostics.EventLog.OverflowAction" /> value. </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="retentionDays" /> is less than one, or larger than 365. </exception>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.EventLog.Log" /> value is not a valid log name.- or -The registry key for the event log could not be opened on the target computer.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[ComVisible(false)]
		public void ModifyOverflowPolicy(OverflowAction action, int retentionDays)
		{
		}

		/// <summary>Specifies the localized name of the event log, which is displayed in the server Event Viewer.</summary>
		/// <param name="resourceFile">The fully specified path to a localized resource file. </param>
		/// <param name="resourceId">The resource identifier that indexes a localized string within the resource file. </param>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.EventLog.Log" /> value is not a valid log name.- or -The registry key for the event log could not be opened on the target computer.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="resourceFile " />is null.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[ComVisible(false)]
		public void RegisterDisplayName(string resourceFile, long resourceId)
		{
		}

		/// <summary>Determines whether an event source is registered on the local computer.</summary>
		/// <returns>true if the event source is registered on the local computer; otherwise, false.</returns>
		/// <param name="source">The name of the event source. </param>
		/// <exception cref="T:System.Security.SecurityException">
		///   <paramref name="source" /> was not found, but some or all of the event logs could not be searched.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static bool SourceExists(string source)
		{
			return false;
		}

		/// <summary>Determines whether an event source is registered on a specified computer.</summary>
		/// <returns>true if the event source is registered on the given computer; otherwise, false.</returns>
		/// <param name="source">The name of the event source. </param>
		/// <param name="machineName">The name the computer on which to look, or "." for the local computer. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="machineName" /> is an invalid computer name. </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///   <paramref name="source" /> was not found, but some or all of the event logs could not be searched.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static bool SourceExists(string source, string machineName)
		{
			return false;
		}

		/// <summary>Writes an information type entry, with the given message text, to the event log.</summary>
		/// <param name="message">The string to write to the event log. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Diagnostics.EventLog.Source" /> property of the <see cref="T:System.Diagnostics.EventLog" /> has not been set.-or- The method attempted to register a new event source, but the computer name in <see cref="P:System.Diagnostics.EventLog.MachineName" />  is not valid.- or -The source is already registered for a different event log.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void WriteEntry(string message)
		{
		}

		/// <summary>Writes an error, warning, information, success audit, or failure audit entry with the given message text to the event log.</summary>
		/// <param name="message">The string to write to the event log. </param>
		/// <param name="type">One of the <see cref="T:System.Diagnostics.EventLogEntryType" /> values. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Diagnostics.EventLog.Source" /> property of the <see cref="T:System.Diagnostics.EventLog" /> has not been set.-or- The method attempted to register a new event source, but the computer name in <see cref="P:System.Diagnostics.EventLog.MachineName" />  is not valid.- or -The source is already registered for a different event log.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> is not a valid <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void WriteEntry(string message, EventLogEntryType type)
		{
		}

		/// <summary>Writes an entry with the given message text and application-defined event identifier to the event log.</summary>
		/// <param name="message">The string to write to the event log. </param>
		/// <param name="type">One of the <see cref="T:System.Diagnostics.EventLogEntryType" /> values. </param>
		/// <param name="eventID">The application-specific identifier for the event. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Diagnostics.EventLog.Source" /> property of the <see cref="T:System.Diagnostics.EventLog" /> has not been set.-or- The method attempted to register a new event source, but the computer name in <see cref="P:System.Diagnostics.EventLog.MachineName" /> is not valid.- or -The source is already registered for a different event log.- or -<paramref name="eventID" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> is not a valid <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void WriteEntry(string message, EventLogEntryType type, int eventID)
		{
		}

		/// <summary>Writes an entry with the given message text, application-defined event identifier, and application-defined category to the event log.</summary>
		/// <param name="message">The string to write to the event log. </param>
		/// <param name="type">One of the <see cref="T:System.Diagnostics.EventLogEntryType" /> values. </param>
		/// <param name="eventID">The application-specific identifier for the event. </param>
		/// <param name="category">The application-specific subcategory associated with the message. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Diagnostics.EventLog.Source" /> property of the <see cref="T:System.Diagnostics.EventLog" /> has not been set.-or- The method attempted to register a new event source, but the computer name in <see cref="P:System.Diagnostics.EventLog.MachineName" /> is not valid.- or -The source is already registered for a different event log.- or -<paramref name="eventID" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> is not a valid <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void WriteEntry(string message, EventLogEntryType type, int eventID, short category)
		{
		}

		/// <summary>Writes an entry with the given message text, application-defined event identifier, and application-defined category to the event log, and appends binary data to the message.</summary>
		/// <param name="message">The string to write to the event log. </param>
		/// <param name="type">One of the <see cref="T:System.Diagnostics.EventLogEntryType" /> values. </param>
		/// <param name="eventID">The application-specific identifier for the event. </param>
		/// <param name="category">The application-specific subcategory associated with the message. </param>
		/// <param name="rawData">An array of bytes that holds the binary data associated with the entry. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Diagnostics.EventLog.Source" /> property of the <see cref="T:System.Diagnostics.EventLog" /> has not been set.-or- The method attempted to register a new event source, but the computer name in <see cref="P:System.Diagnostics.EventLog.MachineName" /> is not valid.- or -The source is already registered for a different event log.- or -<paramref name="eventID" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> is not a valid <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public void WriteEntry(string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
		{
		}

		/// <summary>Writes an information type entry with the given message text to the event log, using the specified registered event source.</summary>
		/// <param name="source">The source by which the application is registered on the specified computer. </param>
		/// <param name="message">The string to write to the event log. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="source" /> value is an empty string ("").- or -The <paramref name="source" /> value is null.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void WriteEntry(string source, string message)
		{
		}

		/// <summary>Writes an error, warning, information, success audit, or failure audit entry with the given message text to the event log, using the specified registered event source.</summary>
		/// <param name="source">The source by which the application is registered on the specified computer. </param>
		/// <param name="message">The string to write to the event log. </param>
		/// <param name="type">One of the <see cref="T:System.Diagnostics.EventLogEntryType" /> values. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="source" /> value is an empty string ("").- or -The <paramref name="source" /> value is null.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> is not a valid <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void WriteEntry(string source, string message, EventLogEntryType type)
		{
		}

		/// <summary>Writes an entry with the given message text and application-defined event identifier to the event log, using the specified registered event source.</summary>
		/// <param name="source">The source by which the application is registered on the specified computer. </param>
		/// <param name="message">The string to write to the event log. </param>
		/// <param name="type">One of the <see cref="T:System.Diagnostics.EventLogEntryType" /> values. </param>
		/// <param name="eventID">The application-specific identifier for the event. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="source" /> value is an empty string ("").- or -The <paramref name="source" /> value is null.- or -<paramref name="eventID" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> is not a valid <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID)
		{
		}

		/// <summary>Writes an entry with the given message text, application-defined event identifier, and application-defined category to the event log, using the specified registered event source. The <paramref name="category" /> can be used by the Event Viewer to filter events in the log.</summary>
		/// <param name="source">The source by which the application is registered on the specified computer. </param>
		/// <param name="message">The string to write to the event log. </param>
		/// <param name="type">One of the <see cref="T:System.Diagnostics.EventLogEntryType" /> values. </param>
		/// <param name="eventID">The application-specific identifier for the event. </param>
		/// <param name="category">The application-specific subcategory associated with the message. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="source" /> value is an empty string ("").- or -The <paramref name="source" /> value is null.- or -<paramref name="eventID" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> is not a valid <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category)
		{
		}

		/// <summary>Writes an entry with the given message text, application-defined event identifier, and application-defined category to the event log (using the specified registered event source) and appends binary data to the message.</summary>
		/// <param name="source">The source by which the application is registered on the specified computer. </param>
		/// <param name="message">The string to write to the event log. </param>
		/// <param name="type">One of the <see cref="T:System.Diagnostics.EventLogEntryType" /> values. </param>
		/// <param name="eventID">The application-specific identifier for the event. </param>
		/// <param name="category">The application-specific subcategory associated with the message. </param>
		/// <param name="rawData">An array of bytes that holds the binary data associated with the entry. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="source" /> value is an empty string ("").- or -The <paramref name="source" /> value is null.- or -<paramref name="eventID" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -The message string is longer than 31,839 bytes (32,766 bytes on Windows operating systems before Windows Vista).- or -The source name results in a registry key path longer than 254 characters. </exception>
		/// <exception cref="T:System.ComponentModel.InvalidEnumArgumentException">
		///   <paramref name="type" /> is not a valid <see cref="T:System.Diagnostics.EventLogEntryType" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void WriteEntry(string source, string message, EventLogEntryType type, int eventID, short category, byte[] rawData)
		{
		}

		/// <summary>Writes an event log entry with the given event data, message replacement strings, and associated binary data.</summary>
		/// <param name="instance">An <see cref="T:System.Diagnostics.EventInstance" /> instance that represents a localized event log entry. </param>
		/// <param name="data">An array of bytes that holds the binary data associated with the entry. </param>
		/// <param name="values">An array of strings to merge into the message text of the event log entry. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Diagnostics.EventLog.Source" /> property of the <see cref="T:System.Diagnostics.EventLog" /> has not been set.-or- The method attempted to register a new event source, but the computer name in <see cref="P:System.Diagnostics.EventLog.MachineName" /> is not valid.- or -The source is already registered for a different event log.- or -<paramref name="instance.InstanceId" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -<paramref name="values" /> has more than 256 elements.- or -One of the <paramref name="values" /> elements is longer than 32766 bytes.- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[ComVisible(false)]
		public void WriteEvent(EventInstance instance, byte[] data, object[] values)
		{
		}

		/// <summary>Writes a localized entry to the event log.</summary>
		/// <param name="instance">An <see cref="T:System.Diagnostics.EventInstance" /> instance that represents a localized event log entry. </param>
		/// <param name="values">An array of strings to merge into the message text of the event log entry. </param>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Diagnostics.EventLog.Source" /> property of the <see cref="T:System.Diagnostics.EventLog" /> has not been set.-or- The method attempted to register a new event source, but the computer name in <see cref="P:System.Diagnostics.EventLog.MachineName" /> is not valid.- or -The source is already registered for a different event log.- or -<paramref name="instance.InstanceId" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -<paramref name="values" /> has more than 256 elements.- or -One of the <paramref name="values" /> elements is longer than 32766 bytes.- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		[ComVisible(false)]
		public void WriteEvent(EventInstance instance, object[] values)
		{
		}

		/// <summary>Writes an event log entry with the given event data, message replacement strings, and associated binary data, and using the specified registered event source.</summary>
		/// <param name="source">The name of the event source registered for the application on the specified computer. </param>
		/// <param name="instance">An <see cref="T:System.Diagnostics.EventInstance" /> instance that represents a localized event log entry. </param>
		/// <param name="data">An array of bytes that holds the binary data associated with the entry. </param>
		/// <param name="values">An array of strings to merge into the message text of the event log entry. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="source" /> value is an empty string ("").- or -The <paramref name="source" /> value is null.- or -<paramref name="instance.InstanceId" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -<paramref name="values" /> has more than 256 elements.- or -One of the <paramref name="values" /> elements is longer than 32766 bytes.- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void WriteEvent(string source, EventInstance instance, byte[] data, object[] values)
		{
		}

		/// <summary>Writes an event log entry with the given event data and message replacement strings, using the specified registered event source.</summary>
		/// <param name="source">The name of the event source registered for the application on the specified computer. </param>
		/// <param name="instance">An <see cref="T:System.Diagnostics.EventInstance" /> instance that represents a localized event log entry. </param>
		/// <param name="values">An array of strings to merge into the message text of the event log entry. </param>
		/// <exception cref="T:System.ArgumentException">The <paramref name="source" /> value is an empty string ("").- or -The <paramref name="source" /> value is null.- or -<paramref name="instance.InstanceId" /> is less than zero or greater than <see cref="F:System.UInt16.MaxValue" />.- or -<paramref name="values" /> has more than 256 elements.- or -One of the <paramref name="values" /> elements is longer than 32766 bytes.- or -The source name results in a registry key path longer than 254 characters.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="instance" /> is null.</exception>
		/// <exception cref="T:System.InvalidOperationException">The registry key for the event log could not be opened.</exception>
		/// <exception cref="T:System.ComponentModel.Win32Exception">The operating system reported an error when writing the event entry to the event log. A Windows error code is not available.</exception>
		/// <filterpriority>1</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public static void WriteEvent(string source, EventInstance instance, object[] values)
		{
		}
	}
}
