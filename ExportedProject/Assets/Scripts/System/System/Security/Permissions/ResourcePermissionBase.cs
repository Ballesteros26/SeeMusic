namespace System.Security.Permissions
{
	/// <summary>Allows control of code access security permissions.</summary>
	[Serializable]
	public abstract class ResourcePermissionBase : CodeAccessPermission
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Permissions.ResourcePermissionBase" /> class.</summary>
		protected ResourcePermissionBase()
		{
		}

		/// <summary>Determines whether the current permission object is a subset of the specified permission.</summary>
		/// <returns>true if the current permission object is a subset of the specified permission object; otherwise, false.</returns>
		/// <param name="target">A permission object that is to be tested for the subset relationship. </param>
		public override bool IsSubsetOf(IPermission target)
		{
			return false;
		}

		/// <summary>Creates and returns an XML encoding of the security object and its current state.</summary>
		/// <returns>An XML encoding of the security object, including any state information.</returns>
		public override SecurityElement ToXml()
		{
			return null;
		}
	}
}
