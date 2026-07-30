using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata;

namespace System.Runtime.Remoting
{
	/// <summary>Defines utility methods for use by the .NET Framework remoting infrastructure.</summary>
	[ComVisible(true)]
	public class InternalRemotingServices
	{
		private static Hashtable _soapAttributes;

		/// <summary>Gets an appropriate SOAP-related attribute for the specified class member or method parameter. </summary>
		/// <returns>The SOAP-related attribute for the specified class member or method parameter.</returns>
		/// <param name="reflectionObject">A class member or method parameter.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="Infrastructure" />
		/// </PermissionSet>
		public static SoapAttribute GetCachedSoapAttribute(object reflectionObject)
		{
			return null;
		}
	}
}
