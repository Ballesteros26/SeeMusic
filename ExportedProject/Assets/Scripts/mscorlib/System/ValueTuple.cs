using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	[Serializable]
	[StructLayout((LayoutKind)0, Size = 1)]
	public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple
	{
		int ITuple.Length => 0;

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ValueTuple other)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object other)
		{
			return 0;
		}

		public int CompareTo(ValueTuple other)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string IValueTupleInternal.ToStringEnd()
		{
			return null;
		}

		internal static int CombineHashCodes(int h1, int h2)
		{
			return 0;
		}

		internal static int CombineHashCodes(int h1, int h2, int h3)
		{
			return 0;
		}

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			return 0;
		}

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
		{
			return 0;
		}

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
		{
			return 0;
		}

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
		{
			return 0;
		}

		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
		{
			return 0;
		}
	}
	[Serializable]
	public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple
	{
		public T1 Item1;

		int ITuple.Length => 0;

		public ValueTuple(T1 item1)
		{
			Item1 = default(T1);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ValueTuple<T1> other)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object other)
		{
			return 0;
		}

		public int CompareTo(ValueTuple<T1> other)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string IValueTupleInternal.ToStringEnd()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)3)]
	public struct ValueTuple<T1, T2> : IEquatable<(T1, T2)>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<(T1, T2)>, IValueTupleInternal, ITuple
	{
		public T1 Item1;

		public T2 Item2;

		int ITuple.Length => 0;

		public ValueTuple(T1 item1, T2 item2)
		{
			Item1 = default(T1);
			Item2 = default(T2);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals((T1, T2) other)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object other)
		{
			return 0;
		}

		public int CompareTo((T1, T2) other)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return 0;
		}

		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string IValueTupleInternal.ToStringEnd()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)3)]
	public struct ValueTuple<T1, T2, T3> : IEquatable<(T1, T2, T3)>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<(T1, T2, T3)>, IValueTupleInternal, ITuple
	{
		public T1 Item1;

		public T2 Item2;

		public T3 Item3;

		int ITuple.Length => 0;

		public ValueTuple(T1 item1, T2 item2, T3 item3)
		{
			Item1 = default(T1);
			Item2 = default(T2);
			Item3 = default(T3);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals((T1, T2, T3) other)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object other)
		{
			return 0;
		}

		public int CompareTo((T1, T2, T3) other)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return 0;
		}

		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string IValueTupleInternal.ToStringEnd()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)3)]
	public struct ValueTuple<T1, T2, T3, T4> : IEquatable<(T1, T2, T3, T4)>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<(T1, T2, T3, T4)>, IValueTupleInternal, ITuple
	{
		public T1 Item1;

		public T2 Item2;

		public T3 Item3;

		public T4 Item4;

		int ITuple.Length => 0;

		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			Item1 = default(T1);
			Item2 = default(T2);
			Item3 = default(T3);
			Item4 = default(T4);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals((T1, T2, T3, T4) other)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object other)
		{
			return 0;
		}

		public int CompareTo((T1, T2, T3, T4) other)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return 0;
		}

		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string IValueTupleInternal.ToStringEnd()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)3)]
	public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<(T1, T2, T3, T4, T5)>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<(T1, T2, T3, T4, T5)>, IValueTupleInternal, ITuple
	{
		public T1 Item1;

		public T2 Item2;

		public T3 Item3;

		public T4 Item4;

		public T5 Item5;

		int ITuple.Length => 0;

		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			Item1 = default(T1);
			Item2 = default(T2);
			Item3 = default(T3);
			Item4 = default(T4);
			Item5 = default(T5);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals((T1, T2, T3, T4, T5) other)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object other)
		{
			return 0;
		}

		public int CompareTo((T1, T2, T3, T4, T5) other)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return 0;
		}

		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string IValueTupleInternal.ToStringEnd()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)3)]
	public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal, ITuple where TRest : struct
	{
		public T1 Item1;

		public T2 Item2;

		public T3 Item3;

		public T4 Item4;

		public T5 Item5;

		public T6 Item6;

		public T7 Item7;

		public TRest Rest;

		int ITuple.Length => 0;

		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
		{
			Item1 = default(T1);
			Item2 = default(T2);
			Item3 = default(T3);
			Item4 = default(T4);
			Item5 = default(T5);
			Item6 = default(T6);
			Item7 = default(T7);
			Rest = default(TRest);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			return false;
		}

		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return false;
		}

		int IComparable.CompareTo(object other)
		{
			return 0;
		}

		public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
		{
			return 0;
		}

		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return 0;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return 0;
		}

		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		string IValueTupleInternal.ToStringEnd()
		{
			return null;
		}
	}
}
