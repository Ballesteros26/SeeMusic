using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Represents a security descriptor. A security descriptor includes an owner, a primary group, a Discretionary Access Control List (DACL), and a System Access Control List (SACL).</summary>
	public abstract class GenericSecurityDescriptor
	{
		/// <summary>Gets the length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> object. This length should be used before marshaling the ACL into a binary array with the <see cref="M:System.Security.AccessControl.GenericSecurityDescriptor.GetBinaryForm" /> method.</summary>
		/// <returns>The length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> object.</returns>
		public int BinaryLength => 0;

		/// <summary>Gets values that specify behavior of the <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> object.</summary>
		/// <returns>One or more values of the <see cref="T:System.Security.AccessControl.ControlFlags" /> enumeration combined with a logical OR operation.</returns>
		public abstract ControlFlags ControlFlags { get; }

		/// <summary>Gets or sets the primary group for this <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> object.</summary>
		/// <returns>The primary group for this <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> object.</returns>
		public abstract SecurityIdentifier Group { get; set; }

		/// <summary>Gets or sets the owner of the object associated with this <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> object.</summary>
		/// <returns>The owner of the object associated with this <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> object.</returns>
		public abstract SecurityIdentifier Owner { get; set; }

		/// <summary>Gets the revision level of the <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> object.</summary>
		/// <returns>A byte value that specifies the revision level of the <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" />.</returns>
		public static byte Revision => 0;

		internal virtual GenericAcl InternalDacl => null;

		internal virtual GenericAcl InternalSacl => null;

		internal virtual byte InternalReservedField => 0;

		internal virtual bool DaclIsUnmodifiedAefa => false;

		private bool DaclPresent => false;

		private bool SaclPresent => false;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.GenericSecurity" /> class.</summary>
		protected GenericSecurityDescriptor()
		{
		}

		/// <summary>Returns an array of byte values that represents the information contained in this <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> object.</summary>
		/// <param name="binaryForm">The byte array into which the contents of the <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> is marshaled.</param>
		/// <param name="offset">The offset at which to start marshaling.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> is negative or too high to allow the entire <see cref="T:System.Security.AccessControl.GenericSecurityDescriptor" /> to be copied into <paramref name="array" />.</exception>
		public void GetBinaryForm(byte[] binaryForm, int offset)
		{
		}

		private void WriteUShort(ushort val, byte[] buffer, int offset)
		{
		}

		private void WriteInt(int val, byte[] buffer, int offset)
		{
		}
	}
}
