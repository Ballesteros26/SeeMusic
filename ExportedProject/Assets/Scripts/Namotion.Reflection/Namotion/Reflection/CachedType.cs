using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Namotion.Reflection
{
	public class CachedType
	{
		private Type? _type;

		private bool _isNullableType;

		private string? _typeName;

		private Attribute[]? _inheritedAttributes;

		internal object? _genericArguments;

		internal object? _originalGenericArguments;

		internal object? _elementType;

		private TypeInfo? _typeInfo;

		public Type OriginalType { get; }

		public virtual IEnumerable<Attribute> Attributes => null;

		public string TypeName => null;

		public TypeInfo TypeInfo => null;

		public Attribute[] InheritedAttributes => null;

		public Type Type => null;

		public bool IsNullableType => false;

		public CachedType[] GenericArguments => null;

		public static implicit operator Type(CachedType type)
		{
			return null;
		}

		internal CachedType(Type type)
		{
		}

		public T GetInheritedAttribute<T>() where T : Attribute
		{
			return null;
		}

		public IEnumerable<T> GetInheritedAttributes<T>() where T : notnull
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		protected virtual CachedType GetCachedType(Type type, ref int nullableFlagsIndex)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected void UpdateOriginalGenericArguments()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected void UpdateOriginalGenericArguments(ref int nullableFlagsIndex)
		{
		}
	}
}
