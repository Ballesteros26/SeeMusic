using System;

namespace UnityEngine.UIElements
{
	[Serializable]
	public class VectorImage : ScriptableObject
	{
		[SerializeField]
		internal Texture2D atlas;

		[SerializeField]
		internal VectorImageVertex[] vertices;

		[SerializeField]
		internal ushort[] indices;

		[SerializeField]
		internal GradientSettings[] settings;

		[SerializeField]
		internal Vector2 size;
	}
}
