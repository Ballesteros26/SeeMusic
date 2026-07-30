using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Specifies the base attribute class for code access security.</summary>
	[Serializable]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Obsolete("CAS support is not available with Silverlight applications.")]
	public abstract class CodeAccessSecurityAttribute : SecurityAttribute
	{
	}
}
