using System.Runtime.Serialization;

namespace System.Security.AccessControl
{
	/// <summary>The exception that is thrown when a method in the <see cref="N:System.Security.AccessControl" /> namespace attempts to enable a privilege that it does not have.</summary>
	[Serializable]
	public sealed class PrivilegeNotHeldException : UnauthorizedAccessException, ISerializable
	{
		private readonly string _privilegeName;

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.PrivilegeNotHeldException" /> class.</summary>
		public PrivilegeNotHeldException()
		{
		}

		private PrivilegeNotHeldException(SerializationInfo info, StreamingContext context)
		{
		}

		/// <summary>Sets the <paramref name="info" /> parameter with information about the exception.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.FileIOPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Read="*AllFiles*" PathDiscovery="*AllFiles*" />
		/// </PermissionSet>
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
