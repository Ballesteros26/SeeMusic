using System.Security.AccessControl;
using System.Security.Principal;

namespace System.IO.Pipes
{
	/// <summary>Represents an abstraction of an access control entry (ACE) that defines an access rule for a pipe.</summary>
	public sealed class PipeAccessRule : AccessRule
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Pipes.PipeAccessRule" /> class with the specified identity, pipe access rights, and access control type.</summary>
		/// <param name="identity">An <see cref="T:System.Security.Principal.IdentityReference" /> object that encapsulates a reference to a user account.</param>
		/// <param name="rights">One of the <see cref="T:System.IO.Pipes.PipeAccessRights" /> values that specifies the type of operation associated with the access rule.</param>
		/// <param name="type">One of the <see cref="T:System.Security.AccessControl.AccessControlType" /> values that specifies whether to allow or deny the operation.</param>
		public PipeAccessRule(IdentityReference identity, PipeAccessRights rights, AccessControlType type)
			: base(null, 0, isInherited: false, default(InheritanceFlags), default(PropagationFlags), default(AccessControlType))
		{
		}

		internal PipeAccessRule(IdentityReference identity, int accessMask, bool isInherited, AccessControlType type)
			: base(null, 0, isInherited: false, default(InheritanceFlags), default(PropagationFlags), default(AccessControlType))
		{
		}

		internal static int AccessMaskFromRights(PipeAccessRights rights, AccessControlType controlType)
		{
			return 0;
		}
	}
}
