using System;

namespace ForieroEngine.EnumUtilities
{
	public abstract class EnumUtilBase<E> : EnumUtilUnsafe<E> where E : class, IComparable, IFormattable, IConvertible
	{
	}
}
