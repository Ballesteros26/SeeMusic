using System.Runtime.InteropServices;

namespace System
{
	/// <summary>Provides the base class for value types.</summary>
	/// <filterpriority>2</filterpriority>
	[Serializable]
	[ComVisible(true)]
	public abstract class ValueType
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ValueType" /> class. </summary>
		protected ValueType()
		{
		}

		private static bool InternalEquals(object o1, object o2, out object[] fields)
		{
			fields = null;
			return false;
		}

		internal static bool DefaultEquals(object o1, object o2)
		{
			return false;
		}

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <returns>true if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, false. </returns>
		/// <param name="obj">The object to compare with the current instance. </param>
		/// <filterpriority>2</filterpriority>
		public override bool Equals(object obj)
		{
			return false;
		}

		internal static int InternalGetHashCode(object o, out object[] fields)
		{
			fields = null;
			return 0;
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
		/// <filterpriority>2</filterpriority>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Returns the fully qualified type name of this instance.</summary>
		/// <returns>A <see cref="T:System.String" /> containing a fully qualified type name.</returns>
		/// <filterpriority>2</filterpriority>
		public override string ToString()
		{
			return null;
		}
	}
}
