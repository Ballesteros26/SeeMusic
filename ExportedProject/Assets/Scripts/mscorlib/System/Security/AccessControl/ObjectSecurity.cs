using System.Security.Principal;
using System.Threading;

namespace System.Security.AccessControl
{
	/// <summary>Provides the ability to control access to objects without direct manipulation of Access Control Lists (ACLs). This class is the abstract base class for the <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> and <see cref="T:System.Security.AccessControl.DirectoryObjectSecurity" /> classes.</summary>
	public abstract class ObjectSecurity
	{
		internal CommonSecurityDescriptor descriptor;

		private AccessControlSections sections_modified;

		private ReaderWriterLock rw_lock;

		internal AccessControlSections AccessControlSectionsModified
		{
			get
			{
				return default(AccessControlSections);
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a Boolean value that specifies whether the access rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object have been modified.</summary>
		/// <returns>true if the access rules associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object have been modified; otherwise, false.</returns>
		protected bool AccessRulesModified
		{
			set
			{
			}
		}

		/// <summary>Gets a Boolean value that specifies whether this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a container object.</summary>
		/// <returns>true if the <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a container object; otherwise, false.</returns>
		protected bool IsContainer => false;

		/// <summary>Gets a Boolean value that specifies whether this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a directory object.</summary>
		/// <returns>true if the <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a directory object; otherwise, false.</returns>
		protected bool IsDS => false;

		/// <summary>Gets or sets a Boolean value that specifies whether the owner of the securable object has been modified.</summary>
		/// <returns>true if the owner of the securable object has been modified; otherwise, false.</returns>
		protected bool OwnerModified
		{
			set
			{
			}
		}

		protected ObjectSecurity(CommonSecurityDescriptor securityDescriptor)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.ObjectSecurity" /> class.</summary>
		/// <param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a container object.</param>
		/// <param name="isDS">True if the new <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object is a directory object.</param>
		protected ObjectSecurity(bool isContainer, bool isDS)
		{
		}

		/// <summary>Gets the owner associated with the specified primary group.</summary>
		/// <returns>The owner associated with the specified group.</returns>
		/// <param name="targetType">The primary group for which to get the owner.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.ReflectionPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="MemberAccess" />
		/// </PermissionSet>
		public IdentityReference GetOwner(Type targetType)
		{
			return null;
		}

		/// <summary>Returns an array of byte values that represents the security descriptor information for this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</summary>
		/// <returns>An array of byte values that represents the security descriptor for this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object. This method returns null if there is no security information in this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</returns>
		public byte[] GetSecurityDescriptorBinaryForm()
		{
			return null;
		}

		/// <summary>Removes all access rules associated with the specified <see cref="T:System.Security.Principal.IdentityReference" />.</summary>
		/// <param name="identity">The <see cref="T:System.Security.Principal.IdentityReference" /> for which to remove all access rules.</param>
		/// <exception cref="T:System.InvalidOperationException">All access rules are not in canonical order.</exception>
		public virtual void PurgeAccessRules(IdentityReference identity)
		{
		}

		/// <summary>Sets the owner for the security descriptor associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</summary>
		/// <param name="identity">The owner to set.</param>
		public void SetOwner(IdentityReference identity)
		{
		}

		/// <summary>Sets the specified sections of the security descriptor for this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object from the specified array of byte values.</summary>
		/// <param name="binaryForm">The array of bytes from which to set the security descriptor.</param>
		/// <param name="includeSections">The sections (access rules, audit rules, owner, primary group) of the security descriptor to set.</param>
		public void SetSecurityDescriptorBinaryForm(byte[] binaryForm, AccessControlSections includeSections)
		{
		}

		private void CopySddlForm(CommonSecurityDescriptor sourceDescriptor, AccessControlSections includeSections)
		{
		}

		/// <summary>Applies the specified modification to the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object.</summary>
		/// <returns>true if the DACL is successfully modified; otherwise, false.</returns>
		/// <param name="modification">The modification to apply to the DACL.</param>
		/// <param name="rule">The access rule to modify.</param>
		/// <param name="modified">true if the DACL is successfully modified; otherwise, false.</param>
		protected abstract bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified);

		private void Reading()
		{
		}

		/// <summary>Locks this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object for read access.</summary>
		protected void ReadLock()
		{
		}

		/// <summary>Unlocks this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object for read access.</summary>
		protected void ReadUnlock()
		{
		}

		private void Writing()
		{
		}

		/// <summary>Locks this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object for write access.</summary>
		protected void WriteLock()
		{
		}

		/// <summary>Unlocks this <see cref="T:System.Security.AccessControl.ObjectSecurity" /> object for write access.</summary>
		protected void WriteUnlock()
		{
		}

		internal static SecurityIdentifier SidFromIR(IdentityReference identity)
		{
			return null;
		}

		private void SetAccessControlSectionsModified(AccessControlSections mask, bool modified)
		{
		}
	}
}
