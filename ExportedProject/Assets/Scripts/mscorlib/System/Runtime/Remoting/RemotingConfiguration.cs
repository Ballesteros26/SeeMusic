using System.Collections;
using System.Runtime.InteropServices;

namespace System.Runtime.Remoting
{
	/// <summary>Provides various static methods for configuring the remoting infrastructure.</summary>
	[ComVisible(true)]
	public static class RemotingConfiguration
	{
		private static string applicationID;

		private static string applicationName;

		private static string processGuid;

		private static bool defaultConfigRead;

		private static bool defaultDelayedConfigRead;

		private static CustomErrorsModes _errorMode;

		private static Hashtable wellKnownClientEntries;

		private static Hashtable activatedClientEntries;

		private static Hashtable wellKnownServiceEntries;

		private static Hashtable activatedServiceEntries;

		private static Hashtable channelTemplates;

		private static Hashtable clientProviderTemplates;

		private static Hashtable serverProviderTemplates;

		/// <summary>Gets or sets the name of a remoting application.</summary>
		/// <returns>The name of a remoting application.</returns>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. This exception is thrown only when setting the property value. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static string ApplicationName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the ID of the currently executing process.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the ID of the currently executing process.</returns>
		/// <exception cref="T:System.Security.SecurityException">The immediate caller does not have infrastructure permission. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public static string ProcessId => null;

		internal static void LoadDefaultDelayedChannels()
		{
		}

		/// <summary>Returns a Boolean value that indicates whether the specified <see cref="T:System.Type" /> is allowed to be client activated.</summary>
		/// <returns>true if the specified <see cref="T:System.Type" /> is allowed to be client activated; otherwise, false.</returns>
		/// <param name="svrType">The object <see cref="T:System.Type" /> to check. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static bool IsActivationAllowed(Type svrType)
		{
			return false;
		}

		/// <summary>Checks whether the specified object <see cref="T:System.Type" /> is registered as a remotely activated client type.</summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> that corresponds to the specified object type.</returns>
		/// <param name="svrType">The object type to check. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType)
		{
			return null;
		}

		/// <summary>Checks whether the specified object <see cref="T:System.Type" /> is registered as a well-known client type.</summary>
		/// <returns>The <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> that corresponds to the specified object type.</returns>
		/// <param name="svrType">The object <see cref="T:System.Type" /> to check. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType)
		{
			return null;
		}

		/// <summary>Registers an object <see cref="T:System.Type" /> recorded in the provided <see cref="T:System.Runtime.Remoting.ActivatedClientTypeEntry" /> on the client end as a type that can be activated on the server.</summary>
		/// <param name="entry">Configuration settings for the client-activated type. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry)
		{
		}

		/// <summary>Registers an object type recorded in the provided <see cref="T:System.Runtime.Remoting.ActivatedServiceTypeEntry" /> on the service end as one that can be activated on request from a client.</summary>
		/// <param name="entry">Configuration settings for the client-activated type. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry)
		{
		}

		/// <summary>Registers an object <see cref="T:System.Type" /> recorded in the provided <see cref="T:System.Runtime.Remoting.WellKnownClientTypeEntry" /> on the client end as a well-known type that can be activated on the server.</summary>
		/// <param name="entry">Configuration settings for the well-known type. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry)
		{
		}

		/// <summary>Registers an object <see cref="T:System.Type" /> recorded in the provided <see cref="T:System.Runtime.Remoting.WellKnownServiceTypeEntry" /> on the service end as a well-known type.</summary>
		/// <param name="entry">Configuration settings for the well-known type. </param>
		/// <exception cref="T:System.Security.SecurityException">At least one of the callers higher in the callstack does not have permission to configure remoting types and channels. </exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="RemotingConfiguration" />
		/// </PermissionSet>
		public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry)
		{
		}

		internal static void RegisterChannelTemplate(ChannelData channel)
		{
		}

		internal static void RegisterClientProviderTemplate(ProviderData prov)
		{
		}

		internal static void RegisterServerProviderTemplate(ProviderData prov)
		{
		}

		internal static void RegisterChannels(ArrayList channels, bool onlyDelayed)
		{
		}

		internal static void RegisterTypes(ArrayList types)
		{
		}

		/// <summary>Indicates whether the server channels in this application domain return filtered or complete exception information to local or remote callers.</summary>
		/// <returns>true if only filtered exception information is returned to local or remote callers, as specified by the <paramref name="isLocalRequest" /> parameter; false if complete exception information is returned.</returns>
		/// <param name="isLocalRequest">true to specify local callers; false to specify remote callers. </param>
		public static bool CustomErrorsEnabled(bool isLocalRequest)
		{
			return false;
		}

		internal static void SetCustomErrorsMode(string mode)
		{
		}
	}
}
