namespace System.Diagnostics
{
	/// <summary>Provides a simple listener that directs tracing or debugging output to an <see cref="T:System.Diagnostics.EventLog" />.</summary>
	/// <filterpriority>2</filterpriority>
	public sealed class EventLogTraceListener : TraceListener
	{
		/// <summary>Gets or sets the event log to write to.</summary>
		/// <returns>The event log to write to.</returns>
		/// <filterpriority>2</filterpriority>
		public EventLog EventLog
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogTraceListener" /> class without a trace listener.</summary>
		public EventLogTraceListener()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogTraceListener" /> class using the specified event log.</summary>
		/// <param name="eventLog">The event log to write to. </param>
		public EventLogTraceListener(EventLog eventLog)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.EventLogTraceListener" /> class using the specified source.</summary>
		/// <param name="source">The name of an existing event log source. </param>
		public EventLogTraceListener(string source)
		{
		}

		/// <summary>Writes a message to the event log for this instance.</summary>
		/// <param name="message">The message to write. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="message" /> exceeds 32,766 characters.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public override void Write(string message)
		{
		}

		/// <summary>Writes a message to the event log for this instance.</summary>
		/// <param name="message">The message to write. </param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="message" /> exceeds 32,766 characters.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.EnvironmentPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		///   <IPermission class="System.Diagnostics.EventLogPermission, System, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		/// </PermissionSet>
		public override void WriteLine(string message)
		{
		}
	}
}
