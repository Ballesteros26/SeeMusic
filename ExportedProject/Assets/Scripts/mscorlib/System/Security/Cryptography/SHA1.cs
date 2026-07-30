using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Computes the <see cref="T:System.Security.Cryptography.SHA1" /> hash for the input data.</summary>
	[ComVisible(true)]
	public abstract class SHA1 : HashAlgorithm
	{
		/// <summary>Initializes a new instance of <see cref="T:System.Security.Cryptography.SHA1" />.</summary>
		/// <exception cref="T:System.InvalidOperationException">The policy on this object is not compliant with the FIPS algorithm.</exception>
		protected SHA1()
		{
		}

		/// <summary>Creates an instance of the default implementation of <see cref="T:System.Security.Cryptography.SHA1" />.</summary>
		/// <returns>A new instance of <see cref="T:System.Security.Cryptography.SHA1" />.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public static SHA1 Create()
		{
			return null;
		}
	}
}
