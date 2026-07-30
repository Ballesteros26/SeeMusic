namespace System.Security.AccessControl
{
	/// <summary>Represents a System Access Control List (SACL).</summary>
	public sealed class SystemAcl : CommonAcl
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.SystemAcl" /> class with the specified values from the specified <see cref="T:System.Security.AccessControl.RawAcl" /> object.</summary>
		/// <param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object is a container.</param>
		/// <param name="isDS">true if the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object is a directory object Access Control List (ACL).</param>
		/// <param name="rawAcl">The underlying <see cref="T:System.Security.AccessControl.RawAcl" /> object for the new <see cref="T:System.Security.AccessControl.SystemAcl" /> object. Specify null to create an empty ACL.</param>
		public SystemAcl(bool isContainer, bool isDS, RawAcl rawAcl)
			: base(isContainer: false, isDS: false, null)
		{
		}

		internal override void ApplyCanonicalSortToExplicitAces()
		{
		}

		internal override int GetAceInsertPosition(AceQualifier aceQualifier)
		{
			return 0;
		}

		internal override bool IsAceMeaningless(GenericAce ace)
		{
			return false;
		}

		private static bool IsValidAuditFlags(AuditFlags auditFlags)
		{
			return false;
		}
	}
}
