using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Terrain Binder")]
	[VFXBinder("Utility/Terrain")]
	internal class VFXTerrainBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.TerrainType" })]
		[FormerlySerializedAs("TerrainParameter")]
		public ExposedProperty m_Property;

		public Terrain Terrain;

		private ExposedProperty Terrain_Bounds_center;

		private ExposedProperty Terrain_Bounds_size;

		private ExposedProperty Terrain_HeightMap;

		private ExposedProperty Terrain_Height;

		public string Property
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void UpdateSubProperties()
		{
		}

		public override bool IsValid(VisualEffect component)
		{
			return false;
		}

		public override void UpdateBinding(VisualEffect component)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
