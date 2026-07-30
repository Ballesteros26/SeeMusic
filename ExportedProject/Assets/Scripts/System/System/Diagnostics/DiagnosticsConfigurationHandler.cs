using System.Configuration;
using System.Xml;

namespace System.Diagnostics
{
	/// <summary>Handles the diagnostics section of configuration files.</summary>
	/// <filterpriority>2</filterpriority>
	[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Diagnostics.DiagnosticsConfigurationHandler" /> class.</summary>
		public DiagnosticsConfigurationHandler()
		{
		}

		/// <summary>Parses the configuration settings for the &lt;system.diagnostics&gt; Element section of configuration files.</summary>
		/// <returns>A new configuration object, in the form of a <see cref="T:System.Collections.Hashtable" />.</returns>
		/// <param name="parent">The object inherited from the parent path</param>
		/// <param name="configContext">Reserved. Used in ASP.NET to convey the virtual path of the configuration being evaluated.</param>
		/// <param name="section">The root XML node at the section to handle.</param>
		/// <exception cref="T:System.Configuration.ConfigurationErrorsException">Switches could not be found.-or-Assert could not be found.-or-Trace could not be found.-or-Performance counters could not be found.</exception>
		/// <filterpriority>2</filterpriority>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Unrestricted="true" />
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="ControlEvidence" />
		/// </PermissionSet>
		public virtual object Create(object parent, object configContext, XmlNode section)
		{
			return null;
		}
	}
}
