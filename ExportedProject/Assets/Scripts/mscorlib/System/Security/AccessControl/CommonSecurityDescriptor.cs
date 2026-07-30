using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Represents a security descriptor. A security descriptor includes an owner, a primary group, a Discretionary Access Control List (DACL), and a System Access Control List (SACL).</summary>
	public sealed class CommonSecurityDescriptor : GenericSecurityDescriptor
	{
		private bool is_container;

		private bool is_ds;

		private ControlFlags flags;

		private SecurityIdentifier owner;

		private SecurityIdentifier group;

		private SystemAcl system_acl;

		private DiscretionaryAcl discretionary_acl;

		/// <summary>Gets values that specify behavior of the <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</summary>
		/// <returns>One or more values of the <see cref="T:System.Security.AccessControl.ControlFlags" /> enumeration combined with a logical OR operation.</returns>
		public override ControlFlags ControlFlags => default(ControlFlags);

		/// <summary>Gets or sets the discretionary access control list (DACL) for this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object. The DACL contains access rules.</summary>
		/// <returns>The DACL for this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</returns>
		public DiscretionaryAcl DiscretionaryAcl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal override GenericAcl InternalDacl => null;

		/// <summary>Gets or sets the primary group for this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</summary>
		/// <returns>The primary group for this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</returns>
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

		/// <summary>Gets a Boolean value that specifies whether the object associated with this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object is a container object.</summary>
		/// <returns>true if the object associated with this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object is a container object; otherwise, false.</returns>
		public bool IsContainer => false;

		/// <summary>Gets a Boolean value that specifies whether the object associated with this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object is a directory object.</summary>
		/// <returns>true if the object associated with this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object is a directory object; otherwise, false.</returns>
		public bool IsDS => false;

		/// <summary>Gets or sets the owner of the object associated with this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</summary>
		/// <returns>The owner of the object associated with this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</returns>
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

		/// <summary>Gets or sets the System Access Control List (SACL) for this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object. The SACL contains audit rules.</summary>
		/// <returns>The SACL for this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</returns>
		public SystemAcl SystemAcl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal override GenericAcl InternalSacl => null;

		internal override bool DaclIsUnmodifiedAefa => false;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> class from the specified array of byte values.</summary>
		/// <param name="isContainer">true if the new security descriptor is associated with a container object.</param>
		/// <param name="isDS">true if the new security descriptor is associated with a directory object.</param>
		/// <param name="binaryForm">The array of byte values from which to create the new <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</param>
		/// <param name="offset">The offset in the <paramref name="binaryForm" /> array at which to begin copying.</param>
		public CommonSecurityDescriptor(bool isContainer, bool isDS, byte[] binaryForm, int offset)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> class from the specified information.</summary>
		/// <param name="isContainer">true if the new security descriptor is associated with a container object.</param>
		/// <param name="isDS">true if the new security descriptor is associated with a directory object.</param>
		/// <param name="flags">Flags that specify behavior of the new <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</param>
		/// <param name="owner">The owner for the new <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</param>
		/// <param name="group">The primary group for the new <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</param>
		/// <param name="systemAcl">The System Access Control List (SACL) for the new <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</param>
		/// <param name="discretionaryAcl">The Discretionary Access Control List (DACL) for the new <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</param>
		public CommonSecurityDescriptor(bool isContainer, bool isDS, ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, SystemAcl systemAcl, DiscretionaryAcl discretionaryAcl)
		{
		}

		private void Init(bool isContainer, bool isDS, RawSecurityDescriptor rawSecurityDescriptor)
		{
		}

		private void Init(bool isContainer, bool isDS, ControlFlags flags, SecurityIdentifier owner, SecurityIdentifier group, SystemAcl systemAcl, DiscretionaryAcl discretionaryAcl)
		{
		}

		/// <summary>Removes all access rules for the specified security identifier from the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CommonSecurityDescriptor" /> object.</summary>
		/// <param name="sid">The security identifier for which to remove access rules.</param>
		public void PurgeAccessControl(SecurityIdentifier sid)
		{
		}

		private void CheckAclConsistency(CommonAcl acl)
		{
		}
	}
}
