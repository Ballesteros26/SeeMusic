using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	/// <summary>Represents a security identifier (SID) and provides marshaling and comparison operations for SIDs.</summary>
	[ComVisible(false)]
	public sealed class SecurityIdentifier : IdentityReference, IComparable<SecurityIdentifier>
	{
		private byte[] buffer;

		/// <summary>Returns the maximum size, in bytes, of the binary representation of the security identifier.</summary>
		public static readonly int MaxBinaryLength;

		/// <summary>Returns the minimum size, in bytes, of the binary representation of the security identifier.</summary>
		public static readonly int MinBinaryLength;

		/// <summary>Returns the length, in bytes, of the security identifier (SID) represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary>
		/// <returns>The length, in bytes, of the SID represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns>
		public int BinaryLength => 0;

		/// <summary>Returns an uppercase Security Descriptor Definition Language (SDDL) string for the security identifier (SID) represented by this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary>
		/// <returns>An uppercase SDDL string for the SID represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		public override string Value => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class by using the specified security identifier (SID) in Security Descriptor Definition Language (SDDL) format.</summary>
		/// <param name="sddlForm">SDDL string for the SID used to create the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</param>
		public SecurityIdentifier(string sddlForm)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class by using a specified binary representation of a security identifier (SID).</summary>
		/// <param name="binaryForm">The byte array that represents the SID.</param>
		/// <param name="offset">The byte offset to use as the starting index in <paramref name="binaryForm" />. </param>
		public SecurityIdentifier(byte[] binaryForm, int offset)
		{
		}

		private void CreateFromBinaryForm(IntPtr binaryForm, int length)
		{
		}

		private ulong GetSidAuthority()
		{
			return 0uL;
		}

		private byte GetSidSubAuthorityCount()
		{
			return 0;
		}

		private uint GetSidSubAuthority(byte index)
		{
			return 0u;
		}

		/// <summary>Compares the current <see cref="T:System.Security.Principal.SecurityIdentifier" /> object with the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary>
		/// <returns>A signed number indicating the relative values of this instance and <paramref name="sid" />.Return Value Description Less than zero This instance is less than <paramref name="sid" />. Zero This instance is equal to <paramref name="sid" />. Greater than zero This instance is greater than <paramref name="sid" />. </returns>
		/// <param name="sid">The object to compare with the current object.</param>
		public int CompareTo(SecurityIdentifier sid)
		{
			return 0;
		}

		/// <summary>Returns a value that indicates whether this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object is equal to a specified object.</summary>
		/// <returns>true if <paramref name="o" /> is an object with the same underlying type and value as this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object; otherwise, false.</returns>
		/// <param name="o">An object to compare with this <see cref="T:System.Security.Principal.SecurityIdentifier" /> object, or null.</param>
		public override bool Equals(object o)
		{
			return false;
		}

		/// <summary>Indicates whether the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object is equal to the current <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary>
		/// <returns>true if the value of <paramref name="sid" /> is equal to the value of the current <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns>
		/// <param name="sid">The object to compare with the current object.</param>
		public bool Equals(SecurityIdentifier sid)
		{
			return false;
		}

		/// <summary>Copies the binary representation of the specified security identifier (SID) represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> class to a byte array.</summary>
		/// <param name="binaryForm">The byte array to receive the copied SID.</param>
		/// <param name="offset">The byte offset to use as the starting index in <paramref name="binaryForm" />. </param>
		public void GetBinaryForm(byte[] binaryForm, int offset)
		{
		}

		/// <summary>Serves as a hash function for the current <see cref="T:System.Security.Principal.SecurityIdentifier" /> object. The <see cref="M:System.Security.Principal.SecurityIdentifier.GetHashCode" /> method is suitable for hashing algorithms and data structures like a hash table.</summary>
		/// <returns>A hash value for the current <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Returns the security identifier (SID), in Security Descriptor Definition Language (SDDL) format, for the account represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object. An example of the SDDL format is S-1-5-9. </summary>
		/// <returns>The SID, in SDDL format, for the account represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</returns>
		public override string ToString()
		{
			return null;
		}

		/// <summary>Translates the account name represented by the <see cref="T:System.Security.Principal.SecurityIdentifier" /> object into another <see cref="T:System.Security.Principal.IdentityReference" />-derived type.</summary>
		/// <returns>The converted identity.</returns>
		/// <param name="targetType">The target type for the conversion from <see cref="T:System.Security.Principal.SecurityIdentifier" />. The target type must be a type that is considered valid by the <see cref="M:System.Security.Principal.SecurityIdentifier.IsValidTargetType(System.Type)" /> method.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="targetType " />is null.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="targetType " />is not an <see cref="T:System.Security.Principal.IdentityReference" /> type.</exception>
		/// <exception cref="T:System.Security.Principal.IdentityNotMappedException">Some or all identity references could not be translated.</exception>
		/// <exception cref="T:System.SystemException">A Win32 error code was returned.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public override IdentityReference Translate(Type targetType)
		{
			return null;
		}

		/// <summary>Compares two <see cref="T:System.Security.Principal.SecurityIdentifier" /> objects to determine whether they are equal. They are considered equal if they have the same canonical representation as the one returned by the <see cref="P:System.Security.Principal.SecurityIdentifier.Value" /> property or if they are both null. </summary>
		/// <returns>true if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, false.</returns>
		/// <param name="left">The left operand to use for the equality comparison. This parameter can be null.</param>
		/// <param name="right">The right operand to use for the equality comparison. This parameter can be null.</param>
		public static bool operator ==(SecurityIdentifier left, SecurityIdentifier right)
		{
			return false;
		}

		/// <summary>Compares two <see cref="T:System.Security.Principal.SecurityIdentifier" /> objects to determine whether they are not equal. They are considered not equal if they have different canonical name representations than the one returned by the <see cref="P:System.Security.Principal.SecurityIdentifier.Value" /> property or if one of the objects is null and the other is not.</summary>
		/// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
		/// <param name="left">The left operand to use for the inequality comparison. This parameter can be null.</param>
		/// <param name="right">The right operand to use for the inequality comparison. This parameter can be null.</param>
		public static bool operator !=(SecurityIdentifier left, SecurityIdentifier right)
		{
			return false;
		}

		private static byte[] ParseSddlForm(string sddlForm)
		{
			return null;
		}

		private static bool TryParseAuthority(string s, out ulong result)
		{
			result = default(ulong);
			return false;
		}

		private static bool TryParseSubAuthority(string s, out uint result)
		{
			result = default(uint);
			return false;
		}
	}
}
