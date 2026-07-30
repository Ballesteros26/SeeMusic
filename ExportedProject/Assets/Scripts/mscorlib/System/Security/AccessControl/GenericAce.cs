namespace System.Security.AccessControl
{
	/// <summary>Represents an Access Control Entry (ACE), and is the base class for all other ACE classes.</summary>
	public abstract class GenericAce
	{
		private AceFlags ace_flags;

		private AceType ace_type;

		/// <summary>Gets or sets the <see cref="T:System.Security.AccessControl.AceFlags" /> associated with this <see cref="T:System.Security.AccessControl.GenericAce" /> object.</summary>
		/// <returns>The <see cref="T:System.Security.AccessControl.AceFlags" /> associated with this <see cref="T:System.Security.AccessControl.GenericAce" /> object.</returns>
		public AceFlags AceFlags => default(AceFlags);

		/// <summary>Gets the type of this Access Control Entry (ACE).</summary>
		/// <returns>The type of this ACE.</returns>
		public AceType AceType => default(AceType);

		/// <summary>Gets the audit information associated with this Access Control Entry (ACE).</summary>
		/// <returns>The audit information associated with this Access Control Entry (ACE).</returns>
		public AuditFlags AuditFlags => default(AuditFlags);

		/// <summary>Gets the length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.GenericAce" /> object. This length should be used before marshaling the ACL into a binary array with the <see cref="M:System.Security.AccessControl.GenericAce.GetBinaryForm" /> method.</summary>
		/// <returns>The length, in bytes, of the binary representation of the current <see cref="T:System.Security.AccessControl.GenericAce" /> object.</returns>
		public abstract int BinaryLength { get; }

		/// <summary>Gets flags that specify the inheritance properties of this Access Control Entry (ACE).</summary>
		/// <returns>Flags that specify the inheritance properties of this ACE.</returns>
		public InheritanceFlags InheritanceFlags => default(InheritanceFlags);

		/// <summary>Gets a Boolean value that specifies whether this Access Control Entry (ACE) is inherited or is set explicitly.</summary>
		/// <returns>true if this ACE is inherited; otherwise, false.</returns>
		public bool IsInherited => false;

		/// <summary>Gets flags that specify the inheritance propagation properties of this Access Control Entry (ACE).</summary>
		/// <returns>Flags that specify the inheritance propagation properties of this ACE.</returns>
		public PropagationFlags PropagationFlags => default(PropagationFlags);

		internal GenericAce(AceType type, AceFlags flags)
		{
		}

		internal GenericAce(byte[] binaryForm, int offset)
		{
		}

		/// <summary>Creates a <see cref="T:System.Security.AccessControl.GenericAce" /> object from the specified binary data.</summary>
		/// <returns>The <see cref="T:System.Security.AccessControl.GenericAce" /> object this method creates.</returns>
		/// <param name="binaryForm">The binary data from which to create the new <see cref="T:System.Security.AccessControl.GenericAce" /> object.</param>
		/// <param name="offset">The offset at which to begin unmarshaling.</param>
		public static GenericAce CreateFromBinaryForm(byte[] binaryForm, int offset)
		{
			return null;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Security.AccessControl.GenericAce" /> object is equal to the current <see cref="T:System.Security.AccessControl.GenericAce" /> object.</summary>
		/// <returns>true if the specified <see cref="T:System.Security.AccessControl.GenericAce" /> object is equal to the current <see cref="T:System.Security.AccessControl.GenericAce" /> object; otherwise, false.</returns>
		/// <param name="o">The <see cref="T:System.Security.AccessControl.GenericAce" /> object to compare to the current <see cref="T:System.Security.AccessControl.GenericAce" /> object.</param>
		public sealed override bool Equals(object o)
		{
			return false;
		}

		/// <summary>Marshals the contents of the <see cref="T:System.Security.AccessControl.GenericAce" /> object into the specified byte array beginning at the specified offset.</summary>
		/// <param name="binaryForm">The byte array into which the contents of the <see cref="T:System.Security.AccessControl.GenericAce" /> is marshaled.</param>
		/// <param name="offset">The offset at which to start marshaling.</param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///   <paramref name="offset" /> is negative or too high to allow the entire <see cref="T:System.Security.AccessControl.GenericAcl" /> to be copied into <paramref name="array" />.</exception>
		public abstract void GetBinaryForm(byte[] binaryForm, int offset);

		/// <summary>Serves as a hash function for the <see cref="T:System.Security.AccessControl.GenericAce" /> class. The  <see cref="M:System.Security.AccessControl.GenericAce.GetHashCode" /> method is suitable for use in hashing algorithms and data structures like a hash table.</summary>
		/// <returns>A hash code for the current <see cref="T:System.Security.AccessControl.GenericAce" /> object.</returns>
		public sealed override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Security.AccessControl.GenericAce" /> objects are considered equal.</summary>
		/// <returns>true if the two <see cref="T:System.Security.AccessControl.GenericAce" /> objects are equal; otherwise, false.</returns>
		/// <param name="left">The first <see cref="T:System.Security.AccessControl.GenericAce" /> object to compare.</param>
		/// <param name="right">The second <see cref="T:System.Security.AccessControl.GenericAce" /> to compare.</param>
		public static bool operator ==(GenericAce left, GenericAce right)
		{
			return false;
		}

		/// <summary>Determines whether the specified <see cref="T:System.Security.AccessControl.GenericAce" /> objects are considered unequal.</summary>
		/// <returns>true if the two <see cref="T:System.Security.AccessControl.GenericAce" /> objects are unequal; otherwise, false.</returns>
		/// <param name="left">The first <see cref="T:System.Security.AccessControl.GenericAce" /> object to compare.</param>
		/// <param name="right">The second <see cref="T:System.Security.AccessControl.GenericAce" /> to compare.</param>
		public static bool operator !=(GenericAce left, GenericAce right)
		{
			return false;
		}

		private static bool IsObjectType(AceType type)
		{
			return false;
		}

		internal static ushort ReadUShort(byte[] buffer, int offset)
		{
			return 0;
		}

		internal static int ReadInt(byte[] buffer, int offset)
		{
			return 0;
		}

		internal static void WriteInt(int val, byte[] buffer, int offset)
		{
		}

		internal static void WriteUShort(ushort val, byte[] buffer, int offset)
		{
		}
	}
}
