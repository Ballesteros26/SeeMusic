using System.Runtime.CompilerServices;

namespace NJsonSchema
{
	internal static class EnumExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNull(this JsonObjectType type)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsObject(this JsonObjectType type)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsArray(this JsonObjectType type)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInteger(this JsonObjectType type)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsString(this JsonObjectType type)
		{
			return false;
		}
	}
}
