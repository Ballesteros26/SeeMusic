using System.Runtime.CompilerServices;

namespace System.Reflection
{
	/// <summary>Specifies the name of a key container within the CSP containing the key pair used to generate a strong name.</summary>
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyKeyNameAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly string _003CKeyName_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyKeyNameAttribute" /> class with the name of the container holding the key pair used to generate a strong name for the assembly being attributed.</summary>
		/// <param name="keyName">The name of the container containing the key pair. </param>
		public AssemblyKeyNameAttribute(string keyName)
		{
		}
	}
}
