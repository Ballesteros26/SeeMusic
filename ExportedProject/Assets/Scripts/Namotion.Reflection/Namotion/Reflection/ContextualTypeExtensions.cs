using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Namotion.Reflection
{
	public static class ContextualTypeExtensions
	{
		private readonly struct CacheKey : IEquatable<CacheKey>
		{
			public string Prefix { get; }

			public string Key1 { get; }

			public string? Key2 { get; }

			public string? Key3 { get; }

			public string? Key4 { get; }

			public CacheKey(string Prefix, string Key1, string? Key2 = null, string? Key3 = null, string? Key4 = null)
			{
				this.Prefix = null;
				this.Key1 = null;
				this.Key2 = null;
				this.Key3 = null;
				this.Key4 = null;
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

		private static readonly ConcurrentDictionary<CacheKey, object> Cache;

		public static ContextualType ToContextualType(this Type type)
		{
			return null;
		}

		public static CachedType ToCachedType(this Type type)
		{
			return null;
		}

		public static ContextualPropertyInfo[] GetContextualProperties(this Type type)
		{
			return null;
		}

		public static ContextualType ToContextualType(this Type type, IEnumerable<Attribute> attributes)
		{
			return null;
		}

		public static ContextualPropertyInfo ToContextualProperty(this PropertyInfo propertyInfo)
		{
			return null;
		}

		public static ContextualFieldInfo ToContextualField(this FieldInfo fieldInfo)
		{
			return null;
		}

		public static ContextualAccessorInfo ToContextualAccessor(this MemberInfo memberInfo)
		{
			return null;
		}
	}
}
