using System.Runtime.CompilerServices;

namespace System.Reflection
{
	/// <summary>Specifies that the assembly is not fully signed when created.</summary>
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDelaySignAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly bool _003CDelaySign_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.AssemblyDelaySignAttribute" /> class.</summary>
		/// <param name="delaySign">true if the feature this attribute represents is activated; otherwise, false. </param>
		public AssemblyDelaySignAttribute(bool delaySign)
		{
		}
	}
}
