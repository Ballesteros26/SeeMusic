using System.Security.AccessControl;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	/// <summary>Represents the access control and audit security for a pipe.</summary>
	public class PipeSecurity : NativeObjectSecurity
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.IO.Pipes.PipeSecurity" /> class.</summary>
		public PipeSecurity()
			: base(isContainer: false, default(ResourceType))
		{
		}

		internal PipeSecurity(SafePipeHandle safeHandle, AccessControlSections includeSections)
			: base(isContainer: false, default(ResourceType))
		{
		}

		/// <summary>Adds an access rule to the Discretionary Access Control List (DACL) that is associated with the current <see cref="T:System.IO.Pipes.PipeSecurity" /> object.</summary>
		/// <param name="rule">The access rule to add.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="rule" /> parameter is null.</exception>
		public void AddAccessRule(PipeAccessRule rule)
		{
		}
	}
}
