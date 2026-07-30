using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Represents a security descriptor. A security descriptor includes an owner, a primary group, a Discretionary Access Control List (DACL), and a System Access Control List (SACL).</summary>
	public sealed class RawSecurityDescriptor : GenericSecurityDescriptor
	{
		private ControlFlags control_flags;

		private SecurityIdentifier owner_sid;

		private SecurityIdentifier group_sid;

		private RawAcl system_acl;

		private RawAcl discretionary_acl;

		private byte resourcemgr_control;

		/// <summary>Gets values that specify behavior of the <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</summary>
		/// <returns>One or more values of the <see cref="T:System.Security.AccessControl.ControlFlags" /> enumeration combined with a logical OR operation.</returns>
		public override ControlFlags ControlFlags => default(ControlFlags);

		/// <summary>Gets or sets the Discretionary Access Control List (DACL) for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object. The DACL contains access rules.</summary>
		/// <returns>The DACL for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
		public RawAcl DiscretionaryAcl => null;

		/// <summary>Gets or sets the primary group for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</summary>
		/// <returns>The primary group for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
		public override SecurityIdentifier Group
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the owner of the object associated with this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</summary>
		/// <returns>The owner of the object associated with this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
		public override SecurityIdentifier Owner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a byte value that represents the resource manager control bits associated with this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</summary>
		/// <returns>A byte value that represents the resource manager control bits associated with this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
		public byte ResourceManagerControl => 0;

		/// <summary>Gets or sets the System Access Control List (SACL) for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object. The SACL contains audit rules.</summary>
		/// <returns>The SACL for this <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</returns>
		public RawAcl SystemAcl => null;

		internal override GenericAcl InternalDacl => null;

		internal override GenericAcl InternalSacl => null;

		internal override byte InternalReservedField => 0;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> class from the specified array of byte values.</summary>
		/// <param name="binaryForm">The array of byte values from which to create the new <see cref="T:System.Security.AccessControl.RawSecurityDescriptor" /> object.</param>
		/// <param name="offset">The offset in the  <paramref name="binaryForm" /> array at which to begin copying.</param>
		public RawSecurityDescriptor(byte[] binaryForm, int offset)
		{
		}

		private ushort ReadUShort(byte[] buffer, int offset)
		{
			return 0;
		}

		private int ReadInt(byte[] buffer, int offset)
		{
			return 0;
		}
	}
}
