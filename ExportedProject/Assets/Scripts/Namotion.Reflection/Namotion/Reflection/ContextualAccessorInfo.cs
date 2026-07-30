using System;
using System.Collections.Generic;

namespace Namotion.Reflection
{
	public abstract class ContextualAccessorInfo : ContextualMemberInfo
	{
		public abstract ContextualType AccessorType { get; }

		public Attribute[] ContextAttributes => null;

		public abstract object? GetValue(object? obj);

		public abstract void SetValue(object? obj, object? value);

		public T? GetContextAttribute<T>()
		{
			return default(T);
		}

		public IEnumerable<T> GetContextAttributes<T>() where T : notnull
		{
			return null;
		}
	}
}
