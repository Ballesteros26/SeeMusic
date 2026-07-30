using System.Runtime.CompilerServices;

namespace System.Resources
{
	/// <summary>Instructs a <see cref="T:System.Resources.ResourceManager" /> object to ask for a particular version of a satellite assembly.</summary>
	[AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class SatelliteContractVersionAttribute : Attribute
	{
		[CompilerGenerated]
		private readonly string _003CVersion_003Ek__BackingField;

		/// <summary>Initializes a new instance of the <see cref="T:System.Resources.SatelliteContractVersionAttribute" /> class.</summary>
		/// <param name="version">A string that specifies the version of the satellite assemblies to load. </param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="version" /> parameter is null. </exception>
		public SatelliteContractVersionAttribute(string version)
		{
		}
	}
}
