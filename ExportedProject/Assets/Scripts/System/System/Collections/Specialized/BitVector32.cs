namespace System.Collections.Specialized
{
	/// <summary>Provides a simple structure that stores Boolean values and small integers in 32 bits of memory.</summary>
	public struct BitVector32
	{
		private uint _data;

		/// <summary>Gets or sets the state of the bit flag indicated by the specified mask.</summary>
		/// <returns>true if the specified bit flag is on (1); otherwise, false.</returns>
		/// <param name="bit">A mask that indicates the bit to get or set. </param>
		public bool this[int bit]
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Creates the first mask in a series of masks that can be used to retrieve individual bits in a <see cref="T:System.Collections.Specialized.BitVector32" /> that is set up as bit flags.</summary>
		/// <returns>A mask that isolates the first bit flag in the <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode, ControlEvidence" />
		/// </PermissionSet>
		public static int CreateMask()
		{
			return 0;
		}

		/// <summary>Creates an additional mask following the specified mask in a series of masks that can be used to retrieve individual bits in a <see cref="T:System.Collections.Specialized.BitVector32" /> that is set up as bit flags.</summary>
		/// <returns>A mask that isolates the bit flag following the one that <paramref name="previous" /> points to in <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		/// <param name="previous">The mask that indicates the previous bit flag. </param>
		/// <exception cref="T:System.InvalidOperationException">
		///   <paramref name="previous" /> indicates the last bit flag in the <see cref="T:System.Collections.Specialized.BitVector32" />. </exception>
		public static int CreateMask(int previous)
		{
			return 0;
		}

		/// <summary>Determines whether the specified object is equal to the <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>true if the specified object is equal to the <see cref="T:System.Collections.Specialized.BitVector32" />; otherwise, false.</returns>
		/// <param name="o">The object to compare with the current <see cref="T:System.Collections.Specialized.BitVector32" />. </param>
		public override bool Equals(object o)
		{
			return false;
		}

		/// <summary>Serves as a hash function for the <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>A hash code for the <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Returns a string that represents the specified <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>A string that represents the specified <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		/// <param name="value">The <see cref="T:System.Collections.Specialized.BitVector32" /> to represent. </param>
		public static string ToString(BitVector32 value)
		{
			return null;
		}

		/// <summary>Returns a string that represents the current <see cref="T:System.Collections.Specialized.BitVector32" />.</summary>
		/// <returns>A string that represents the current <see cref="T:System.Collections.Specialized.BitVector32" />.</returns>
		public override string ToString()
		{
			return null;
		}
	}
}
