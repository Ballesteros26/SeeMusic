namespace System.Security.AccessControl
{
	/// <summary>Controls access to objects without direct manipulation of access control lists (ACLs). This class is the abstract base class for the <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> class.</summary>
	public abstract class CommonObjectSecurity : ObjectSecurity
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> class.</summary>
		/// <param name="isContainer">true if the new object is a container object.</param>
		protected CommonObjectSecurity(bool isContainer)
			: base(null)
		{
		}

		/// <summary>Adds the specified access rule to the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary>
		/// <param name="rule">The access rule to add.</param>
		protected void AddAccessRule(AccessRule rule)
		{
		}

		/// <summary>Applies the specified modification to the Discretionary Access Control List (DACL) associated with this <see cref="T:System.Security.AccessControl.CommonObjectSecurity" /> object.</summary>
		/// <returns>true if the DACL is successfully modified; otherwise, false.</returns>
		/// <param name="modification">The modification to apply to the DACL.</param>
		/// <param name="rule">The access rule to modify.</param>
		/// <param name="modified">true if the DACL is successfully modified; otherwise, false.</param>
		protected override bool ModifyAccess(AccessControlModification modification, AccessRule rule, out bool modified)
		{
			modified = default(bool);
			return false;
		}
	}
}
