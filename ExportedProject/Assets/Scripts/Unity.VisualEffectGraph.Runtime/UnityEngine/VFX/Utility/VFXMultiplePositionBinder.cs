using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[VFXBinder("Point Cache/Multiple Position Binder")]
	[AddComponentMenu("VFX/Property Binders/Multiple Position Binder")]
	internal class VFXMultiplePositionBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "UnityEngine.Texture2D" })]
		[FormerlySerializedAs("PositionMapParameter")]
		public ExposedProperty PositionMapProperty;

		[VFXPropertyBinding(new string[] { "System.Int32" })]
		[FormerlySerializedAs("PositionCountParameter")]
		public ExposedProperty PositionCountProperty;

		public GameObject[] Targets;

		public bool EveryFrame;

		private Texture2D positionMap;

		private int count;

		protected override void OnEnable()
		{
		}

		public override bool IsValid(VisualEffect component)
		{
			return false;
		}

		public override void UpdateBinding(VisualEffect component)
		{
		}

		private void UpdateTexture()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
