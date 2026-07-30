using System.Security.Principal;

namespace System.Security.AccessControl
{
	/// <summary>Represents an access control list (ACL) and is the base class for the <see cref="T:System.Security.AccessControl.DiscretionaryAcl" /> and <see cref="T:System.Security.AccessControl.SystemAcl" /> classes.</summary>
	public abstract class CommonAcl : GenericAcl
	{
		internal delegate bool RemoveAcesCallback<T>(T ace);

		private bool is_aefa;

		private bool is_canonical;

		private bool is_container;

		private bool is_ds;

		internal RawAcl raw_acl;

		/// <summary>Gets the length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object. This length should be used before marshaling the access control list (ACL) into a binary array by using the <see cref="M:System.Security.AccessControl.CommonAcl.GetBinaryForm" /> method.</summary>
		/// <returns>The length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object.</returns>
		public sealed override int BinaryLength => 0;

		/// <summary>Gets the number of access control entries (ACEs) in the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object.</summary>
		/// <returns>The number of ACEs in the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object.</returns>
		public sealed override int Count => 0;

		/// <summary>Gets a Boolean value that specifies whether the access control entries (ACEs) in the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object are in canonical order.</summary>
		/// <returns>true if the ACEs in the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object are in canonical order; otherwise, false.</returns>
		public bool IsCanonical => false;

		/// <summary>Sets whether the <see cref="T:System.Security.AccessControl.CommonAcl" /> object is a container. </summary>
		/// <returns>true if the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object is a container.</returns>
		public bool IsContainer => false;

		/// <summary>Sets whether the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object is a directory object access control list (ACL).</summary>
		/// <returns>true if the current <see cref="T:System.Security.AccessControl.CommonAcl" /> object is a directory object ACL.</returns>
		public bool IsDS => false;

		internal bool IsAefa
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets the revision level of the <see cref="T:System.Security.AccessControl.CommonAcl" />.</summary>
		/// <returns>A byte value that specifies the revision level of the <see cref="T:System.Security.AccessControl.CommonAcl" />.</returns>
		public sealed override byte Revision => 0;

		/// <summary>Gets or sets the <see cref="T:System.Security.AccessControl.CommonAce" /> at the specified index.</summary>
		/// <returns>The <see cref="T:System.Security.AccessControl.CommonAce" /> at the specified index.</returns>
		/// <param name="index">The zero-based index of the <see cref="T:System.Security.AccessControl.CommonAce" /> to get or set.</param>
		public sealed override GenericAce this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal CommonAcl(bool isContainer, bool isDS, RawAcl rawAcl)
		{
		}

		internal CommonAcl(bool isContainer, bool isDS, byte revision, int capacity)
		{
		}

		internal CommonAcl(bool isContainer, bool isDS, int capacity)
		{
		}

		private void Init(bool isContainer, bool isDS, RawAcl rawAcl)
		{
		}

		/// <summary>Marshals the contents of the <see cref="T:System.Security.AccessControl.CommonAcl" /> object into the specified byte array beginning at the specified offset.</summary>
		/// <param name="binaryForm">The byte array into which the contents of the <see cref="T:System.Security.AccessControl.CommonAcl" /> is marshaled.</param>
		/// <param name="offset">The offset at which to start marshaling.</param>
		public sealed override void GetBinaryForm(byte[] binaryForm, int offset)
		{
		}

		/// <summary>Removes all access control entries (ACEs) contained by this <see cref="T:System.Security.AccessControl.CommonAcl" /> object that are associated with the specified <see cref="T:System.Security.Principal.SecurityIdentifier" /> object.</summary>
		/// <param name="sid">The <see cref="T:System.Security.Principal.SecurityIdentifier" /> object to check for.</param>
		public void Purge(SecurityIdentifier sid)
		{
		}

		internal void RequireCanonicity()
		{
		}

		internal void CanonicalizeAndClearAefa()
		{
		}

		internal virtual bool IsAceMeaningless(GenericAce ace)
		{
			return false;
		}

		private bool TestCanonicity()
		{
			return false;
		}

		internal int GetCanonicalExplicitDenyAceCount()
		{
			return 0;
		}

		internal int GetCanonicalExplicitAceCount()
		{
			return 0;
		}

		private void MergeExplicitAces()
		{
		}

		private GenericAce MergeExplicitAcePair(GenericAce ace1, GenericAce ace2)
		{
			return null;
		}

		private static void GetObjectAceTypeGuids(ObjectAce ace, out Guid type, out Guid inheritedType)
		{
			type = default(Guid);
			inheritedType = default(Guid);
		}

		internal abstract void ApplyCanonicalSortToExplicitAces();

		internal void ApplyCanonicalSortToExplicitAces(int start, int count)
		{
		}

		internal void RemoveAces<T>(RemoveAcesCallback<T> callback) where T : GenericAce
		{
		}

		internal void AddAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
		}

		private QualifiedAce AddAceGetQualifiedAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
			return null;
		}

		private void AddAce(QualifiedAce newAce)
		{
		}

		private static GenericAce CopyAce(GenericAce ace)
		{
			return null;
		}

		internal abstract int GetAceInsertPosition(AceQualifier aceQualifier);

		private AceFlags GetAceFlags(InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
			return default(AceFlags);
		}

		internal void RemoveAceSpecific(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
		}

		internal void SetAce(AceQualifier aceQualifier, SecurityIdentifier sid, int accessMask, InheritanceFlags inheritanceFlags, PropagationFlags propagationFlags, AuditFlags auditFlags)
		{
		}

		private void SetAce(QualifiedAce newAce)
		{
		}
	}
}
