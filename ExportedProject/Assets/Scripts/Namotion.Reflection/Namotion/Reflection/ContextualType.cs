using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Namotion.Reflection
{
	public class ContextualType : CachedType
	{
		private static readonly byte[] _emptyNullableFlags;

		private readonly int _nullableFlagsIndex;

		private byte[]? _nullableFlags;

		private Nullability? nullability;

		private ContextualMethodInfo[]? _methods;

		private ContextualPropertyInfo[]? _properties;

		[CompilerGenerated]
		private readonly ContextualType? _003CParent_003Ek__BackingField;

		private ContextualType? _enumerableItemType;

		public Attribute[] ContextAttributes { get; private set; }

		public Nullability OriginalNullability { get; private set; }

		public override IEnumerable<Attribute> Attributes => null;

		public new ContextualType[] GenericArguments => null;

		public ContextualType[] OriginalGenericArguments => null;

		public ContextualType? ElementType => null;

		public ContextualType? EnumerableItemType => null;

		public ContextualType? BaseType => null;

		public Nullability Nullability => default(Nullability);

		public ContextualPropertyInfo[] Properties => null;

		public ContextualMethodInfo[] Methods => null;

		internal static ContextualType ForType(Type type, IEnumerable<Attribute> contextAttributes)
		{
			return null;
		}

		internal ContextualType(Type type, IEnumerable<Attribute> contextAttributes, ContextualType? parent, ref int nullableFlagsIndex, byte[]? nullableFlags, NullableFlagsSource[] customAttributeProviders)
			: base(null)
		{
		}

		public T GetContextAttribute<T>() where T : Attribute
		{
			return null;
		}

		public T? GetAttribute<T>()
		{
			return default(T);
		}

		public override string ToString()
		{
			return null;
		}

		protected override CachedType GetCachedType(Type type, ref int nullableFlagsIndex)
		{
			return null;
		}

		private void InitializeNullableFlagsAndOriginalNullability(ref int nullableFlagsIndex, NullableFlagsSource[] customAttributeProviders)
		{
		}

		private byte[] GetFlagsFromNullableAttribute(Attribute nullableAttribute)
		{
			return null;
		}

		private static byte[] GetFlagsFromCustomAttributeProviders(NullableFlagsSource[] customAttributeProviders)
		{
			return null;
		}
	}
}
