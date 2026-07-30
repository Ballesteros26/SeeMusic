using System.Runtime.InteropServices;

namespace UnityEngine.Android
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct Permission
	{
		public static bool HasUserAuthorizedPermission(string permission)
		{
			return false;
		}

		public static void RequestUserPermission(string permission)
		{
		}

		public static void RequestUserPermissions(string[] permissions, PermissionCallbacks callbacks)
		{
		}
	}
}
