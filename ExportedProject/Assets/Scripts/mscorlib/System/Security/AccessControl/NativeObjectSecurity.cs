using System.Runtime.InteropServices;

namespace System.Security.AccessControl
{
	/// <summary>Provides the ability to control access to native objects without direct manipulation of Access Control Lists (ACLs). Native object types are defined by the <see cref="T:System.Security.AccessControl.ResourceType" /> enumeration.</summary>
	public abstract class NativeObjectSecurity : CommonObjectSecurity
	{
		/// <summary>Provides a way for integrators to map numeric error codes to specific exceptions that they create.</summary>
		/// <returns>The <see cref="T:System.Exception" /> this delegate creates.</returns>
		/// <param name="errorCode">The numeric error code.</param>
		/// <param name="name">The name of the securable object with which the <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is associated.</param>
		/// <param name="handle">The handle of the securable object with which the <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is associated.</param>
		/// <param name="context">An object that contains contextual information about the source or destination of the exception.</param>
		protected internal delegate Exception ExceptionFromErrorCode(int errorCode, string name, SafeHandle handle, object context);

		private delegate int GetSecurityInfoNativeCall(SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor);

		private ExceptionFromErrorCode exception_from_error_code;

		private ResourceType resource_type;

		internal ResourceType ResourceType => default(ResourceType);

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> class with the specified values.</summary>
		/// <param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is a container object.</param>
		/// <param name="resourceType">The type of securable object with which the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is associated.</param>
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType)
			: base(isContainer: false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> class by using the specified values.</summary>
		/// <param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is a container object.</param>
		/// <param name="resourceType">The type of securable object with which the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is associated.</param>
		/// <param name="exceptionFromErrorCode">A delegate implemented by integrators that provides custom exceptions. </param>
		/// <param name="exceptionContext">An object that contains contextual information about the source or destination of the exception.</param>
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext)
			: base(isContainer: false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> class with the specified values. We recommend that the values of the <paramref name="includeSections" /> parameters passed to the constructor and persist methods be identical. For more information, see Remarks.</summary>
		/// <param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is a container object.</param>
		/// <param name="resourceType">The type of securable object with which the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is associated.</param>
		/// <param name="handle">The handle of the securable object with which the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is associated.</param>
		/// <param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> enumeration values that specifies the sections of the security descriptor (access rules, audit rules, owner, primary group) of the securable object to include in this <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object.</param>
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections)
			: base(isContainer: false)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> class with the specified values. We recommend that the values of the <paramref name="includeSections" /> parameters passed to the constructor and persist methods be identical. For more information, see Remarks.</summary>
		/// <param name="isContainer">true if the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is a container object.</param>
		/// <param name="resourceType">The type of securable object with which the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is associated.</param>
		/// <param name="handle">The handle of the securable object with which the new <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object is associated.</param>
		/// <param name="includeSections">One of the <see cref="T:System.Security.AccessControl.AccessControlSections" /> enumeration values that specifies the sections of the security descriptor (access rules, audit rules, owner, primary group) of the securable object to include in this <see cref="T:System.Security.AccessControl.NativeObjectSecurity" /> object.</param>
		/// <param name="exceptionFromErrorCode">A delegate implemented by integrators that provides custom exceptions. </param>
		/// <param name="exceptionContext">An object that contains contextual information about the source or destination of the exception.</param>
		protected NativeObjectSecurity(bool isContainer, ResourceType resourceType, SafeHandle handle, AccessControlSections includeSections, ExceptionFromErrorCode exceptionFromErrorCode, object exceptionContext)
			: base(isContainer: false)
		{
		}

		private void ClearAccessControlSectionsModified()
		{
		}

		internal static Exception DefaultExceptionFromErrorCode(int errorCode, string name, SafeHandle handle, object context)
		{
			return null;
		}

		private void RaiseExceptionOnFailure(int errorCode, string name, SafeHandle handle, object context)
		{
		}

		internal virtual int InternalGet(SafeHandle handle, AccessControlSections includeSections)
		{
			return 0;
		}

		private int Win32GetHelper(GetSecurityInfoNativeCall nativeCall, AccessControlSections includeSections)
		{
			return 0;
		}

		[PreserveSig]
		private static extern int GetSecurityInfo(SafeHandle handle, ResourceType resourceType, SecurityInfos securityInfos, out IntPtr owner, out IntPtr group, out IntPtr dacl, out IntPtr sacl, out IntPtr descriptor);

		[PreserveSig]
		private static extern IntPtr LocalFree(IntPtr handle);

		[PreserveSig]
		private static extern int GetSecurityDescriptorLength(IntPtr descriptor);

		[PreserveSig]
		private static extern bool IsValidSecurityDescriptor(IntPtr descriptor);
	}
}
