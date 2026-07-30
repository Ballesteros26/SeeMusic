using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Resources
{
	/// <summary>Represents a resource manager that provides convenient access to culture-specific resources at run time.</summary>
	[Serializable]
	[ComVisible(true)]
	public class ResourceManager
	{
		internal class CultureNameResourceSetPair
		{
		}

		internal class ResourceManagerMediator
		{
			private ResourceManager _rm;

			internal ResourceManagerMediator(ResourceManager rm)
			{
			}
		}

		/// <summary>Contains a <see cref="T:System.Collections.Hashtable" /> that returns a mapping from cultures to <see cref="T:System.Resources.ResourceSet" /> objects. </summary>
		[Obsolete("call InternalGetResourceSet instead")]
		protected Hashtable ResourceSets;

		[NonSerialized]
		private Dictionary<string, ResourceSet> _resourceSets;

		/// <summary>Specifies the main assembly that contains the resources.</summary>
		protected Assembly MainAssembly;

		private CultureInfo _neutralResourcesCulture;

		[NonSerialized]
		private CultureNameResourceSetPair _lastUsedResourceCache;

		private bool UseManifest;

		[OptionalField(VersionAdded = 1)]
		private bool UseSatelliteAssem;

		[OptionalField]
		private UltimateResourceFallbackLocation _fallbackLoc;

		[OptionalField(VersionAdded = 1)]
		private Assembly _callingAssembly;

		[OptionalField(VersionAdded = 4)]
		private RuntimeAssembly m_callingAssembly;

		[NonSerialized]
		private IResourceGroveler resourceGroveler;

		/// <summary>Holds the number used to identify resource files.</summary>
		public static readonly int MagicNumber;

		/// <summary> Specifies the version of resource file headers that the current implementation of <see cref="T:System.Resources.ResourceManager" /> can interpret and produce.</summary>
		public static readonly int HeaderVersionNumber;

		private static readonly Type _minResourceSet;

		internal static readonly string ResReaderTypeName;

		internal static readonly string ResSetTypeName;

		internal static readonly string MscorlibName;

		internal static readonly int DEBUG;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Resources.ResourceManager" /> class with default values.</summary>
		protected ResourceManager()
		{
		}

		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
		}

		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
		}

		internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2)
		{
			return false;
		}
	}
}
