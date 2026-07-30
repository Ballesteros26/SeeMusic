using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace ForieroEngine.EnumUtilities
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class EnumUtilUnsafe<E> where E : IComparable, IFormattable, IConvertible
	{
		internal EnumUtilUnsafe()
		{
		}

		public static Type GetUnderlyingType<T>() where T : struct, E
		{
			return null;
		}

		public static string GetName<T>(T value) where T : struct, E
		{
			return null;
		}

		public static T Parse<T>(string value) where T : struct, E
		{
			return default(T);
		}

		public static T Parse<T>(string value, bool ignoreCase) where T : struct, E
		{
			return default(T);
		}

		public static T[] GetValues<T>() where T : struct, E
		{
			return null;
		}

		public static string[] GetNames<T>() where T : struct, E
		{
			return null;
		}

		public static bool TryParse<T>(string value, out T result) where T : struct, E
		{
			result = default(T);
			return false;
		}

		public static bool TryParse<T>(string value, bool ignoreCase, out T result) where T : struct, E
		{
			result = default(T);
			return false;
		}

		public static T BitwiseOr<T>(T left, T right) where T : struct, E
		{
			return default(T);
		}

		public static T BitwiseAnd<T>(T left, T right) where T : struct, E
		{
			return default(T);
		}

		public static T BitwiseExclusiveOr<T>(T left, T right) where T : struct, E
		{
			return default(T);
		}

		public static T BitwiseNot<T>(T value) where T : struct, E
		{
			return default(T);
		}

		public static bool HasFlag<T>(T value, T flag) where T : struct, E
		{
			return false;
		}

		public static T SetFlag<T>(T value, T flag) where T : struct, E
		{
			return default(T);
		}

		public static T UnsetFlag<T>(T value, T flag) where T : struct, E
		{
			return default(T);
		}

		public static T ToggleFlag<T>(T value, T flag) where T : struct, E
		{
			return default(T);
		}

		public static T ToggleFlag<T>(T value, T flag, bool flagSet) where T : struct, E
		{
			return default(T);
		}

		public static bool IsDefined<T>(T value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(string name) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(sbyte value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(byte value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(ushort value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(short value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(int value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(uint value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(long value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(ulong value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(float value) where T : struct, E
		{
			return false;
		}

		public static bool IsDefined<T>(double value) where T : struct, E
		{
			return false;
		}

		public static T FromByte<T>(byte value) where T : struct, E
		{
			return default(T);
		}

		public static T FromSByte<T>(sbyte value) where T : struct, E
		{
			return default(T);
		}

		public static T FromInt16<T>(short value) where T : struct, E
		{
			return default(T);
		}

		public static T FromUInt16<T>(ushort value) where T : struct, E
		{
			return default(T);
		}

		public static T FromInt32<T>(int value) where T : struct, E
		{
			return default(T);
		}

		public static T FromUInt32<T>(uint value) where T : struct, E
		{
			return default(T);
		}

		public static T FromInt64<T>(long value) where T : struct, E
		{
			return default(T);
		}

		public static T FromUInt64<T>(ulong value) where T : struct, E
		{
			return default(T);
		}

		public static T FromSingle<T>(float value) where T : struct, E
		{
			return default(T);
		}

		public static T FromDouble<T>(double value) where T : struct, E
		{
			return default(T);
		}

		public static byte ToByte<T>(T value) where T : struct, E
		{
			return 0;
		}

		public static sbyte ToSByte<T>(T value) where T : struct, E
		{
			return 0;
		}

		public static short ToInt16<T>(T value) where T : struct, E
		{
			return 0;
		}

		public static ushort ToUInt16<T>(T value) where T : struct, E
		{
			return 0;
		}

		public static int ToInt32<T>(T value) where T : struct, E
		{
			return 0;
		}

		public static uint ToUInt32<T>(T value) where T : struct, E
		{
			return 0u;
		}

		public static long ToInt64<T>(T value) where T : struct, E
		{
			return 0L;
		}

		public static ulong ToUInt64<T>(T value) where T : struct, E
		{
			return 0uL;
		}

		public static float ToSingle<T>(T value) where T : struct, E
		{
			return 0f;
		}

		public static double ToDouble<T>(T value) where T : struct, E
		{
			return 0.0;
		}

		public static Y GetAttribute<Y, T>() where Y : Attribute where T : struct, E
		{
			return null;
		}

		public static IEnumerable<Y> GetAttributes<Y, T>() where Y : Attribute where T : struct, E
		{
			return null;
		}

		public static Y GetAttribute<Y, T>(T value) where Y : Attribute where T : struct, E
		{
			return null;
		}

		public static IEnumerable<Y> GetAttributes<Y, T>(T value) where Y : Attribute where T : struct, E
		{
			return null;
		}

		public static bool HasAttribute<Y, T>() where Y : Attribute where T : struct, E
		{
			return false;
		}

		public static bool HasFlagsAttribute<T>() where T : struct, E
		{
			return false;
		}

		public static FieldInfo[] GetEnumFields<T>() where T : struct, E
		{
			return null;
		}

		public static IReadOnlyDictionary<T, DescriptionAttribute> GetValueDescription<T>() where T : struct, E
		{
			return null;
		}

		public static IReadOnlyDictionary<T, NameAttribute<DescriptionAttribute>> GetValueNameDescription<T>() where T : struct, E
		{
			return null;
		}

		public static IReadOnlyDictionary<T, Tuple<string, IEnumerable<Attribute>>> GetValueNameAttributes<T>() where T : struct, E
		{
			return null;
		}

		public static IReadOnlyDictionary<string, ValueAttribute<T, Y>> GetNameValueAttribute<T, Y>() where T : struct, E where Y : Attribute
		{
			return null;
		}

		public static IReadOnlyDictionary<T, NameAttribute<Y>> GetValueNameAttribute<T, Y>() where T : struct, E where Y : Attribute
		{
			return null;
		}

		public static IReadOnlyDictionary<T, Y> GetValueAttribute<T, Y>() where T : struct, E where Y : Attribute
		{
			return null;
		}

		public static IReadOnlyDictionary<string, T> GetNameValue<T>() where T : struct, E
		{
			return null;
		}

		public static IReadOnlyDictionary<T, string> GetValueName<T>() where T : struct, E
		{
			return null;
		}
	}
}
