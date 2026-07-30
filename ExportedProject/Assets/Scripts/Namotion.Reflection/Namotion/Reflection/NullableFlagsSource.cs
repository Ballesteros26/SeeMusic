using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Namotion.Reflection
{
	internal readonly struct NullableFlagsSource
	{
		private readonly struct CacheKey : IEquatable<CacheKey>
		{
			public Type Type { get; }

			public Assembly? Assembly { get; }

			public CacheKey(Type Type, Assembly? Assembly)
			{
				this.Type = null;
				this.Assembly = null;
			}

			public override string ToString()
			{
				return null;
			}

			private bool PrintMembers(StringBuilder builder)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public bool Equals(CacheKey other)
			{
				return false;
			}
		}

		private static Dictionary<CacheKey, NullableFlagsSource> _nullableCache;

		public readonly byte[]? NullableFlags;

		public static NullableFlagsSource Create(Type type, Assembly? assembly = null)
		{
			return default(NullableFlagsSource);
		}

		public static NullableFlagsSource Create(MemberInfo member)
		{
			return default(NullableFlagsSource);
		}

		private NullableFlagsSource(Type type, Assembly? assembly)
		{
			NullableFlags = null;
		}

		private NullableFlagsSource(MemberInfo memberInfo)
		{
			NullableFlags = null;
		}

		private static byte[] GetNullableFlags<T>(T provider) where T : notnull, ICustomAttributeProvider
		{
			return null;
		}
	}
}
